using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            #region Task-1
            //int[] arr1 = { 4, 5, 2, 6, 4, 3 };
            //int[] arr2 = { 7, 4, 2, 76, 45, 65 };

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    bool flag = false;
            //    for (int j = 0; j < arr2.Length; j++)
            //    {
            //        if (arr1[i] == arr2[j])
            //        {
            //            flag = true;
            //        }
            //    }
            //    if (!flag)
            //    {
            //        Console.WriteLine(arr1[i]);
            //    }
            //}
            #endregion
            #region Task-2
            //Product product1 = new Product("Product-1")
            //{
            //    Count = 2,
            //    Price = 150,
            //};

            //product1.Sell();
            //Console.WriteLine(product1.Total);
            //product1.Sell();
            //Console.WriteLine(product1.Total);
            //product1.Sell();
            //Console.WriteLine(product1.Total);

            #endregion
            #region Task-3
            //string name = Console.ReadLine();
            //User user = new User(name);
            //string password = Console.ReadLine();
            //user.Password = password;
            #endregion
            #region Task-4
            //int[] arr = {100 , 30 ,40 ,100 };

            //int result = CalcAvg(arr);
            //if (result >= 60) Console.WriteLine("Mezun olduz!");
            //else Console.WriteLine("Mezun olmadiniz!");
            #endregion
            #region Task-5
            //Console.WriteLine(CalcPrice(150 , 50 , 200));
            #endregion
        }

        static int CalcAvg(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum / arr.Length;
        }
        static double CalcPrice(double a, double b, double c)
        {
            double minNumber = a;
            if (minNumber > b)
            {
                minNumber = b;
            }
            if (minNumber > c)
            {
                minNumber = c;
            }
            double price = (a + b + c) - minNumber;
            return price;
        }
    }
}
