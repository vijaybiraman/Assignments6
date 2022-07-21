using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundMinmax
{
    internal class MinMax2
    {
        public static int[] FoundMinmax1(int[] arr,int[]b)
        {
            int max = 0;
            int min = 0;
            int count = 0;
            int i = 0;
            int j = 0;
            while (i <= arr.Length - 1 && j <= arr.Length - 1)
            {
                if (arr[j] < arr[i])
                {
                    count++;
                }
                if (i == arr.Length - 1)
                {
                    if (count == 0)
                    {
                        max = arr[j];
                        break;
                    }
                    i = 0;
                    j++;
                    count = 0;
                }
                i++;
            }
            i = 0;
            j = 0;
            count = 0;
            while (i <= arr.Length - 1 && j <= arr.Length - 1)
            {
                if (arr[j] > arr[i])
                {
                    count++;
                }
                if (i == arr.Length - 1)
                {
                    if (count == 0)
                    {
                        min = arr[j];
                        break;
                    }
                    i = 0;
                    j++;
                    count = 0;
                }
                i++;
            }

            b[0] = max;
            b[1] = min;
            return b;
        }
    }
}
