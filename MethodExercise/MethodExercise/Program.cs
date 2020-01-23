using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Add(1, 2, true);
            Console.WriteLine("True or False?");
            

            Console.WriteLine(Add(10, 4));

            Console.WriteLine(Addition(4, 6));

            Console.WriteLine(Multiply(10, 100));

            Console.WriteLine(Multiply(100, 100) + " " + Addition(20, 5));

            Console.WriteLine(MultTwo(25, 4));

            AddTwo(2, 5);

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

        public static int Addition(int x, int y)
        {
            var answer = x + y;
            return answer;
        }

        public static int Multiply(int x, int y)
        {
            var answer = x * y;
            return answer;
        }

        public static int MultTwo(int First, int Second)
        {
            return First * Second;

        }

        public static void AddTwo(int one, int two)
        {
            Console.WriteLine(one + two);
        }

        public static int Add(int one, int two)
        {
            return one + two;

        }

        public static double Add(double one, double two)
        {
            return one + two;
        }

        public static string Add(int one, int two, bool isTrue)
        {
            var sum = one + two;

            isTrue = true;
            
            if (isTrue == true)
            {
                Console.WriteLine(sum + " dollars");
                return sum + " dollars";  
            }

            else if (isTrue = true && sum < 2)
            {
                return sum + " dollar";
            }

            else
            {
                return " it was false";
            }

          
        }
    }
}
