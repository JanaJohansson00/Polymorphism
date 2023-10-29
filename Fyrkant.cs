using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Fyrkant : Geometri //Subklass som ärver från Basklassen Geometri och implementerar Area metoden.
    {
        int Side { get; set; }

        public Fyrkant() //Constructor för att sätta fasta värden till sidlängden.
        {
            Side = 5; //Fasta värden i constructorn.
        }
        public override double Area() //Overrideat Area metoden för att beräkna arean.
        {
            return Side * Side; //Olika implementeringar i varje figur då det räknas ut olika beroende på figur.
        }
    }
}
