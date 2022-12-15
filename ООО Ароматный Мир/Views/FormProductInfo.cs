using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ООО_Ароматный_Мир.Entitites;

namespace ООО_Ароматный_Мир.Views
{
	public partial class FormProductInfo : Form
	{
		Product _product;
		public FormProductInfo(Product p)
		{
			_product = p;
			InitializeComponent();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormProductInfo_Load(object sender, EventArgs e)
		{
			tbArticle.Text = _product.Article;
			tbName.Text = _product.Name;
			tbCategory.Text = _product.Category.Name;
			tbMeasurementUnit.Text = _product.MeasurementUnit.Name;
			tbManufacturer.Text = _product.Manufacturer.Name;
			tbVendor.Text = _product.Vendor.Name;
			tbCost.Text = ((double)_product.Cost - ((double)_product.Cost * (double)(_product.CurrentDiscount * 0.01))).ToString();
			tbQuantity.Text = _product.QuantityInStock.ToString();
			tbDiscount.Text = _product.CurrentDiscount.ToString();
			rtbDescription.Text = _product.Description;

			if (_product.Photo != null)
			{
				try
				{
					pbPhoto.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\Images\" + _product.Photo);
				}
				catch
				{
					pbPhoto.Image = Properties.Resources.picture;
				}
			}
			else
				pbPhoto.Image = Properties.Resources.picture;

			pbPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
		}
	}
}
