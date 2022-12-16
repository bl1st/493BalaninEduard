namespace ООО_Ароматный_Мир.Views
{
	partial class FormProductInfo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductInfo));
			this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
			this.btnExit = new System.Windows.Forms.Button();
			this.pbImage = new System.Windows.Forms.PictureBox();
			this.labelOrganisationName = new System.Windows.Forms.Label();
			this.tbQuantity = new System.Windows.Forms.TextBox();
			this.labelQuantity = new System.Windows.Forms.Label();
			this.tbDiscount = new System.Windows.Forms.TextBox();
			this.tbCost = new System.Windows.Forms.TextBox();
			this.tbMeasurementUnit = new System.Windows.Forms.TextBox();
			this.tbVendor = new System.Windows.Forms.TextBox();
			this.tbManufacturer = new System.Windows.Forms.TextBox();
			this.pbPhoto = new System.Windows.Forms.PictureBox();
			this.labelPhoto = new System.Windows.Forms.Label();
			this.rtbDescription = new System.Windows.Forms.RichTextBox();
			this.labelDescr = new System.Windows.Forms.Label();
			this.labelCost = new System.Windows.Forms.Label();
			this.labelDisocunt = new System.Windows.Forms.Label();
			this.labelMeasureUnit = new System.Windows.Forms.Label();
			this.labelVendor = new System.Windows.Forms.Label();
			this.labelManufacturer = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbCategory = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.labelProdArticle = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.tbArticle = new System.Windows.Forms.TextBox();
			this.tlpHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
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
			this.tlpHeader.Size = new System.Drawing.Size(775, 84);
			this.tlpHeader.TabIndex = 2;
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
			this.btnExit.Location = new System.Drawing.Point(662, 3);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(109, 78);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "Назад";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
			this.pbImage.Size = new System.Drawing.Size(108, 78);
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
			this.labelOrganisationName.Location = new System.Drawing.Point(120, 0);
			this.labelOrganisationName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelOrganisationName.Name = "labelOrganisationName";
			this.labelOrganisationName.Size = new System.Drawing.Size(534, 84);
			this.labelOrganisationName.TabIndex = 1;
			this.labelOrganisationName.Text = "ООО \"Ароматный мир\"";
			this.labelOrganisationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbQuantity
			// 
			this.tbQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbQuantity.Location = new System.Drawing.Point(194, 347);
			this.tbQuantity.Name = "tbQuantity";
			this.tbQuantity.ReadOnly = true;
			this.tbQuantity.Size = new System.Drawing.Size(185, 22);
			this.tbQuantity.TabIndex = 21;
			// 
			// labelQuantity
			// 
			this.labelQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelQuantity.AutoSize = true;
			this.labelQuantity.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelQuantity.Location = new System.Drawing.Point(3, 336);
			this.labelQuantity.Name = "labelQuantity";
			this.labelQuantity.Size = new System.Drawing.Size(185, 45);
			this.labelQuantity.TabIndex = 20;
			this.labelQuantity.Text = "Кол-во на складе:";
			this.labelQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbDiscount
			// 
			this.tbDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbDiscount.Location = new System.Drawing.Point(194, 304);
			this.tbDiscount.Name = "tbDiscount";
			this.tbDiscount.ReadOnly = true;
			this.tbDiscount.Size = new System.Drawing.Size(185, 22);
			this.tbDiscount.TabIndex = 19;
			// 
			// tbCost
			// 
			this.tbCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbCost.Location = new System.Drawing.Point(194, 262);
			this.tbCost.Name = "tbCost";
			this.tbCost.ReadOnly = true;
			this.tbCost.Size = new System.Drawing.Size(185, 22);
			this.tbCost.TabIndex = 17;
			// 
			// tbMeasurementUnit
			// 
			this.tbMeasurementUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbMeasurementUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbMeasurementUnit.Location = new System.Drawing.Point(194, 220);
			this.tbMeasurementUnit.Name = "tbMeasurementUnit";
			this.tbMeasurementUnit.ReadOnly = true;
			this.tbMeasurementUnit.Size = new System.Drawing.Size(185, 22);
			this.tbMeasurementUnit.TabIndex = 18;
			// 
			// tbVendor
			// 
			this.tbVendor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbVendor.Location = new System.Drawing.Point(194, 178);
			this.tbVendor.Name = "tbVendor";
			this.tbVendor.ReadOnly = true;
			this.tbVendor.Size = new System.Drawing.Size(185, 22);
			this.tbVendor.TabIndex = 14;
			// 
			// tbManufacturer
			// 
			this.tbManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbManufacturer.Location = new System.Drawing.Point(194, 136);
			this.tbManufacturer.Name = "tbManufacturer";
			this.tbManufacturer.ReadOnly = true;
			this.tbManufacturer.Size = new System.Drawing.Size(185, 22);
			this.tbManufacturer.TabIndex = 16;
			// 
			// pbPhoto
			// 
			this.pbPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbPhoto.Location = new System.Drawing.Point(576, 213);
			this.pbPhoto.Name = "pbPhoto";
			this.tableLayoutPanel1.SetRowSpan(this.pbPhoto, 4);
			this.pbPhoto.Size = new System.Drawing.Size(188, 165);
			this.pbPhoto.TabIndex = 11;
			this.pbPhoto.TabStop = false;
			// 
			// labelPhoto
			// 
			this.labelPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelPhoto.AutoSize = true;
			this.labelPhoto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelPhoto.Location = new System.Drawing.Point(385, 210);
			this.labelPhoto.Name = "labelPhoto";
			this.labelPhoto.Size = new System.Drawing.Size(185, 42);
			this.labelPhoto.TabIndex = 10;
			this.labelPhoto.Text = "Фото:";
			this.labelPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// rtbDescription
			// 
			this.rtbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbDescription.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rtbDescription.Location = new System.Drawing.Point(576, 3);
			this.rtbDescription.Name = "rtbDescription";
			this.rtbDescription.ReadOnly = true;
			this.tableLayoutPanel1.SetRowSpan(this.rtbDescription, 4);
			this.rtbDescription.Size = new System.Drawing.Size(188, 162);
			this.rtbDescription.TabIndex = 9;
			this.rtbDescription.Text = "";
			// 
			// labelDescr
			// 
			this.labelDescr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelDescr.AutoSize = true;
			this.labelDescr.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelDescr.Location = new System.Drawing.Point(385, 0);
			this.labelDescr.Name = "labelDescr";
			this.labelDescr.Size = new System.Drawing.Size(185, 42);
			this.labelDescr.TabIndex = 8;
			this.labelDescr.Text = "Описание:";
			this.labelDescr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelCost
			// 
			this.labelCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelCost.AutoSize = true;
			this.labelCost.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCost.Location = new System.Drawing.Point(3, 252);
			this.labelCost.Name = "labelCost";
			this.labelCost.Size = new System.Drawing.Size(185, 42);
			this.labelCost.TabIndex = 6;
			this.labelCost.Text = "Цена (с учетом скидки):";
			this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelDisocunt
			// 
			this.labelDisocunt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelDisocunt.AutoSize = true;
			this.labelDisocunt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelDisocunt.Location = new System.Drawing.Point(3, 294);
			this.labelDisocunt.Name = "labelDisocunt";
			this.labelDisocunt.Size = new System.Drawing.Size(185, 42);
			this.labelDisocunt.TabIndex = 7;
			this.labelDisocunt.Text = "Скидка:";
			this.labelDisocunt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMeasureUnit
			// 
			this.labelMeasureUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelMeasureUnit.AutoSize = true;
			this.labelMeasureUnit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelMeasureUnit.Location = new System.Drawing.Point(3, 210);
			this.labelMeasureUnit.Name = "labelMeasureUnit";
			this.labelMeasureUnit.Size = new System.Drawing.Size(185, 42);
			this.labelMeasureUnit.TabIndex = 3;
			this.labelMeasureUnit.Text = "Ед. измерения:";
			this.labelMeasureUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelVendor
			// 
			this.labelVendor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelVendor.AutoSize = true;
			this.labelVendor.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelVendor.Location = new System.Drawing.Point(3, 168);
			this.labelVendor.Name = "labelVendor";
			this.labelVendor.Size = new System.Drawing.Size(185, 42);
			this.labelVendor.TabIndex = 2;
			this.labelVendor.Text = "Поставщик:";
			this.labelVendor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelManufacturer
			// 
			this.labelManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelManufacturer.AutoSize = true;
			this.labelManufacturer.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelManufacturer.Location = new System.Drawing.Point(3, 126);
			this.labelManufacturer.Name = "labelManufacturer";
			this.labelManufacturer.Size = new System.Drawing.Size(185, 42);
			this.labelManufacturer.TabIndex = 1;
			this.labelManufacturer.Text = "Производитель:";
			this.labelManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(3, 84);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(185, 42);
			this.label5.TabIndex = 5;
			this.label5.Text = "Категория:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbCategory
			// 
			this.tbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbCategory.Location = new System.Drawing.Point(194, 94);
			this.tbCategory.Name = "tbCategory";
			this.tbCategory.ReadOnly = true;
			this.tbCategory.Size = new System.Drawing.Size(185, 22);
			this.tbCategory.TabIndex = 15;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Controls.Add(this.pbPhoto, 3, 5);
			this.tableLayoutPanel1.Controls.Add(this.labelPhoto, 2, 5);
			this.tableLayoutPanel1.Controls.Add(this.rtbDescription, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelDescr, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.tbCategory, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.labelProdArticle, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tbName, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tbQuantity, 1, 8);
			this.tableLayoutPanel1.Controls.Add(this.tbDiscount, 1, 7);
			this.tableLayoutPanel1.Controls.Add(this.tbCost, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.tbMeasurementUnit, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.tbVendor, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.tbManufacturer, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.labelDisocunt, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.labelMeasureUnit, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.labelCost, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.labelVendor, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.tbArticle, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelManufacturer, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.labelQuantity, 0, 8);
			this.tableLayoutPanel1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 90);
			this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(767, 381);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 9;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(767, 381);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// labelProdArticle
			// 
			this.labelProdArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelProdArticle.AutoSize = true;
			this.labelProdArticle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelProdArticle.Location = new System.Drawing.Point(3, 0);
			this.labelProdArticle.Name = "labelProdArticle";
			this.labelProdArticle.Size = new System.Drawing.Size(185, 42);
			this.labelProdArticle.TabIndex = 0;
			this.labelProdArticle.Text = "Ариткул:";
			this.labelProdArticle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbName
			// 
			this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbName.Location = new System.Drawing.Point(194, 52);
			this.tbName.Name = "tbName";
			this.tbName.ReadOnly = true;
			this.tbName.Size = new System.Drawing.Size(185, 22);
			this.tbName.TabIndex = 13;
			// 
			// labelName
			// 
			this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelName.Location = new System.Drawing.Point(3, 42);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(185, 42);
			this.labelName.TabIndex = 4;
			this.labelName.Text = "Название:";
			this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbArticle
			// 
			this.tbArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbArticle.Location = new System.Drawing.Point(194, 10);
			this.tbArticle.Name = "tbArticle";
			this.tbArticle.ReadOnly = true;
			this.tbArticle.Size = new System.Drawing.Size(185, 22);
			this.tbArticle.TabIndex = 12;
			// 
			// FormProductInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(775, 483);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.tlpHeader);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(791, 522);
			this.Name = "FormProductInfo";
			this.Text = "ООО \"Ароматный мир\"";
			this.Load += new System.EventHandler(this.FormProductInfo_Load);
			this.tlpHeader.ResumeLayout(false);
			this.tlpHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlpHeader;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.PictureBox pbImage;
		private System.Windows.Forms.Label labelOrganisationName;
		private System.Windows.Forms.TextBox tbQuantity;
		private System.Windows.Forms.Label labelQuantity;
		private System.Windows.Forms.TextBox tbDiscount;
		private System.Windows.Forms.TextBox tbCost;
		private System.Windows.Forms.TextBox tbMeasurementUnit;
		private System.Windows.Forms.TextBox tbVendor;
		private System.Windows.Forms.TextBox tbManufacturer;
		private System.Windows.Forms.PictureBox pbPhoto;
		private System.Windows.Forms.Label labelPhoto;
		private System.Windows.Forms.RichTextBox rtbDescription;
		private System.Windows.Forms.Label labelDescr;
		private System.Windows.Forms.Label labelCost;
		private System.Windows.Forms.Label labelDisocunt;
		private System.Windows.Forms.Label labelMeasureUnit;
		private System.Windows.Forms.Label labelVendor;
		private System.Windows.Forms.Label labelManufacturer;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbCategory;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label labelProdArticle;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox tbArticle;
	}
}