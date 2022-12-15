using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ООО_Ароматный_Мир.Entitites;
using ООО_Ароматный_Мир.Views;

namespace ООО_Ароматный_Мир
{
	public partial class FormAuthorize : Form
	{
		Timer t;
	
		public FormAuthorize()
		{
			InitializeComponent();
			t = new Timer();
			t.Interval = 10000;
			t.Tick += T_Tick;
		}

		private void T_Tick(object sender, EventArgs e)
		{
			t.Enabled = false;
			t.Stop();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (t.Enabled)
				return;
			string login = tbLogin.Text;
			string password = tbPassword.Text;

			var user = Classes.Helper.context.User.Where(u => u.Login == login && u.Password == password).FirstOrDefault();
			if (user ==null)
			{
				MessageBox.Show("Неправильный логин или пароль!\nБлокировка авторизации на 10 секунд","Ошибка");
				t.Enabled = true;
				t.Start();
				return;
			}
			MessageBox.Show($"Добро пожаловать, {user.Name} {user.Patronymic}\nРоль: {user.Role.Name}", "Оповещение");

			FormProducts f = new FormProducts(user.Role.Name, $"{user.Surename} {user.Name} {user.Patronymic}");
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		private void btnLoginAsGuest_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"Добро пожаловать, Гость", "Оповещение");

			FormProducts f = new FormProducts("Гость",null);
			this.Hide();
			f.ShowDialog();
			this.Show();
		}
	}
}
