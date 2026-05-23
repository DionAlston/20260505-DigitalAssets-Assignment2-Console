namespace _20260422_Test
{
    partial class  Form1
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
            panelContent = new Panel();
            btnInventory = new Button();
            btnHome = new Button();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.BackColor = SystemColors.ControlLight;
            panelContent.Location = new Point(0, 35);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(735, 375);
            panelContent.TabIndex = 0;
            panelContent.Paint += panelContent_Paint;
            // 
            // btnInventory
            // 
            btnInventory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInventory.Location = new Point(115, 3);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(97, 26);
            btnInventory.TabIndex = 3;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnHome
            // 
            btnHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.Location = new Point(12, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(97, 26);
            btnHome.TabIndex = 4;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(734, 411);
            Controls.Add(btnHome);
            Controls.Add(panelContent);
            Controls.Add(btnInventory);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);

        }

        #endregion

        private Panel panelContent;
        private Button btnInventory;
        private Button btnHome;
    }
}