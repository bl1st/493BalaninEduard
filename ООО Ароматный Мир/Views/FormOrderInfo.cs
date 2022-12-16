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
	public partial class FormOrderInfo : Form
	{
		public FormOrderInfo(string userName)
		{
			InitializeComponent();

			if (userName == null) 
				labelUserName.Text = $"Имя: Гость"; 
			else
				labelUserName.Text = $"Имя: {userName}";

		}






		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormOrderInfo_Load(object sender, EventArgs e)
		{
			var outposts = Helper.context.Outpost.ToList();
			cbOutposts.DataSource = outposts;
			cbOutposts.ValueMember = "ID";
			cbOutposts.DisplayMember = "Address";

			FillPanel();
		}


		private void FillPanel()
		{
			panelProducts.Controls.Clear();
			int pos = 0;
			foreach (ClientProduct product in ClientOrder.products)
			{
				Product p = Helper.context.Product.Where(pr => pr.Article == product.Article).FirstOrDefault();
				ProductPanel pp = new ProductPanel(p,panelProducts);
				panelProducts.Controls.Add(pp);
				pp.Location = new Point(0, 5 + (pos++ * pp.Height));
				panelProducts.Controls.Add(pp);
			}

			FillOrderInfo();
		}


		private void FillOrderInfo()
		{
			rtbDescription.Text = $"Общее кол-во товаров: {ClientOrder.totalProductQuantity} шт." +
				$"\nОбщая стоимость без учета скидки: {ClientOrder.totalCostNoDiscount} руб." +
				$"\nОбщая скидка: {ClientOrder.totalDiscountAmount} руб." +
				$"\nОбщая стоимость с учетом скидки: {ClientOrder.totalCostWithDiscount} руб.";
		}
	}
}
