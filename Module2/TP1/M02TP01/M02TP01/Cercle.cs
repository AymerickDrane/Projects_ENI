using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02TP01
{
    public class Cercle : Forme
    {
        public int Rayon { get; set; }

        public override double Aire() =>
            double.Pi * (Rayon * Rayon);

        public override double Perimetre() =>
            double.Pi * (Rayon * 2);
    }
}
