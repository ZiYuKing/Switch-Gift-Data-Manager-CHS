namespace SwitchGiftDataManager.WinForm
{
    partial class SaveWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveWindow));
            GrpBuild = new GroupBox();
            RadioUnique = new RadioButton();
            RadioMultiple = new RadioButton();
            TxtDestPath = new TextBox();
            BtnPath = new Button();
            GrpDest = new GroupBox();
            BtnCancel = new Button();
            BtnSave = new Button();
            FolderBrowser = new FolderBrowserDialog();
            groupBox2 = new GroupBox();
            BtnSrcBrowse = new Button();
            TxtSourcePath = new TextBox();
            GrpBuild.SuspendLayout();
            GrpDest.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // GrpBuild
            // 
            GrpBuild.Controls.Add(RadioUnique);
            GrpBuild.Controls.Add(RadioMultiple);
            GrpBuild.Location = new Point(14, 12);
            GrpBuild.Name = "GrpBuild";
            GrpBuild.Size = new Size(515, 58);
            GrpBuild.TabIndex = 0;
            GrpBuild.TabStop = false;
            GrpBuild.Text = "保存方式";
            // 
            // RadioUnique
            // 
            RadioUnique.AutoSize = true;
            RadioUnique.Location = new Point(268, 26);
            RadioUnique.Name = "RadioUnique";
            RadioUnique.Size = new Size(135, 24);
            RadioUnique.TabIndex = 1;
            RadioUnique.Text = "保持分开的文件";
            RadioUnique.UseVisualStyleBackColor = true;
            // 
            // RadioMultiple
            // 
            RadioMultiple.AutoSize = true;
            RadioMultiple.Checked = true;
            RadioMultiple.Location = new Point(86, 26);
            RadioMultiple.Name = "RadioMultiple";
            RadioMultiple.Size = new Size(135, 24);
            RadioMultiple.TabIndex = 0;
            RadioMultiple.TabStop = true;
            RadioMultiple.Text = "合并为一个文件";
            RadioMultiple.UseVisualStyleBackColor = true;
            // 
            // TxtDestPath
            // 
            TxtDestPath.Location = new Point(7, 26);
            TxtDestPath.Name = "TxtDestPath";
            TxtDestPath.Size = new Size(402, 27);
            TxtDestPath.TabIndex = 1;
            // 
            // BtnPath
            // 
            BtnPath.Location = new Point(416, 26);
            BtnPath.Name = "BtnPath";
            BtnPath.Size = new Size(92, 29);
            BtnPath.TabIndex = 2;
            BtnPath.Text = "浏览";
            BtnPath.UseVisualStyleBackColor = true;
            BtnPath.Click += BtnPath_Click;
            // 
            // GrpDest
            // 
            GrpDest.Controls.Add(TxtDestPath);
            GrpDest.Controls.Add(BtnPath);
            GrpDest.Location = new Point(14, 153);
            GrpDest.Name = "GrpDest";
            GrpDest.Size = new Size(515, 66);
            GrpDest.TabIndex = 3;
            GrpDest.TabStop = false;
            GrpDest.Text = "BCAT目的路径";
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(111, 225);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(141, 29);
            BtnCancel.TabIndex = 4;
            BtnCancel.Text = "取消";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(281, 225);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(141, 29);
            BtnSave.TabIndex = 5;
            BtnSave.Text = "保存";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnSrcBrowse);
            groupBox2.Controls.Add(TxtSourcePath);
            groupBox2.Location = new Point(14, 76);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(515, 66);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "BCAT来源路径";
            // 
            // BtnSrcBrowse
            // 
            BtnSrcBrowse.Location = new Point(416, 26);
            BtnSrcBrowse.Name = "BtnSrcBrowse";
            BtnSrcBrowse.Size = new Size(92, 27);
            BtnSrcBrowse.TabIndex = 1;
            BtnSrcBrowse.Text = "浏览";
            BtnSrcBrowse.UseVisualStyleBackColor = true;
            BtnSrcBrowse.Click += BtnSrcBrowse_Click;
            // 
            // TxtSourcePath
            // 
            TxtSourcePath.Location = new Point(7, 26);
            TxtSourcePath.Name = "TxtSourcePath";
            TxtSourcePath.Size = new Size(402, 27);
            TxtSourcePath.TabIndex = 0;
            // 
            // SaveWindow
            // 
            AcceptButton = BtnSave;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnCancel;
            ClientSize = new Size(543, 261);
            Controls.Add(groupBox2);
            Controls.Add(BtnSave);
            Controls.Add(BtnCancel);
            Controls.Add(GrpDest);
            Controls.Add(GrpBuild);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SaveWindow";
            StartPosition = FormStartPosition.Manual;
            Text = "保存BCAT";
            GrpBuild.ResumeLayout(false);
            GrpBuild.PerformLayout();
            GrpDest.ResumeLayout(false);
            GrpDest.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GrpBuild;
        private RadioButton RadioUnique;
        private RadioButton RadioMultiple;
        private TextBox TxtDestPath;
        private Button BtnPath;
        private GroupBox GrpDest;
        private Button BtnCancel;
        private Button BtnSave;
        private FolderBrowserDialog FolderBrowser;
        private GroupBox groupBox2;
        private Button BtnSrcBrowse;
        private TextBox TxtSourcePath;
    }
}