using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Rektangel : Geometri //Subklass som ärver från Basklassen Geometri och implementerar Area metoden.
    {
        int BaseLenght { get; set; }
        int Height { get; set; }

        public Rektangel() //Constructor för att sätta fasta värden till BaseLengt och Height.
        {
            BaseLenght = 7; //Fasta värden i constructorn.
            Height = 8; //Fasta värden i constructorn.
        }
        public override double Area() //Overrideat Area metoden för att beräkna arean.
        {
            return BaseLenght * Height;
        }
    }

}
