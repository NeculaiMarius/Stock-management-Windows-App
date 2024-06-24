using Gestiune_Stocuri_PAW.Gestiune_StocuriDataSetTableAdapters;
using PROIECT___EXERSAT_TEST;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Gestiune_Stocuri_PAW
{
	public partial class ClientiForm : Form
	{
		public ClientiForm()
		{
			InitializeComponent();
			CustomizeMenu();
			btnSterge.Enabled = false;
			btnModifica.Enabled = false;
		}

		private void ClientiForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'gestiune_StocuriDataSet1.Clienti' table. You can move, or remove it, as needed.
			this.clientiTableAdapter.Fill(this.gestiune_StocuriDataSet1.Clienti);
			gvClienti.ClearSelection();

		}


		private void adaugaClientToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Clienti_secundar formular=new Clienti_secundar(0,null);
			if (formular.ShowDialog() == DialogResult.OK)
			{
				ClientiForm_Load(sender, e);
			}
		}


		private void editeazaClientToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (gvClienti.SelectedRows.Count > 0)
			{
				int id=(int)gvClienti.SelectedRows[0].Cells[0].Value;
				Clienti client = new Clienti();

				client.Nume=gvClienti.SelectedRows[0].Cells[1].Value.ToString();
				client.Prenume=gvClienti.SelectedRows[0].Cells[2].Value.ToString();
				client.Telefon=gvClienti.SelectedRows[0].Cells[3].Value.ToString();
				client.Adresa=gvClienti.SelectedRows[0].Cells[4].Value.ToString();

				Clienti_secundar formular = new Clienti_secundar(id,client);
				if (formular.ShowDialog() == DialogResult.OK)
				{
					ClientiForm_Load(sender, e);
				}
			}
		}

		private void stergeClientToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (gvClienti.SelectedRows.Count > 0)
			{
				DialogResult rezultat = MessageBox.Show(
					"Sigur doriti sa stergeti acest client?\n" +
					"Se vor sterge toate comenzile asociate acestui client !",
					"Confirmare Stergere",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button2);

				if (rezultat == DialogResult.Yes)
				{
					string con = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""Gestiune Stocuri"";Integrated Security=True;";
					SqlConnection conexiune = new SqlConnection(con);
					conexiune.Open();

					string delete = @"DELETE FROM dbo.Clienti WHERE [ID]=" + gvClienti.SelectedRows[0].Cells[0].Value.ToString() + ";";
					SqlCommand cmd = new SqlCommand(delete, conexiune);
					cmd.ExecuteNonQuery();

					string delete_comenzi = @"DELETE FROM dbo.Comenzi WHERE [Id client]=" + gvClienti.SelectedRows[0].Cells[0].Value.ToString() + ";";
					SqlCommand cmd_stergere_comenzi = new SqlCommand(delete_comenzi, conexiune);
					cmd_stergere_comenzi.ExecuteNonQuery();

					ClientiForm_Load(sender, e);

					conexiune.Close();
				}
			}
		}

		private void btnAdauga_Click(object sender, EventArgs e)
		{
			adaugaClientToolStripMenuItem_Click(sender, e);
		}

		private void btnModifica_Click(object sender, EventArgs e)
		{
			editeazaClientToolStripMenuItem_Click(sender,e);
		}

		private void btnSterge_Click(object sender, EventArgs e)
		{
			stergeClientToolStripMenuItem_Click(sender, e);
		}

		private void tbCautare_TextChanged(object sender, EventArgs e)
		{
			string termenCautare = tbCautare.Text.ToLower();
			string filterExpression = string.Format("[Nume] LIKE '%{0}%' OR [Prenume] LIKE '%{0}%'", termenCautare);
			((BindingSource)gvClienti.DataSource).Filter = filterExpression;
			gvClienti.ClearSelection();
		}

		private void gvClienti_SelectionChanged(object sender, EventArgs e)
		{
			if (gvClienti.SelectedRows.Count > 0)
			{
				selectie_curenta1.modificaSelectie("ID : " + gvClienti.SelectedRows[0].Cells[0].Value.ToString() + "  Nume: " + gvClienti.SelectedRows[0].Cells[1].Value.ToString()+" "+ gvClienti.SelectedRows[0].Cells[2].Value.ToString());

				btnModifica.Enabled = true;
				btnSterge.Enabled = true;
			}
			else
			{
				btnSterge.Enabled = false;
				btnModifica.Enabled = false;
			}
		}

		private void ClientiForm_Click(object sender, EventArgs e)
		{
			gvClienti.ClearSelection();
		}

		private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "fisier clienti (*.cln)|*.cln";
			saveFileDialog.CheckPathExists = true;

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				List<Clienti> lista_clienti = new List<Clienti>();
				foreach (DataGridViewRow gv_row in gvClienti.Rows)
				{
					Clienti c = new Clienti();
					c.Nume = gv_row.Cells[1].Value.ToString();
					c.Prenume = gv_row.Cells[2].Value.ToString();
					c.Telefon = gv_row.Cells[3].Value.ToString();
					c.Adresa = gv_row.Cells[4].Value.ToString();
				
					lista_clienti.Add(c);
				}

				try
				{
					BinaryFormatter serializator = new BinaryFormatter();
					Stream fisier = File.Create(saveFileDialog.FileName);
					serializator.Serialize(fisier, lista_clienti);
					fisier.Close();
					MessageBox.Show("Lista de clienti a fost salvata cu succes!");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void restaurarebinToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "fisier clienti (*.prd)|*.cln";
			openFileDialog.CheckFileExists = true;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				List<Clienti> lista_clienti = new List<Clienti>();
				Stream fisier = File.OpenRead(openFileDialog.FileName);
				BinaryFormatter serializator = new BinaryFormatter();
				lista_clienti.AddRange((List<Clienti>)serializator.Deserialize(fisier));

				if (gvClienti.Rows.Count > 0)
				{
					if (MessageBox.Show("Exista deja produse in lista.", " Doriti sa le stergeti ? ", MessageBoxButtons.YesNo) == DialogResult.Yes) ;
					//this.produseTableAdapter.Delete();
				}

				foreach (Clienti c in lista_clienti)
				{
					clientiTableAdapter.Insert(c.Nume, c.Prenume, c.Telefon, c.Adresa);
				}
				ClientiForm_Load(sender, e);
				fisier.Close();
			}
		}

		private void salvarexmlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "fisier clienti (*.xml)|*.xml";
			saveFileDialog.CheckPathExists = true;

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				List<Clienti> lista_clienti = new List<Clienti>();
				foreach (DataGridViewRow gv_row in gvClienti.Rows)
				{
					Clienti c = new Clienti();
					c.Nume = gv_row.Cells[1].Value.ToString();
					c.Prenume = gv_row.Cells[2].Value.ToString();
					c.Telefon = gv_row.Cells[3].Value.ToString();
					c.Adresa = gv_row.Cells[4].Value.ToString();

					lista_clienti.Add(c);
				}
				try
				{
					XmlSerializer serializator = new XmlSerializer(typeof(List<Clienti>));
					Stream fisier = File.Create(saveFileDialog.FileName);
					serializator.Serialize(fisier, lista_clienti);
					fisier.Close();
					MessageBox.Show("Lista de clienti a fost salvata cu succes!");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void restaurarexmlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "fisier clienti (*.xml)|*.xml";
			openFileDialog.CheckFileExists = true;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					Stream fisier = File.OpenRead(openFileDialog.FileName);
					XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Clienti>));
					List<Clienti> lista = xmlSerializer.Deserialize(fisier) as List<Clienti>;
					if (gvClienti.Rows.Count > 0)
					{
						if (MessageBox.Show("Exista deja clienti in lista.", " Doriti sa ii stergeti ? ", MessageBoxButtons.YesNo) == DialogResult.Yes) ;
						//this.produseTableAdapter.Delete();
					}

					foreach (Clienti c in lista)
					{
						clientiTableAdapter.Insert(c.Nume, c.Prenume, c.Telefon, c.Adresa);
					}
					fisier.Close();
					ClientiForm_Load(sender, e);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}


		private void gvClienti_MouseDown(object sender, MouseEventArgs e)
		{
			if (gvClienti.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = gvClienti.SelectedRows[0];
				gvClienti.DoDragDrop(selectedRow, DragDropEffects.Copy);
			}
		}


		private void btnSterge_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
			{
				e.Effect = DragDropEffects.Copy;
				btnSterge.Size = new Size(btnSterge.Width, btnSterge.Height+50);
				btnSterge.BackColor = Color.DarkRed;

				Image imagine = global::Gestiune_Stocuri_PAW.Properties.Resources.delete_48dp_FILL0_wght400_GRAD0_opsz48;
				btnSterge.BackgroundImage = imagine;
				btnSterge.BackgroundImageLayout = ImageLayout.Zoom;
				btnSterge.Text = null;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}

		}

		private void btnSterge_DragLeave(object sender, EventArgs e)
		{
			btnSterge.Size = new Size(btnSterge.Width, btnSterge.Height-50);
			btnSterge.BackColor = Color.Crimson;

			btnSterge.BackgroundImage = null;
			btnSterge.Text = "Sterge produs";
		}

		private void btnSterge_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
			{
				stergeClientToolStripMenuItem_Click(sender, e);
			}
			btnSterge_DragLeave(sender, e);
		}



		//Stilizare

		private void CustomizeMenu()
		{
			this.menuStrip1.BackColor = Color.MediumSlateBlue;
			this.menuStrip1.ForeColor = Color.White;
			this.menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

			foreach (ToolStripMenuItem item in this.menuStrip1.Items)
			{
				item.BackColor = Color.MediumSlateBlue;
				item.ForeColor = Color.White;
				item.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

				foreach (ToolStripMenuItem subItem in item.DropDownItems)
				{
					subItem.BackColor = Color.MediumSlateBlue;
					subItem.ForeColor = Color.White;
					subItem.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
				}
			}
		}

		private void ClientiForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				if(MessageBox.Show("Sigur doriiti sa iesiti?","Iesire",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
					this.Close();
			}
		}
	}
}
