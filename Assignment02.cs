using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_junaidmalik
{
    class Assignment02
    {
        static void Main(string[] args)
        {
            int size = UserInterfaceConsole.GetNumber("Enter the array size");
            Console.WriteLine("Enter the Elements of Array");
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Even Numbers");
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] % 2) == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Odd Numbers");
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] % 2) != 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
