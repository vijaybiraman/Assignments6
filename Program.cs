using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundMinmax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a= new int[2];
            int[] b = new int[2];
            int[] arr = { 19, 13, 12, 14, 15, 16, 17, 18, 11, 20 };
            Console.WriteLine(arr.Length);
            a=FoundMinmax(arr,a);
            Console.WriteLine("Max :" + a[0] + " Min :" + a[1]);

            b=MinMax2.FoundMinmax1(arr,b);
            Console.WriteLine("Max :" + b[0] + " Min :" + b[1]);
            Console.ReadLine();
        }
        public static int[] FoundMinmax(int[] arr, int[]a)
        {
            int var1=arr.Max();
            a[0] = var1;
            int var2 = arr.Min();
            a[1] = var2;
            return a;
        }
    }
}
