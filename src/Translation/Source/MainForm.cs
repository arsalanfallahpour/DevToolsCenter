using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastExperience.Tools.Translation
{
    public partial class MainForm : Form
    {
        public TranslationService Service => service;
        private TranslationService service;

        public MainForm()
        {
            InitializeComponent();
            //DropRecreateTestFile();
            _messageContainer = new MessageContainer(ReleseMessages);
        }
        private void ReleseMessages(object sender, EventArgs e)
            => MessageBox.Show(_messageContainer.GetFormatedMessage(), "پیام ها");
        private void InitialFileds()
        {
            _messageContainer.Initialize();
            throw new NotImplementedException();
        }

        //private void DropRecreateTestFile()
        //{
        //    if (!File.Exists(encodedFilePath))
        //        File.Create(encodedFilePath);
        //    else
        //    {

        //        File.Delete(encodedFilePath);
        //        File.Create(encodedFilePath);
        //    }
        //}

        private async void btnTranslateCharSet_Click(object sender, EventArgs e)
        {
            await TranslateFromArabic1256ToUTF8();
        }
        public ParameterModel ParameterValues => parameterValues;
        public ParameterModel parameterValues;
        private  readonly MessageContainer _messageContainer;

        private async Task TranslateFromArabic1256ToUTF8()
        {
            try
            {
                folderBrowserDialog.Description = "پوشه حاوی فایل های عربی را انتخاب نمایید";
                var dialogResult = folderBrowserDialog.ShowDialog();
                string targetPath = string.Empty;
                if (dialogResult == DialogResult.OK)
                    targetPath = folderBrowserDialog.SelectedPath;
                else
                    return;

                folderBrowserDialog.Description = "پوشه خروجی را انتخاب نمایید";
                dialogResult = folderBrowserDialog.ShowDialog();
                string outputPath = string.Empty;
                if (dialogResult == DialogResult.OK)
                    outputPath = folderBrowserDialog.SelectedPath;
                else
                    return;

                await ProcessFiles(targetPath, outputPath);

            }
            catch (Exception ex)
            {
                ShowMessageBox(ex);
            }
        }
        private List<string> GetFileExtensionList(string text)
        {
            if (string.IsNullOrEmpty(text.Trim()))
                return new List<string>();

            var list = new List<string>();
            foreach (var extension in text.Split(' '))
                if (!string.IsNullOrEmpty(extension.Trim()) || !extension.Contains('.'))
                    list.Add(extension);

            return list;
        }
        private List<string> GetFolderNameList(string text)
        {
            if (string.IsNullOrEmpty(text.Trim()))
                return new List<string>();

            var list = new List<string>();
            foreach (var fileName in text.Split(' '))
                if (!string.IsNullOrEmpty(fileName.Trim())
                    || !fileName.Contains('*')
                    || !fileName.Contains('?')
                    || !fileName.Contains(';')
                    || !fileName.Contains('{')
                    || !fileName.Contains('{')
                    || !fileName.Contains(']')
                    || !fileName.Contains('[')
                    || !fileName.Contains('/')
                    || !fileName.Contains('&')
                    || !fileName.Contains('%')
                    || !fileName.Contains('$')
                    || !fileName.Contains('#')
                    || !fileName.Contains('@')
                    || !fileName.Contains('\\'))
                    list.Add(fileName);
                else
                {
                    _messageContainer.ReleseMessages();
                    _messageContainer.AddMessage($"The file {fileName} not include becuse contains illegal chars", true);
                }

            if (_messageContainer.StateRelesed)
                _messageContainer.ShowMessage(this, new EventArgs());
            return list;
        }

        private static void ShowMessageBox(Exception ex)
        {
            MessageBox.Show(ex.Message, "خطای عمومی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
        private void ShowMessageBox(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            btnExit_Click(null, new EventArgs());
        }


        private async void btnDoItAgain_Click(object sender, EventArgs e)
        {
            try
            {
                if (ParameterValues == null)
                    return;
                if (string.IsNullOrEmpty(parameterValues.LastTargetPath))
                    return;
                if (string.IsNullOrEmpty(parameterValues.LastOutputPath))
                    return;

                await ProcessFiles(ParameterValues.LastTargetPath, ParameterValues.LastOutputPath);
            }
            catch (Exception ex)
            {
                ShowMessageBox(ex);
            }

        }
        private async Task ProcessFiles(string targetPath, string outputPath)
        {
            try {
                var excludedFileExtensions = GetFileExtensionList(txtExcludeFilesToProcess.Text);
                var includedFileExtensions = GetFileExtensionList(txtIncludeFilesToProcess.Text);

                var excludedFolderNames = GetFolderNameList(txtExcludeFoldersToProcess.Text);
                var includedFolderNames = GetFolderNameList(txtIncludeFoldersToProcess.Text);

                service = new TranslationService(targetPath,
                                                 outputPath,
                                                 excludedFileExtensions,
                                                 includedFileExtensions,
                                                 excludedFolderNames,
                                                 includedFolderNames);
                parameterValues = new ParameterModel(targetPath, outputPath);
                await Service
                    .TranslateTo(chBoxJutRootFolderFiles.Checked,
                                 EncodingTypes.Arabic1256,
                                 EncodingTypes.UTF8,
                                 GetIncludeFileToProcessBehavior(),
                                 GetIncludeFolderToProcessBehavior());

            }
            catch (ArgumentNullException argNullEx)
            {
                ShowMessageBox("مسیری جهت انجام فرایند انتخاب نشده", "خطا در فرایند تبدیل");
            }
            catch (ArgumentException argEx)
            {
                ShowMessageBox("مسیر مورد نظر یافت نشد", "خطا در فرایند تبدیل");
            }
            ShowMessageEndOfProcessMessage();
        }
        private void btnExit_Click(object sender, EventArgs e) 
            => Application.Exit();

        private IncludingBehavior GetIncludeFileToProcessBehavior()
        {
            if (radioBtnIncludeFilesToProcess.Checked)
                return IncludingBehavior.UseIncludeList;
            else if (radioBtnExcludeFilesToProcess.Checked)
                return IncludingBehavior.UseExcludeList;
            else if (radioBtnIncludeAllFilesToProcess.Checked)
                return IncludingBehavior.IncludeAll;

                throw new NotSupportedException("IncludingBehavior Not Supported");
        }
        private IncludingBehavior GetIncludeFolderToProcessBehavior()
        {
            if (radioBtnIncludeFoldersToProcess.Checked)
                return IncludingBehavior.UseIncludeList;
            else if (radioBtnExcludeFoldersToProcess.Checked)
                return IncludingBehavior.UseExcludeList;
            else if (radioBtnIncludeAllFoldersToProcess.Checked)
                return IncludingBehavior.IncludeAll;

            throw new NotSupportedException("IncludingBehavior Not Supported");
        }

        #region RadioButtons
        private void UpdateFoldersRadioButtonsAccess()
        {
            UpdateRadioButtonExcludeFolders();
            UpdateRadioButtonIncludeFolders();
        }
        private void radioBtnIncludeAllFoldersToProcess_CheckedChanged(object sender, EventArgs e)
            => UpdateFoldersRadioButtonsAccess();
        private void radioBtnIncludeFoldersToProcess_CheckedChanged(object sender, EventArgs e)
            => UpdateRadioButtonIncludeFolders();
        private void UpdateRadioButtonIncludeFolders()
            => txtIncludeFoldersToProcess.Enabled = radioBtnIncludeFoldersToProcess.Checked;
        private void UpdateRadioButtonExcludeFolders()
            => txtExcludeFoldersToProcess.Enabled = radioBtnExcludeFoldersToProcess.Checked;

        private void radioBtnExcludeFoldersToProcess_CheckedChanged(object sender, EventArgs e)
            => UpdateRadioButtonExcludeFolders();

        private void UpdateFilesRadioButtonsAccess()
        {
            UpdateRadioButtonExcludeFiles();
            UpdateRadioButtonIncludeFiles();
        }
        private void UpdateRadioButtonIncludeFiles()
            => txtIncludeFilesToProcess.Enabled = radioBtnIncludeFilesToProcess.Checked;
        private void UpdateRadioButtonExcludeFiles()
            => txtExcludeFilesToProcess.Enabled = radioBtnExcludeFilesToProcess.Checked;


        private void radioBtnIncludeAllFilesToProcess_CheckedChanged(object sender, EventArgs e)
            => UpdateFilesRadioButtonsAccess();

        private void radioBtnIncludeFilesToProcess_CheckedChanged(object sender, EventArgs e)
            => UpdateRadioButtonIncludeFiles();

        private void radioBtnExcludeFilesToProcess_CheckedChanged(object sender, EventArgs e)
            => UpdateRadioButtonExcludeFiles();
        #endregion

        private void btnClearOutputFolder_Click(object sender, EventArgs e)
        {
            if (parameterValues == null)
                return;
            if (string.IsNullOrEmpty(parameterValues.LastOutputPath))
                return;

            var dialogResult = MessageBox.Show("آیا با پاکسازی (حذف) محتویات پوشه مقصد موافق هستید؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            if (dialogResult == DialogResult.Yes)
                ClearOutputDirectory();


            ShowMessageEndOfProcessMessage();
        }

        private void ClearOutputDirectory()
        {
            Directory.Delete(ParameterValues.LastOutputPath, true);
            Directory.CreateDirectory(ParameterValues.LastOutputPath);
        }

        private static void ShowMessageEndOfProcessMessage()
        {
            MessageBox.Show("عملیات با موفقیت انجام شد",
                                        "پایان عملیات",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information,
                                        MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.RightAlign);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new AboutBox()
                .ShowDialog();
        }
    }
}
