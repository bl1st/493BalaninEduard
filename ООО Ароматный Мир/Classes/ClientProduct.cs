using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООО_Ароматный_Мир.Classes
{
	public class ClientProduct
	{
		public string Article;
		public int Quantity = 1;

		public ClientProduct(string article, int quantity) 
		{
			this.Article = article;
			this.Quantity = quantity;
		}
	}
}
