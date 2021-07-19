using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
	class InventoryManager
	{
		public List<InventoryItem> products = new List<InventoryItem>();
		
		public InventoryManager()
		{
			//default constructor
		}

		public void add(List<InventoryItem> list, InventoryItem item)
		{
			products.Add(item);
		}

		public void remove(List<InventoryItem> list,InventoryItem item)
		{
            list.Remove(item);
		}

		public string update(List<InventoryItem> list, InventoryItem item, string updatedName)
		{
            //loop through elements
            for (int i = 0; i < list.Count; i++)
            {
                if (item.ItemName == updatedName)
                {
                    MessageBox.Show("Product updated successfully!");
					break;
                }
            }
			//restock items quantity
			return item.ItemName + ": " + "$" + item.ItemPrice + " | Qty Available: " + item.ItemQuantity;
        }

            //NEW CODE ATTEMPT TO CHECK ITEMS IN LIST BY NAME.. ****NEW CODE WORKS! 7/8/2019 Update****
            //Upon further testing, the 'item not found' works sometimes but loops through too many items, although it find the item searched for
        public void search(List<InventoryItem> list, string searchTerm)
        {
            foreach(InventoryItem item in list)
            {
				if (item.ItemName == searchTerm)
				{
					MessageBox.Show($"Found {searchTerm} in Inventory directory.");
				}
				else
				{
					MessageBox.Show($"Item {searchTerm} notfound!");
				}
            }
        }

        public string display(InventoryItem item)
		{
			//display the item name and the price of the item
			
			return item.ItemName + ": " + "$" + item.ItemPrice + " | Qty Available: " + item.ItemQuantity;
		}
		public void display(List<InventoryItem> list, InventoryItem item)
		{
			MessageBox.Show(item.ToString());
		}

		public void display(List<InventoryItem> list, string item)
		{
			MessageBox.Show(item.ToString());
		}
	}
}
