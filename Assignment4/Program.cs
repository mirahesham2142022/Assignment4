using System.Globalization;
using System.Text;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For loop
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region for _ for_each(works on a copy of array)



            // int[] nUmbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ///use for if u want to acesss index
            //for (int i = 0; i < nUmbers.Length; i++)
            //{
            //if(nUmbers[i]=5)
            //break;
            //    Console.WriteLine(nUmbers[i]);
            //} 
            //class implemnt inteface Ienuemrble,Cant edit any value inside array (ust for display)
            //foreach(int number in nUmbers)
            //{
            //    Console.WriteLine(number);
            //   // Console.WriteLine(number+10); applicable bec I dont edit r change the values of array 
            //}    
            #endregion
            #region while-Do_while
            //int num;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Enter even");
            //    // num = int.Parse(Console.ReadLine());
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //} while (num % 2 == 1 || !flag);
            //Console.WriteLine($"{ num } is Even");

            //while ((num % 2 == 1 || !flag)
            //{
            //    Console.WriteLine("Enter even");
            //    // num = int.Parse(Console.ReadLine());
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //}
            //Console.WriteLine($"{num}is Even");
            #endregion


            #region string
            //Immutable
            //Class->RefreceType
            //String Name1, Name2;
            //Name1 = ("Ahmed");
            //Name2 = ("Ahmed");
            //Console.WriteLine(Name1.GetHashCode());
            //Console.WriteLine(Name2.GetHashCode());

            //Name1 = ("Mira");
            //Name2 = ("Dina");
            //Console.WriteLine(Name1.GetHashCode());
            //Console.WriteLine(Name2.GetHashCode());
            //Name2 = Name1;
            //Console.WriteLine(Name1.GetHashCode());
            //Console.WriteLine(Name2.GetHashCode());
            #endregion
            #region   String builder 

            //linkedlist of chars
            //StringBuilder Message;
            //Message= new StringBuilder("Mira");
            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());
            //Message.Append("Hesham");
            //Console.WriteLine(Message.GetHashCode());

            #endregion
            #region StringBuilder Funcions 
            //StringBuilder Message;
            //Message = new StringBuilder("Mira");
            //Message.Remove(0, 3);
            //Message.Insert(0,"Hello");
            //Message.Append(" Hesham ");
            //Console.WriteLine(Message.ToString());

            #endregion

            #region Array1D 
            //Referncetype
            //int[] Nums = { 1, 2, 3 };
            //int[] Nums = new int[] { 1, 2, 3 };
            //int[]Nums = new int[] { 1, 2, 3 };
            //int[] Nums = new int[3];
            // for (int i = 0; i<Nums.Length; i++) {
            //    Console.WriteLine($"Enter elemnt{i+1}");
            //    Nums[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < Nums.Length; i++)
            //{
            //    Console.WriteLine(Nums[i]);
            //}
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine(Nums.Length);
            //Console.WriteLine(Nums.Rank);


            #endregion

            #region Array2D
            //int[,] Marks = new int[3, 4];
            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    bool flag;
            //    Console.WriteLine($"enter Grades Student {i+1}");
            //    for (int k = 0; k< Marks.GetLength(1); k++)
            //    {
            //        Console.WriteLine($"enter Grades of subjects {k + 1}");
            //       flag= int.TryParse(Console.ReadLine(), out Marks[i, k]);
            //        if (flag && Marks[i, k] >= 0)
            //        {
            //            k++;
            //        }

            //    }
            //}
            #endregion

            #region iterate On 2d Array on  one loop
            //int[,] Marks = new int[3, 5];
            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine(Marks[i / Marks.GetLength(1), i % Marks.GetLength(1)]);
            //}
            #endregion

            #region JudgedArray
            int[][] Number = new int[3][];
            Number[0] = new int[3] { 1, 2, 3 };
            Number[1] = new int[2] { 1, 2 };
            Number[2] = new int[3];
            for (int i = 0; i < Number.Length; i++)
            {
                for (int j = 0; j < Number[i].Length;j++)
                {
                    Console.WriteLine(Number[i][j]);
                }
                Console.WriteLine("-----------");
            }
            #endregion
        }
    }
}
