using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Parallellogram : Geometri //Subklass som ärver från Basklassen Geometri och implementerar Area metoden.
    {
        int ParallellogramBase { get; set; }
        int ParallellogramLength { get; set; }

        public Parallellogram() //Constructor för att sätta fasta värden till ParallellogramBase och ParallellogramLength.
        {
            ParallellogramBase = 9; //Fasta värden i constructorn.
            ParallellogramLength = 10; //Fasta värden i constructorn.
        }
        public override double Area() //Overrideat Area metoden för att beräkna arean.
        {
            return ParallellogramBase * ParallellogramLength;
        }
    }
}
