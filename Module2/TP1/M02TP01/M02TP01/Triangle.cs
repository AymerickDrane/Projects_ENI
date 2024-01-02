using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02TP01
{
    public class Triangle : Forme
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int Base { get; set; }  
        public int Hauteur { get; set; }

        public override double Aire() =>
            (Base * Hauteur) * 2;

        public override double Perimetre() =>
            A + B + C;
    }
}
