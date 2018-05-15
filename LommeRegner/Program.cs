using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LommeRegner
{
    class Program
    {
        static int GetIntFromUser(string spørgsmål)
        {
            Console.Write(spørgsmål);
            string input;
            int resultat;
            input = Console.ReadLine();

            while (!int.TryParse(input, out resultat))
            {
                Console.Write("Whatever you wrote, cannot be accpeted, try again: ");
                input = Console.ReadLine();
            }
            return resultat;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Black;

            int slut = 0;
            do
            {
                int tal = 0;
                int RegneTal1 = 0;
                int RegneTal2 = 0;
                int GangeTal1 = 0;
                int GangeTal2 = 0;
                int ResultatTal1 = 0;
                int ResultatTal2 = 0;
                int Resultat = 0;
                int[] array1 = new int[2];
                
                do
                {
                    array1[tal] = GetIntFromUser("Write a number: ");
                    tal++;

                } while (tal != array1.Length);
                Console.WriteLine();
                for (int i = 2; i <= array1[0]; i++)
                {
                    if (array1[0] % i == 0)
                    {
                        RegneTal1 = array1[0] / i;
                        GangeTal1 = i;
                        Console.WriteLine(RegneTal1 + " x " + GangeTal1);
                        break;
                    }
                }
                for (int z = 2; z <= array1[1]; z++)
                {
                    if (array1[1] % z == 0)
                    {
                        RegneTal2 = array1[1] / z;
                        GangeTal2 = z;
                        Console.WriteLine(RegneTal2 + " x " + GangeTal2);
                        break;
                    }
                }
                Console.ReadKey();
                ResultatTal1 = RegneTal1 * RegneTal2;
                Console.WriteLine();
                Console.WriteLine("Then we take the first number in both");
                Console.WriteLine(RegneTal1 + " x " + RegneTal2 + " = " + ResultatTal1);

                ResultatTal2 = GangeTal1 * GangeTal2;
                Console.WriteLine();
                Console.WriteLine("Then we take the second number in both");
                Console.WriteLine(GangeTal1 + " x " + GangeTal2 + " = " + ResultatTal2);

                Resultat = ResultatTal1 + ResultatTal2;
                Console.WriteLine();
                Console.WriteLine("Now we put the 2 results together");
                Console.WriteLine(ResultatTal1 + " + " + ResultatTal2 + " = " + Resultat);

                Console.WriteLine();
                Console.WriteLine(Resultat);
                Console.WriteLine();

                Console.WriteLine("Write 1 to try again, write any other number to exit");
                int JaNej = GetIntFromUser("Write your number: ");
                Console.WriteLine();
                switch (JaNej)
                {
                    case 1:
                        slut = 0;
                        break;

                    default:
                        slut = 1;
                        break;
                }
                Console.Clear();
            } while (slut == 0);

        }
    }
}
