using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestiune_Stocuri_PAW
{
	public class NumarCuvinte
	{
		private static readonly string[] Units = { "", "unu", "doi", "trei", "patru", "cinci", "șase", "șapte", "opt", "nouă" };
		private static readonly string[] Tens = { "", "zece", "douăzeci", "treizeci", "patruzeci", "cincizeci", "șaizeci", "șaptezeci", "optzeci", "nouăzeci" };
		private static readonly string[] Teens = { "zece", "unsprezece", "doisprezece", "treisprezece", "paisprezece", "cinsprezece", "șaisprezece", "șaptesprezece", "optsprezece", "nouăsprezece" };
		private static readonly string[] Hundreds = { "", "sută", "două sute", "trei sute", "patru sute", "cinci sute", "șase sute", "șapte sute", "opt sute", "nouă sute" };

		public static string ConvertNumberToWords(float number)
		{
			int lei = (int)number;
			int bani = (int)((number - lei) * 100);

			string leiInWords = ConvertIntToWords(lei) + " lei";
			string baniInWords = ConvertIntToWords(bani) + " bani";

			return leiInWords + " și " + baniInWords;
		}

		private static string ConvertIntToWords(int number)
		{
			if (number == 0)
			{
				return "zero";
			}

			if (number < 10)
			{
				return Units[number];
			}

			if (number < 20)
			{
				return Teens[number - 10];
			}

			if (number < 100)
			{
				return Tens[number / 10] + (number % 10 > 0 ? " și " + Units[number % 10] : "");
			}

			if (number < 1000)
			{
				return Hundreds[number / 100] + (number % 100 > 0 ? " " + ConvertIntToWords(number % 100) : "");
			}

			if (number < 1000000)
			{
				return ConvertIntToWords(number / 1000) + " mii" + (number % 1000 > 0 ? " " + ConvertIntToWords(number % 1000) : "");
			}

			if (number < 1000000000)
			{
				return ConvertIntToWords(number / 1000000) + " milioane" + (number % 1000000 > 0 ? " " + ConvertIntToWords(number % 1000000) : "");
			}

			return number.ToString();
		}
	}
}
