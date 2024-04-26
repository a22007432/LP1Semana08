using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Dog : Animal, IMammal
    {
        // Number of nipples this animal
        // Gets & sets with constructor
        public int NumberOfNipples { get; }          // gets property

        // ------------------------------------------------------------------ //

        /// <summary>
        /// Initializes a new instance of the Dog class.
        /// Inherits from Animal and implements IMammal
        /// </summary>
        public Dog()
        {   
            // initializes dog with 8 nipples
            NumberOfNipples = 8;
        }

        /// <summary>
        /// Overrides the Sound method from Animal with a Dog sound.
        /// </summary>
        /// <returns>
        /// Base string + "Woof!" in string format.
        /// </returns>
        public override string Sound()
        {
            return $"{base.Sound()} Woof!";
        }
    }
}