using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensus
{
    public class CensusDataModel
    {
            public string State { get; set; }
            public string Population { get; set; }
            public string AreaInSqKm { get; set; }
            public string DensityPerSqKm { get; set; }
    }
    public class StateCodeModel
    {
        public string SrNo { get; set; }
        public string State { get; set; }
        public string Name { get; set; }
        public string TIN { get; set; }
        public string StateCode { get; set; }
    }
}
