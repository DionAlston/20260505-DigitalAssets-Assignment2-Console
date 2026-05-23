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
            panelNavigation = new Panel();
            btnInventory = new Button();
            buttonHome = new Button();
            panelContent.SuspendLayout();
            panelNavigation.SuspendLayout();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.BackColor = SystemColors.ActiveCaption;
            panelContent.Controls.Add(panelNavigation);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(734, 411);
            panelContent.TabIndex = 0;
            // 
            // panelNavigation
            // 
            panelNavigation.BackColor = SystemColors.ControlDark;
            panelNavigation.Controls.Add(btnInventory);
            panelNavigation.Controls.Add(buttonHome);
            panelNavigation.Dock = DockStyle.Top;
            panelNavigation.Location = new Point(0, 0);
            panelNavigation.Name = "panelNavigation";
            panelNavigation.Size = new Size(734, 45);
            panelNavigation.TabIndex = 16;
            // 
            // btnInventory
            // 
            btnInventory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInventory.Location = new Point(113, 10);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(97, 26);
            btnInventory.TabIndex = 3;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
            // 
            // buttonHome
            // 
            buttonHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHome.Location = new Point(10, 10);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(97, 26);
            buttonHome.TabIndex = 0;
            buttonHome.Text = "Homepage";
            buttonHome.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 411);
            Controls.Add(panelContent);
            Name = "Form1";
            Text = "Form1";
            panelContent.ResumeLayout(false);
            panelNavigation.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private Panel panelContent;
        private Panel panelNavigation;
        private Button btnInventory;
        private Button buttonHome;
    }
}