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
	public partial class ComenziForm : Form
	{
		public ComenziForm()
		{
			InitializeComponent();
			gvComenzi_Load();
		}

		private void ComenziForm_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'gestiune_StocuriDataSet3.Produse' table. You can move, or remove it, as needed.
            this.produseTableAdapter.Fill(this.gestiune_StocuriDataSet3.Produse);
            // TODO: This line of code loads data into the 'gestiune_StocuriDataSet2.Clienti' table. You can move, or remove it, as needed.
            this.clientiTableAdapter.Fill(this.gestiune_StocuriDataSet2.Clienti);

        }

		private void gvComenzi_Load()
		{
			try
			{
				string con = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""Gestiune Stocuri"";Integrated Security=True;";
				SqlConnection conexiune = new SqlConnection(con);
				conexiune.Open();

				string query = @"
							SELECT
								Comenzi.[Id],
								Comenzi.[Id Client],
								Clienti.[Nume],
								Clienti.[Prenume],
								Comenzi.[Id Produs],
								Produse.[Nume produs],
								Comenzi.[Cantitate],
								ROUND(Comenzi.[cantitate] * Produse.[Pret], 2) AS Pret_total
							FROM
								Comenzi
							INNER JOIN
								produse ON comenzi.[Id Produs] = produse.[Id]
							INNER JOIN
								clienti ON comenzi.[Id Client] = clienti.[Id];";
				SqlDataAdapter sda = new SqlDataAdapter(query, conexiune);
				DataTable dt = new DataTable();
				sda.Fill(dt);
				gvComenzi.DataSource = dt;
				conexiune.Close();

			}
			catch (Exception ex) 
			{
				MessageBox.Show("A aparut o eroare: "+ex.Message);
			}
		}

		private void gvClienti_SelectionChanged(object sender, EventArgs e)
		{
			if (gvClienti.SelectedRows.Count > 0)
			{
				tbIdClient.Text = gvClienti.SelectedRows[0].Cells[0].Value.ToString();
				tbClient.Text = gvClienti.SelectedRows[0].Cells[1].Value.ToString() + " " + gvClienti.SelectedRows[0].Cells[2].Value.ToString();
			}
		}

		private void gvProduse_SelectionChanged(object sender, EventArgs e)
		{
			if (gvProduse.SelectedRows.Count > 0)
			{
				tbIdProdus.Text = gvProduse.SelectedRows[0].Cells[0].Value.ToString();
				tbProdus.Text = gvProduse.SelectedRows[0].Cells[1].Value.ToString();
				tbSuma.Text=(Convert.ToDecimal(gvProduse.SelectedRows[0].Cells[5].Value)*numericCantitate.Value).ToString();
			}
		}

		private void numericCantitate_ValueChanged(object sender, EventArgs e)
		{
			tbSuma.Text = (Convert.ToDecimal(gvProduse.SelectedRows[0].Cells[5].Value) * numericCantitate.Value).ToString();
		}

		private void btnComanda_Click(object sender, EventArgs e)
		{
			try
			{
				
				string con = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""Gestiune Stocuri"";Integrated Security=True;";
				SqlConnection conexiune = new SqlConnection(con);
				conexiune.Open();

				string check = @"SELECT [Cantitate] from dbo.Produse WHERE [Id]=" + tbIdProdus.Text + ";";
				SqlCommand check_cmd=new SqlCommand(check, conexiune);
				int cantitate_disponibila=(int)check_cmd.ExecuteScalar();



				if (cantitate_disponibila >= numericCantitate.Value && numericCantitate.Value != 0)
				{
					string insert = @"INSERT INTO dbo.Comenzi([Id client],[Id Produs], [Cantitate])
								VALUES('" + tbIdClient.Text + "', " +
										"'" + tbIdProdus.Text + "', " +
										"" + numericCantitate.Value.ToString() + ")";
					SqlCommand cmd = new SqlCommand(insert, conexiune);
					cmd.ExecuteNonQuery();

					string update = @"UPDATE dbo.Produse 
									SET [Cantitate]=[Cantitate]-" + numericCantitate.Value +
									"WHERE [Id]=" + tbIdProdus.Text + "";

					SqlCommand cmd_update = new SqlCommand(update, conexiune);
					cmd_update.ExecuteNonQuery();

					conexiune.Close();
					ComenziForm_Load(sender, e);
				}
				else if (numericCantitate.Value == 0)
				{
					MessageBox.Show("Cantitatea nu poate fi 0");
				}
				else
				{
					MessageBox.Show("Nu exista destule produse in stoc");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Eroare la insert comenzi: " + ex.Message);
			}

			gvComenzi_Load();
		}

		private void btnStatistici_Click(object sender, EventArgs e)
		{
			Grafic grafic=new Grafic();
			grafic.Show();
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			if (gvComenzi.SelectedRows.Count > 0)
			{
				// Preluarea datelor din rândul selectat
				string idComanda = gvComenzi.SelectedRows[0].Cells[0].Value.ToString();
				string numeClient = gvComenzi.SelectedRows[0].Cells[2].Value.ToString()+" "+ gvComenzi.SelectedRows[0].Cells[3].Value.ToString();
				string idClient = gvComenzi.SelectedRows[0].Cells[1].Value.ToString();
				string numeProdus = gvComenzi.SelectedRows[0].Cells[5].Value.ToString();
				string cantitate = gvComenzi.SelectedRows[0].Cells[6].Value.ToString();
				string pretTotal = gvComenzi.SelectedRows[0].Cells[7].Value.ToString();
				string pretCuvinte = NumarCuvinte.ConvertNumberToWords((float)Convert.ToSingle(gvComenzi.SelectedRows[0].Cells[7].Value));

				// Configurarea fonturilor și a layout-ului
				Font fontTitle = new Font("Arial", 22, FontStyle.Bold);
				Font font = new Font("Arial", 14);
				int startX = 10;
				int startY = 10;
				int offset = 30;

				// Desenarea titlului furnizorului
				e.Graphics.DrawString("Furnizor: SC Depozit SRL", font, Brushes.Black, startX, startY);
				startY += offset;
				e.Graphics.DrawString("CIF: RO 123456", font, Brushes.Black, startX, startY);
				startY += offset;
				e.Graphics.DrawString("Nr. Reg. Com.: J22/05/2024", font, Brushes.Black, startX, startY);
				startY += offset;
				e.Graphics.DrawString("Sediul: Str. Principala", font, Brushes.Black, startX, startY);
				startY += offset;
				e.Graphics.DrawString("Judet: Bucuresti - Sector 1", font, Brushes.Black, startX, startY);
				startY += offset;
				e.Graphics.DrawString("Cont: R0XXXX098765432101234", font, Brushes.Black, startX, startY);
				startY += offset;
				e.Graphics.DrawString("Banca: Banca Nationala", font, Brushes.Black, startX, startY);
				startY += offset * 2;

				// Desenarea titlului chitanței
				e.Graphics.DrawString("Chitanța nr.: " + idComanda, fontTitle, Brushes.Black, startX, startY);
				startY += offset * 2;

				// Desenarea detaliilor chitanței
				e.Graphics.DrawString("Am primit de la: " + numeClient + ", client cu id " + idClient + ",", font, Brushes.Black, startX, startY);
				startY += offset;
				e.Graphics.DrawString("suma de " + pretTotal + " lei (" + pretCuvinte + "), ", font, Brushes.Black, startX, startY);
				startY += offset;
				e.Graphics.DrawString("reprezentând contravaloarea a: ", font, Brushes.Black, startX, startY);
				startY += offset;
				e.Graphics.DrawString("     -->  "+cantitate + " unități din produsul " + numeProdus + ".", font, Brushes.Black, startX, startY);
			}
		}


		private void printeazaChToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (gvComenzi.SelectedRows.Count > 0)
			{
				printPreviewDialog1.ShowDialog();
			}
		}

		private void gvComenzi_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				int rowIndex = gvComenzi.HitTest(e.X, e.Y).RowIndex;
				if (rowIndex >= 0)
				{
					gvComenzi.ClearSelection();
					gvComenzi.Rows[rowIndex].Selected = true;
				}
			}
		}

		private void ComenziForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				if (MessageBox.Show("Sigur doriiti sa iesiti?", "Iesire", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					this.Close();
			}
		}
	}
}
