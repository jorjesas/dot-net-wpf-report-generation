using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoCReports.Models
{
    public class XYPointCombinedSeriesModel
    {
        public IEnumerable<XYPointModel> Series1 { get; set; }
        public IEnumerable<XYPointModel> Series2 { get; set; }
        public IEnumerable<XYPointModel> Series3 { get; set; }
        public IEnumerable<XYPointModel> Series4 { get; set; }
        public IEnumerable<XYPointModel> Series5 { get; set; }
    }
}
