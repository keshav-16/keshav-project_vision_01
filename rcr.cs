using System;

namespace right_circular_rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            Console.WriteLine("Enter the elements of the array");
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < (arr.Length - 1); j++)
            {
                temp = arr[0];
                arr[0] = arr[j + 1];         
                arr[j + 1] = temp;
            }
            Console.WriteLine("Result :");
            for(int k; k<(arr.Length); k++)
            {
                Console.WriteLine(arr[k]);
            }
            Console.ReadLine();
        }
    }
}
