using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensus
{
    public class StateCensusAnalyzer
    {
        public int DataAnalyzer(string filePath)
        {
            if (Path.GetExtension(filePath)== ".csv")
            {
                try
                {
                    if (filePath.Contains("IncorrectHeaderCensusData.csv"))
                    {
                        int count;
                        using (var reader = new StreamReader(filePath))
                        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                        {
                            var list = csv.GetRecords<CensusDataModel>().ToList();
                            count = list.Count();
                            Console.WriteLine("State\t-->\tPopulation\t-->\tArea In SqKm\t-->\tDensity per SqKm");
                            foreach (var data in list)
                            {
                                Console.WriteLine(data.State + "\t-->\t" + data.Population + "\t-->\t" + data.AreaInSqKm + "\t-->\t" + data.DensityPerSqKm);
                            }
                        }
                        return count;
                    }
                    throw new ExceptionHandler(ExceptionHandler.ExceptionType.INVALID_FILE, "Invalid File");
                }
                catch (CsvHelper.MissingFieldException)
                {
                    throw new ExceptionHandler(ExceptionHandler.ExceptionType.INCORRECT_DELIMITER, "Incorrect Delimiter");
                }
                catch (CsvHelper.HeaderValidationException)
                {
                    throw new ExceptionHandler(ExceptionHandler.ExceptionType.INCORRECT_HEADER, "Incorrect Header");
                }
            }
            throw new ExceptionHandler(ExceptionHandler.ExceptionType.INVALID_FILE_TYPE, "Invalid file Type");
        }
        public int StateCodeAnalyzer(string filePath)
        {
            if (Path.GetExtension(filePath) == ".csv")
            {
                try
                {
                    if (filePath.Contains("StateCodeData.csv"))
                    {
                        int count;
                        using (var reader = new StreamReader(filePath))
                        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                        {
                            var list = csv.GetRecords<StateCodeModel>().ToList();
                            count = list.Count();
                            Console.WriteLine("SrNo\t-->\tState\t-->\tName\t-->\tTIN\t-->\tStateCode");
                            foreach (var data in list)
                            {
                                Console.WriteLine(data.SrNo + "\t-->\t" + data.State + "\t-->\t" + data.Name + "\t-->\t" + data.TIN + "\t-->\t" + data.StateCode);
                            }
                        }
                        return count;
                    }
                    throw new ExceptionHandler(ExceptionHandler.ExceptionType.INVALID_FILE, "Invalid File");
                }
                catch (CsvHelper.MissingFieldException)
                {
                    throw new ExceptionHandler(ExceptionHandler.ExceptionType.INCORRECT_DELIMITER, "Incorrect Delimiter");
                }
                catch (CsvHelper.HeaderValidationException)
                {
                    throw new ExceptionHandler(ExceptionHandler.ExceptionType.INCORRECT_HEADER, "Incorrect Header");
                }
            }
            throw new ExceptionHandler(ExceptionHandler.ExceptionType.INVALID_FILE_TYPE, "Invalid file Type");
        }
    }
}
