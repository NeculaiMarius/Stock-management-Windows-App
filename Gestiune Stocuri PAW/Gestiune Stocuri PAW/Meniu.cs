using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestiune_Stocuri_PAW
{
	public partial class Meniu : Form
	{
		public Meniu()
		{
			InitializeComponent();
		}

		private void Meniu_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void btnProduse_Click(object sender, EventArgs e)
		{
			ProduseForm produse = new ProduseForm();
			this.Hide();
			if (produse.ShowDialog() == DialogResult.Cancel)
			{
				this.Show();
			}
			
		}

		private void btnClienti_Click(object sender, EventArgs e)
		{
			ClientiForm clienti = new ClientiForm();
			this.Hide();
			if (clienti.ShowDialog() == DialogResult.Cancel)
			{
				this.Show();
			}
		}

		private void btnComenzi_Click(object sender, EventArgs e)
		{
			this.Hide();
			ComenziForm formular = new ComenziForm();
			if (formular.ShowDialog() == DialogResult.Cancel)
			{
				this.Show();
			}
		}

		private void imagine3_Click(object sender, EventArgs e)
		{
			btnComenzi_Click(sender, e);
		}

		private void imagine1_MouseEnter(object sender, EventArgs e)
		{
			imagine1.BackColor=Color.SlateBlue;
		}

		private void imagine1_MouseLeave(object sender, EventArgs e)
		{
			imagine1.BackColor=Color.MediumSlateBlue;
		}

		private void imagine2_MouseEnter(object sender, EventArgs e)
		{
			imagine2.BackColor=Color.SlateBlue;
		}

		private void imagine2_MouseLeave(object sender, EventArgs e)
		{
			imagine2.BackColor = Color.MediumSlateBlue;
		}

		private void imagine3_MouseEnter(object sender, EventArgs e)
		{
			imagine3.BackColor=Color.SlateBlue;
		}

		private void imagine3_MouseLeave(object sender, EventArgs e)
		{
			imagine3.BackColor = Color.MediumSlateBlue;
		}

		private void Meniu_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				if (MessageBox.Show("Sigur doriiti sa inchideti aplicatia?", "Iesire", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					Application.Exit();
			}
		}
	}
}
