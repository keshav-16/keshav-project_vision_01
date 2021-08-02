using System;

namespace reverseword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");
            string line = Console.ReadLine();
            string space = " ";
            foreach (string i in line.Split(' '))
            {
                string temp = " ";
                foreach (char j in i.ToCharArray())
                {
                    temp = j + temp;
                }
                space = space + temp + "";
            }
            Console.WriteLine(space);
        }
    }
}
