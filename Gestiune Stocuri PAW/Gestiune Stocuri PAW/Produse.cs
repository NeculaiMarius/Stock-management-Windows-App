using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT___EXERSAT_TEST
{
	[Serializable]
	public class Produse
	{
		private string numeProdus;
		private int cantitate;
		private string um;
		private string categorie;
		private float pretUM;

		public string NumeProdus
		{
			get { return numeProdus; }
			set { numeProdus = value; }
		}

		public int Cantitate
		{
			get { return cantitate; }
			set { cantitate = value; }
		}

		public string Um
		{
			get { return um; }
			set { um = value; }
		}

		public string Categorie
		{
			get { return categorie; }
			set { categorie = value; }
		}

		public float PretUM
		{
			get { return pretUM; }
			set { pretUM = value; }
		}


		public Produse(string numeMaterial, int cantitate, string um, string categorie, float pretUM)
		{
			numeProdus = numeMaterial;
			Cantitate = cantitate;
			Um = um;
			Categorie = categorie;
			PretUM = pretUM;
		}

		public Produse()
		{
			numeProdus = "Fara nume";
			Cantitate = 0;
			Um = "Nespecificat";
			Categorie = "Nespecificat";
			PretUM = 0;
		}

		public float calculeazaValoare()
		{
			return cantitate * pretUM;
		}


	}
}
