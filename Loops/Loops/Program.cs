using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i==7)
                {
                    Console.WriteLine("Found 7!");
                    break;
                }
            }
            Console.ReadLine();

            int n = 0;
            while (n < 10)
             {
                n++;
                Console.WriteLine(n);
             }
            Console.ReadLine();

            string zig = "You can get what you want out of life " +
                "if you help enough other people get what they want.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }


           


            
        }
    }
}
