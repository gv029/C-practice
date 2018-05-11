using System;

namespace SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = NameChecker();
            string y = ReverseString(x);
            Console.WriteLine(y);
            Console.ReadLine();
        }

        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            string reverseMessage = String.Concat(messageArray);

            return reverseMessage;
        }

        private static string NameChecker()
        {
            string firstName;
            string lastName;
            string city;

            Console.WriteLine("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Which city do you live in? ");
            city = Console.ReadLine();

            string message = firstName + " " + lastName + " " + city;

            Console.WriteLine(message);
            return message;
        }
        
        
    }
 

}
