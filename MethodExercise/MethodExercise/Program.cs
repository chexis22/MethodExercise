using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(4, 6));

            Console.WriteLine(Multiply(10, 100));

            Console.WriteLine(Multiply(100, 100) + " " + Add(20, 5));

            Console.WriteLine("What is your gender?");

            var answer = Console.ReadLine();
            Girl(answer);

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

        public static int Add(int x, int y)
        {
            var answer = x + y;
            return answer;
        }

        public static int Multiply(int x, int y)
        {
            var answer = x * y;
            return answer;
        }

        public static bool Girl(string gender)
        {
            bool response;
            if (gender != "female")
            {
                response = false;
            }
            else
            {
                response = true;
            }
            Console.WriteLine(response);
            return response;
        }
       
    }
}
