using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    public class Kolmnurk
    {
        int a {  get; set; }
        int b { get; set; }
        int c { get; set; }

        public Kolmnurk(int a, int b, int c) 
        {
            this.a = a; this.b = b; this.c = c;
        }

        public int Perimeeter() { return this.a + this.b + this.c; }
        public double Pindala()
        {
            return Math.Round(Math.Sqrt((Perimeeter() / 2) * (Perimeeter() - this.a) * (Perimeeter() - this.b) * (Perimeeter() - this.c)), 2);
        }
        public void Naitamine()
        {
            Console.WriteLine($"a - {this.a}, b - {this.b}, c - {this.c} ; P - {Perimeeter()} ; S - {Pindala()}");
        }
    }
}
