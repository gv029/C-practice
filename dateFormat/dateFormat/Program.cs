using System;

namespace dateFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString());
            Console.ReadLine();

            Console.WriteLine(myValue.AddDays(-3).ToLongDateString());
            Console.ReadLine();


            Console.WriteLine(myValue.AddHours(4).ToLongTimeString());
            Console.ReadLine();

            Console.WriteLine(myValue.Month);
            Console.ReadLine();

            DateTime myBirthday = new DateTime(1993, 7, 6);
            Console.WriteLine("The following is my Birthday: ");
            Console.WriteLine(myBirthday.ToLongDateString());

            Console.ReadLine();


        }
    }
}
