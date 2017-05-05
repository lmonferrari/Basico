using System;

namespace Exercicios_Secao5
{
    class Program
    {
        static void Main(string[] args)
        {

            // exercicio numero 1
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(string.Format("The number {0} is divisible by 3", i));
                }
            }

            //exercicio numero 2
            var result = 0;
            while (true)
            {
                Console.WriteLine("Write a number or ok to exit: ");
                var input = Console.ReadLine();

                if (input.ToUpper() == "OK")
                {
                    break;
                }
                result += Convert.ToInt32(input);
            }
            Console.WriteLine("The sum of input is : " + result);


            //exercicio numero 3
            Console.WriteLine("Tell me a number: ");
            var number = Convert.ToInt32(Console.ReadLine());
            var factorial = 1;
            for (int i = number; i > 1; i--)
            {
                factorial *= i;
            }
            Console.WriteLine("The result of this factorial is : " + factorial);


            //exericico numero 4
            var random = new Random().Next(1, 10);

            for (int i = 4; i > 0; i--)
            {
                Console.WriteLine("Guess a number: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == random)
                {
                    Console.WriteLine("Awesome! You won the game.");
                    break;
                }
                else if (i > 1)
                {
                    Console.WriteLine(string.Format("Try again! you have {0} attempts", i - 1));
                }

                if (i == 1 && guess != random)
                {
                    Console.WriteLine("You lose the game!");
                }
            }


            //exercicio numero 5
            var numbers = Console.ReadLine();
            var maximum = 0;
            foreach (var n in numbers)
            {
                if (!n.Equals(",") && (int)(n) > maximum)
                {
                    maximum = n;
                }
            }
            Console.WriteLine((char)maximum);
        }
    }
}
