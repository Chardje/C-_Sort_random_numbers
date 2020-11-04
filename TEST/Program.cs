using System;

namespace TEST
{
    class Program
    {
        static void Main()
        {
            try
            {
                Random R = new Random();
                const int L = 100;
                int[] X = new int[L];
                int n = 0, c = 0;
                int[,] Chot = new int[2, 100];
                int[,] Nechot = new int[2, 100];
                for (int i = 0; i < L; i++)
                {
                    X[i] = Convert.ToInt32(R.Next(0, 100));
                    if (X[i] % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($" {i + 1}: {X[i]} Chot ");

                        Chot[0, c] = i + 1;
                        Chot[1, c] = X[i];
                        c++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($" {i + 1}: {X[i]} Nechot ");
                        Nechot[0, n] = i + 1;
                        Nechot[1, n] = X[i];
                        n++;
                    }
                    if (i % 10 == 9)
                    {
                        Console.WriteLine();
                    }
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(c);

                for (int i = 0; i < c; i++)
                {

                    Console.Write($" {Chot[0, i]}: {Chot[1, i]} Chot ");
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(n);
                for (int i = 0; i < n; i++)
                {

                    Console.Write($" {Nechot[0, i]}: {Nechot[1, i]} Nechot ");
                }
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Black;
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR");
                Main();
            }
        }
    }
}
