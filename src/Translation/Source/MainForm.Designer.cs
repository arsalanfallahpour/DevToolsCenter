
namespace FastExperience.Tools.Translation
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTranslateCharSet = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.chBoxJutRootFolderFiles = new System.Windows.Forms.CheckBox();
            this.txtIncludeFilesToProcess = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDoItAgain = new System.Windows.Forms.Button();
            this.radioBtnIncludeFilesToProcess = new System.Windows.Forms.RadioButton();
            this.radioBtnIncludeAllFilesToProcess = new System.Windows.Forms.RadioButton();
            this.gboxFileFilteringConfig = new System.Windows.Forms.GroupBox();
            this.radioBtnExcludeFilesToProcess = new System.Windows.Forms.RadioButton();
            this.txtExcludeFilesToProcess = new System.Windows.Forms.TextBox();
            this.gboxFolderFilteringConfig = new System.Windows.Forms.GroupBox();
            this.radioBtnIncludeAllFoldersToProcess = new System.Windows.Forms.RadioButton();
            this.radioBtnExcludeFoldersToProcess = new System.Windows.Forms.RadioButton();
            this.radioBtnIncludeFoldersToProcess = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txtExcludeFoldersToProcess = new System.Windows.Forms.TextBox();
            this.txtIncludeFoldersToProcess = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnClearOutputFolder = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.gboxFileFilteringConfig.SuspendLayout();
            this.gboxFolderFilteringConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTranslateCharSet
            // 
            this.btnTranslateCharSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTranslateCharSet.BackColor = System.Drawing.Color.PeachPuff;
            this.btnTranslateCharSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranslateCharSet.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTranslateCharSet.ForeColor = System.Drawing.Color.Orange;
            this.btnTranslateCharSet.Location = new System.Drawing.Point(0, 516);
            this.btnTranslateCharSet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnTranslateCharSet.Name = "btnTranslateCharSet";
            this.btnTranslateCharSet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnTranslateCharSet.Size = new System.Drawing.Size(345, 34);
            this.btnTranslateCharSet.TabIndex = 0;
            this.btnTranslateCharSet.Text = "تبدیل فایل ها از Arabic1256 به UTF8";
            this.btnTranslateCharSet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTranslateCharSet.UseVisualStyleBackColor = false;
            this.btnTranslateCharSet.Click += new System.EventHandler(this.btnTranslateCharSet_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "پوشه مقصد را جهت ترجمه انتخاب کنید";
            this.folderBrowserDialog.UseDescriptionForTitle = true;
            // 
            // chBoxJutRootFolderFiles
            // 
            this.chBoxJutRootFolderFiles.AutoSize = true;
            this.chBoxJutRootFolderFiles.BackColor = System.Drawing.SystemColors.Highlight;
            this.chBoxJutRootFolderFiles.Checked = true;
            this.chBoxJutRootFolderFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxJutRootFolderFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chBoxJutRootFolderFiles.Font = new System.Drawing.Font("B Nazanin", 11.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chBoxJutRootFolderFiles.Location = new System.Drawing.Point(0, 548);
            this.chBoxJutRootFolderFiles.Margin = new System.Windows.Forms.Padding(5, 6, 20, 6);
            this.chBoxJutRootFolderFiles.Name = "chBoxJutRootFolderFiles";
            this.chBoxJutRootFolderFiles.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.chBoxJutRootFolderFiles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chBoxJutRootFolderFiles.Size = new System.Drawing.Size(755, 28);
            this.chBoxJutRootFolderFiles.TabIndex = 1;
            this.chBoxJutRootFolderFiles.Text = "فقط فایل های موجود در ریشه پوشه پردازش شود";
            this.chBoxJutRootFolderFiles.UseVisualStyleBackColor = false;
            // 
            // txtIncludeFilesToProcess
            // 
            this.txtIncludeFilesToProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIncludeFilesToProcess.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIncludeFilesToProcess.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIncludeFilesToProcess.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtIncludeFilesToProcess.Location = new System.Drawing.Point(6, 83);
            this.txtIncludeFilesToProcess.Multiline = true;
            this.txtIncludeFilesToProcess.Name = "txtIncludeFilesToProcess";
            this.txtIncludeFilesToProcess.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIncludeFilesToProcess.Size = new System.Drawing.Size(563, 76);
            this.txtIncludeFilesToProcess.TabIndex = 2;
            this.txtIncludeFilesToProcess.Text = ".txt .cs";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.LightGray;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(709, 515);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExit.Size = new System.Drawing.Size(42, 37);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "x";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseCompatibleTextRendering = true;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDoItAgain
            // 
            this.btnDoItAgain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoItAgain.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDoItAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoItAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoItAgain.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDoItAgain.Location = new System.Drawing.Point(344, 515);
            this.btnDoItAgain.Name = "btnDoItAgain";
            this.btnDoItAgain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDoItAgain.Size = new System.Drawing.Size(79, 37);
            this.btnDoItAgain.TabIndex = 7;
            this.btnDoItAgain.Text = "Do It Again";
            this.btnDoItAgain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoItAgain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDoItAgain.UseCompatibleTextRendering = true;
            this.btnDoItAgain.UseVisualStyleBackColor = true;
            this.btnDoItAgain.Click += new System.EventHandler(this.btnDoItAgain_Click);
            // 
            // radioBtnIncludeFilesToProcess
            // 
            this.radioBtnIncludeFilesToProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnIncludeFilesToProcess.AutoSize = true;
            this.radioBtnIncludeFilesToProcess.Checked = true;
            this.radioBtnIncludeFilesToProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioBtnIncludeFilesToProcess.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.radioBtnIncludeFilesToProcess.Location = new System.Drawing.Point(576, 83);
            this.radioBtnIncludeFilesToProcess.Name = "radioBtnIncludeFilesToProcess";
            this.radioBtnIncludeFilesToProcess.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioBtnIncludeFilesToProcess.Size = new System.Drawing.Size(174, 37);
            this.radioBtnIncludeFilesToProcess.TabIndex = 9;
            this.radioBtnIncludeFilesToProcess.TabStop = true;
            this.radioBtnIncludeFilesToProcess.Text = "فقط فایل هایی با پسوند";
            this.radioBtnIncludeFilesToProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBtnIncludeFilesToProcess.UseCompatibleTextRendering = true;
            this.radioBtnIncludeFilesToProcess.UseVisualStyleBackColor = true;
            this.radioBtnIncludeFilesToProcess.CheckedChanged += new System.EventHandler(this.radioBtnIncludeFilesToProcess_CheckedChanged);
            // 
            // radioBtnIncludeAllFilesToProcess
            // 
            this.radioBtnIncludeAllFilesToProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnIncludeAllFilesToProcess.AutoSize = true;
            this.radioBtnIncludeAllFilesToProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioBtnIncludeAllFilesToProcess.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.radioBtnIncludeAllFilesToProcess.Location = new System.Drawing.Point(608, 39);
            this.radioBtnIncludeAllFilesToProcess.Name = "radioBtnIncludeAllFilesToProcess";
            this.radioBtnIncludeAllFilesToProcess.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioBtnIncludeAllFilesToProcess.Size = new System.Drawing.Size(142, 37);
            this.radioBtnIncludeAllFilesToProcess.TabIndex = 10;
            this.radioBtnIncludeAllFilesToProcess.Text = "تبدیل همه فایل ها";
            this.radioBtnIncludeAllFilesToProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBtnIncludeAllFilesToProcess.UseCompatibleTextRendering = true;
            this.radioBtnIncludeAllFilesToProcess.UseVisualStyleBackColor = true;
            this.radioBtnIncludeAllFilesToProcess.CheckedChanged += new System.EventHandler(this.radioBtnIncludeAllFilesToProcess_CheckedChanged);
            // 
            // gboxFileFilteringConfig
            // 
            this.gboxFileFilteringConfig.Controls.Add(this.radioBtnIncludeAllFilesToProcess);
            this.gboxFileFilteringConfig.Controls.Add(this.radioBtnExcludeFilesToProcess);
            this.gboxFileFilteringConfig.Controls.Add(this.txtExcludeFilesToProcess);
            this.gboxFileFilteringConfig.Controls.Add(this.txtIncludeFilesToProcess);
            this.gboxFileFilteringConfig.Controls.Add(this.radioBtnIncludeFilesToProcess);
            this.gboxFileFilteringConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboxFileFilteringConfig.ForeColor = System.Drawing.Color.DarkGray;
            this.gboxFileFilteringConfig.Location = new System.Drawing.Point(0, 0);
            this.gboxFileFilteringConfig.Name = "gboxFileFilteringConfig";
            this.gboxFileFilteringConfig.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gboxFileFilteringConfig.Size = new System.Drawing.Size(755, 249);
            this.gboxFileFilteringConfig.TabIndex = 11;
            this.gboxFileFilteringConfig.TabStop = false;
            this.gboxFileFilteringConfig.Text = "تنظیم فیلترینگ فایل";
            this.gboxFileFilteringConfig.UseCompatibleTextRendering = true;
            // 
            // radioBtnExcludeFilesToProcess
            // 
            this.radioBtnExcludeFilesToProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnExcludeFilesToProcess.AutoSize = true;
            this.radioBtnExcludeFilesToProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioBtnExcludeFilesToProcess.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.radioBtnExcludeFilesToProcess.Location = new System.Drawing.Point(500, 166);
            this.radioBtnExcludeFilesToProcess.Name = "radioBtnExcludeFilesToProcess";
            this.radioBtnExcludeFilesToProcess.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioBtnExcludeFilesToProcess.Size = new System.Drawing.Size(250, 37);
            this.radioBtnExcludeFilesToProcess.TabIndex = 11;
            this.radioBtnExcludeFilesToProcess.Text = "همه فایل ها بجز فایل هایی با پسوند";
            this.radioBtnExcludeFilesToProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBtnExcludeFilesToProcess.UseCompatibleTextRendering = true;
            this.radioBtnExcludeFilesToProcess.UseVisualStyleBackColor = true;
            this.radioBtnExcludeFilesToProcess.CheckedChanged += new System.EventHandler(this.radioBtnExcludeFilesToProcess_CheckedChanged);
            // 
            // txtExcludeFilesToProcess
            // 
            this.txtExcludeFilesToProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExcludeFilesToProcess.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtExcludeFilesToProcess.Enabled = false;
            this.txtExcludeFilesToProcess.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtExcludeFilesToProcess.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtExcludeFilesToProcess.Location = new System.Drawing.Point(6, 166);
            this.txtExcludeFilesToProcess.Multiline = true;
            this.txtExcludeFilesToProcess.Name = "txtExcludeFilesToProcess";
            this.txtExcludeFilesToProcess.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtExcludeFilesToProcess.Size = new System.Drawing.Size(487, 74);
            this.txtExcludeFilesToProcess.TabIndex = 10;
            this.txtExcludeFilesToProcess.Text = ".gitignore .sln .resx";
            // 
            // gboxFolderFilteringConfig
            // 
            this.gboxFolderFilteringConfig.Controls.Add(this.radioBtnIncludeAllFoldersToProcess);
            this.gboxFolderFilteringConfig.Controls.Add(this.radioBtnExcludeFoldersToProcess);
            this.gboxFolderFilteringConfig.Controls.Add(this.radioBtnIncludeFoldersToProcess);
            this.gboxFolderFilteringConfig.Controls.Add(this.radioButton1);
            this.gboxFolderFilteringConfig.Controls.Add(this.radioButton2);
            this.gboxFolderFilteringConfig.Controls.Add(this.txtExcludeFoldersToProcess);
            this.gboxFolderFilteringConfig.Controls.Add(this.txtIncludeFoldersToProcess);
            this.gboxFolderFilteringConfig.Controls.Add(this.radioButton3);
            this.gboxFolderFilteringConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboxFolderFilteringConfig.ForeColor = System.Drawing.Color.DarkGray;
            this.gboxFolderFilteringConfig.Location = new System.Drawing.Point(0, 249);
            this.gboxFolderFilteringConfig.Name = "gboxFolderFilteringConfig";
            this.gboxFolderFilteringConfig.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gboxFolderFilteringConfig.Size = new System.Drawing.Size(755, 251);
            this.gboxFolderFilteringConfig.TabIndex = 12;
            this.gboxFolderFilteringConfig.TabStop = false;
            this.gboxFolderFilteringConfig.Text = "تنظیم فیلترینگ فولدر";
            this.gboxFolderFilteringConfig.UseCompatibleTextRendering = true;
            // 
            // radioBtnIncludeAllFoldersToProcess
            // 
            this.radioBtnIncludeAllFoldersToProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnIncludeAllFoldersToProcess.AutoSize = true;
            this.radioBtnIncludeAllFoldersToProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioBtnIncludeAllFoldersToProcess.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.radioBtnIncludeAllFoldersToProcess.Location = new System.Drawing.Point(602, 44);
            this.radioBtnIncludeAllFoldersToProcess.Name = "radioBtnIncludeAllFoldersToProcess";
            this.radioBtnIncludeAllFoldersToProcess.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioBtnIncludeAllFoldersToProcess.Size = new System.Drawing.Size(148, 37);
            this.radioBtnIncludeAllFoldersToProcess.TabIndex = 13;
            this.radioBtnIncludeAllFoldersToProcess.Text = "تبدیل همه فولدر ها";
            this.radioBtnIncludeAllFoldersToProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBtnIncludeAllFoldersToProcess.UseCompatibleTextRendering = true;
            this.radioBtnIncludeAllFoldersToProcess.UseVisualStyleBackColor = true;
            this.radioBtnIncludeAllFoldersToProcess.CheckedChanged += new System.EventHandler(this.radioBtnIncludeAllFoldersToProcess_CheckedChanged);
            // 
            // radioBtnExcludeFoldersToProcess
            // 
            this.radioBtnExcludeFoldersToProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnExcludeFoldersToProcess.AutoSize = true;
            this.radioBtnExcludeFoldersToProcess.Checked = true;
            this.radioBtnExcludeFoldersToProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioBtnExcludeFoldersToProcess.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.radioBtnExcludeFoldersToProcess.Location = new System.Drawing.Point(515, 171);
            this.radioBtnExcludeFoldersToProcess.Name = "radioBtnExcludeFoldersToProcess";
            this.radioBtnExcludeFoldersToProcess.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioBtnExcludeFoldersToProcess.Size = new System.Drawing.Size(235, 37);
            this.radioBtnExcludeFoldersToProcess.TabIndex = 14;
            this.radioBtnExcludeFoldersToProcess.TabStop = true;
            this.radioBtnExcludeFoldersToProcess.Text = "همه فایل ها بجز فولدر هایی با نام";
            this.radioBtnExcludeFoldersToProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBtnExcludeFoldersToProcess.UseCompatibleTextRendering = true;
            this.radioBtnExcludeFoldersToProcess.UseVisualStyleBackColor = true;
            this.radioBtnExcludeFoldersToProcess.CheckedChanged += new System.EventHandler(this.radioBtnExcludeFoldersToProcess_CheckedChanged);
            // 
            // radioBtnIncludeFoldersToProcess
            // 
            this.radioBtnIncludeFoldersToProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnIncludeFoldersToProcess.AutoSize = true;
            this.radioBtnIncludeFoldersToProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioBtnIncludeFoldersToProcess.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.radioBtnIncludeFoldersToProcess.Location = new System.Drawing.Point(592, 88);
            this.radioBtnIncludeFoldersToProcess.Name = "radioBtnIncludeFoldersToProcess";
            this.radioBtnIncludeFoldersToProcess.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioBtnIncludeFoldersToProcess.Size = new System.Drawing.Size(158, 37);
            this.radioBtnIncludeFoldersToProcess.TabIndex = 12;
            this.radioBtnIncludeFoldersToProcess.Text = "فقط فولدر هایی با نام";
            this.radioBtnIncludeFoldersToProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBtnIncludeFoldersToProcess.UseCompatibleTextRendering = true;
            this.radioBtnIncludeFoldersToProcess.UseVisualStyleBackColor = true;
            this.radioBtnIncludeFoldersToProcess.CheckedChanged += new System.EventHandler(this.radioBtnIncludeFoldersToProcess_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.radioButton1.Location = new System.Drawing.Point(1111, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton1.Size = new System.Drawing.Size(142, 37);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.Text = "تبدیل همه فایل ها";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseCompatibleTextRendering = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.radioButton2.Location = new System.Drawing.Point(1003, 149);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton2.Size = new System.Drawing.Size(250, 37);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.Text = "همه فایل ها بجز فایل هایی با پسوند";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseCompatibleTextRendering = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // txtExcludeFoldersToProcess
            // 
            this.txtExcludeFoldersToProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExcludeFoldersToProcess.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtExcludeFoldersToProcess.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtExcludeFoldersToProcess.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtExcludeFoldersToProcess.Location = new System.Drawing.Point(6, 168);
            this.txtExcludeFoldersToProcess.Multiline = true;
            this.txtExcludeFoldersToProcess.Name = "txtExcludeFoldersToProcess";
            this.txtExcludeFoldersToProcess.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtExcludeFoldersToProcess.Size = new System.Drawing.Size(487, 74);
            this.txtExcludeFoldersToProcess.TabIndex = 10;
            this.txtExcludeFoldersToProcess.Text = ".git .vs .vscode bin obj debug release";
            // 
            // txtIncludeFoldersToProcess
            // 
            this.txtIncludeFoldersToProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIncludeFoldersToProcess.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIncludeFoldersToProcess.Enabled = false;
            this.txtIncludeFoldersToProcess.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIncludeFoldersToProcess.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtIncludeFoldersToProcess.Location = new System.Drawing.Point(6, 85);
            this.txtIncludeFoldersToProcess.Multiline = true;
            this.txtIncludeFoldersToProcess.Name = "txtIncludeFoldersToProcess";
            this.txtIncludeFoldersToProcess.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIncludeFoldersToProcess.Size = new System.Drawing.Size(563, 76);
            this.txtIncludeFoldersToProcess.TabIndex = 2;
            this.txtIncludeFoldersToProcess.Text = "Source src";
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton3.AutoSize = true;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.radioButton3.Location = new System.Drawing.Point(1079, 66);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton3.Size = new System.Drawing.Size(174, 37);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.Text = "فقط فایل هایی با پسوند";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.UseCompatibleTextRendering = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnClearOutputFolder
            // 
            this.btnClearOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearOutputFolder.BackColor = System.Drawing.Color.LightGray;
            this.btnClearOutputFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearOutputFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearOutputFolder.Font = new System.Drawing.Font("B Nazanin", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearOutputFolder.Location = new System.Drawing.Point(591, 515);
            this.btnClearOutputFolder.Name = "btnClearOutputFolder";
            this.btnClearOutputFolder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClearOutputFolder.Size = new System.Drawing.Size(112, 37);
            this.btnClearOutputFolder.TabIndex = 13;
            this.btnClearOutputFolder.Text = "Clear Output Folder";
            this.btnClearOutputFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearOutputFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClearOutputFolder.UseCompatibleTextRendering = true;
            this.btnClearOutputFolder.UseVisualStyleBackColor = false;
            this.btnClearOutputFolder.Click += new System.EventHandler(this.btnClearOutputFolder_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbout.Font = new System.Drawing.Font("B Nazanin", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAbout.ForeColor = System.Drawing.Color.LightYellow;
            this.btnAbout.Location = new System.Drawing.Point(4, 551);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(27, 23);
            this.btnAbout.TabIndex = 14;
            this.btnAbout.Text = "؟ About";
            this.btnAbout.UseCompatibleTextRendering = true;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(755, 576);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnClearOutputFolder);
            this.Controls.Add(this.gboxFolderFilteringConfig);
            this.Controls.Add(this.btnDoItAgain);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.chBoxJutRootFolderFiles);
            this.Controls.Add(this.btnTranslateCharSet);
            this.Controls.Add(this.gboxFileFilteringConfig);
            this.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainForm";
            this.Text = "Translations";
            this.gboxFileFilteringConfig.ResumeLayout(false);
            this.gboxFileFilteringConfig.PerformLayout();
            this.gboxFolderFilteringConfig.ResumeLayout(false);
            this.gboxFolderFilteringConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTranslateCharSet;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckBox chBoxJutRootFolderFiles;
        private System.Windows.Forms.TextBox txtIncludeFilesToProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnDoItAgain;
        private System.Windows.Forms.RadioButton radioBtnIncludeFilesToProcess;
        private System.Windows.Forms.RadioButton radioBtnIncludeAllFilesToProcess;
        private System.Windows.Forms.GroupBox gboxFileFilteringConfig;
        private System.Windows.Forms.RadioButton radioBtnExcludeFilesToProcess;
        private System.Windows.Forms.TextBox txtExcludeFilesToProcess;
        private System.Windows.Forms.GroupBox gboxFolderFilteringConfig;
        private System.Windows.Forms.RadioButton radioBtngIncludeAllFoldersToProcess;
        private System.Windows.Forms.RadioButton radioBtnExcludeFoldersToProcess;
        private System.Windows.Forms.RadioButton radioBtnIncludeFoldersToProcess;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txtExcludeFoldersToProcess;
        private System.Windows.Forms.TextBox txtIncludeFoldersToProcess;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioBtnIncludeAllFoldersToProcess;
        private System.Windows.Forms.Button btnClearOutputFolder;
        private System.Windows.Forms.Button btnAbout;
    }
}

