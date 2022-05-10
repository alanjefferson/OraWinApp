
namespace OraWinApp
{
	partial class DBTester
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnTester = new System.Windows.Forms.Button();
			this.lblResult = new System.Windows.Forms.Label();
			this.lblHostname = new System.Windows.Forms.Label();
			this.lblPort = new System.Windows.Forms.Label();
			this.lblService = new System.Windows.Forms.Label();
			this.txtHostname = new System.Windows.Forms.TextBox();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.txtServiceName = new System.Windows.Forms.TextBox();
			this.lblUserName = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnTester
			// 
			this.btnTester.Location = new System.Drawing.Point(353, 173);
			this.btnTester.Name = "btnTester";
			this.btnTester.Size = new System.Drawing.Size(75, 23);
			this.btnTester.TabIndex = 0;
			this.btnTester.Text = "Conectar";
			this.btnTester.UseVisualStyleBackColor = true;
			this.btnTester.Click += new System.EventHandler(this.btnTester_Click);
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Location = new System.Drawing.Point(42, 213);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(16, 13);
			this.lblResult.TabIndex = 1;
			this.lblResult.Text = "...";
			// 
			// lblHostname
			// 
			this.lblHostname.AutoSize = true;
			this.lblHostname.Location = new System.Drawing.Point(42, 24);
			this.lblHostname.Name = "lblHostname";
			this.lblHostname.Size = new System.Drawing.Size(78, 13);
			this.lblHostname.TabIndex = 2;
			this.lblHostname.Text = "Nome do Host:";
			// 
			// lblPort
			// 
			this.lblPort.AutoSize = true;
			this.lblPort.Location = new System.Drawing.Point(42, 54);
			this.lblPort.Name = "lblPort";
			this.lblPort.Size = new System.Drawing.Size(35, 13);
			this.lblPort.TabIndex = 3;
			this.lblPort.Text = "Porta:";
			// 
			// lblService
			// 
			this.lblService.AutoSize = true;
			this.lblService.Location = new System.Drawing.Point(42, 81);
			this.lblService.Name = "lblService";
			this.lblService.Size = new System.Drawing.Size(46, 13);
			this.lblService.TabIndex = 4;
			this.lblService.Text = "Serviço:";
			// 
			// txtHostname
			// 
			this.txtHostname.Location = new System.Drawing.Point(145, 24);
			this.txtHostname.Name = "txtHostname";
			this.txtHostname.Size = new System.Drawing.Size(283, 20);
			this.txtHostname.TabIndex = 5;
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(145, 51);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(65, 20);
			this.txtPort.TabIndex = 6;
			// 
			// txtServiceName
			// 
			this.txtServiceName.Location = new System.Drawing.Point(145, 78);
			this.txtServiceName.Name = "txtServiceName";
			this.txtServiceName.Size = new System.Drawing.Size(283, 20);
			this.txtServiceName.TabIndex = 7;
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Location = new System.Drawing.Point(42, 115);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(61, 13);
			this.lblUserName.TabIndex = 8;
			this.lblUserName.Text = "User-name:";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(42, 146);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(56, 13);
			this.lblPassword.TabIndex = 9;
			this.lblPassword.Text = "Password:";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(145, 112);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(149, 20);
			this.txtUsername.TabIndex = 10;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(145, 143);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(149, 20);
			this.txtPassword.TabIndex = 11;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// DBTester
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(474, 261);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.txtServiceName);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.txtHostname);
			this.Controls.Add(this.lblService);
			this.Controls.Add(this.lblPort);
			this.Controls.Add(this.lblHostname);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.btnTester);
			this.Name = "DBTester";
			this.Text = "Teste Conexão Banco Oracle";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnTester;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.Label lblHostname;
		private System.Windows.Forms.Label lblPort;
		private System.Windows.Forms.Label lblService;
		private System.Windows.Forms.TextBox txtHostname;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.TextBox txtServiceName;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPassword;
	}
}

