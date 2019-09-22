using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
	class InventoryItem
	{
		//backing fields for an item in inventory to hold
		private string _itemName;
		private decimal _itemPrice;
		private int _itemQuantity;
		private int _itemCalories;
		private string _vendorName;

		public InventoryItem()
		{
			//default constructor
		}

		//Constructor only with name parameter for simple listing purposes
		public InventoryItem(string name)
		{
			this._itemName = name;
		}

		//Constructor only with name and price parameters for simple listing and search purposes
		public InventoryItem(string name, decimal price)
		{
			this._itemName = name;
			this._itemPrice = price;
		}

		//Constructor with name, price and quantity values for more advanced operations
		public InventoryItem(string name, decimal price, int quantity)
		{
			this._itemName = name;
			this._itemPrice = price;
			this._itemQuantity = quantity;
		}

		//Constructor with all parameters EXCEPT 'calories'
		//meant for non-food items such as a notebook, pencil, etc.
		public InventoryItem(string name, decimal price, int quantity, string vendor)
		{
			this._itemName = name;
			this._itemPrice = price;
			this._itemQuantity = quantity;
			this._vendorName = vendor;
		}

		//Constructor with all fields as parameters
		public InventoryItem(string name, decimal price, int quantity, int calories, string vendor)
		{
			this._itemName = name;
			this._itemPrice = price;
			this._itemQuantity = quantity;
			this._itemCalories = calories;
			this._vendorName = vendor;
		}

		//method to print inventory contents
		public string printItems()
		{
			return ItemName;
		}

		/*
		 *Properties / Accessors
		 */
		public string ItemName
		{
			get { return _itemName; }
			set { _itemName = value; }
		}

		public decimal ItemPrice
		{
			get { return _itemPrice; }
			set { _itemPrice = value; }
		}

		public int ItemQuantity
		{
			get { return _itemQuantity; }
			set { _itemQuantity = value; }
		}

		public int ItemCalories
		{
			get { return _itemCalories; }
			set { _itemCalories = value; }
		}

		public string ItemVendor
		{
			get { return _vendorName; }
			set { _vendorName = value; }
		}

	}
}