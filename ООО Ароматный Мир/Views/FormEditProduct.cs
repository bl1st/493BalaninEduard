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
using System.Xml;
using ООО_Ароматный_Мир.Classes;
using ООО_Ароматный_Мир.Entitites;

namespace ООО_Ароматный_Мир.Views
{
	public partial class FormEditProduct : Form
	{
		Product _p;
		public FormEditProduct(Product product)
		{
			_p = product;
			InitializeComponent();
		}

		private void FormEditProduct_Load(object sender, EventArgs e)
		{
			pbPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
			if (_p == null)
			{
				FillComboBoxes();
				cbCategory.SelectedValue = 1;
				cbManufacturer.SelectedValue = 1;
				cbVendor.SelectedValue = 1;
				cbMeasurementUnit.SelectedValue = 1;
				tbArticle.ReadOnly = false;

				pbPhoto.Tag = null;

			}
			else
			{
				FillComboBoxes();
				SelectComboBoxes();
				tbArticle.Text = _p.Article;
				tbName.Text = _p.Name;
				numCost.Value = _p.Cost;
				numQuantity.Value = _p.QuantityInStock;
				numCurDiscount.Value = _p.CurrentDiscount;
				numMaxDiscount.Value = _p.MaximumDiscount;
				rtbDescription.Text = _p.Description;

				pbPhoto.Tag = _p.Photo;
				if (_p.Photo == null)
				{
					pbPhoto.Image = Properties.Resources.picture;
				}
				else
				{
					pbPhoto.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\Images\" + _p.Photo);
				}
				
			}

		}


		private void FillComboBoxes()
		{
			var categories = Helper.context.Category.ToList();
			cbCategory.DataSource = categories;
			cbCategory.ValueMember = "ID";
			cbCategory.DisplayMember = "Name";

			var measurements = Helper.context.MeasurementUnit.ToList();
			cbMeasurementUnit.DataSource = measurements;
			cbMeasurementUnit.ValueMember = "ID";
			cbMeasurementUnit.DisplayMember = "Name";

			var vendors = Helper.context.Vendor.ToList();
			cbVendor.DataSource = vendors;
			cbVendor.ValueMember = "ID";
			cbVendor.DisplayMember = "Name";

			var manufs = Helper.context.Manufacturer.ToList();
			cbManufacturer.DataSource = manufs;
			cbManufacturer.ValueMember = "ID";
			cbManufacturer.DisplayMember = "Name";


		}


		private void SelectComboBoxes()
		{
			cbCategory.SelectedValue = _p.CategoryID;
			cbManufacturer.SelectedValue = _p.ManufacturerID;
			cbVendor.SelectedValue = _p.VendorID;
			cbMeasurementUnit.SelectedValue = _p.MeasurementUnitID;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (_p == null)
			{
				Product p = new Product();
				p.Article = tbArticle.Text;
				p.Name = tbName.Text;
				p.ManufacturerID = (int)cbManufacturer.SelectedValue;
				p.VendorID = (int)cbVendor.SelectedValue;
				p.CategoryID = (int)cbCategory.SelectedValue;
				p.MeasurementUnitID = (int)cbMeasurementUnit.SelectedValue;
				p.Cost = numCost.Value;
				p.CurrentDiscount = (byte)numCurDiscount.Value;
				p.MaximumDiscount = (byte)numMaxDiscount.Value;
				p.QuantityInStock = (int)numQuantity.Value;
				p.Description = rtbDescription.Text;
				p.Photo = pbImage.Tag?.ToString();

				Helper.context.Product.Add(p);
				_p = p;
				if (Helper.SaveChanges())
				{
					MessageBox.Show("Товар успешно удален");
					this.Close();
				}

			}
			else
			{
				_p.Name = tbName.Text;
				_p.ManufacturerID = (int)cbManufacturer.SelectedValue;
				_p.VendorID = (int)cbVendor.SelectedValue;
				_p.CategoryID = (int)cbCategory.SelectedValue;
				_p.MeasurementUnitID = (int)cbMeasurementUnit.SelectedValue;
				_p.Cost = numCost.Value;
				_p.CurrentDiscount = (byte)numCurDiscount.Value;
				_p.MaximumDiscount = (byte)numMaxDiscount.Value;
				_p.QuantityInStock = (int)numQuantity.Value;
				_p.Description = rtbDescription.Text;
				_p.Photo = pbPhoto.Tag?.ToString();
				MessageBox.Show("Успешно обновлены данные", "Ошибкав");
			}
		
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Вы уверены?", "Оповещение", MessageBoxButtons.YesNo);
			if (res == DialogResult.Yes)
			{
				Helper.context.Product.Remove(_p);
				if (Helper.SaveChanges())
				{
					MessageBox.Show("Товар успешно удален");
					this.Close();
				}
			}
		}

		private void btnPlus_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Title = "Выбор фото";
			ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				Image img = Image.FromFile(ofd.FileName);
				pbPhoto.Image = img;
				pbPhoto.Tag = Path.GetFileName(ofd.FileName);
				img.Save(Directory.GetCurrentDirectory() + @"\Images\" + pbPhoto.Tag.ToString());
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
