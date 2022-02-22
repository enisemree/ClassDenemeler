using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Daire
    {
        //R -> Yarı çap demek
        private double Pi = 3.14;
        private double YariCap { get; set; }

        public Daire(double _yariCap)
        {
            YariCap = _yariCap;
        }

        public double AlanBul()
        {
            double alan = Pi*UsAl(YariCap,2);
            return alan;
        }

        public double CevreBul()
        {
            double cevre = 2 * Pi * YariCap;
            return cevre;
        }

        private double UsAl(double sayi, double us)
        {
            double sayininUssu = 1;
            for(int i=0;i<us;i++)
            {
                sayininUssu = sayininUssu * sayi;
            }
            return sayininUssu;
        }
    }
}
