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
        public void convertStringToArray_ShouldConvertThePassingStringValuesIntoAnArray_ArrayOfStrings()
        {
            string nameStrings = "Esteban Hidalgo\nSofia Hidalgo";

            string[] expectedResult = { "Esteban Hidalgo", "Sofia Hidalgo" };

            string[] result = SortListOfNameAndWriteOnFile.convertStringToArray(nameStrings);

            CollectionAssert.AreEqual(expectedResult, result);
        }

    }
}
