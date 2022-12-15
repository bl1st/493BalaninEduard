using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ООО_Ароматный_Мир.Classes;
using ООО_Ароматный_Мир.CustomElements;
using ООО_Ароматный_Мир.Entitites;

namespace ООО_Ароматный_Мир.Views
{
	public partial class FormProducts : Form
	{
		private string _roleName;
		private string _userName;
		public FormProducts(string roleName, string userName)
		{
			this._roleName = roleName;
			this._userName = userName;
			InitializeComponent();
			_userName = userName;
		}

		private void FormProducts_Load(object sender, EventArgs e)
		{
			if (_roleName == "Администратор")
			{
				btnAddProduct.Enabled = true;
				btnAddProduct.Visible = true;
			}

			cbSortCost.Items.Add("По возрастанию");
			cbSortCost.Items.Add("По убыванию");
			cbSortCost.SelectedIndex = 0;

			cbDiscountAmount.Items.Add("Все диапазоны");
			cbDiscountAmount.Items.Add("0-10%");
			cbDiscountAmount.Items.Add("11-14%");
			cbDiscountAmount.Items.Add("15% и более");
			cbDiscountAmount.SelectedIndex = 0;

			var categories = Helper.context.Category.ToList();

			Category cat = new Category();
			cat.Name = "Все категории";
			cat.ID = 0;
			Helper.context.Entry(cat)
				.State = System.Data.Entity.EntityState.Detached;
			categories.Insert(0, cat);
			cbCategories.DataSource = categories;
			cbCategories.ValueMember = "ID";
			cbCategories.DisplayMember = "Name";
			cbCategories.SelectedIndex = 0;


			cbSortCost.SelectedIndexChanged += UpdateProducts;
			cbDiscountAmount.SelectedIndexChanged += UpdateProducts;
			cbCategories.SelectedIndexChanged += UpdateProducts;
			tbProductName.TextChanged += UpdateProducts;

			GetProducts();

		}

		private void UpdateProducts(object sender, EventArgs e)
		{
			GetProducts();
		}

		private void GetProducts()
		{
			int start = 0;
			int end = 100;

			switch (cbDiscountAmount.SelectedIndex)
			{
				case 1:
					end = 10;
					break;
				case 2:
					start = 11;
					end = 14;
					break;
				case 3:
					start = 15;
					break;
			}

			string prodName = tbProductName.Text.Trim();
			int categoryId = Convert.ToInt32(cbCategories.SelectedValue);
		
			int totalProds = Helper.context.Product.Count();

			List<Product> prods;
			if (categoryId == 0)
			{
				 prods = Helper.context.Product.Where
				(p =>
					p.CurrentDiscount >= start &&
					p.CurrentDiscount <= end &&				
					p.Name.Contains(prodName)
				).ToList();
			}
			else
			{
				prods = Helper.context.Product.Where
				(p =>
					p.CurrentDiscount >= start &&
					p.CurrentDiscount <= end &&
					p.CategoryID == categoryId &&
					p.Name.Contains(prodName)
				).ToList();
			}
		

			if (cbSortCost.SelectedItem.ToString() == "По убыванию")
			{
				prods = prods.OrderByDescending(p => p.Cost).ToList();
			}
			else
			{
				prods = prods.OrderBy(p => p.Cost).ToList();
			}

			labelProductsCount.Text = $"Найдено: {prods.Count} из {totalProds}";

			FillPanel(prods);
		}

		private void FillPanel(List<Product> prods)
		{
			int pos = 5;
			panelProducts.Controls.Clear();
			foreach (var product in prods)
			{
				ProductPanel pp = new ProductPanel(product, panelProducts);
				pp.Location = new Point(5, pos);
				pp.BorderStyle = BorderStyle.Fixed3D;
				if (product.CurrentDiscount > 15 )
				{
					pp.BackColor = Color.FromArgb(Convert.ToInt32("7F",16), Convert.ToInt32("FF", 16), Convert.ToInt32("00", 16));
				}
				panelProducts.Controls.Add(pp);
				pp.Tag = product;
				pp.DoubleClick += Pp_DoubleClick;

				pos += pp.Height;
			
				
			}
			panelProducts.AutoScroll = true;
		}

		private void Pp_DoubleClick(object sender, EventArgs e)
		{
			Product p = (Product)(sender as ProductPanel).Tag;
			if (_roleName != "Администратор")
			{
				FormProductInfo formInfo = new FormProductInfo(p);
				this.Hide();
				formInfo.ShowDialog();
				this.Show();
				GetProducts();
			}
			else
			{
				FormEditProduct forminfo = new FormEditProduct(p);
				this.Hide();
				forminfo.ShowDialog();
				this.Show();
				GetProducts();
			}


		}

		private void btnAddProduct_Click(object sender, EventArgs e)
		{
			FormEditProduct forminfo = new FormEditProduct(null);
			this.Hide();
			forminfo.ShowDialog();
			this.Show();
			GetProducts();
		}
	}
}
