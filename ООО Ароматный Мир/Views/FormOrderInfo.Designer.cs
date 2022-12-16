namespace ООО_Ароматный_Мир.Views
{
	partial class FormOrderInfo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderInfo));
			this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
			this.btnExit = new System.Windows.Forms.Button();
			this.pbImage = new System.Windows.Forms.PictureBox();
			this.labelOrganisationName = new System.Windows.Forms.Label();
			this.tlpBody = new System.Windows.Forms.TableLayoutPanel();
			this.labelUserName = new System.Windows.Forms.Label();
			this.panelProducts = new System.Windows.Forms.Panel();
			this.rtbDescription = new System.Windows.Forms.RichTextBox();
			this.labelDescription = new System.Windows.Forms.Label();
			this.labelOutpost = new System.Windows.Forms.Label();
			this.cbOutposts = new System.Windows.Forms.ComboBox();
			this.tlpHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
			this.tlpBody.SuspendLayout();
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
			this.tlpHeader.Size = new System.Drawing.Size(863, 84);
			this.tlpHeader.TabIndex = 2;
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
			this.btnExit.Location = new System.Drawing.Point(737, 3);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(122, 78);
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
			this.pbImage.Size = new System.Drawing.Size(121, 78);
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
			this.labelOrganisationName.Location = new System.Drawing.Point(133, 0);
			this.labelOrganisationName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelOrganisationName.Name = "labelOrganisationName";
			this.labelOrganisationName.Size = new System.Drawing.Size(596, 84);
			this.labelOrganisationName.TabIndex = 1;
			this.labelOrganisationName.Text = "ООО \"Ароматный мир\"";
			this.labelOrganisationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tlpBody
			// 
			this.tlpBody.ColumnCount = 2;
			this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpBody.Controls.Add(this.labelUserName, 0, 0);
			this.tlpBody.Controls.Add(this.panelProducts, 0, 1);
			this.tlpBody.Controls.Add(this.cbOutposts, 1, 4);
			this.tlpBody.Controls.Add(this.labelOutpost, 1, 3);
			this.tlpBody.Controls.Add(this.labelDescription, 0, 3);
			this.tlpBody.Controls.Add(this.rtbDescription, 0, 4);
			this.tlpBody.Location = new System.Drawing.Point(4, 90);
			this.tlpBody.Name = "tlpBody";
			this.tlpBody.RowCount = 6;
			this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpBody.Size = new System.Drawing.Size(855, 396);
			this.tlpBody.TabIndex = 3;
			// 
			// labelUserName
			// 
			this.labelUserName.AutoSize = true;
			this.labelUserName.Location = new System.Drawing.Point(3, 0);
			this.labelUserName.Name = "labelUserName";
			this.labelUserName.Size = new System.Drawing.Size(39, 18);
			this.labelUserName.TabIndex = 0;
			this.labelUserName.Text = "Имя:";
			// 
			// panelProducts
			// 
			this.panelProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tlpBody.SetColumnSpan(this.panelProducts, 2);
			this.panelProducts.Location = new System.Drawing.Point(3, 21);
			this.panelProducts.Name = "panelProducts";
			this.tlpBody.SetRowSpan(this.panelProducts, 2);
			this.panelProducts.Size = new System.Drawing.Size(849, 216);
			this.panelProducts.TabIndex = 1;
			// 
			// rtbDescription
			// 
			this.rtbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbDescription.Location = new System.Drawing.Point(3, 261);
			this.rtbDescription.Name = "rtbDescription";
			this.tlpBody.SetRowSpan(this.rtbDescription, 2);
			this.rtbDescription.Size = new System.Drawing.Size(421, 132);
			this.rtbDescription.TabIndex = 2;
			this.rtbDescription.Text = "";
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Location = new System.Drawing.Point(3, 240);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(117, 18);
			this.labelDescription.TabIndex = 3;
			this.labelDescription.Text = "Описание заказа:";
			// 
			// labelOutpost
			// 
			this.labelOutpost.AutoSize = true;
			this.labelOutpost.Location = new System.Drawing.Point(430, 240);
			this.labelOutpost.Name = "labelOutpost";
			this.labelOutpost.Size = new System.Drawing.Size(104, 18);
			this.labelOutpost.TabIndex = 4;
			this.labelOutpost.Text = "Пукты выдачи:";
			// 
			// cbOutposts
			// 
			this.cbOutposts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cbOutposts.FormattingEnabled = true;
			this.cbOutposts.Location = new System.Drawing.Point(430, 261);
			this.cbOutposts.Name = "cbOutposts";
			this.cbOutposts.Size = new System.Drawing.Size(422, 26);
			this.cbOutposts.TabIndex = 5;
			// 
			// FormOrderInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(863, 546);
			this.Controls.Add(this.tlpBody);
			this.Controls.Add(this.tlpHeader);
			this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormOrderInfo";
			this.Text = "ООО \"Ароматный мир\"";
			this.Load += new System.EventHandler(this.FormOrderInfo_Load);
			this.tlpHeader.ResumeLayout(false);
			this.tlpHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
			this.tlpBody.ResumeLayout(false);
			this.tlpBody.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlpHeader;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.PictureBox pbImage;
		private System.Windows.Forms.Label labelOrganisationName;
		private System.Windows.Forms.TableLayoutPanel tlpBody;
		private System.Windows.Forms.Label labelUserName;
		private System.Windows.Forms.Panel panelProducts;
		private System.Windows.Forms.RichTextBox rtbDescription;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.Label labelOutpost;
		private System.Windows.Forms.ComboBox cbOutposts;
	}
}