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
            Assert.AreEqual(expected,result);
        }
    }
}