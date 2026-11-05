using System.Web;

namespace Test_ViceReozmernaPole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] pole = new string[4 , 4];
            int soucetJmen = 0;
            int cislo;

            Console.WriteLine("----- Program pro práci s dvourozměrným polem -----");
            Console.WriteLine("Zadejte 16 jmen pro naplnění pole 4x4, pokud na místě nikdo nesedí, napište \"X\":");
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    Console.Write($"Zadejte prvek [{i},{j}] (jméno): ");

                    Console.ForegroundColor = ConsoleColor.Green;
                    pole[i, j] = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Gray;

                    while (string.IsNullOrEmpty(pole[i, j]) || int.TryParse(pole[i,j], out cislo) == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Chyba! Musíte zadat platné jméno. ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Zkuste to znovu.\r\n");
                        Console.Write($"Zadejte prvek [{i},{j}] (jméno): ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        pole[i, j] = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    
                    if (pole[i, j] == "X" || pole[i, j] == "x")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Na daném místě nikdo sedět nebude.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else if (string.IsNullOrEmpty(pole[i, j]) == false)
                    {
                        soucetJmen++;
                    }
                }
            }

            Console.WriteLine("-----------------------------------");

            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    if (pole[i, j] == "X" || pole[i, j] == "x")
                    {
                        Console.Write(" \t");
                    }
                    else
                    {
                        Console.Write($"{pole[i, j]}\t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Součet všech jmen pole je: {soucetJmen}");
        }
    }
}
