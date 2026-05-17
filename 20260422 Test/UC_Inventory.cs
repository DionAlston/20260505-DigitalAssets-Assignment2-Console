using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;                        // New
using System.Text.RegularExpressions;   // New
using System.Windows.Forms;

namespace _20260422_Test
{
    public partial class UC_Inventory : UserControl
    {
        public UC_Inventory()
        {
            InitializeComponent();
        }

        // Data structures to hold products in bindingList and bindingSource
        // Function: Allows for updating of DGV and UI
        private BindingList<Product> _inventoryList = new BindlingList<Product>();
        private BindingSource _bindingSource = new BindingSource();

        string filePath = "./inventory.csv";


        // For loading of UC_Inventory
        // NOTE: Configure and implement CSV file
        private void UC_Inventory_Load(object sender, EventArgs e)
        {
            string path = filePath;

            var tempData = InventoryService.LoadFromCSV(path);

            _inventoryList.Clear();
            foreach (var item in tempData)
            {
                _inventoryList.Add(item);
            }

            dgvInventory.DataSource = _inventoryList;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)   // ???
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) = return;

            int newId
            string name
            string brand
            decimal price
            int quantity

            Product newProduct = new Product (newId, name, brand, price, quantity);
            _inventoryList.Add(newProduct);

            _bindingSource.ResetBindings = (false);

            ClearFields();

        }

        // Updating products logic
        // On event of button Click, machine will check for the integer declared in txtID
        // If a declared integer is not in catalogue. Machine will display message and return prompt to user
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out int idToUpdate))
            {
                MessageBox.Show("Please select a valid product ID from the inventory catalogue to update.");
                return;
            }
            var productToUpdate = _inventoryList.FirstOrDefault(p => p.ProductID == idToUpdate);

            // Updating declared fields if properties not Null
            if (productToUpdate != null)
            {
                // Validate the new inputs before applying changes
                if (ValidateInputs())
                {
                    // Update the object properties (excluding ProductID)
                    productToUpdate.ProductName = txtName.Text;
                    productToUpdate.ProductBrand = txtBrand.Text;
                    productToUpdate.ProductPrice = decimal.Parse(txtPrice.Text);
                    productToUpdate.ProductQuantity = int.Parse(txtQuantity.Text);

                    // Refresh the grid to show the updated data
                    _bindingSource.ResetBindings(false);
                    dgvInventory.Refresh();

                    // Clear input fields
                    ClearFields();
                    MessageBox.Show("Product updated successfully in catalogue.");
                }
            }
            else
            {
                MessageBox.Show("Product ID not found in inventory catalogue.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Search
            {

            }

            Product productToDelete = Product 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ,

            ClearFields();
        }

        // Validating user inputs into editable fields using regex
        private bool ValidateInputs()
        {
            // Check if name has characters that are not upper or lowercase alphabet letters, positive integers 0-9 or spaces
            if (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z0-9 ]+$"))
            {
                MessageBox.Show("Invalid input. Please only use letters and numbers (0-9) in the Product Name.");
                return false;
            }
            // Check if price is a decimal and register as invalid
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Invalid input. Please enter a valid positive price.");
                return false;
            }
            // Check if qty is positive integer and register as invalid
            if (!int.TryParse(txtQuantity.Text, out int qty) || qty < 0)
            {
                MessageBox.Show("Invalid input. Please enter a valid positive quantity.");
                return false;
            }

            return true;
            // NOTE python made for processing data and for analysis not for building programs
        }
        // Clearing of editable fields, used in btnAdd_Click
        private void ClearFields()
        {
            txtID.Clear();
            txtName.Clear();
            txtBrand.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            // NOTE 13/05 Change txt element names to above in Inventory form design
                 // 17/05 ???
        }

        // EXPERIMENTAL new feature / Moving text
        // 17/05 Make colour in gradiance (rainbow) with timer2?
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelWelcome.Left -= 2;

            // If the label disappears off the left edge, reset it to the right edge
            if (labelWelcome.Right < 0)
            {
                labelWelcome.Left = this.Width;
            }
        }
    }
}
