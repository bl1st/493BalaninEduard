using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ООО_Ароматный_Мир.Entitites;

namespace ООО_Ароматный_Мир.Classes
{
	internal static class Helper
	{
		public static DBPorfumeEntities context;


		public static bool SaveChanges()
		{
			try
			{
				context.SaveChanges();
			}
			catch 
			{
				MessageBox.Show("Ошибка сохранения изменений","Ошибка");
				return false;
			}

			return true;
		}

	}
}
