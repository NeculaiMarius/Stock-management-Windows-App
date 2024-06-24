	using Gestiune_Stocuri_PAW.Properties;
using PROIECT___EXERSAT_TEST;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Gestiune_Stocuri_PAW
{
	public partial class ProduseForm : Form
	{
		public ProduseForm()
		{
			InitializeComponent();

			btnSterge.Enabled = false;
			btnModifica.Enabled = false;

			CustomizeMenu();
		}



		private void adaugaProdusToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Produs_secundar formular = new Produs_secundar(0, null);
			if (formular.ShowDialog() == DialogResult.OK)
			{
				ProduseForm_Load(sender, e);
			}
		}

		private void editeazaProdusToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (gvProduse.SelectedRows.Count > 0)
			{
				Produse produs = new Produse();
				produs.NumeProdus = gvProduse.SelectedRows[0].Cells[1].Value.ToString();
				produs.Categorie = gvProduse.SelectedRows[0].Cells[2].Value.ToString();
				produs.Cantitate = (int)(gvProduse.SelectedRows[0].Cells[3].Value);
				produs.Um = gvProduse.SelectedRows[0].Cells[4].Value.ToString();
				produs.PretUM = Convert.ToSingle(gvProduse.SelectedRows[0].Cells[5].Value);

				//MessageBox.Show(produs.NumeProdus + produs.Categorie + produs.Um + produs.Cantitate.ToString() + produs.PretUM.ToString());

				int id = Convert.ToInt32(gvProduse.SelectedRows[0].Cells[0].Value);
				Produs_secundar formular = new Produs_secundar(id, produs);
				if (formular.ShowDialog() == DialogResult.OK)
				{
					ProduseForm_Load(sender, e);
				}
			}
		}

		private void stergeProdusToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (gvProduse.SelectedRows.Count > 0)
			{
				DialogResult rezultat = MessageBox.Show(
					"Sigur doriti sa stergeti acest produs?\n" +
					"Se vor sterge toate comenzile asociate acestui produs !",
					"Stergere!",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button2);

				if (rezultat == DialogResult.Yes)
				{
					//string con = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""Gestiune Stocuri"";Integrated Security=True;";
					SqlConnection conexiune = new SqlConnection("con");
					conexiune.Open();

					string delete = @"DELETE FROM dbo.Produse WHERE [ID]=" + gvProduse.SelectedRows[0].Cells[0].Value.ToString() + ";";
					SqlCommand cmd = new SqlCommand(delete, conexiune);

					string delete_comenzi=@"DELETE FROM dbo.Comenzi WHERE [Id produs]="+gvProduse.SelectedRows[0].Cells[0].Value.ToString()+";";
					SqlCommand cmd_stergere_comenzi = new SqlCommand(delete_comenzi,conexiune);
					cmd_stergere_comenzi.ExecuteNonQuery();
					cmd.ExecuteNonQuery();

					ProduseForm_Load(sender, e);
					conexiune.Close();
				}
			}
		}

		private void gvProduse_SelectionChanged(object sender, EventArgs e)
		{
			if (gvProduse.SelectedRows.Count > 0)
			{
				selectie_curenta1.modificaSelectie("ID : " + gvProduse.SelectedRows[0].Cells[0].Value.ToString() + "  Nume: " + gvProduse.SelectedRows[0].Cells[1].Value.ToString());
				btnModifica.Enabled = true;
				btnSterge.Enabled = true;
			}
			else
			{
				btnSterge.Enabled = false;
				btnModifica.Enabled = false;
			}
		}

		private void ProduseForm_Click(object sender, EventArgs e)
		{
			gvProduse.ClearSelection();
		}

		private void btnAdauga_Click(object sender, EventArgs e)
		{
			adaugaProdusToolStripMenuItem_Click(sender, e);
		}

		private void btnModifica_Click(object sender, EventArgs e)
		{
			editeazaProdusToolStripMenuItem_Click(sender, e);
		}

		private void btnSterge_Click(object sender, EventArgs e)
		{
			stergeProdusToolStripMenuItem_Click(sender, e);
		}

		private void tbCautare_TextChanged(object sender, EventArgs e)
		{
			string termenCautare = tbCautare.Text.ToLower();
			((BindingSource)gvProduse.DataSource).Filter = "[Nume produs] LIKE '%" + termenCautare + "%'";
			gvProduse.ClearSelection();
		}

		private void ProduseForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'gestiune_StocuriDataSet.Produse' table. You can move, or remove it, as needed.
			this.produseTableAdapter.Fill(this.gestiune_StocuriDataSet.Produse);
			gvProduse.ClearSelection();

		}

		private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "fisier produse (*.prd)|*.prd";
			saveFileDialog.CheckPathExists = true;

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				List<Produse> lista_produse = new List<Produse>();
				foreach (DataGridViewRow gv_row in gvProduse.Rows)
				{
					Produse p = new Produse();
					p.NumeProdus = gv_row.Cells[1].Value.ToString();
					p.Categorie = gv_row.Cells[2].Value.ToString();
					p.Cantitate = (int)gv_row.Cells[3].Value;
					p.Um = gv_row.Cells[4].Value.ToString();
					p.PretUM = Convert.ToSingle(gv_row.Cells[5].Value);
					lista_produse.Add(p);
				}

				try
				{
					BinaryFormatter serializator = new BinaryFormatter();
					Stream fisier = File.Create(saveFileDialog.FileName);
					serializator.Serialize(fisier, lista_produse);
					fisier.Close();
					MessageBox.Show("Lista de produse a fost salvata cu succes!");
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
			openFileDialog.Filter = "fisier produse (*.prd)|*.prd";
			openFileDialog.CheckFileExists = true;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				List<Produse> lista_produse = new List<Produse>();
				Stream fisier = File.OpenRead(openFileDialog.FileName);
				BinaryFormatter serializator = new BinaryFormatter();
				lista_produse.AddRange((List<Produse>)serializator.Deserialize(fisier));

				if (gvProduse.Rows.Count > 0)
				{
					if (MessageBox.Show("Exista deja produse in lista.", " Doriti sa le stergeti ? ", MessageBoxButtons.YesNo) == DialogResult.Yes) ;
					//this.produseTableAdapter.Delete();
				}

				foreach (Produse p in lista_produse)
				{
					produseTableAdapter.Insert(p.NumeProdus, p.Categorie, p.Cantitate, p.Um, p.PretUM);
				}
				ProduseForm_Load(sender, e);
				fisier.Close();
			}
		}

		private void salvarexmlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "fisier produse (*.xml)|*.xml";
			saveFileDialog.CheckPathExists = true;

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				List<Produse> lista_produse = new List<Produse>();
				foreach (DataGridViewRow gv_row in gvProduse.Rows)
				{
					Produse p = new Produse();
					p.NumeProdus = gv_row.Cells[1].Value.ToString();
					p.Categorie = gv_row.Cells[2].Value.ToString();
					p.Cantitate = (int)gv_row.Cells[3].Value;
					p.Um = gv_row.Cells[4].Value.ToString();
					p.PretUM = Convert.ToSingle(gv_row.Cells[5].Value);
					lista_produse.Add(p);
				}
				try
				{
					XmlSerializer serializator = new XmlSerializer(typeof(List<Produse>));
					Stream fisier = File.Create(saveFileDialog.FileName);
					serializator.Serialize(fisier, lista_produse);
					fisier.Close();
					MessageBox.Show("Lista de produse a fost salvata cu succes!");
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
			openFileDialog.Filter = "fisier produse (*.xml)|*.xml";
			openFileDialog.CheckFileExists = true;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					Stream fisier = File.OpenRead(openFileDialog.FileName);
					XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Produse>));
					List<Produse> lista = xmlSerializer.Deserialize(fisier) as List<Produse>;
					if (gvProduse.Rows.Count > 0)
					{
						if (MessageBox.Show("Exista deja produse in lista.", " Doriti sa le stergeti ? ", MessageBoxButtons.YesNo) == DialogResult.Yes) ;
						//this.produseTableAdapter.Delete();
					}

					foreach (Produse p in lista)
					{
						produseTableAdapter.Insert(p.NumeProdus, p.Categorie, p.Cantitate, p.Um, p.PretUM);
					}
					fisier.Close();
					ProduseForm_Load(sender, e);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
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

		private void ProduseForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			
		}

		private void gvProduse_MouseDown(object sender, MouseEventArgs e)
		{
			if (gvProduse.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = gvProduse.SelectedRows[0];
				gvProduse.DoDragDrop(selectedRow, DragDropEffects.Copy);
			}
		}

		private void btnSterge_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
			{
				e.Effect = DragDropEffects.Copy;
				btnSterge.Size = new Size(btnSterge.Width, btnSterge.Height + 50);
				btnSterge.BackColor = Color.DarkRed;

				Image imagine = global::Gestiune_Stocuri_PAW.Properties.Resources.delete_48dp_FILL0_wght400_GRAD0_opsz48;
				btnSterge.BackgroundImage = imagine;
				btnSterge.BackgroundImageLayout=ImageLayout.Zoom;
				btnSterge.Text=null;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}

		}

		private void btnSterge_DragLeave(object sender, EventArgs e)
		{
			btnSterge.Size = new Size(btnSterge.Width, btnSterge.Height -50);
			btnSterge.BackColor = Color.Crimson;

			btnSterge.BackgroundImage = null;
			btnSterge.Text = "Sterge produs";
		}

		private void btnSterge_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
			{
				stergeProdusToolStripMenuItem_Click(sender, e);
			}
		}

		private void ProduseForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				if (MessageBox.Show("Sigur doriiti sa iesiti?", "Iesire", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					this.Close();
			}
		}
	}
}
