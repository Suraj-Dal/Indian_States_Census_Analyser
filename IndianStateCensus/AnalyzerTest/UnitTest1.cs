namespace AnalyzerTest
{
    public class Tests
    {
        [Test]
        public void GivenCSVFilePath_CheckNoOfRecords_WithExpectedCount()
        {
            int expected = 29;
            IndianStateCensus.StateCensusAnalyzer analyzer = new IndianStateCensus.StateCensusAnalyzer();
            int result = analyzer.DataAnalyzer(@"C:\Projects\Indian_States_Census_Analyser\StateCensusData.csv");
            Assert.AreEqual(expected, result);
        }
        [Test]//UC1.2 Given invalid file
        public void GivenInvalidFile_ThrowCostomException_InvaliFile()
        {
            try
            {
                int expected = 29;
                IndianStateCensus.StateCensusAnalyzer analyzer = new IndianStateCensus.StateCensusAnalyzer();
                int result = analyzer.DataAnalyzer(@"C:\Projects\Indian_States_Census_Analyser\CensusData.csv");
                Assert.AreEqual(expected, result);
            }
            catch(Exception ex)
            {
                Assert.AreEqual("Invalid File", ex.Message);
            }
        }
        [Test]//UC1.3 given invalid file type
        public void GivenInvalidFileType_ThrowCostomException_InvaliFileType()
        {
            try
            {
                int expected = 29;
                IndianStateCensus.StateCensusAnalyzer analyzer = new IndianStateCensus.StateCensusAnalyzer();
                int result = analyzer.DataAnalyzer(@"C:\Projects\Indian_States_Census_Analyser\StateCensusData.cs");
                Assert.AreEqual(expected, result);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid file Type", ex.Message);
            }
        }
        [Test]//UC1.4 given correct file but with incorrect delimiter
        public void GivenIncorrectDelimiter_ThrowCostomException_IncorrectDelimiter()
        {
            try
            {
                int expected = 29;
                IndianStateCensus.StateCensusAnalyzer analyzer = new IndianStateCensus.StateCensusAnalyzer();
                int result = analyzer.DataAnalyzer(@"C:\Projects\Indian_States_Census_Analyser\InvalidDelimiterCensusData.csv");
                Assert.AreEqual(expected, result);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Incorrect Delimiter", ex.Message);
            }
        }
        [Test]//UC1.5 given correct file but with incorrect Header
        public void GivenIncorrectHeader_ThrowCostomException_IncorrectHeader()
        {
            try
            {
                int expected = 29;
                IndianStateCensus.StateCensusAnalyzer analyzer = new IndianStateCensus.StateCensusAnalyzer();
                int result = analyzer.DataAnalyzer(@"C:\Projects\Indian_States_Census_Analyser\IncorrectHeaderCensusData.csv");
                Assert.AreEqual(expected, result);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Incorrect Header", ex.Message);
            }
        }
        [Test]// UC 2.1 Given path of State code test count return by function with expected result. 
        public void GivenCSVFilePath_CheckNoOfRecords_WithExpectedCount_InStateCodeFile()
        {
            int expected = 37;
            IndianStateCensus.StateCensusAnalyzer analyzer = new IndianStateCensus.StateCensusAnalyzer();
            int result = analyzer.StateCodeAnalyzer(@"C:\Projects\Indian_States_Census_Analyser\StateCodeData.csv");
            Assert.AreEqual(expected, result);
        }
        [Test]//UC 2.2 Given invalid file test exeption return by function
        public void GivenInvalidFile_ThrowCostomException_InvaliFile_StateCodeFile()
        {
            try
            {
                int expected = 37;
                IndianStateCensus.StateCensusAnalyzer analyzer = new IndianStateCensus.StateCensusAnalyzer();
                int result = analyzer.StateCodeAnalyzer(@"C:\Projects\Indian_States_Census_Analyser\StateData.csv");
                Assert.AreEqual(expected, result);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid File", ex.Message);
            }
        }
        [Test]//UC2.3 given invalid file type
        public void GivenInvalidFileType_ThrowCostomException_InvaliFileType_StateCodeFile()
        {
            try
            {
                int expected = 37;
                IndianStateCensus.StateCensusAnalyzer analyzer = new IndianStateCensus.StateCensusAnalyzer();
                int result = analyzer.StateCodeAnalyzer(@"C:\Projects\Indian_States_Census_Analyser\StateCodeData.cs");
                Assert.AreEqual(expected, result);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid file Type", ex.Message);
            }
        }
        [Test]//UC2.4 given correct file but with incorrect delimiter
        public void GivenIncorrectDelimiter_ThrowCostomException_IncorrectDelimiter_StateCodeFile()
        {
            try
            {
                int expected = 37;
                IndianStateCensus.StateCensusAnalyzer analyzer = new IndianStateCensus.StateCensusAnalyzer();
                int result = analyzer.StateCodeAnalyzer(@"C:\Projects\Indian_States_Census_Analyser\IncorrectDelimiterStateCodeData.csv");
                Assert.AreEqual(expected, result);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Incorrect Delimiter", ex.Message);
            }
        }
        [Test]//UC2.5 given correct file but with incorrect Header
        public void GivenIncorrectHeader_ThrowCostomException_IncorrectHeader_StateCodeFile()
        {
            try
            {
                int expected = 37;
                IndianStateCensus.StateCensusAnalyzer analyzer = new IndianStateCensus.StateCensusAnalyzer();
                int result = analyzer.StateCodeAnalyzer(@"C:\Projects\Indian_States_Census_Analyser\IncorrectHeaderStateCodeData.csv");
                Assert.AreEqual(expected, result);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Incorrect Header", ex.Message);
            }
        }
    }
}