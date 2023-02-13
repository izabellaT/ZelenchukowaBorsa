using System;
using System.Collections.Generic;
using System.Text;

namespace ZelenchukowaBorsa.Model
{
    public class Borsa
    {
        private double n;
        private double m;
        private int kgZ;
        private int kgP;
        public double N
        {
            get { return this.n; }
            set 
            {
                if (n < 0.00 || n > 1000.00)
                {
                    Console.WriteLine("invalid price");
                }
                else
                {
                    this.n = value;
                }        
            }
        }
        public double M
        {
            get { return this.m; }
            set
            {
                if (n < 0.00 || n > 1000.00)
                {
                    Console.WriteLine("invalid price");
                }
                else
                {
                    this.m = value;
                }
            }
        }
        public int KgZ
        {
            get { return this.kgZ; }
            set
            {
                if (n < 0.00 || n > 1000.00)
                {
                    Console.WriteLine("invalid killograms");
                }
                else
                {
                    this.kgZ = value;
                }
            }
        }
        public int KgP
        {
            get { return this.kgP; }
            set
            {
                if (n < 0.00 || n > 1000.00)
                {
                    Console.WriteLine("invalid killograms");
                }
                else
                {
                    this.kgP = value;
                }
            }
        }
        public Borsa(double n, double m, int kgZ, int kgP)
        {
            N = n;
            M = m;
            KgZ = kgZ;
            KgP = kgP;
        }
        public double Callculator()
        {
            double totalPrice = 0;
            totalPrice = this.N * 1.94 * this.kgZ + this.M * 1.94 * this.kgP;
            return totalPrice;
        }
    }
}
