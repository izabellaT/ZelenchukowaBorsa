using System;
using System.Collections.Generic;
using System.Text;
using ZelenchukowaBorsa.Model;
using ZelenchukowaBorsa.View;

namespace ZelenchukowaBorsa.Controllers
{
    public class BorsaController
    {
        private Borsa borsa;
        private Display display;
        public BorsaController()
        {
            display = new Display();
            borsa = new Borsa(display.N, display.M, display.KgZ, display.KgP);
            display.TotalPrice = borsa.Callculator();
        }
    }
}
