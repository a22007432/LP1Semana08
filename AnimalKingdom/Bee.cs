using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Bee : Animal, ICanFly
    {
        public int NumberOfWings { get; }
        public Bee()
        {
            NumberOfWings = 2;
        }

        // overides sound
        public override string Sound()
        {
            return $"{base.Sound()} Bzzz";
        }
    }
}