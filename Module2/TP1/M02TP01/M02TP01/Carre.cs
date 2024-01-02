using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02TP01
{
    public class Carre : Quadrilatere
    {
        public Carre()
        {
            Largeur = Longueur;
        }

        public override double Aire() =>
        Longueur * Largeur;
        public override double Perimetre() =>
            (Largeur * 2) + (Longueur * 2);

    }
}
