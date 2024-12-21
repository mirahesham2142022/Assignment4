using System.Collections.Generic;
using System.ComponentModel;

namespace Assignment4_Questions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.Write("Enter an integer: ");
            //int x = int.Parse(Console.ReadLine());


            //for (int i = 1; i <= x; i++)
            //{
            //    Console.Write(i);
            //    Console.WriteLine(" ");

            //}
            #endregion
            #region 2- Write a program that allows the user to insert an integer then print a multiplication table up to 12. 
            //Console.Write("Enter an integer: ");
            //int x = int.Parse(Console.ReadLine());


            //for (int i = 1; i <= x; i++)
            //{
            //    Console.Write(i*12);
            //    Console.WriteLine(" ");

            //}
            #endregion

            #region 3 - Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.Write("Enter an integer: ");
            //int x = int.Parse(Console.ReadLine());


            //for (int i = 1; i <= x; i++)
            //{
            //    if(i%2==0)
            //    Console.Write(i);
            //    Console.WriteLine(" ");

            //}

            #endregion

            #region  Write a program that takes two integers then prints the power.
            //Console.Write("Enter num1: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter num2: ");
            //int num2 = int.Parse(Console.ReadLine());


            //int result = 1;
            //for (int i = 0; i < num2; i++)
            //{
            //    result *= num1;
            //}
            //Console.WriteLine($"{num1}^{num2} = {result}");

            #endregion
            #region Q5 ReverseSring

            //    Console.Write("Enter string: ");
            //    string word = Console.ReadLine();
            //    string reversedString = "";
            //    for (int i = word.Length - 1; i >= 0; i--)
            //    {
            //        reversedString += word[i];
            //    }
            //    Console.WriteLine("Reversed string: " + reversedString);
            //} 
            #endregion

            Console.Write("Enter the size of the identity  ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
            
                Console.WriteLine();
            }
        }
        #region q12 Write a program in C# Sharp to find the sum of all elements of the array. 
        //int[] numbers = { 5, 10, 15, 20, 25 };
        //int sum = 0;
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    sum += numbers[i];
        //}
        //Console.WriteLine("The sum  " + sum);
        #endregion

        #region Q15 Print max and min
        //int[] array = { 3, 5, 7, 2, 8, 1, 9, 4 };
        // int max = array[0];
        // int min = array[0];
        // for (int i = 1; i < array.Length; i++)
        // {
        //     if (array[i] > max)
        //     {
        //         max = array[i];
        //     }

        //     if (array[i] < min)
        //     {
        //         min = array[i];
        //     }
        // }
        // Console.WriteLine("Maximum " + max);
        // Console.WriteLine("Minimum " + min); 
        #endregion
        #region Q19 Reverse order
        //int[] array = { 1, 2, 3, 4, 5 };
        //for (int i = array.Length-1 ; i >= 0; i--)
        //{
        //    Console.Write(array[i] + " ");
        //}

        #endregion

    }
    }
