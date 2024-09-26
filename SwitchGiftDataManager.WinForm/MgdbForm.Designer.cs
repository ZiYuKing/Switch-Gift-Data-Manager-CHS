namespace SwitchGiftDataManager.WinForm
{
    partial class MgdbForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MgdbForm));
            lblMessage = new Label();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(110, 8);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(108, 17);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "正在下载, 请稍候...";
            // 
            // MgdbForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 34);
            ControlBox = false;
            Controls.Add(lblMessage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MgdbForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "神秘礼物数据库";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMessage;
    }
}