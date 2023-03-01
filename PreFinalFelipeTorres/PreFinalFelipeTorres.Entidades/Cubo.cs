using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreFinalFelipeTorres.Entidades
{
    public class Cubo
    {
        public int Arista { get; set; }

        public Color Color { get; set; }

        public Trazo Trazo { get; set; }

        public Cubo()
        {

        }

        public double GetArea() => 6 * Math.Pow(Arista, 2);
        public double GetVolumen() => Math.Pow(Arista, 3);

    }
}
