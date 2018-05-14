﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {

            string x = createFile();
            writeToNewFile(x);

        }
        static void textWriter()
        {
            //sample of writing text to file using the WriteAllText method
            Console.WriteLine("Please enter your name:");
            string text = Console.ReadLine();
            string directory = @"C:\Users\v-gavida\Desktop\sampledocument.txt";
            File.WriteAllText(directory, text);

            //displaying feedback to user that text has been written
            Console.WriteLine("Text written to sampledocument.txt in your Desktop (Press ENTER to continue...)");
            Console.ReadLine();
        }
        static string createFile()
        {
            //Creating a new file using the Create method
            Console.WriteLine("Creating a new file...");
            Console.WriteLine("Please type a new filename: ");

            string filename = Console.ReadLine();
            filename += ".txt";

            string filelocation = @"C:\Users\v-gavida\\Desktop\" + filename;
            var myFile = File.Create(filelocation);
            Console.WriteLine(filelocation);
            myFile.Close();

            return filelocation; 
        }

        static void writeToNewFile(string filelocation)
        {
            //Writing text to the new file
            Console.WriteLine("Type a sentence to insert into the file: ");
            string newSentence = Console.ReadLine();

            File.WriteAllText(filelocation, newSentence);
            Console.WriteLine("text has been written to new at {0}", filelocation);
            Console.ReadLine();
        }
    }
}
