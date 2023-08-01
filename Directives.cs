#define  BubbleSort
#define QuickSort
#define noError

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks1
{

    internal class Directives
    {
        #region QuickSortAlgo
        public static int[] SortArray(int[] array, int leftIndex, int rightIndex)

        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];

            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                SortArray(array, leftIndex, j);

            if (i < rightIndex)
                SortArray(array, i, rightIndex);

            return array;
        }
        #endregion



//#line 13 "Directives.cs"
//        dooble

//#pragma warning disable
//#warning This warning is skipped
//#pragma warning restore

//#warning This Warning is not Skipped


        static void Main(string[] args)

        {
            int[] arr = { 2, 3, 7, 2, 0 };
            int temp;
            #if (!noError)
#error code is filled with error
#endif

#if (BubbleSort)
            #region BubbleSortAlgorithm
            
                bool swapped = true;
                while(swapped)
                {
                    swapped = false;
                    for(int i  = 0; i < arr.Length - 1; i++)
                    {
                        if (arr[i]>  arr[i + 1])
                        {
                            
                            temp = arr[i];
                            arr[i] = arr[i + 1];
                            arr[i + 1] = temp;
                            swapped = true;

                        }
                    }
                

            }
            #endregion



#elif QuickSort
            Directives.SortArray(arr, 0, arr.Length - 1);
#endif



            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
       
       

    }
}
        