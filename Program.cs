using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task-1
            Console.WriteLine("Hello,World!");

            //Task-2
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");

            //Task-3
            int num1, num2;
            Console.WriteLine("Enter First Number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ENter Second Number");
            num2 = int.Parse(Console.ReadLine());
            int addition = num1 + num2;
            int Subtraction = num1 - num2;

            int Multiplication = num1 * num2;
            double division = num1 / num2;
            int modules = num1 % num2;
            Console.WriteLine("Addition:\t" + addition);
            Console.WriteLine("Subtraction:\t" + Subtraction);
            Console.WriteLine("Multiplication:\t" + Multiplication);
            Console.WriteLine("Division:\t" + division);

            Console.WriteLine("Mosules:\t" + modules);
            int num3, num4;
            Console.WriteLine("Enter First Number for division by Zero");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ENter Second Number for division by Zero");
            num4 = int.Parse(Console.ReadLine());
            double divByZero = num3 / num4;
            Console.WriteLine("DiVision By Zero:\t" + divByZero);

            //Task-4

            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Given Number is Even");
            }
            else
            {
                Console.WriteLine("Given Number is Odd");
            }

            //Task-5

            Console.WriteLine("Lets prints the numbers from 1 to 10 on the console!");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            //Task-6
            Console.WriteLine("Enter No of Elements in Array");
            int NoOfElment = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Array Values");
            int[] Arr = new int[NoOfElment];
            for (int i = 0; i < NoOfElment; i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < NoOfElment; i++)
            {
                sum += Arr[i];

            }
            Console.WriteLine("Sum of Array Elements:\t" + sum);
            double average = (double)sum / NoOfElment;
            Console.WriteLine("Average of Array elements:\t" + average);


            //Task-7


            int Factorial(int n)
            {
                if (n == 0 || n == 1)
                    return 1;
                else
                    return n * Factorial(n - 1);
            }
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("Error: Please enter a positive integer.");
            }
            else
            {
                long result = Factorial(num);
                Console.WriteLine($"Factorial of {num} is {result}.");
                Console.ReadKey();
            }

            //Task-8
            Console.WriteLine("Enter age");
            string age=Console.ReadLine();
            int validateInput;
            try {
                if (int.TryParse(age, out validateInput))
                {
                    if (validateInput < 0)
                    {
                        Console.WriteLine("Error: Age cannot be negative.");
                    }
                    else if (validateInput < 18)
                    {
                        Console.WriteLine("You are a minor.");
                    }
                    else if (validateInput >= 18 && validateInput < 65)
                    {
                        Console.WriteLine("You are an adult.");
                    }
                    else
                    {
                        Console.WriteLine("You are a senior.");
                    }
                    
                }
                
            }catch (Exception ex)
            {
                Console.WriteLine("Error"+ex.Message);
            }
            finally
            {
                Console.WriteLine("ENd of the program");
                Console.ReadKey();
            }

           


        }

       
     
        }
    }

