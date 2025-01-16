namespace Certiflyte
{
    partial class Splash
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
            appNameLabel = new Label();
            appTypeLabel = new Label();
            deviceIDLabel = new Label();
            SuspendLayout();
            // 
            // appNameLabel
            // 
            appNameLabel.AutoSize = true;
            appNameLabel.Font = new Font("Segoe UI Semibold", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appNameLabel.Location = new Point(73, 108);
            appNameLabel.Name = "appNameLabel";
            appNameLabel.Size = new Size(567, 159);
            appNameLabel.TabIndex = 0;
            appNameLabel.Text = "Certiflyer";
            // 
            // appTypeLabel
            // 
            appTypeLabel.AutoSize = true;
            appTypeLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appTypeLabel.Location = new Point(469, 132);
            appTypeLabel.Name = "appTypeLabel";
            appTypeLabel.Size = new Size(141, 38);
            appTypeLabel.TabIndex = 1;
            appTypeLabel.Text = "Enterprise";
            // 
            // deviceIDLabel
            // 
            deviceIDLabel.AutoSize = true;
            deviceIDLabel.Location = new Point(12, 366);
            deviceIDLabel.Name = "deviceIDLabel";
            deviceIDLabel.Size = new Size(118, 20);
            deviceIDLabel.TabIndex = 2;
            deviceIDLabel.Text = "Device Identifier";
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 395);
            Controls.Add(deviceIDLabel);
            Controls.Add(appTypeLabel);
            Controls.Add(appNameLabel);
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            Load += Splash_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label appNameLabel;
        private Label appTypeLabel;
        private Label deviceIDLabel;
    }
}