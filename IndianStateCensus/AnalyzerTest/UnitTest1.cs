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
        public void GivenInvaliFile_ThrowCostomExceptio_InvaliFile()
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
    }
}