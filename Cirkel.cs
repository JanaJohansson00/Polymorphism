using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Cirkel : Geometri //Subklass som ärver från Basklassen Geometri och implementerar Area metoden.
    {
        double Radius { get; set; }
        double Pi { get; set; }

        public Cirkel() //Constructor för att sätta fasta värden till radie och pi.
        {
            Radius = 4; //Fasta värden i constructorn.
            Pi = Math.PI; //Fasta värden i constructorn.
        }
        public override double Area() //Overrideat Area metoden för att beräkna arean.
        {
            return Radius * Radius * Pi;
        }
    }
}
