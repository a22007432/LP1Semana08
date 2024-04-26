using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Bat : Animal, IMammal, ICanFly 
    {  
        public int NumberOfNipples { get; }  

        public int NumberOfWings { get; }

        public Bat()
        {
            NumberOfNipples = 2; 
            NumberOfWings = 2;
        }

        public override string Sound()
        {
            return $"{base.Sound()} Screech";
        }

    }
}