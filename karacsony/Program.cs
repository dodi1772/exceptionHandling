namespace karacsony
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Hi");
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
                catch (FormatException)
                {
                    Console.WriteLine("Hiba: Csak számokat adhatsz meg.");
                }
                catch (Exception ex)
				{
                    Console.WriteLine($"Hiba: {ex.Message}");
                }
            }
            Console.WriteLine($"thx miki: {jogyerekek}");
        }
	}
}
