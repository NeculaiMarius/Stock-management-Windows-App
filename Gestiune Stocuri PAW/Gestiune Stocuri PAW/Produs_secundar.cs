using PROIECT___EXERSAT_TEST;
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
	public partial class Produs_secundar : Form
	{
		public int id;
		public Produse produs;
		public Produs_secundar(int id,Produse produs)
		{
			InitializeComponent();
			this.id = id;
			this.produs = produs;
			if (this.id ==0)
			{
				btnOk.Text = "Adauga";
			}
			else if(this.id!=0)
			{
				btnOk.Text = "Modifica";
				tbNume.Text = produs.NumeProdus;
				tbCantitate.Text=produs.Cantitate.ToString();
				tbPret.Text = produs.PretUM.ToString();
				cbUM.SelectedItem = produs.Um;
				cbCategorie.SelectedItem = produs.Categorie;
			}
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			//Validari date
			int cantitate;
			float pret;

			if (tbNume.Text.Length < 3)
			{
				errorProvider.SetError(tbNume, "Numele trebuie sa aiba minim 3 caractere.");
				DialogResult = DialogResult.None;
			}
			else errorProvider.SetError(tbNume, "");

			if (int.TryParse(tbCantitate.Text, out cantitate) == false)
			{
				errorProvider.SetError(tbCantitate, "Cantitatea nu este un numar valid");
				this.DialogResult = DialogResult.None;
			}
			else errorProvider.SetError(tbCantitate, "");


			if (float.TryParse(tbPret.Text, out pret) == false)
			{
				errorProvider.SetError(tbPret, "Pretul nu este un numar valid");
				DialogResult = DialogResult.None;
			}
			else errorProvider.SetError(tbPret, "");


			if (cbCategorie.SelectedItem == null)
			{
				errorProvider.SetError(cbCategorie, "Te rog selectează o categorie.");
				this.DialogResult = DialogResult.None;
			}
			else errorProvider.SetError(cbCategorie, "");


			string con = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""Gestiune Stocuri"";Integrated Security=True;";
			SqlConnection conexiune = new SqlConnection(con);

			if (this.id == 0 && this.DialogResult==DialogResult.OK)
			{
				conexiune.Open();

				string insert = @"INSERT INTO dbo.Produse([Nume produs],[Categorie], [Cantitate], [Unitate de masura], [Pret])
								VALUES('" + tbNume.Text + "', " +
								"'" + cbCategorie.Text + "', " +
								"'" + tbCantitate.Text + "', " +
								"'" + cbUM.Text + "', " +
								"'" + tbPret.Text + "')";

				SqlCommand cmd = new SqlCommand(insert, conexiune);
				cmd.ExecuteNonQuery();
				conexiune.Close();
			}
			else if (this.id != 0 && this.DialogResult==DialogResult.OK)
			{
				conexiune.Open();
				string update = @"UPDATE dbo.Produse
								SET [Nume produs]='" + tbNume.Text + "', " +
								"[Categorie]='" + cbCategorie.Text + "', " +
								"[Cantitate]='" + tbCantitate.Text + "', " +
								"[Unitate de masura]='" + cbUM.Text + "', " +
								"[Pret]=" + tbPret.Text + " WHERE [Id]=" + this.id + ";";
				SqlCommand cmd=new SqlCommand(update, conexiune);
				cmd.ExecuteNonQuery();
				conexiune.Close();
			}
		}
	}
}
