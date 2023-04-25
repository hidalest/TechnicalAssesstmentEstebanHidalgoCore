using TechnicalAssesstmentEstebanHidalgoCore;

namespace TechnicalAssestmentEstebanHidalgoCore
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Check if a file path was provided as a command-line argument
            if (args.Length > 0)
            {
                // Get the file path from the command-line argument
                string filePath = args[0];
                SortListOfNameAndWriteOnFile sortFile = new SortListOfNameAndWriteOnFile(filePath);
            }
            else
            {
                Console.WriteLine("Please provide a file path as a command-line argument.");
            }

            Console.ReadLine();
        }

    }
}
