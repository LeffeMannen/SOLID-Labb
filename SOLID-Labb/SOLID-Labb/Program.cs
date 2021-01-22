using System;

namespace SOLID_Labb
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = ColorAnimal();

            Console.WriteLine("---------------");
            Console.WriteLine();

            foreach (var animal in animals)
            {
                TextAnimal(animal);
            }

            Console.WriteLine("---------------");
            Console.WriteLine();

        }

        static Animal[] ColorAnimal()
        {
            Animal[] animals = {new Dog("Black"),
                            new Hedgehog("Pink"),
                            new Bird("Yellow")};

            return animals;
        }

        static void TextAnimal(Animal animal)
        {
            if (animal is Dog dog)
            {
                dog.TransferOwnership("Niklas");
            }

            animal.Eat();
            animal.Sleep();
            animal.Speak();
            animal._color = "Grey";
            Console.WriteLine(animal.GetType().Name + " is " + animal._color);
            Console.WriteLine();

        }
    }


}