using System;
using System.Collections.Generic;
using System.Security.Policy;

public class opdracht2
{
	public opdracht2()
	{
		static void Main(string[] args)
        {
			IDictionary<int, string> items = new Dictionary<int, string>();
			items.Add(brood, "1.00");
			items.Add(kaas, "1.50");
			items.Add(Melk, "1.00");
			items.Add(banaan, "2.50");
			items.Add(pringles, "1.50");
			items.Add(Milka, "1.50");
			items.Add(wijn, "12.00");
			items.Add(tomaten, "2.00");
			items.Add(ham, "1.50");
			items.Add(bier, "6.00");

			foreach (KeyValuePair<int, string> kvp in items)
				Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value)




        }
	}
}
