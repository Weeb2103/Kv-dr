using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vypocty
{
    internal class Kvádr
    {
        public double StranaA { get; set; }
        public double StranaB { get; set; }
        public double StranaC { get; set; }
        public Kvádr(double a, double b, double c)
        { 
          this.StranaA = a;
          this.StranaB = b;
          this.StranaC = c;
        }
        public double VypocetObjemu()
        {
            return StranaA *StranaB *StranaC;
        }
        public double VypocetPovrchu()
        {
            return 2 * (StranaA*StranaB+StranaC*StranaA+StranaB*StranaC);  
        }
        public double VypocetTelesUhlo()
        {
            return Math.Sqrt( Math.Pow(StranaA, 2) + Math.Pow(StranaB, 2) + Math.Pow(StranaC, 2));
        }
        public double VypocetStenUhlo()
        {
            return Math.Sqrt( Math.Pow(StranaA, 2) + Math.Pow(StranaB, 2));
        }
    }
}
