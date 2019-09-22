namespace Inventory_Management_System
{
	partial class homeScreen
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.displayButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.InventoryContents = new System.Windows.Forms.ListBox();
            this.searchPrice = new System.Windows.Forms.TextBox();
            this.addPrice = new System.Windows.Forms.TextBox();
            this.searchName = new System.Windows.Forms.TextBox();
            this.addName = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addQuantity = new System.Windows.Forms.TextBox();
            this.searchQuantity = new System.Windows.Forms.TextBox();
            this.updateName = new System.Windows.Forms.TextBox();
            this.updatePrice = new System.Windows.Forms.TextBox();
            this.updateQuantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // displayButton
            // 
            this.displayButton.AutoSize = true;
            this.displayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayButton.Location = new System.Drawing.Point(12, 39);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(75, 28);
            this.displayButton.TabIndex = 0;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.AutoSize = true;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.Red;
            this.removeButton.Location = new System.Drawing.Point(12, 99);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(80, 28);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.AutoSize = true;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(130, 347);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 28);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Green;
            this.addButton.Location = new System.Drawing.Point(130, 242);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 28);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(130, 296);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 28);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // InventoryContents
            // 
            this.InventoryContents.FormattingEnabled = true;
            this.InventoryContents.ItemHeight = 16;
            this.InventoryContents.Location = new System.Drawing.Point(130, 12);
            this.InventoryContents.Name = "InventoryContents";
            this.InventoryContents.Size = new System.Drawing.Size(459, 196);
            this.InventoryContents.TabIndex = 3;
            this.InventoryContents.SelectedIndexChanged += new System.EventHandler(this.InventoryContents_SelectedIndexChanged);
            // 
            // searchPrice
            // 
            this.searchPrice.Location = new System.Drawing.Point(366, 297);
            this.searchPrice.Name = "searchPrice";
            this.searchPrice.Size = new System.Drawing.Size(100, 22);
            this.searchPrice.TabIndex = 10;
            // 
            // addPrice
            // 
            this.addPrice.Location = new System.Drawing.Point(366, 243);
            this.addPrice.Name = "addPrice";
            this.addPrice.Size = new System.Drawing.Size(100, 22);
            this.addPrice.TabIndex = 6;
            // 
            // searchName
            // 
            this.searchName.Location = new System.Drawing.Point(236, 297);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(100, 22);
            this.searchName.TabIndex = 9;
            // 
            // addName
            // 
            this.addName.Location = new System.Drawing.Point(236, 243);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(100, 22);
            this.addName.TabIndex = 5;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(256, 220);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(63, 20);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Name";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(389, 220);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(56, 20);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "Price";
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(239, 393);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 28);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(381, 393);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 28);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(498, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Quantity";
            // 
            // addQuantity
            // 
            this.addQuantity.Location = new System.Drawing.Point(489, 243);
            this.addQuantity.Name = "addQuantity";
            this.addQuantity.Size = new System.Drawing.Size(100, 22);
            this.addQuantity.TabIndex = 7;
            // 
            // searchQuantity
            // 
            this.searchQuantity.Location = new System.Drawing.Point(489, 296);
            this.searchQuantity.Name = "searchQuantity";
            this.searchQuantity.Size = new System.Drawing.Size(100, 22);
            this.searchQuantity.TabIndex = 17;
            // 
            // updateName
            // 
            this.updateName.Location = new System.Drawing.Point(236, 347);
            this.updateName.Name = "updateName";
            this.updateName.Size = new System.Drawing.Size(100, 22);
            this.updateName.TabIndex = 18;
            // 
            // updatePrice
            // 
            this.updatePrice.Location = new System.Drawing.Point(366, 347);
            this.updatePrice.Name = "updatePrice";
            this.updatePrice.Size = new System.Drawing.Size(100, 22);
            this.updatePrice.TabIndex = 19;
            // 
            // updateQuantity
            // 
            this.updateQuantity.Location = new System.Drawing.Point(489, 347);
            this.updateQuantity.Name = "updateQuantity";
            this.updateQuantity.Size = new System.Drawing.Size(100, 22);
            this.updateQuantity.TabIndex = 20;
            // 
            // homeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(631, 462);
            this.Controls.Add(this.updateQuantity);
            this.Controls.Add(this.updatePrice);
            this.Controls.Add(this.updateName);
            this.Controls.Add(this.searchQuantity);
            this.Controls.Add(this.addQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.addName);
            this.Controls.Add(this.searchName);
            this.Controls.Add(this.addPrice);
            this.Controls.Add(this.searchPrice);
            this.Controls.Add(this.InventoryContents);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.displayButton);
            this.Name = "homeScreen";
            this.Text = "Inventory Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button displayButton;
		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.ListBox InventoryContents;
		private System.Windows.Forms.TextBox searchPrice;
		private System.Windows.Forms.TextBox addPrice;
		private System.Windows.Forms.TextBox searchName;
		private System.Windows.Forms.TextBox addName;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label priceLabel;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox addQuantity;
        private System.Windows.Forms.TextBox searchQuantity;
        private System.Windows.Forms.TextBox updateName;
        private System.Windows.Forms.TextBox updatePrice;
        private System.Windows.Forms.TextBox updateQuantity;
    }
}

