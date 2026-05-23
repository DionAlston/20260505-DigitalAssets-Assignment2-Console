namespace _20260422_Test
{
    partial class UC_Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Home));
            labelWelcomeInfo = new Label();
            labelWelcomeBig = new Label();
            pictureBoxLogoBanner = new PictureBox();
            labelCopyright = new Label();
            labelWelcomeDC = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoBanner).BeginInit();
            SuspendLayout();
            // 
            // labelWelcomeInfo
            // 
            labelWelcomeInfo.AutoSize = true;
            labelWelcomeInfo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelWelcomeInfo.ForeColor = SystemColors.ControlText;
            labelWelcomeInfo.Location = new Point(21, 240);
            labelWelcomeInfo.Name = "labelWelcomeInfo";
            labelWelcomeInfo.Size = new Size(550, 25);
            labelWelcomeInfo.TabIndex = 1;
            labelWelcomeInfo.Text = "Stationary and Consumable Stores Management Application\r\n";
            // 
            // labelWelcomeBig
            // 
            labelWelcomeBig.AutoSize = true;
            labelWelcomeBig.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelWelcomeBig.Location = new Point(12, 150);
            labelWelcomeBig.Margin = new Padding(0, 0, 3, 0);
            labelWelcomeBig.Name = "labelWelcomeBig";
            labelWelcomeBig.Size = new Size(237, 65);
            labelWelcomeBig.TabIndex = 2;
            labelWelcomeBig.Text = "Welcome";
            labelWelcomeBig.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxLogoBanner
            // 
            pictureBoxLogoBanner.Image = (Image)resources.GetObject("pictureBoxLogoBanner.Image");
            pictureBoxLogoBanner.Location = new Point(15, 390);
            pictureBoxLogoBanner.Name = "pictureBoxLogoBanner";
            pictureBoxLogoBanner.Size = new Size(375, 45);
            pictureBoxLogoBanner.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogoBanner.TabIndex = 3;
            pictureBoxLogoBanner.TabStop = false;
            // 
            // labelCopyright
            // 
            labelCopyright.AutoSize = true;
            labelCopyright.Location = new Point(545, 420);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(188, 15);
            labelCopyright.TabIndex = 4;
            labelCopyright.Text = "© Australian Capital Territory 2026";
            // 
            // labelWelcomeDC
            // 
            labelWelcomeDC.AutoSize = true;
            labelWelcomeDC.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelWelcomeDC.ForeColor = Color.DarkBlue;
            labelWelcomeDC.Location = new Point(21, 215);
            labelWelcomeDC.Name = "labelWelcomeDC";
            labelWelcomeDC.Size = new Size(154, 25);
            labelWelcomeDC.TabIndex = 5;
            labelWelcomeDC.Text = "Dickson College";
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(labelWelcomeDC);
            Controls.Add(labelCopyright);
            Controls.Add(pictureBoxLogoBanner);
            Controls.Add(labelWelcomeBig);
            Controls.Add(labelWelcomeInfo);
            Name = "UC_Home";
            Size = new Size(750, 450);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoBanner).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Label labelWelcomeInfo;
        private Label labelWelcomeBig;
        private PictureBox pictureBoxLogoBanner;
        private Label labelCopyright;
        private Label labelWelcomeDC;
    }
}
