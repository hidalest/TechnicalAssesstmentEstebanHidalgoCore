using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalAssestmentEstebanHidalgo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Please enter the path of the file, use the following format 'C:\\\\...:' ");
            string pathOfFile = Console.ReadLine();
            string stringOfNames = readDataFromFile("C:\\unsorted-names-list.txt");
            string[] listOfNames = convertStringToArray(stringOfNames);


            Console.ReadLine();
        }

        public static string readDataFromFile(string filePath)
        {
            try
            {
                StreamReader sr = new StreamReader(filePath);
                return sr.ReadToEnd();

            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public static string[] convertStringToArray(string str)
        {

            string[] namesArray = str.Split('\n');
            return namesArray;


        }


    }
}