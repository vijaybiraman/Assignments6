using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINMAX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[2];
            int[] b = new int[2];
            int[] arr = { 11, 12, 20, 19, 13, 14, 18, 17, 15, 16 };
            a=FindMinMax(arr,a);
            Console.WriteLine("min : "+a[0] + "  max :" + a[1]);

            b=MinMax1.minMax1(arr,b);
            Console.WriteLine("min : " + b[0] + "  max :" + b[1]);
            
            Console.ReadLine();
        }
        public static int[] FindMinMax(int[] arr, int[]a)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i] < min)
                {
                    min = arr[i];
                    a[0] = min;
                }

                if(arr[i] > max)
                {
                    max = arr[i];
                    a[1] = max;
                }
            }
            return a;
        }
    }
}
