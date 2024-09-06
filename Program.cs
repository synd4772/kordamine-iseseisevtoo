using System;
using System.Formats.Asn1;

namespace Kordamine
{
    internal class Program
    {
        static public void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("(VARIANT 9) Vali \n1 - Leia 10x10 suuruse ruutmaatriksi elementide summa ja teos.\n2 - Ülesandeks on kolm kolmnurka oma külgedega (a, b, c). Leida suurima perimeetri või suurima pindalaga kolmnurk. Kas see on alati sama kolmnurk?\n3 - Sorteeri sisestatud perekonnanimede nimekiri tähestiku järgi ja too see ekraanile\n");
                try
                {
                    int vastus = int.Parse(Console.ReadLine());
                    if (vastus == 1)
                    {
                        Funktsioonid.SquareArray();
                    }
                    else if (vastus == 2)
                    {
                        Funktsioonid.KolmnurkUlesanne();
                    }
                    else if (vastus == 3)
                    {
                        Funktsioonid.Perekonnanimed();
                    }
                    else if (vastus == 4)
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());

                }
                
            }
        }
    }
}