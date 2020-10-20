using System;

namespace Boodschappen
{
	public class Item
	{
		const float Btw = 0.21f;
		public string naam;
		public float prijs = 2.00f;

		public Item (string nNaam, float nPrijs, float nBtw)
        {
			naam = nNaam;
			prijs = nPrijs;
			Btw = nBtw;
        }

		public float BTW(int aantal, float prijs, float btw)
		{
			return aantal * prijs + ((aantal * prijs) * Btw);
		}

	}
}
