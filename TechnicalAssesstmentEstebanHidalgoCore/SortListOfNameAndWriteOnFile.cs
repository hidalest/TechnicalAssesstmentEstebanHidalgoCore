using TechnicalAssestmentEstebanHidalgo;

namespace TechnicalAssesstmentEstebanHidalgoCore
{
    public class SortListOfNameAndWriteOnFile
    {
        public static void SortListOfNameAndWriteOnFileAction(string filePath)
        {
            LastNameComparer lastNameComparer = new LastNameComparer();

            string stringOfNames = readDataFromFile(filePath);
            string[] listOfNames = convertStringToArray(stringOfNames);

            Array.Sort(listOfNames, lastNameComparer);
            writeDataToFile(listOfNames, "sorted-names-list.txt");

            Console.WriteLine("The names sorted by last name: ");
            foreach (string name in listOfNames)
            {
                Console.WriteLine($"{name}");
            }

        }

        // Receives an array of string and another parameter for the file name.
        // Calls the StreamReader object to read data in the file passed as filePath.
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
        // Receives an array of string and another parameter for the file name.
        // Calls the StreamWriter object to write each name of the array of names in the file passed as FileName.
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
        // Splits a string separated by '\n' and convert it to an array of strings.
        public static string[] convertStringToArray(string namesString)
        {

            string[] namesArray = namesString.Split('\n');
            return namesArray;


        }
    }


}
