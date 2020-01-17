using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            var yourName = Console.ReadLine();

            Console.WriteLine($"My name is {yourName}");

            Console.WriteLine("What is your favorite color?");

            var yourColor = Console.ReadLine();

            Console.WriteLine($"My favorite color is {yourColor}!");

            Console.WriteLine("What is your favorite animal?");

            var yourAnimal = Console.ReadLine();

            Console.WriteLine($"My favorite animal is a {yourAnimal}!");

            Console.WriteLine("What is your favorite band?");

            var yourBand = Console.ReadLine();

            Console.WriteLine($"My favorite band is {yourBand}");
        }
    }
}
