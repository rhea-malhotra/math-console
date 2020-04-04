using System;
using System.Collections.Generic;

namespace Myfirstproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose:");
            Console.WriteLine("Prime Number: 1");
            Console.WriteLine("Find Factors: 2");
            Console.WriteLine("Positive Number: 3");
            Console.WriteLine("Multiples : 4 ");
            Console.WriteLine("Is a number a factor of another : 5 ");
            Console.WriteLine("Factorials: 6");
            Console.WriteLine("");
            Console.Write("Enter Choice: ");
            //comment test

            String choice = Console.ReadLine();
            try
            {
                if (choice == "1")
                {
                    primeNumber();
                }
                else if (choice == "2")
                {
                    findFactors();
                }
                else if (choice == "3")
                {
                    positiveNumber();
                }
                else if (choice == "4")
                {
                    multiples();
                }
                else if (choice == "5")
                {
                    factorOfAnother();
                }
                else if (choice == "6")
                {
                    factorials();
                }
                else
                {
                    Console.Write("Please choose number 1 - 6");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Please review your input as an error may have occured as a result of it.");
            }

        }



        static void primeNumber()
        {
            Console.Write("Input number 1: ");
            String input1 = Console.ReadLine();

            int num1 = Convert.ToInt32(input1);

            for (int div = 2; div <= num1; div++)
            {
                if (num1 % div == 0)
                {
                    if (num1 == div)
                    {
                        Console.Write(num1 + " is a prime number ");
                    }
                    else
                    {
                        Console.Write(num1 + " is not a prime number ");
                    }
                    break;
                }
            }
        }

        static void findFactors()
        {
            List<int> list = new List<int>();
            String output = "";
            Console.Write("Input number 1: ");
            String input1 = Console.ReadLine();

            int num1 = Convert.ToInt32(input1);

            for (int div = 2; div <= 0.5 * num1; div++)
            {
                if (num1 % div == 0)
                {
                    list.Add(num1 / div);
                    output += num1 / div + " ";
                }
            }
            //test comment
            Console.Write(output);
        }

        static void positiveNumber()
        {
            Console.Write("Input number 1: ");
            String input1 = Console.ReadLine();

            int num1 = Convert.ToInt32(input1);

            if (num1 > 0)
            {
                Console.Write(num1 + " is a positive number ");
            }
            else if (num1 < 0)
            {
                Console.Write(num1 + " is a negative number ");
            }
            else
            {
                Console.Write(num1 + " is neither positive nor negative");
            }
        }

        static void multiples()
        {
            Console.Write("Input a number: ");
            String input1 = Console.ReadLine();

            try
            {
                int num1 = Convert.ToInt32(input1);
                for (int i = 0; i <= 10; i++)
                {
                    int answer = num1 * i;
                    Console.WriteLine(num1 + "x" + i + "=" + answer);
                }
            }
            catch (Exception e)
            {
            }
        }

        static void factorOfAnother()
        {
            Console.Write("Input number 1: ");
            String input1 = Console.ReadLine();

            Console.Write("Input number 2: ");
            String input2 = Console.ReadLine();

            int num1 = Convert.ToInt32(input1);
            int num2 = Convert.ToInt32(input2);

            if (num2 % num1 == 0 && num1 % num2 == 0)
            {
                Console.WriteLine(num1 + " is a factor of " + num2 + " and " + num2 + " is a factor of " + num1);
            }
            else if (num2 % num1 == 0 && num1 % num2 != 0)
            {
                Console.WriteLine(num2 + " is a factor of " + num1 + " but " + num1 + " is not a factor of " + num2);
            }
            else if (num1 % num2 == 0 && num2 % num1 != 0)
            {
                Console.WriteLine(num1 + " is a factor of " + num2 + " but " + num2 + " is not a factor of " + num1);
            }
            else
            {
                Console.WriteLine("Neither number is a factor of the other");
            }
        }

        static void factorials()
        {
            try
            {
                Console.Write("Input a number:");
                String input1 = Console.ReadLine();

                int num = Convert.ToInt32(input1);

                int addNumber = 0;

                for (int add = 1; add <= num; add++)
                {
                    addNumber += add;
                }
                Console.Write(addNumber);
            }

            catch (Exception e)
            {
                Console.WriteLine("Please review your input as an error may have occured as a result of it.");
            }


        }
    }
}
