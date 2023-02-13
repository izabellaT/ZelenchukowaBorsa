using System;
using System.Collections.Generic;
using System.Text;

namespace ZelenchukowaBorsa.View
{
    public class Display
    {
        public double N { get; set; }
        public double M { get; set; }
        public int KgZ { get; set; }
        public int KgP { get; set; }
        public double TotalPrice { get; set; }
        public Display()
        {
            N = 0;
            M = 0;
            KgZ = 0;
            KgP = 0;
            TotalPrice = 0;
            GetValues();
        }
        private void GetValues()
        {
            N = double.Parse(Console.ReadLine());
            M = double.Parse(Console.ReadLine());
            KgZ = int.Parse(Console.ReadLine());
            KgP = int.Parse(Console.ReadLine());
        }
    }
}
