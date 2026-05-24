namespace _20260422_Test
{
    partial class UC_Inventory
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
            components = new System.ComponentModel.Container();
            btnAdd = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            txtName = new TextBox();
            txtID = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtBrand = new TextBox();
            btnUpdate = new Button();
            labelName = new Label();
            labelID = new Label();
            labelPrice = new Label();
            labelQuantity = new Label();
            labelBrand = new Label();
            labelWelcome = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            dgvInventory = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductBrand = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            txtDelete = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(10, 217);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
            btnDelete.Location = new Point(157, 289);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 23);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(94, 217);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(78, 23);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(62, 7);
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 23);
            txtName.TabIndex = 3;
            // 
            // txtID
            // 
            txtID.Location = new Point(62, 36);
            txtID.Name = "txtID";
            txtID.Size = new Size(180, 23);
            txtID.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(62, 65);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(180, 23);
            txtPrice.TabIndex = 6;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(62, 94);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(180, 23);
            txtQuantity.TabIndex = 7;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(62, 123);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(180, 23);
            txtBrand.TabIndex = 8;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(178, 217);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 23);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(17, 10);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 10;
            labelName.Text = "Name";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(38, 39);
            labelID.Name = "labelID";
            labelID.Size = new Size(18, 15);
            labelID.TabIndex = 11;
            labelID.Text = "ID";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(23, 68);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(33, 15);
            labelPrice.TabIndex = 12;
            labelPrice.Text = "Price";
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(3, 97);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(53, 15);
            labelQuantity.TabIndex = 13;
            labelQuantity.Text = "Quantity";
            // 
            // labelBrand
            // 
            labelBrand.AutoSize = true;
            labelBrand.Location = new Point(18, 126);
            labelBrand.Name = "labelBrand";
            labelBrand.Size = new Size(38, 15);
            labelBrand.TabIndex = 14;
            labelBrand.Text = "Brand";
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelWelcome.Location = new Point(212, 2);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(292, 21);
            labelWelcome.TabIndex = 16;
            labelWelcome.Text = "Welcome to the Inventory Catalogue";
            labelWelcome.Click += labelWelcome_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 25;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(labelBrand);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(labelQuantity);
            panel1.Controls.Add(txtQuantity);
            panel1.Controls.Add(labelPrice);
            panel1.Controls.Add(txtBrand);
            panel1.Controls.Add(labelID);
            panel1.Location = new Point(10, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 157);
            panel1.TabIndex = 17;
            // 
            // dgvInventory
            // 
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, ProductBrand, Price, Quantity });
            dgvInventory.Location = new Point(282, 36);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowTemplate.Height = 25;
            dgvInventory.Size = new Size(443, 324);
            dgvInventory.TabIndex = 18;
            dgvInventory.CellContentClick += dgvInventory_CellContentClick;
            // 
            // ProductID
            // 
            ProductID.HeaderText = "ID";
            ProductID.Name = "ProductID";
            ProductID.ReadOnly = true;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Name";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // ProductBrand
            // 
            ProductBrand.HeaderText = "Brand";
            ProductBrand.Name = "ProductBrand";
            ProductBrand.ReadOnly = true;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Qty";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // txtDelete
            // 
            txtDelete.Location = new Point(13, 289);
            txtDelete.Name = "txtDelete";
            txtDelete.Size = new Size(141, 23);
            txtDelete.TabIndex = 19;
            txtDelete.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 36);
            label1.Name = "label1";
            label1.Size = new Size(181, 15);
            label1.TabIndex = 20;
            label1.Text = "Add or Edit Product in Catalogue";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 271);
            label2.Name = "label2";
            label2.Size = new Size(220, 15);
            label2.TabIndex = 21;
            label2.Text = "Delete a Catalogue listing by ID or Name";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.ForestGreen;
            btnSave.Location = new Point(72, 337);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 23);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // UC_Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDelete);
            Controls.Add(dgvInventory);
            Controls.Add(panel1);
            Controls.Add(labelWelcome);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Name = "UC_Inventory";
            Size = new Size(735, 375);
            Load += UC_Inventory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button btnAdd;
        private Button btnDelete;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnSave;
        private TextBox txtName;
        private TextBox txtID;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtBrand;
        private Label labelName;
        private Label labelID;
        private Label labelPrice;
        private Label labelQuantity;
        private Label labelBrand;
        private Label labelWelcome;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private DataGridView dgvInventory;
        private TextBox txtDelete;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductBrand;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
    }
}
