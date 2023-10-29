using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Ellips : Geometri //Subklass som ärver från Basklassen Geometri och implementerar Area metoden.
    {
        double Pi { get; set; }
        double MajorAxis { get; set; }
        double MinorAxis { get; set; }

        public Ellips() //Constructor för att sätta fasta värden till MajorAxis och MinorAxis.
        {
            MajorAxis = 5.2; //Fasta värde i constructorn.
            MinorAxis = 7; //Fasta värde i constructorn.
            Pi = Math.PI; //Fasta värde i constructorn.
        }
        public override double Area() //Overrideat Area metoden för att beräkna arean.
        {
            return MajorAxis * MinorAxis * Pi;
        }
    }
}
