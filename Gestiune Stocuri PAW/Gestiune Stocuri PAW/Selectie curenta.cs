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
	public partial class Selectie_curenta : UserControl
	{
		public Selectie_curenta()
		{
			InitializeComponent();
		}

		public void modificaSelectie(string selectie)
		{
			tbSelectie.Text = selectie;
		}
	}
}
