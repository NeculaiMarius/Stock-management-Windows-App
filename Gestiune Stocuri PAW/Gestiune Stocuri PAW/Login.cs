using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestiune_Stocuri_PAW
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void btnSterge_Click(object sender, EventArgs e)
		{
			tbUsername.Clear();
			tbPassword.Clear();
			tbUsername.Focus();
		}

		private void btnAutentificare_Click(object sender, EventArgs e)
		{
			string con = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""Gestiune Stocuri"";Integrated Security=True;";
			SqlConnection conexiune = new SqlConnection(con);

			string select = @"SELECT * FROM dbo.Utilizatori where username='"+tbUsername.Text+"' and password='"+tbPassword.Text+"' ;";
			SqlDataAdapter sda = new SqlDataAdapter(select, conexiune);
			
			DataTable dt = new DataTable();
			sda.Fill(dt);

			if (dt.Rows.Count == 1)
			{
				this.Hide();
				Meniu meniu = new Meniu();
				meniu.Show();
			}
			else
			{
				btnSterge_Click(sender, e);
				MessageBox.Show("Nume de utilizator sau parola incorecta");
			}

			conexiune.Close();
		}
	}
}
