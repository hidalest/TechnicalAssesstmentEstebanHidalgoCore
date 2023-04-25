using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TechnicalAssestmentEstebanHidalgo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LastNameComparer lastNameComparer = new LastNameComparer();

            // Check if a file path was provided as a command-line argument
            /* if (args.Length > 0)
             {
                 // Get the file path from the command-line argument
                 string filePath = args[0];*/

            //Console.Write("Please enter the path of the file, use the following format 'C:\\\\...:' ");

            string stringOfNames = readDataFromFile("C:\\unsorted-names-list.txt");
            string[] listOfNames = convertStringToArray(stringOfNames);
            
            Array.Sort(listOfNames, lastNameComparer);
            writeDataToFile(listOfNames, "sorted-names-list.txt");

            /*}
            else
            {
                Console.WriteLine("Please provide a file path as a command-line argument.");
            }*/

            Console.ReadLine();
        }

        public static string readDataFromFile(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    return reader.ReadToEnd();
                } 
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public static void writeDataToFile(string[] arrayOfNames, string fileName)
        {
            StreamWriter writter = new StreamWriter(fileName);
            try
            {
                foreach (string name in arrayOfNames)
                {
                    writter.WriteLine(name);
                }
                Console.WriteLine($"puff! the sorted names where added to the file '{fileName}'");
            }
            catch (IOException e)
            {
                Console.WriteLine("Something went wrong, please try again later...:");
                Console.WriteLine(e.Message);
                throw;
            }
            finally { writter.Close(); }

        }

        public static string[] convertStringToArray(string str)
        {

            string[] namesArray = str.Split('\n');
            return namesArray;


        }


    }
}