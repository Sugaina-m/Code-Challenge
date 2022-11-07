using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Program
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the number : ");
        int size = int.Parse(Console.ReadLine());
        int[,] array = GetArray(size);
        for (int iterator1 = 0; iterator1 < size; iterator1++)
        {
            for (int iterator2 = 0; iterator2 < size; iterator2++)
            {
                if (iterator1 == iterator2)
                {
                    array[iterator1, iterator2] = 0;
                }
                else if (iterator1 < iterator2)
                {
                    array[iterator1, iterator2] = 1;
                }
                else
                {
                    array[iterator1, iterator2] = -1;
                }
            }
            System.Console.WriteLine();
        }
        for (int iterator1 = 0; iterator1 < size; iterator1++)
        {
            for (int iterator2 = 0; iterator2 < size; iterator2++)
            {
                System.Console.Write(array[iterator1, iterator2] + " ");
            }
            System.Console.WriteLine();
            System.Console.ReadLine();
        }
    }

    public static int[,] GetArray(int size)
    {
        int[,] array = new int[size, size];
        return array;
    }
}