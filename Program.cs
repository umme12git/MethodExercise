using System;

namespace MethodExercise
{
    class Program
    {
        public static int addition(params int[] numbers)
        {
            int result = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            return result;

        }

        public static int subtraction(params int[] numbers)
        {
            int result = numbers[0];

            for(int i = 1; i < numbers.Length; i++) 
            {
                result  -= numbers[i];
            }
            return result;
        }

        public static int multiplication(params int[] numbers)
        {
            int result = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                result *= numbers[i];
            }
            return result;
        }

        public static int division(params int[] numbers)
        {
            int result = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                result /= numbers[i];
            }
            return result;
        }

        public static int modulus(params int[] numbers)
        {
            int result = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                result %= numbers[i];
            }
            return result;
        }
        public static string getname(string name)
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            return name;
        }

        public static string getcolor(string color)
        {
            Console.WriteLine("What is your favorite color?");
            color = Console.ReadLine();
            return color;
            
        }

        public static string getanimal(string animal)
        {
            Console.WriteLine("What is your favorite animal?");
            animal = Console.ReadLine();
            return animal;
        }

        public static string getband(string band)
        {
            Console.WriteLine("What is your favorite band?");
            band = Console.ReadLine();
            return band;
        }


        static void Main(string[] args)
        {

            string name = new string("");
            string color = new string("");
            string animal = new string("");
            string band = new string("");
            int num;

                
            name =   getname(name);
            color =  getcolor(color);
            animal = getanimal (animal);
            band =   getband (band);

            //string interpolation
            Console.WriteLine($"Your info -- your name is {name}, your favorite color is {color}, " +
                              $"your favorite animal is {animal}, your favorite band is {band} ");


            //Calling methods for calculations
            num = addition(1, 2, 6);
            Console.WriteLine($"The result of addition is {num}");
            num = addition(49, 20, 50, 100);
            Console.WriteLine($"Second call - The result of addition is {num}");
            num = subtraction(100, 38,7);
            Console.WriteLine($"The result of subtraction is {num}");
            num = multiplication(4, 6, 8);
            Console.WriteLine($"The result of multiplication is {num}");
            num = division(200, 2, 50);
            Console.WriteLine($"The result of division is {num}");
            num = modulus(35,4,2);
            Console.WriteLine($"The remainder of the divisin is {num}");





        }
    }
}
