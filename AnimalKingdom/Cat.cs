using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Cat : Animal, IMammal
    {
     public int NumberOfNipples { get; } // gets property

        // ------------------------------------------------------------------ //

        /// <summary>
        /// Defines a cat, initializes with 6 nipples
        /// Inherits from Animal and implements IMammal
        /// </summary>
        public Cat()
        {

            NumberOfNipples = 6; // set number of nipples to 6

        }

        /// <summary>
        /// Overrides sound adding base + miau
        /// </summary>
        /// <returns></returns>
        public override string Sound() // overrides sound
        {
            return $"{base.Sound()} Miau";
        }
    }   
    
}