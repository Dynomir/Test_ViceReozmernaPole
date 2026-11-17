using System.Net.WebSockets;

namespace procivcovani_na_test_vicerozmerove_pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soucetPrvku = 0;
            string[,] pole = new string[5, 5];

            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    Console.Write($"Zadejte položku ({i}:{j}): ");
                    pole[i, j] = Console.ReadLine();
                }
            }

            Console.WriteLine("------------------------------------------");

            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    Console.Write($"{pole[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("------------------------------------------");

            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {

                    if (pole[i, j] == "OAKM")
                    {
                        Console.Write("Ahoj\t");
                    }
                    else
                    {
                        Console.Write($"{pole[i, j]}\t");
                    }

                    if (String.IsNullOrWhiteSpace(pole[i, j]) == false)
                    {
                        soucetPrvku++;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Součet všech položek: {soucetPrvku}");

        }
    }
}
