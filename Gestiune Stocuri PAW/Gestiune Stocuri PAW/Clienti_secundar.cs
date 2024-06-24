using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestiune_Stocuri_PAW
{
	public partial class Clienti_secundar : Form
	{
		public int id;
		public Clienti client;
		public Clienti_secundar(int id, Clienti client)
		{
			InitializeComponent();
			this.id = id;
			this.client = client;
			if (this.id == 0)
			{
				btnOk.Text = "Adauga";
			}
			else if(this.id!=0)
			{
				btnOk.Text = "Modifica";
				tbNume.Text=client.Nume;
				tbNrTelefon.Text = client.Telefon;
				tbAdresa.Text = client.Adresa;
				tbPrenume.Text = client.Prenume;
			}

		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if (tbNume.Text.Length < 3)
			{
				errorProvider.SetError(tbNume, "Numele trebuie sa aiba minim 3 caractere");
				this.DialogResult = DialogResult.None;
			}
			else errorProvider.SetError(tbNume, null);

			if (tbPrenume.Text.Length < 3)
			{
				errorProvider.SetError(tbPrenume, "Prenumele trebuie sa aiba minim 3 caractere");
				this.DialogResult = DialogResult.None;
			}
			else errorProvider.SetError(tbPrenume, null);

			if (tbNrTelefon.Text.Length != 10)
			{
				errorProvider.SetError(tbNrTelefon, "Nr. de telefon trebuie sa aiba 10 cifre");
				this.DialogResult = DialogResult.None;
			}
			else errorProvider.SetError(tbNrTelefon, null);

			if (tbAdresa.Text.Length < 5)
			{
				errorProvider.SetError(tbAdresa, "Adresa trebuie sa aiba minim 5 caractere");
				this.DialogResult = DialogResult.None;
			}
			else errorProvider.SetError(tbAdresa, null);


			string con = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""Gestiune Stocuri"";Integrated Security=True;";
			SqlConnection conexiune = new SqlConnection(con);

			if (this.id == 0 && this.DialogResult == DialogResult.OK)
			{
				conexiune.Open();
				string insert = @"INSERT INTO dbo.Clienti([Nume],[Prenume], [Telefon], [Adresa])
								VALUES('" + tbNume.Text + "', " +
								"'" + tbPrenume.Text + "', " +
								"'" + tbNrTelefon.Text + "', " +
								"'" + tbAdresa.Text + "')";

				SqlCommand cmd = new SqlCommand(insert, conexiune);
				cmd.ExecuteNonQuery();
				conexiune.Close();
			}
			else if (this.id != 0 && this.DialogResult == DialogResult.OK)
			{
				conexiune.Open();
				string update = @"UPDATE dbo.Clienti
								SET [Nume]='" + tbNume.Text + "', " +
								"[Prenume]='" + tbPrenume.Text + "', " +
								"[Telefon]='" + tbNrTelefon.Text + "', " +
								"[Adresa]='" + tbAdresa.Text + "' WHERE [Id]=" + this.id + ";";
				SqlCommand cmd = new SqlCommand(update, conexiune);
				cmd.ExecuteNonQuery();
				conexiune.Close();
			}
		}
	}
}
