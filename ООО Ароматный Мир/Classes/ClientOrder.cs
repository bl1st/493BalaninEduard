using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ООО_Ароматный_Мир.Entitites;

namespace ООО_Ароматный_Мир.Classes
{
	public static class ClientOrder
	{
		public static List<ClientProduct> products = new List<ClientProduct>();

		public static double totalCostNoDiscount = 0;
		public static double totalCostWithDiscount = 0;
		public static double totalDiscountAmount = 0;
		public static int totalProductQuantity = 0;


		public static void AddProduct(ClientProduct product)
		{
			if (products.Count == 0)
			{
				products.Add(product);
			}
			else
			{
				ClientProduct cp = products.Where(p => p.Article == product.Article).FirstOrDefault();
				if  (cp!= null)
				{					
					cp.Quantity++;
				}
				else
				{
					products.Add(product);
				}
				
			}
			RecalcuteCosts();
		}


		public static void RemoveProduct(ClientProduct product)
		{
			ClientProduct cp = products.Where(p => p.Article == product.Article).FirstOrDefault();
			products.Remove(cp);
			RecalcuteCosts();
		}


		private static void RecalcuteCosts()
		{
			totalCostNoDiscount = 0;
			totalCostWithDiscount = 0;
			totalDiscountAmount = 0;
			totalProductQuantity = 0;
			foreach(ClientProduct prod in products)
			{
				Product product = Helper.context.Product.Where(p=> p.Article == prod.Article).FirstOrDefault();
				totalCostNoDiscount += (double)product.Cost * prod.Quantity;
				double discountAmount =  (double)product.Cost*(product.CurrentDiscount * 0.01);
				totalDiscountAmount += discountAmount * prod.Quantity;
				totalCostWithDiscount +=  ((double)product.Cost - discountAmount) * prod.Quantity;
				totalProductQuantity += prod.Quantity;
			}
		}

	}
}
