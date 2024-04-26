using System;

namespace AnimalKingdom
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals    = new Animal[10];

            Random rand         = new Random();


            for (int i = 0; i < animals.Length; i++)
            {
                switch (rand.Next(4))
                {
                    case 0:
                    {
                        animals[i] = new Bee();
                        break;
                    }

                    case 1:
                    {
                        animals[i] = new Bat(); 
                        break;
                    }

                    case 2:
                    {
                        animals[i] = new Cat(); 
                        break;
                    }

                    case 3:
                    {
                        animals[i] = new Dog();
                        break;
                    }

                    default: {break;}
                }
            }


            foreach (Animal a in animals){


                Console.Write($"{a.GetType().Name} {a.Sound()}");

                if (a is IMammal)
                {
                    Console.Write($", Nº Nipples: {(a as IMammal).NumberOfNipples}");

                }

                if (a is ICanFly)
                {
                    Console.Write($", Nº Wings: {(a as ICanFly).NumberOfWings}");
                }

                Console.WriteLine();
            }
        }
    }
}
