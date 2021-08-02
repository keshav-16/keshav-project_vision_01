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
            foreach (var i in line.Split(' '))
            {
                string temp = " ";
                foreach (var j in i.ToCharArray())
                {
                    temp = j + temp;
                }
                space = space + temp + "";
            }
            Console.WriteLine(space);
        }
    }
}
