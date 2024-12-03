namespace karacsony
{
	internal class Program
	{
		static void Main(string[] args)
		{
            /*Console.WriteLine("Hi");
            Console.WriteLine("help help help, gyerek");
			int jogyerekek = 0;
			bool siker = false;
            while (!siker)
            {
                Console.WriteLine("pls jogyerekek szama: ");
				string input=Console.ReadLine();
				try
				{
					jogyerekek=Convert.ToInt32(input);
                    if (jogyerekek<0)
                    {
                        throw new Exception("A jó gyerekek száma nem lehet negatív.");
                    }
                    siker = true;
                }
                catch (OverflowException)
                {
                    //2,147,483,647
                    Console.WriteLine("Sok");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hiba: Csak számokat adhatsz meg.");
                }
                catch (Exception ex)
				{
                    Console.WriteLine($"Hiba: {ex.Message}");
                }
            }
            Console.WriteLine($"thx miki: {jogyerekek}");*/
            negyedik();

        }
        static void elso()
        {
			Console.WriteLine("Add meg a jó gyerekek nevét: ");
			string nev = Console.ReadLine();
			Console.WriteLine($"Hány ajándékot kapjon {nev}?");
			try
			{
				int ajandek = Convert.ToInt32(Console.ReadLine());
				if (ajandek < 0)
				{
					throw new Exception("Az ajándékok száma nem lehet negatív.");
				}
				Console.WriteLine($"{nev} {ajandek} darab ajándékot kapott.");
			}
			catch (FormatException)
			{
				Console.WriteLine("Csak számot lehet megadni.");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Hiba: {ex.Message}");
			}
		}
		static void masodik()
		{
			string[] raktar = {"édesség","ruha","játék"};
			int[] mennyiseg = { 10, 15, 2 };
            for (int i = 0; i < raktar.Length; i++)
            {
                Console.WriteLine($"Nincs elég {raktar[i]} raktáron!");
				try
				{
                    Console.WriteLine("Add meg a feltöltendő mennyiséget: ");
					int beker = Convert.ToInt32(Console.ReadLine());
                    if (beker<0)
                    {
                        throw new Exception("A szám nem lehet negatív!")
                    }
					mennyiseg[i] += beker;
                    Console.WriteLine($"A {raktar[i]} új mennyisége ennyi: {mennyiseg[i]}");
                }
				catch(FormatException)
				{
                    Console.WriteLine("A bemenet hibás!");
				}
				catch (Exception ex)
				{
                    Console.WriteLine($"Hiba: {ex.Message}");
				}
            }
        }
		static void harmadik()
		{
            Console.Write("Hány gyerek kapott ajándékot: ");
			int gyerekSzam=Convert.ToInt32(Console.ReadLine());
			List<int> ertekek = new List<int>();
			bool fut = true;
            for (int i = 0; i < gyerekSzam; i++)
            {
                while (fut)
                {
                    try
                    {
                        Console.Write($"Add meg az ajándék értékét({i + 1}): ");
                        int ertek = Convert.ToInt32(Console.ReadLine());
                        if (ertek <= 0)
                        {
                            throw new Exception("Az érték nem lehet negatív!");
                        }
                        ertekek.Add(ertek);
                        Console.WriteLine("Érték hozzáadva a listához.");
                        fut = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("A bemenet csak szám lehet.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Hiba: {ex.Message}");
                    }
                }
                fut = true;
            }
        }
        static void negyedik()
        {
            List<string> gyerekNevek = new List<string>();
            List<int> ajandekSzamok = new List<int>();
            bool fut=true;
            while (fut)
            {
                try
                {
                    Console.Write("Add meg a gyerek nevét: ");
                    string bekerNev = Console.ReadLine();
                    gyerekNevek.Add(bekerNev);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nem megfelelő bemeneti formátum.");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("A megadott érték nem lehet üres.");
                }
                try
                {
                    Console.Write("Add meg az ajándékok mennyiségét: ");
                    int ajandekMenny = Convert.ToInt32(Console.ReadLine());
                    if (ajandekMenny<0)
                    {
                        throw new Exception("A szám nem lehet negatív.")
                    }
                    ajandekSzamok.Add(ajandekMenny);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nem megfelelő bemeneti formátum.");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("A megadott érték nem lehet üres.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hiba: {ex.Message}");
                }
                try
                {
                    Console.Write("Még megad(i/n): ");
                    char megad = Convert.ToChar(Console.ReadLine());
                    if (megad == 'n')
                    {
                        fut = false;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nem megfelelő bemeneti formátum.");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("A megadott érték nem lehet üres.");
                }
            }
        }
	}
}
