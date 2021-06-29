using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate001_01
{
    delegate int delCompare(int p_iNumA, int p_iNumB);
    class Program
    {
        static int AscendCompare(int p_iNumA, int p_iNumB)
        {
            if (p_iNumA > p_iNumB)
            {
                return 1;
            }
            else if (p_iNumA == p_iNumB)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        static int DescendCompare(int p_iNumA, int p_iNumB)
        {
            if (p_iNumA < p_iNumB)
            {
                return 1;
            }
            else if (p_iNumA == p_iNumB)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        static void BubbleSort(int [] p_iArray, delCompare compare)
        {
            int i = 0;
            int j = 0;
            int temp = 0;
            for (i = 0; i < p_iArray.Length-1; i++)
                                                                                                                                                                                                                                                                                                                                                                                                                                                 {
                for (j = 0; j < p_iArray.Length - (i+1); j++)
                {
                    if (compare(p_iArray[j], p_iArray[j+1]) >0)
                    {
                        temp = p_iArray[j + 1];
                        p_iArray[j + 1] = p_iArray[j];
                        p_iArray[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] iArrayAsc = { 3, 4, 11, 34, 55, -1 };
            Console.WriteLine("Sorting Ascending");
            BubbleSort(iArrayAsc, new delCompare(AscendCompare));

            for (int i = 0; i < iArrayAsc.Length; i++)
            {
                Console.WriteLine($"iArray{i}: {iArrayAsc[i]}");
            }

            Console.WriteLine("Sorting Descending");

            int[] iArrayDesc = { 10, 12, 31, 4, 5 };
            BubbleSort(iArrayDesc, new delCompare(DescendCompare));

            for (int i = 0; i < iArrayDesc.Length; i++)
            {
                Console.WriteLine($"iArray{i}: {iArrayDesc[i]}");
            }
            Console.ReadLine();

        }
    }
}
