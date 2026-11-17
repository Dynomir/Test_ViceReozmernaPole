namespace Kino_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rada;
            int sloupec;
            int pocetMist = 0;
            bool pokracovani = true;
            int[,] kino = new int[10, 10];
            const int cenaListku = 129;

            (int, int) ziskaniMista()
            {
                Console.Write("Zadejte číslo řady: ");
                while (int.TryParse(Console.ReadLine(), out rada) == false || rada > 10 || rada < 1)
                {
                    Console.Write("Zadejte číslo řady znova: ");
                }
                Console.Write("Zadejte číslo sloupce: ");
                while (int.TryParse(Console.ReadLine(), out sloupec) == false || sloupec > 10 || sloupec < 1)
                {
                    Console.Write("Zadejte číslo sloupce znova: ");
                }
                return (rada, sloupec);
            }

            void vypsaniMoznosti()
            {
                Console.WriteLine("Jak chcete pokračovat?");
                Console.WriteLine("1) Objednat další vstupenku");
                Console.WriteLine("2) Zrušit objednávku");
                Console.WriteLine("3) Ukončit a zaplatit");
            }


            do
            {
                ziskaniMista();

                while (kino[rada - 1, sloupec - 1] == 1)
                {
                    Console.WriteLine("Místo již bylo rezervováno! Zadejte jiné místo:");
                    ziskaniMista();
                }
                pocetMist++;
                kino[rada - 1, sloupec - 1] = 1;

                Console.WriteLine("----------- Plátno -----------");
                for (int i = 0; i < kino.GetLength(0); i++)
                {
                    for (int j = 0; j < kino.GetLength(1); j++)
                    {
                        if (kino[i, j] == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("[X]");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else
                        {
                            Console.Write("[ ]");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("------------------------------");
                Console.WriteLine();

                vypsaniMoznosti();
                int vyberMoznosti;
                while (int.TryParse(Console.ReadLine(), out vyberMoznosti) == false || vyberMoznosti > 3 || vyberMoznosti < 1)
                {
                    Console.Write("Zadejte číslo znova: ");
                }

                if (vyberMoznosti == 1)
                {
                    pokracovani = true;
                    continue;
                }
                if (vyberMoznosti == 2)
                {

                    pokracovani = false;
                    continue;
                }
                if (vyberMoznosti == 3)
                {
                    Console.WriteLine($"Celková cena je {cenaListku * pocetMist} za {pocetMist} míst.");
                    pokracovani = false;
                }
            } while (pokracovani == true);

            Console.WriteLine("Program se vypne po stisknutí ENTER");
            Console.ReadLine();
            Console.WriteLine("Program se vypíná...");
            Environment.Exit(0);
        }
    }
}
