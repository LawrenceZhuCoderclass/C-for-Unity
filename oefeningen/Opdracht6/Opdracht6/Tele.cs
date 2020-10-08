using System;
using System.Security.Cryptography.X509Certificates;

namespace Te
{
	public class Tele
	{
		const float Btw = 0.21f;
		public float prijs = 3.95f;
		public string Type;
		public string Model;
		public string OS;
		public string CEO;
		
	
		public Tele (string nType, string nModel, string nOS, string nCEO, float nPrijs)
        {
			Type = nType;
			Model = nModel;
			OS = nOS;
			CEO = nCEO;
			prijs = nPrijs;
        }
		public float BTW(int aantal )
        {
			return aantal * prijs + ((aantal * prijs) * Btw);
        }
	}

}

