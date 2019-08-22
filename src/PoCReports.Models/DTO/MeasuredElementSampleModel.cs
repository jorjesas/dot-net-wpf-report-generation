using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoCReports.Models
{
    public class MeasuredElementSampleModel
    {
        public string ElementName { get; set; }
        public string ElementCrystal { get; set; }
        public string SampleName { get; set; }
        public double SampleMeasure { get; set; }
        public double SampleDifference { get; set; }
    }
}
