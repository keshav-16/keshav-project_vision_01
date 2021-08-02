using System;

namespace all_substrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();
            Console.WriteLine("result :");
            for(int i=0; i<word.Length; i++)
            {
                for(int j=0; j<(word.Length - 1); j++)
                {
                    Console.WriteLine(word.Substring(i, j + 1));
                }
            }
            Console.ReadLine();
        }
    }
}
