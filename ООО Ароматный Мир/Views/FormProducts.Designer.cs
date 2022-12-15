namespace ООО_Ароматный_Мир.Views
{
	partial class FormProducts
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
			this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
			this.btnExit = new System.Windows.Forms.Button();
			this.pbImage = new System.Windows.Forms.PictureBox();
			this.labelOrganisationName = new System.Windows.Forms.Label();
			this.panelProducts = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnAddProduct = new System.Windows.Forms.Button();
			this.btnShowOrder = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.labelName = new System.Windows.Forms.Label();
			this.cbCategories = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbDiscountAmount = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.labelSortCost = new System.Windows.Forms.Label();
			this.cbSortCost = new System.Windows.Forms.ComboBox();
			this.tbProductName = new System.Windows.Forms.TextBox();
			this.labelProductsCount = new System.Windows.Forms.Label();
			this.tlpHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpHeader
			// 
			this.tlpHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
			this.tlpHeader.ColumnCount = 3;
			this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tlpHeader.Controls.Add(this.btnExit, 2, 0);
			this.tlpHeader.Controls.Add(this.pbImage, 0, 0);
			this.tlpHeader.Controls.Add(this.labelOrganisationName, 1, 0);
			this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.tlpHeader.Location = new System.Drawing.Point(0, 0);
			this.tlpHeader.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tlpHeader.Name = "tlpHeader";
			this.tlpHeader.RowCount = 1;
			this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
			this.tlpHeader.Size = new System.Drawing.Size(1076, 84);
			this.tlpHeader.TabIndex = 1;
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
			this.btnExit.Location = new System.Drawing.Point(918, 3);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(154, 78);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "Выход";
			this.btnExit.UseVisualStyleBackColor = false;
			// 
			// pbImage
			// 
			this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbImage.Image = global::ООО_Ароматный_Мир.Properties.Resources.logo;
			this.pbImage.Location = new System.Drawing.Point(4, 3);
			this.pbImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.pbImage.Name = "pbImage";
			this.pbImage.Size = new System.Drawing.Size(153, 78);
			this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbImage.TabIndex = 0;
			this.pbImage.TabStop = false;
			// 
			// labelOrganisationName
			// 
			this.labelOrganisationName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelOrganisationName.AutoSize = true;
			this.labelOrganisationName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelOrganisationName.Location = new System.Drawing.Point(165, 0);
			this.labelOrganisationName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelOrganisationName.Name = "labelOrganisationName";
			this.labelOrganisationName.Size = new System.Drawing.Size(745, 84);
			this.labelOrganisationName.TabIndex = 1;
			this.labelOrganisationName.Text = "ООО \"Ароматный мир\"";
			this.labelOrganisationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelProducts
			// 
			this.panelProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelProducts.Location = new System.Drawing.Point(4, 174);
			this.panelProducts.Name = "panelProducts";
			this.panelProducts.Size = new System.Drawing.Size(1068, 299);
			this.panelProducts.TabIndex = 2;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanel1.Controls.Add(this.btnAddProduct, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnShowOrder, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 479);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1076, 84);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// btnAddProduct
			// 
			this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
			this.btnAddProduct.Enabled = false;
			this.btnAddProduct.Location = new System.Drawing.Point(4, 3);
			this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnAddProduct.Name = "btnAddProduct";
			this.btnAddProduct.Size = new System.Drawing.Size(153, 78);
			this.btnAddProduct.TabIndex = 4;
			this.btnAddProduct.Text = "Добавить продукт";
			this.btnAddProduct.UseVisualStyleBackColor = false;
			this.btnAddProduct.Visible = false;
			this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
			// 
			// btnShowOrder
			// 
			this.btnShowOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnShowOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
			this.btnShowOrder.Location = new System.Drawing.Point(918, 3);
			this.btnShowOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnShowOrder.Name = "btnShowOrder";
			this.btnShowOrder.Size = new System.Drawing.Size(154, 78);
			this.btnShowOrder.TabIndex = 1;
			this.btnShowOrder.Text = "Просмотреть заказ";
			this.btnShowOrder.UseVisualStyleBackColor = false;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
			this.tableLayoutPanel2.ColumnCount = 6;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Controls.Add(this.labelName, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.cbCategories, 5, 0);
			this.tableLayoutPanel2.Controls.Add(this.label2, 4, 0);
			this.tableLayoutPanel2.Controls.Add(this.cbDiscountAmount, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.label1, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.labelSortCost, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.cbSortCost, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.tbProductName, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.labelProductsCount, 3, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 84);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1076, 84);
			this.tableLayoutPanel2.TabIndex = 4;
			// 
			// labelName
			// 
			this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelName.Location = new System.Drawing.Point(4, 42);
			this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(137, 42);
			this.labelName.TabIndex = 9;
			this.labelName.Text = "Поиск по имени:";
			this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbCategories
			// 
			this.cbCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cbCategories.FormattingEnabled = true;
			this.cbCategories.Location = new System.Drawing.Point(833, 9);
			this.cbCategories.Name = "cbCategories";
			this.cbCategories.Size = new System.Drawing.Size(240, 23);
			this.cbCategories.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(750, 0);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 42);
			this.label2.TabIndex = 6;
			this.label2.Text = "Категория:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbDiscountAmount
			// 
			this.cbDiscountAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cbDiscountAmount.FormattingEnabled = true;
			this.cbDiscountAmount.Location = new System.Drawing.Point(504, 9);
			this.cbDiscountAmount.Name = "cbDiscountAmount";
			this.cbDiscountAmount.Size = new System.Drawing.Size(239, 23);
			this.cbDiscountAmount.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(394, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 42);
			this.label1.TabIndex = 4;
			this.label1.Text = "Размер скидки:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelSortCost
			// 
			this.labelSortCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelSortCost.AutoSize = true;
			this.labelSortCost.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelSortCost.Location = new System.Drawing.Point(4, 0);
			this.labelSortCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelSortCost.Name = "labelSortCost";
			this.labelSortCost.Size = new System.Drawing.Size(137, 42);
			this.labelSortCost.TabIndex = 2;
			this.labelSortCost.Text = "Сортировка по цене:";
			this.labelSortCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbSortCost
			// 
			this.cbSortCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cbSortCost.FormattingEnabled = true;
			this.cbSortCost.Location = new System.Drawing.Point(148, 10);
			this.cbSortCost.Name = "cbSortCost";
			this.cbSortCost.Size = new System.Drawing.Size(239, 23);
			this.cbSortCost.TabIndex = 3;
			// 
			// tbProductName
			// 
			this.tbProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbProductName.Location = new System.Drawing.Point(148, 51);
			this.tbProductName.Name = "tbProductName";
			this.tbProductName.Size = new System.Drawing.Size(239, 23);
			this.tbProductName.TabIndex = 8;
			// 
			// labelProductsCount
			// 
			this.labelProductsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelProductsCount.AutoSize = true;
			this.labelProductsCount.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelProductsCount.Location = new System.Drawing.Point(505, 42);
			this.labelProductsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelProductsCount.Name = "labelProductsCount";
			this.labelProductsCount.Size = new System.Drawing.Size(237, 42);
			this.labelProductsCount.TabIndex = 10;
			this.labelProductsCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FormProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1076, 563);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.panelProducts);
			this.Controls.Add(this.tlpHeader);
			this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "FormProducts";
			this.Text = "ООО Ароматный мир";
			this.Load += new System.EventHandler(this.FormProducts_Load);
			this.tlpHeader.ResumeLayout(false);
			this.tlpHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlpHeader;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.PictureBox pbImage;
		private System.Windows.Forms.Label labelOrganisationName;
		private System.Windows.Forms.Panel panelProducts;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnAddProduct;
		private System.Windows.Forms.Button btnShowOrder;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label labelSortCost;
		private System.Windows.Forms.ComboBox cbSortCost;
		private System.Windows.Forms.ComboBox cbDiscountAmount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbCategories;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox tbProductName;
		private System.Windows.Forms.Label labelProductsCount;
	}
}