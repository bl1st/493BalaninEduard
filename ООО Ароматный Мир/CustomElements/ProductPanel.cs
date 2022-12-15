using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ООО_Ароматный_Мир.Entitites;

namespace ООО_Ароматный_Мир.CustomElements
{

	public  class ProductPanel : Panel
	{
	
		public PictureBox pbImage;
		public Label productName;
		public Label productDescription;
		public Label productManufacturer;
		public Label productCost;
		public Label productDiscount;
		private int gap;

		public ProductPanel(Product p, Panel panel)
		{
			this.Width = panel.Width - 30;
			this.Height = 100;
			gap = 10;

			pbImage = new PictureBox();
			pbImage.Location = new System.Drawing.Point(gap, gap);
			pbImage.Size = new System.Drawing.Size(this.Height - gap *2, this.Height - gap * 2);

			if (p.Photo != null)
			{
				try
				{
					pbImage.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\Images\" + p.Photo);
				}
				catch
				{
					pbImage.Image = Properties.Resources.picture;
				}
			}
			else
				pbImage.Image = Properties.Resources.picture;

			pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

			productName = new Label();
			int pos = 0;
			productName.Location = new Point(pbImage.Location.X + pbImage.Width + gap, (this.Height/5) * pos +gap);
			productName.AutoSize = true;
			productName.Font = new Font("Comic Sans MS", 14.0f, FontStyle.Bold);
			pos++;

			productDescription = new Label();
			
			productDescription.Location = new Point(pbImage.Location.X + pbImage.Width + gap, (this.Height / 5) * pos + gap);
			productDescription.AutoSize = true;
			productDescription.Font = new Font("Comic Sans MS", 14.0f, FontStyle.Regular);
			pos++;

			productManufacturer = new Label();

			productManufacturer.Location = new Point(pbImage.Location.X + pbImage.Width + gap, (this.Height / 5) * pos + gap);
			productManufacturer.AutoSize = true;
			productManufacturer.Font = new Font("Comic Sans MS", 14.0f, FontStyle.Regular);
			pos++;

			productCost = new Label();

			productCost.Location = new Point(pbImage.Location.X + pbImage.Width + gap, (this.Height / 5) * pos + gap);
			productCost.AutoSize = true;
			productCost.Font = new Font("Comic Sans MS", 14.0f, FontStyle.Regular);
			pos++;

			if (p.CurrentDiscount > 0)
			{
				productDiscount = new Label();
				productDiscount.AutoSize = true;
				productDiscount.Font = new Font("Comic Sans MS", 14.0f, FontStyle.Regular);
				productDiscount.Text = $"Скидка {p.CurrentDiscount}%";
				productDiscount.TextAlign = ContentAlignment.MiddleCenter;
				productDiscount.Location = new Point(this.Width - productDiscount.Width - (gap * 2), (this.Height / 2) - (productDiscount.Height / 2));
				this.Controls.Add(productDiscount);
			}

			productName.Text = p.Name;
			if (p.Description.Length > 30)
			{
				productDescription.Text = p.Description.Substring(0,30) + "...";
			}
			else
			{
				productDescription.Text = p.Description;
			}
			
			productManufacturer.Text = p.Manufacturer.Name;
			double curCost = (double)p.Cost - ((double)p.Cost * (double)(p.CurrentDiscount * 0.01));
			productCost.Text = curCost.ToString() + " руб.";

			this.Controls.Add(pbImage);
			this.Controls.Add(productName);
			this.Controls.Add(productDescription);
			this.Controls.Add(productManufacturer);
			this.Controls.Add(productCost);
			

		}
	}
}
