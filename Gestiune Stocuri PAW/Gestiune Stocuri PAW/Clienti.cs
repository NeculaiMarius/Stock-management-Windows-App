using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Gestiune_Stocuri_PAW
{
	[Serializable]
	public class Clienti
	{
		private string nume;
		private string prenume;
		private string telefon;
		private string adresa;

		public Clienti()
		{
			nume = "Fara nume";
			prenume = "Fara prenume";
			telefon = "Nespecificat";
			adresa = "Nespecificata";
		}

		public string Nume
		{
			get { return nume; }
			set { nume = value; }
		}

		public string Prenume
		{ 
			get { return prenume; } 
			set { prenume = value; } 
		}

		public string Telefon
		{
			get { return telefon; }
			set { telefon = value; }
		}

		public string Adresa
		{
			get { return adresa; }
			set { adresa = value; }
		}


	

	}
}
