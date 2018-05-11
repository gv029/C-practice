using System;

namespace stringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = "What if I need a \nnew line?";
            //string myString = "Go do your c:\\Drive";
            //string myString = @"Go to your c:\Drive";

            //string myString = String.Format("{0} = {1}", "First", "Second");

            //string myString = string.Format("{0:C}", 123);

            //string myString = string.Format("{0:N}", 1234567890);

            //string myString = string.Format("{0:P}", .123);

            //custom formatting
            //string myString = string.Format("Phone number: {0:(###)-###-####}", 2146687428);





            //string myString = " a somewhat long sentence that doesn't really say anything ";

            // myString = myString.Substring(1,myString.Length-2);
            // myString = myString.ToUpper();
            //myString = myString.Replace(" ", "*");
            //myString = myString.Remove(12);

            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {

            }

            Console.WriteLine(myString.Length);


            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
