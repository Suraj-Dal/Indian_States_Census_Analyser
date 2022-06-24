IndianStateCensus.StateCensusAnalyzer analyzer = new IndianStateCensus.StateCensusAnalyzer();
int count = analyzer.DataAnalyzer(@"C:\Projects\Indian_States_Census_Analyser\StateCensusData.csv");
Console.WriteLine("No. of records in file are:" + count);
