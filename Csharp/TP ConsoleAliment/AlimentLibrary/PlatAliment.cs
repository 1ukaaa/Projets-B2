using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentLibrary
{
    public class PlatAliment
    {
        public Aliment Aliment { get; set; }
        public double Poids { get; set; }

        public PlatAliment(Aliment aliment, double poids)
        {
            Aliment = aliment;
            Poids = poids;
        }
    }
}
