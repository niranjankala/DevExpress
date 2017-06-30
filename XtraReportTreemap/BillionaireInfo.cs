using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtraReportTreemap
{
    public class BillionaireInfo
    {
        public String Name { get; set; }
        public String Residence { get; set; }
        public String Source { get; set; }
        public int Age { get; set; }
        public double NetWorth { get; set; }
    }

    public class EnergyInfo
    {
        public string Type { get; set; }
        public double Value { get; set; }
    }

    public class CountryStatistics
    {
        public string Name { get; set; }

        List<EnergyInfo> energyStatistics = new List<EnergyInfo>();
        public List<EnergyInfo> EnergyStatistics { get { return energyStatistics; } }
    }
}
