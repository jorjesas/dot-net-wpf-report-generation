using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoCReports.Models
{
    public class InstrumentConfigurationHeaderDataModel
    {
        public string InstrumentName { get; set; }
        public double XRayTubePowerSupply { get; set; }
        public string ConveyorType { get; set; }
        public int PositionNumber { get; set; }
        public string Target { get; set; }
    }
}
