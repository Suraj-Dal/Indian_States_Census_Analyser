IndianStateCensus.StateCensusAnalyzer analyzer = new IndianStateCensus.StateCensusAnalyzer();
Console.WriteLine("0.Exit\n1.State Sensus Data\n2.State Code\nEnter your choice:");
int choice = Convert.ToInt32(Console.ReadLine());
while (choice != 0)
{
    switch (choice)
    {
        case 1:
            int countRecords = analyzer.DataAnalyzer(@"C:\Projects\Indian_States_Census_Analyser\StateCensusData.csv");
            Console.WriteLine("No. of records in file are:" + countRecords);
            break;
        case 2:
            int noOfRecords = analyzer.StateCodeAnalyzer(@"C:\Projects\Indian_States_Census_Analyser\StateCodeData.csv");
            Console.WriteLine("No. of records in file are:" + noOfRecords);
            break;
        default:
            Console.WriteLine("Enter valid choice");
            break;
    }
    Console.WriteLine("0.Exit\n1.State Sensus Data\n2.State Code\nEnter your choice:");
    choice = Convert.ToInt32(Console.ReadLine());
}
