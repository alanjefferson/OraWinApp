using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client; // ODP.NET Oracle managed provider
using Oracle.ManagedDataAccess.Types;

namespace OraWinApp
{
	public partial class DBTester : Form
	{
		public DBTester()
		{
			InitializeComponent();
		}

		private void btnTester_Click(object sender, EventArgs e)
		{
			try
			{
				string hostname = txtHostname.Text;
				string port = txtPort.Text;
				string serviceName = txtServiceName.Text;
				string userName = txtUsername.Text;
				string password = txtPassword.Text;

				//string oradb = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=" + hostname + ")(PORT=" + port + "))(CONNECT_DATA=(SERVICE_NAME=" + serviceName + "))); User Id=" + userName + "; Password="+ password + ";";
				string oradb = "Data Source=(description=(address_list=(address=(protocol=tcp)(host=" + hostname + ")(port=" + port + ")))(connect_data=(SERVICE_NAME=" + serviceName + ")(SERVER=dedicated))); User Id=" + userName + "; Password=" + password + ";";
				OracleConnection conn = new OracleConnection(oradb);
				conn.Open();

				lblResult.Text = "Conexão efetuada! " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");

				/*
				OracleCommand cmd = new OracleCommand();
				cmd.Connection = conn;
				cmd.CommandText = "select department_name from departments where department_id = 10";
				cmd.CommandType = CommandType.Text;
				OracleDataReader dr = cmd.ExecuteReader();
				dr.Read();
				lblResult.Text = dr.GetString(0);
				*/

				conn.Dispose();
			}
			catch(Exception ex)
			{
				lblResult.Text = "Erro na tentativa de conexão: " + ex.Message;
			}
		}
	}
}
