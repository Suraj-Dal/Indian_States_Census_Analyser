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
        [Test]//UC1.3 given correct file but with incorrect delimiter
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
    }
}