using System;
using System.Collections;
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
	public partial class Grafic : Form
	{
		public Grafic()
		{
			InitializeComponent();
		}

		private void Grafic_Load(object sender, EventArgs e)
		{
			string con = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""Gestiune Stocuri"";Integrated Security=True;";
			SqlConnection conexiune = new SqlConnection(con);
			conexiune.Open();

			string select = @"SELECT Clienti.[Nume],Clienti.[Prenume], SUM(Comenzi.[Cantitate]*Produse.[Pret]) FROM Clienti,Produse,Comenzi
							WHERE Clienti.[Id]=Comenzi.[Id Client]
							AND Produse.[Id]=Comenzi.[Id Produs]
							GROUP BY Clienti.[Nume],Clienti.[Prenume];";

			SqlDataAdapter sda = new SqlDataAdapter(select, conexiune);
			DataTable dt = new DataTable();
			sda.Fill(dt);

			foreach (DataRow dr in dt.Rows)
			{
				graficComenzi.Series["Comenzi"].Points.AddXY(dr[0].ToString()+" "+dr[1].ToString(), Convert.ToDouble(dr[2]));
			}

			conexiune.Close();
		}
	}
}
