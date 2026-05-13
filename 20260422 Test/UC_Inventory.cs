using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //New
using System.Text.RegularExpressions; //New
using System.Windows.Forms;

namespace _20260422_Test
{
    public partial class UC_Inventory : UserControl
    {
        public UC_Inventory()
        {
            InitializeComponent();
        }

        private void UC_Inventory_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

            // Logic for updating declared fields
            if (productToUpdate != null)
            {
                // 3. Validate the new inputs before applying changes
                if (ValidateInputs())
                {
                    // 4. Update the object properties (excluding ProductID)
                    productToUpdate.ProductName = txtName.Text;
                    productToUpdate.ProductBrand = txtBrand.Text;
                    productToUpdate.ProductPrice = decimal.Parse(txtPrice.Text);
                    productToUpdate.ProductQuantity = int.Parse(txtQuantity.Text);

                    // 5. Refresh the grid to show the updated data
                    _bindingSource.ResetBindings(false);
                    dgvInventory.Refresh();

                    // 6. Clear input fields
                    ClearFields();
                    MessageBox.Show("Product updated successfully in catalogue.");
                }
            }
            else
            {
                MessageBox.Show("Product ID not found in inventory catalogue.");
            }
        }

        // In regex: Validating inventory user inputs into editable fields
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
        // logic for clearing editable fields
        private void ClearFields()
        {
            txtID.Clear();
            txtName.Clear();
            txtBrand.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            // 13/05 Change txt element names to above in Inventory form design
        }
    }
}
