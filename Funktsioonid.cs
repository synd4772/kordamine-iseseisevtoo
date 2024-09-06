using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    public class Funktsioonid
    {
        static public void SquareArray ()
        {
            int[,] intArray = new int[10, 10];
            int sum = 0;
            int proizv = 1;
            Random rand = new Random();
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    intArray[i, j] = rand.Next(1, 20);
                    sum += intArray[i, j];
                    proizv = proizv * intArray[i, j];
                }
            }

            Console.WriteLine($"sum - {sum}, teos - {proizv}");
        }

        static public void KolmnurkUlesanne()
        {
            Random rand = new Random();
            int[] suurP = new int[2] {-1 , 0};
            double[] suurS = new double[2] {-1 , 0};
            List<Kolmnurk> kolmNurkList = new List<Kolmnurk>()
            {
                new Kolmnurk(rand.Next(1,20), rand.Next(1,20), rand.Next(1,20)),
                new Kolmnurk(rand.Next(1,20), rand.Next(1,20), rand.Next(1,20)),
                new Kolmnurk(rand.Next(1,20), rand.Next(1,20), rand.Next(1,20))
            };
            for (int i = 0; i < kolmNurkList.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                kolmNurkList[i].Naitamine();
                if (kolmNurkList[i].Perimeeter() > suurP[1])
                {
                    suurP[0] = i;
                    suurP[1] = kolmNurkList[i].Perimeeter();
                }
                if (kolmNurkList[i].Pindala() > suurS[1])
                {
                    suurS[0] = i;
                    suurS[1] = kolmNurkList[i].Pindala();
                }
            }
            Console.WriteLine($"{suurP[0] + 1} kolmnurk on kõige suurema perimeetriga ({suurP[1]}), {suurS[0] + 1} kolmnurk on suurima pindalaga ({suurS[1]})\n");
        }
        static public void Perekonnanimed()
        {
            
            Random rand = new Random();
            int length = rand.Next(3,6);
            string vastus;
            List<string> perekonnanimedArray = new List<string>();
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Sisesta perekonnanimi");
                vastus = Console.ReadLine();
                perekonnanimedArray.Add(vastus);
            }
            perekonnanimedArray.Sort();
            Console.WriteLine("");
            foreach (string perekonn in perekonnanimedArray)
            {
                Console.WriteLine(perekonn);
            }

        }
    }
}
    