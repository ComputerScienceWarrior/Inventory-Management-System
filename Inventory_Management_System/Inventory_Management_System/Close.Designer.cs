namespace Inventory_Management_System
{
	partial class Close
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
			this.closeButton = new System.Windows.Forms.Button();
			this.closeMessage = new System.Windows.Forms.Label();
			this.closeMessage2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(223, 125);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 0;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// closeMessage
			// 
			this.closeMessage.AutoSize = true;
			this.closeMessage.Font = new System.Drawing.Font("Verdana", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.closeMessage.Location = new System.Drawing.Point(100, 31);
			this.closeMessage.Name = "closeMessage";
			this.closeMessage.Size = new System.Drawing.Size(321, 23);
			this.closeMessage.TabIndex = 1;
			this.closeMessage.Text = "Program closed successfully!";
			// 
			// closeMessage2
			// 
			this.closeMessage2.AutoSize = true;
			this.closeMessage2.Font = new System.Drawing.Font("Verdana", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.closeMessage2.Location = new System.Drawing.Point(3, 70);
			this.closeMessage2.Name = "closeMessage2";
			this.closeMessage2.Size = new System.Drawing.Size(516, 23);
			this.closeMessage2.TabIndex = 2;
			this.closeMessage2.Text = "Thank you for using The management System!";
			// 
			// Close
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(540, 160);
			this.Controls.Add(this.closeMessage2);
			this.Controls.Add(this.closeMessage);
			this.Controls.Add(this.closeButton);
			this.Name = "Close";
			this.Text = "Close";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label closeMessage2;
		public System.Windows.Forms.Button closeButton;
		public System.Windows.Forms.Label closeMessage;
	}
}