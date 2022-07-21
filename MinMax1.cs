using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINMAX
{    internal class MinMax1
    {
        public static int[] minMax1(int[] arr, int[]b)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int count = 0;
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    count++;
                }
                if (count > 0)
                {
                    min = arr[i];
                    b[0] = min;
                    count = 0;
                }

                if (arr[i] > max)
                {
                    counter++;
                }
                if (counter > 0)
                {
                    max = arr[i];
                    b[1] = max;
                    counter = 0;
                }
                }
            return b;
            }
        }
    }

