namespace ООО_Ароматный_Мир
{
	partial class FormAuthorize
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorize));
			this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
			this.btnExit = new System.Windows.Forms.Button();
			this.pbImage = new System.Windows.Forms.PictureBox();
			this.labelOrganisationName = new System.Windows.Forms.Label();
			this.tlpBody = new System.Windows.Forms.TableLayoutPanel();
			this.labelLogin = new System.Windows.Forms.Label();
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.labelPasswrod = new System.Windows.Forms.Label();
			this.tbPassword = new System.Windows.Forms.MaskedTextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnLoginAsGuest = new System.Windows.Forms.Button();
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
			this.tlpHeader.Name = "tlpHeader";
			this.tlpHeader.RowCount = 1;
			this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpHeader.Size = new System.Drawing.Size(769, 85);
			this.tlpHeader.TabIndex = 0;
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
			this.btnExit.Location = new System.Drawing.Point(656, 3);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(110, 79);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "Выход";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// pbImage
			// 
			this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbImage.Image = global::ООО_Ароматный_Мир.Properties.Resources.logo;
			this.pbImage.Location = new System.Drawing.Point(3, 3);
			this.pbImage.Name = "pbImage";
			this.pbImage.Size = new System.Drawing.Size(109, 79);
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
			this.labelOrganisationName.Location = new System.Drawing.Point(118, 0);
			this.labelOrganisationName.Name = "labelOrganisationName";
			this.labelOrganisationName.Size = new System.Drawing.Size(532, 85);
			this.labelOrganisationName.TabIndex = 1;
			this.labelOrganisationName.Text = "ООО \"Ароматный мир\"";
			this.labelOrganisationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tlpBody
			// 
			this.tlpBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tlpBody.ColumnCount = 4;
			this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpBody.Controls.Add(this.labelLogin, 1, 1);
			this.tlpBody.Controls.Add(this.tbLogin, 2, 1);
			this.tlpBody.Controls.Add(this.labelPasswrod, 1, 2);
			this.tlpBody.Controls.Add(this.tbPassword, 2, 2);
			this.tlpBody.Controls.Add(this.btnLogin, 1, 3);
			this.tlpBody.Controls.Add(this.btnLoginAsGuest, 2, 3);
			this.tlpBody.Location = new System.Drawing.Point(0, 88);
			this.tlpBody.Name = "tlpBody";
			this.tlpBody.RowCount = 5;
			this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
			this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
			this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
			this.tlpBody.Size = new System.Drawing.Size(766, 369);
			this.tlpBody.TabIndex = 1;
			// 
			// labelLogin
			// 
			this.labelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelLogin.AutoSize = true;
			this.labelLogin.Location = new System.Drawing.Point(194, 132);
			this.labelLogin.Name = "labelLogin";
			this.labelLogin.Size = new System.Drawing.Size(185, 32);
			this.labelLogin.TabIndex = 0;
			this.labelLogin.Text = "Логин:";
			this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbLogin
			// 
			this.tbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbLogin.Location = new System.Drawing.Point(385, 135);
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(185, 26);
			this.tbLogin.TabIndex = 1;
			// 
			// labelPasswrod
			// 
			this.labelPasswrod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelPasswrod.AutoSize = true;
			this.labelPasswrod.Location = new System.Drawing.Point(194, 164);
			this.labelPasswrod.Name = "labelPasswrod";
			this.labelPasswrod.Size = new System.Drawing.Size(185, 32);
			this.labelPasswrod.TabIndex = 1;
			this.labelPasswrod.Text = "Пароль:";
			this.labelPasswrod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbPassword
			// 
			this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPassword.Location = new System.Drawing.Point(385, 167);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.Size = new System.Drawing.Size(185, 26);
			this.tbPassword.TabIndex = 2;
			// 
			// btnLogin
			// 
			this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLogin.Location = new System.Drawing.Point(194, 199);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(185, 33);
			this.btnLogin.TabIndex = 3;
			this.btnLogin.Text = "Войти";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnLoginAsGuest
			// 
			this.btnLoginAsGuest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLoginAsGuest.Location = new System.Drawing.Point(385, 199);
			this.btnLoginAsGuest.Name = "btnLoginAsGuest";
			this.btnLoginAsGuest.Size = new System.Drawing.Size(185, 33);
			this.btnLoginAsGuest.TabIndex = 4;
			this.btnLoginAsGuest.Text = "Войти как гость";
			this.btnLoginAsGuest.UseVisualStyleBackColor = true;
			this.btnLoginAsGuest.Click += new System.EventHandler(this.btnLoginAsGuest_Click);
			// 
			// FormAuthorize
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 460);
			this.Controls.Add(this.tlpBody);
			this.Controls.Add(this.tlpHeader);
			this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormAuthorize";
			this.Text = "ООО Ароматный мир";
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
		private System.Windows.Forms.Label labelLogin;
		private System.Windows.Forms.TextBox tbLogin;
		private System.Windows.Forms.Label labelPasswrod;
		private System.Windows.Forms.MaskedTextBox tbPassword;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnLoginAsGuest;
	}
}

