using System.Collections.Generic;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;

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

            #region Q4  Write a program that takes two integers then prints the power.
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
            #region Q6 Prime Numbers
            //Console.Write("enter start number");
            //int start = int.Parse(Console.ReadLine());
            //Console.Write("enter end num ");
            //int end = int.Parse(Console.ReadLine());
            //if (start < 2)
            //    start = 2;
            //for (int num = start; num <= end; num++)
            //{
            //    bool isPrime = true;
            //    for (int i = 2; i <= num / 2; i++)
            //    {
            //        if (num % i == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime)
            //    {
            //        Console.WriteLine(num );
            //    }
            //}
        }
        #endregion

        #region Q8 and 11 Identiy Matrix

        //Console.Write("Enter the size of the identity  ");
        //int n = int.Parse(Console.ReadLine());
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < n; j++)
        //    {
        //        if (i == j)
        //        {
        //            Console.Write("1 ");
        //        }
        //        else
        //        {
        //            Console.Write("0 ");
        //        }
        //    }

        //    Console.WriteLine();

        #endregion}
        #region Q9 Extracted String
        //string inputString = "Hello, World!";
        //int start = 6; 
        //string extractedSubstring = "";
        //for (int i = start; i < inputString.Length; i++)
        //{
        //    if (i < inputString.Length)
        //    {
        //        extractedSubstring += inputString[i]; 
        //    }

        //Console.WriteLine("Extarcted subString " + extractedSubstring);
        //} 
        #endregion

        #region Q10Combinestring
        //string Msg1 = Console.ReadLine();
        //string Msg2 = Console.ReadLine();
        //string FinalWord = Msg1 + " " + Msg2;
        //Console.WriteLine(FinalWord); 
        #endregion

        #region q12 Write a program in C# Sharp to find the sum of all elements of the array. 
        //int[] numbers = { 5, 10, 15, 20, 25 };
        //int sum = 0;
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    sum += numbers[i];
        //}
        //Console.WriteLine("The sum  " + sum);
        #endregion

        #region 14- Write a program in C# Sharp to count the frequency of each element of an array.

        //int[] array = { 1, 2, 3, 2 };
        //for (int i = 0; i < array.Length; i++)
        //{
        //    int count = 0;
        //    for (int j = i; j < array.Length; j++)
        //    {
        //        if (array[i] == array[j])
        //        {
        //            count++;
        //        }
        //    }
        //    Console.WriteLine($"count of number {array[i]} is {count}");

        //} 
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
        #region 16- Write a program in C# Sharp to find the second largest element in an array.
       
        //Console.Write("Enter size of array ");
        //int n = int.Parse(Console.ReadLine());
        //int[] array = new int[n];
        //int SecondLargestNum;
        //Console.WriteLine("Enter the array elemnts");
        //for (int i = 0; i < n; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}
        //Array.Sort(array);
        //SecondLargestNum = array[array.Length - 2];
        //Console.WriteLine($"Second Largest Number {SecondLargestNum} "); 
        #endregion

       
        #region Q17 LongestDistance 
        //    Console.WriteLine("Enter araay size:");
        //    int n = int.Parse(Console.ReadLine());
        //    int[] arr = new int[n];
        //    Console.WriteLine("Enter rray elemnts:");
        //    for (int i = 0; i < n; i++)
        //    {
        //        arr[i] = int.Parse(Console.ReadLine());
        //    }
        //    int longestDistance = 0;

        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = i + 1; j < n; j++)
        //    {
        //        if (arr[i] == arr[j])
        //        {

        //            int distance = j - i - 1;
        //            if (distance > longestDistance)
        //            {
        //                longestDistance = distance;
        //            }
        //        }


        //    }
        //}
        //Console.WriteLine("The longest distance" + longestDistance); 
        #region Q18  Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.


        //Console.WriteLine("Enter rows num");
        //int rows = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter cols num:");
        //int cols = int.Parse(Console.ReadLine());
        //int[,] array1 = new int[rows, cols];
        //int[,] array2 = new int[rows, cols];
        //Console.WriteLine("Enter first array elemnts:");

        //for (int i = 0; i < rows; i++)
        //{
        //    for (int j = 0; j < cols; j++)
        //    {
        //        array1[i, j] = int.Parse(Console.ReadLine());
        //    }
        //}
        //for (int i = 0; i < rows; i++)
        //{
        //    for (int j = 0; j < cols; j++)
        //    {
        //        array2[i, j] = array1[i, j];
        //    }
        //}
        //for (int i = 0; i < rows; i++)
        //{
        //    for (int j = 0; j < cols; j++)
        //    {
        //        Console.WriteLine(array2[i, j] +" ");
        //    }

        //}

        #endregion

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
