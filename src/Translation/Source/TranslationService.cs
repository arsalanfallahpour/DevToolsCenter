using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastExperience.Tools.Translation
{
    public class TranslationService
    {
        public TranslationService(string targetFolder,
                                  string outputPath,
                                  List<string> excludedFileExtensions,
                                  List<string> includedFileExtensions,
                                  List<string> excludedFolderNames,
                                  List<string> includedFolderNames)
        {
            ProcessPaths(targetFolder, outputPath);
            ProcessFileExtensions(excludedFileExtensions, includedFileExtensions);
            ProcessFolderNames(excludedFolderNames, includedFolderNames);
        }

        public string TargetFolder => targetFolder;
        public string targetFolder;
        public string OutputPath => outputPath;
        public string outputPath;
        public List<string> ExcludedFileExtensions => excludedFileExtensions;
        public List<string> excludedFileExtensions;

        public List<string> IncludedFolderNames => includedFolderNames;
        public List<string> includedFolderNames;

        public List<string> ExcludedFolderNames => excludedFolderNames;
        public List<string> excludedFolderNames;

        public List<string> IncludedFileExtensions => includedFileExtensions;
        public List<string> includedFileExtensions;

        private void ProcessPaths(string targetFolder, string outputPath)
        {
            ValidatePaths(targetFolder, outputPath);
            this.targetFolder = targetFolder;
            this.outputPath = outputPath;
        }

        private void ProcessFileExtensions(List<string> excludedFileExtensions, List<string> includedFileExtensions)
        {
            if (excludedFileExtensions == null)
                this.excludedFileExtensions = new List<string>();
            else
                this.excludedFileExtensions = excludedFileExtensions;
            if (includedFileExtensions == null)
                this.includedFileExtensions = new List<string>();
            else
                this.includedFileExtensions = includedFileExtensions;
        }

        private void ProcessFolderNames(List<string> excludedFolderNames, List<string> includedFolderNames)
        {
            if (excludedFolderNames == null)
                this.excludedFolderNames = new List<string>();
            else
                this.excludedFolderNames = excludedFolderNames;
            if (includedFolderNames == null)
                this.includedFolderNames = new List<string>();
            else
                this.includedFolderNames = includedFolderNames;
        }

        private static void ValidatePaths(string targetFolder, string outputPath)
        {
            if (string.IsNullOrEmpty(targetFolder))
                throw new ArgumentNullException("Target Folder Cannot Be Null or Empty String!");
            if (string.IsNullOrEmpty(outputPath))
                throw new ArgumentNullException("Ouput Folder Cannot Be Null or Empty String!");

            if (!Directory.Exists(targetFolder))
                throw new ArgumentException("Target Folder Not Exist!");

            if (!Directory.Exists(targetFolder))
                throw new ArgumentException("Output Folder Not Exist!");
        }

        public async Task TranslateTo(bool justTranslateRootFolder,
                                      EncodingTypes fromEncoding,
                                      EncodingTypes toEncoding,
                                      IncludingBehavior includeFileToProcessBehavior,
                                      IncludingBehavior includeFolderToProcessBehavior)
        {
            var filePaths = new List<string>();

            if (justTranslateRootFolder)
                filePaths = Directory.GetFiles(
                    targetFolder,
                    "*.*",
                    SearchOption.TopDirectoryOnly)
                    ?.ToList();
            else
                filePaths = Directory.GetFiles(
                    targetFolder,
                    "*.*",
                    SearchOption.AllDirectories)
                    ?.ToList();

            if (filePaths.Count == 0)
            {
                MessageBox.Show("فایلی پیدا نشد");
                await Task.CompletedTask;
            }
            foreach (var filePath in filePaths)
            {
                var relativePathToTargetRootPath = filePath.Remove(0, targetFolder.Length);
                var fileOutputPath = outputPath + "\\" + relativePathToTargetRootPath;
                var parentDirectory = new FileInfo(fileOutputPath).Directory.Parent.Name;

                var fileInfo = new FileInfo(filePath);
                var directoryInfo = new FileInfo(fileInfo.Directory.FullName);

                if (includeFolderToProcessBehavior == IncludingBehavior.UseExcludeList)
                    if (excludedFolderNames.Count != 0)
                        if (excludedFolderNames.Any(o => o == directoryInfo.Name))
                            continue;

                if (includeFolderToProcessBehavior == IncludingBehavior.UseIncludeList)
                    if (includedFolderNames.Count != 0)
                        if (!includedFolderNames.Any(o => o == directoryInfo.Name))
                            continue;

                if (includeFileToProcessBehavior == IncludingBehavior.UseExcludeList)
                    if (excludedFileExtensions.Count != 0)
                    if (excludedFileExtensions.Any(o => o == fileInfo.Extension))
                    continue;

                if (includeFileToProcessBehavior == IncludingBehavior.UseIncludeList)
                    if (includedFileExtensions.Count != 0)
                    if (!includedFileExtensions.Any(o => o == fileInfo.Extension))
                        continue;
    
                if (!fileInfo.Exists)
                    throw new Exception("فایل " + filePath + " پیدا نشد");


                await ChangeEncoding(filePath, fileOutputPath, fromEncoding, toEncoding);
            }
        }

        private async Task ChangeEncoding(string filePath, string fileOutputPath, EncodingTypes fromEncoding, EncodingTypes toEncoding)
        {
            filePath = FormatPath(filePath);
            fileOutputPath = FormatPath(fileOutputPath);
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var arabic = Encoding.GetEncoding(1256);

            string contents = await File.ReadAllTextAsync(filePath, arabic);

            if (string.IsNullOrEmpty(contents))
            {

                await Task.CompletedTask;
                return;
            }

                var utf8 = UTF8Encoding.GetEncoding(65001);

            var fileOutputDirectory = new DirectoryInfo(fileOutputPath).Parent.FullName.ToString();
            if (!isDirectoryExist(fileOutputDirectory))
                Directory.CreateDirectory(fileOutputDirectory);

            await File.WriteAllTextAsync(fileOutputPath, contents, utf8);
        }

        private bool isDirectoryExist(string fileOutputDirectory)
          => new DirectoryInfo(fileOutputDirectory).Exists;

        private string FormatPath(string filePath) 
            => Path.GetFullPath(filePath);
    }
}