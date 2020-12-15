﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(12, 7);
            f1.Afficher();

            Fraction f2 = new Fraction(46);
            f2.Afficher();

            Fraction f3 = new Fraction();
            f3.Afficher();

            Fraction f4 = new Fraction(12,7);
            f4.Oppose();

            Fraction f5 = new Fraction(12, 7);
            f5.Inverse();

            bool result=f1.SuperieurA(f2);
            Console.WriteLine(result);

            Fraction f0 = new Fraction(24, 14);
            f0.Afficher();
            bool result2 = f1.EgalA(f0);
            Console.WriteLine(result2);


            Console.ReadKey();
        }
    }

    public class Fraction
    {
        private int num;
        private int deno;

        public int UNnum { get => num; set => num = value; }
        public int UNdeno { get => deno; set => deno = value; }

        public Fraction()
        {
            this.num = 0;
            this.deno = 1;
        }
        public Fraction(int UNnum)
        {
            this.num = UNnum;
            this.deno = 1;
        }
        public Fraction(int UNnum, int UNdeno)
        {
            this.num = UNnum;
            this.deno = UNdeno;
        }

        public void Afficher()
        {
            double lol = this.num / this.deno;
            Console.WriteLine(this.num + " sur " + this.deno + " est egal a "+lol);
        }

        public void Oppose()
        {
            string lol = "-" + this.num;
            int lo=int.Parse(lol);
            double l = lo / this.deno;
            Console.WriteLine(lol + " sur " + this.deno + " est egal a " + l);
        }

        public void Inverse()
        {
            double lol =  this.deno / this.num ;
            Console.WriteLine(this.deno + " sur " + this.num + " est egal a " + lol);
        }

        public bool SuperieurA(Fraction fract)
        {
            double un = this.num / this.deno;
            double deux=fract.num / fract.deno;

            if (un<deux)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool EgalA(Fraction fract)
        {
            double un = this.num / this.deno;
            double deux = fract.num / fract.deno;

            if (un == deux)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}