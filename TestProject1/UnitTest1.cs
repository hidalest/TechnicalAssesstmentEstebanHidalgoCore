using TechnicalAssesstmentEstebanHidalgoCore;
using TechnicalAssestmentEstebanHidalgo;

namespace TestTechnicalAssesstment.UnitTests
{
    [TestClass]
    public class SortListOfNameAndWriteOnFileTest
    {
        [TestMethod]
        public void TestReadDataFromFile_ShouldReadDataFromFile_NewData()
        {

            string expectedString = "Hello, world!";
            string filePath = "test.txt";

            // Write test data to a file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(expectedString);
            }


            string resultString = SortListOfNameAndWriteOnFile.readDataFromFile(filePath);


            Assert.AreEqual(expectedString, resultString);

            // Clean up the test file
            File.Delete(filePath);
        }


        [TestMethod]
        public void TestSortListOfNameAndWriteOnFile_checkForSortedNamesOnTheSortedFile()
        {
            string filePath = "unsorted-names-list.txt";
            SortListOfNameAndWriteOnFile sortObj = new SortListOfNameAndWriteOnFile(filePath);

            // Verify that the output file exists and contains expected data
            string[] expected = { "Alvarez, Marin", "Archer, Adonis Julius", "Bentley, Beau Tristan", "Clarke, Hunter Uriah Mathew", "Gardner, Leo", "Lewis, Vaughn", "Lindsey, London", "Lopez, Mikayla", "Parsons, Janet", "Ritter, Frankie Conner", "Yoder, Shelby Nathan" };
            string[] actual = File.ReadAllLines("sorted-names-list.txt");
            Assert.AreEqual(expected, actual);
        }
    }
}
