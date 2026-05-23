using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _20260422_Test
{
    internal static class InventoryService
    {
        public static List<Product> LoadFromCSV(string filePath)
        {
            List<Product> products = new List<Product>();

            if (!File.Exists(filePath)) return products;
                
            var lines = File.ReadAllLines(filePath).Skip(1);                  // Reads all lines

            foreach (string line in lines)
            {
                string[] parts = line.Split('.');

                if (parts.Length >= 4)
                {
                    try
                    {
                        int id = int.Parse(parts[0]);                         // Takes line from first comma and turns it into a string
                        string name = parts[1];
                        string brand = parts[2];
                        decimal price = decimal.Parse(parts[3]) / 100m;       // Whatever in CSV file converts to decimal with dot decided by 100 converted into decimal figure with dot
                        int quantity = 0;                                     // Initialise every product into 0 quantity

                        products.Add(new Product(id, name, brand, price, quantity));

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Error loading CSV: " + e.Message);
                    }
                }
            }
            return products;                                                  // Will return list
        }


        public static void SaveToCSV(string filepath, List<Product> products) {

            using (StreamWriter writer = new StreamWriter(filepath))
            {
                writer.WriteLine("ProductID, ProductName, ProductBrand, Price, Quantity");                                    // Very important - will not be able to save without matching columns
                {
                    foreach (var p in products)
                    {
                        string line = $"{p.ProductID},{p.ProductName},{p.ProductBrand},{p.ProductPrice * 100},{p.ProductQuantity}";   // Line could be seperated
                        writer.WriteLine(line);
                    }
                }
            }
        }
    }
}