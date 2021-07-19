using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
	public partial class homeScreen : Form
	{
		//list of inventory items
		List<InventoryItem> products = new List<InventoryItem>();

		//Inventory Manager
		InventoryManager inventory = new InventoryManager();

		//closing message for Management System
		//instantiate object
		Close message = new Close();

		int index;
		int quantity;

		public homeScreen()
		{
			InitializeComponent();
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			//display close message
			message.ShowDialog();
			//EXIT THE PROGRAM
			this.Close();
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			//CLEAR THE LISTBOX
			InventoryContents.Items.Clear();
            addName.Text = "";
            searchName.Text = "";
            updateName.Text = "";

            addPrice.Text = "";
            searchPrice.Text = "";
            updatePrice.Text = "";

            addQuantity.Text = "";
            searchQuantity.Text = "";
            updateQuantity.Text = "";


		}

		private void addButton_Click(object sender, EventArgs e)
		{
			//temporary values for name, quantity and price of products
			string name;
			decimal price;

			//error handling for adding the product information
			try
			{
				if(decimal.TryParse(addPrice.Text, out price))
				{
					if(int.TryParse(addQuantity.Text, out quantity))
					{
						name = addName.Text;
						inventory.add(products, new InventoryItem(name, price, quantity));
						products.Add(new InventoryItem(name, price, quantity));

						//show message confirming item added
						MessageBox.Show("Item added successfully!");
					}
					else
					{
						MessageBox.Show("Incorrect value for quantity, try again.");
					}
				}
				else
				{
					MessageBox.Show("Incorrect value for Price, try again.");
					addPrice.Text = "";
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);//display exception
			}
			
			for(int i = 0; i < products.Count; i++)
			{
				inventory.add(products, products[i]);//loop through array and add item to 'products' array
				InventoryContents.Items.Add(products[i]);//add to list
			}
			//clear textboxes
			addName.Text = "";
			addPrice.Text = "";
			addQuantity.Text = "";

			//clear Listbox after
			InventoryContents.Items.Clear();
		}

		private void InventoryContents_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				index = InventoryContents.SelectedIndex;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);//display error message
			}
		}

		private void displayButton_Click(object sender, EventArgs e)
		{

			if(products.Count == 0)
			{
				MessageBox.Show("No products to display!");
			}
			else if (products.Count >= 1)
			{
				//clear the contents and reprint upon each click to prevent duplicates
				InventoryContents.Items.Clear();

				//display inventory products
				foreach (InventoryItem item in products)
				{
					//inventory.display(products, item.ItemName); // a message box pops up if this is uncommented (for testing purposes)
					InventoryContents.Items.Add(inventory.display(item));//display inventory using display method
				}
			}
		}
        //button works with full capabilities as of 8/31/2019 
        //item removes from list
		private void removeButton_Click(object sender, EventArgs e)
		{
            //if an item is selected
			if(InventoryContents.SelectedIndex != -1)
            {
                inventory.remove(products, products[index]);//remove the product selected from the list
                MessageBox.Show("Selected item removed.");
                if(InventoryContents.SelectedIndex == index)
                {
                    InventoryContents.Items.RemoveAt(index);
                }
            }
		}
        /*
         * Everything Work except the Price doesn't update on its own if nothing else is updated
         */
        private void updateButton_Click(object sender, EventArgs e)
        {
            //all temp variables to hold values
            string newName;
            decimal newPrice;
            int newQuantity;
            for(int i = 0; i < products.Count; i++)
            {
                index = InventoryContents.SelectedIndex;
                inventory.update(products, products[index], updateName.Text);
                if (updateName.Text != null)
                {
                    if(updateName.Text == "")
                    {
                        //do nothing
                        continue;
                    }
                    else
                    {
                        newName = updateName.Text;
                        products[index].ItemName = newName;
                        MessageBox.Show("Product Name updated to " + newName);
                    }

                    if(updatePrice.Text != null)
                    {
                        //code to update price
                        if(decimal.TryParse(updatePrice.Text.ToString(), out newPrice))
                        {
                            if(updatePrice.Text == "")
                            {
                                continue;
                            }
                            else
                            {
                                //update price
                                products[index].ItemPrice = newPrice;
                                MessageBox.Show("Price Updated to " + newPrice);
                            }
                        }
                        if(updateQuantity.Text != null)
                        {
                            //code to update quantity

                            if (int.TryParse(updateQuantity.Text.ToString(), out newQuantity))
                            {
                                if(updateQuantity.Text == "")
                                {
                                    //do nothing
                                    continue;
                                }
                                else
                                {
                                    products[index].ItemQuantity = newQuantity;
                                    MessageBox.Show("Quantity updated to " + newQuantity);
                                }
                            }
                        }
                    }
                    InventoryContents.Items.Clear();//clear the Invetory Contents
                    //clear all fields after updating everything
                    updateName.Text = "";
                    updatePrice.Text = "";
                    updateQuantity.Text = "";
                }
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
		{
			/*
			 * Only issue with search is the casing.
			 * Actually, more issue found (5/13/19) message box displaying too many times
			 * and other strange bugs with the message box search.
             * 8/30/2019 FIXED ISSUE WITH MULTIPLE MESSAGE BOX BY REMOVING 'ELSE' BLOCK OF 'IF-ELSE' STATEMENT
             * Now the proper searched Items returns.. HOWEVER.. need to determine whether 'search' is necessary in InventoryManager.cs
			 */
			//test loop to fix bug in foreach loop
			for (int i = 0; i < products.Count; i++)
			{
                inventory.search(products, products[i]);
                if (products[i].ItemName.Equals(searchName.Text))
                {
                    //change this to display searched item in listbox
                    MessageBox.Show("Item " + searchName.Text + " found in Inventory!");
				}
				else
				{
					MessageBox.Show("Nothing found.");
				}
            }
        }

		private void updateName_TextChanged(object sender, EventArgs e)
		{

		}

		private void homeScreen_Load(object sender, EventArgs e)
		{

		}
	}
}
