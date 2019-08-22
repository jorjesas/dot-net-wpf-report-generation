using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoCReports.Models
{
    public class XYPointModel
    {
        public double Y { get; set; }
        public double X { get; set; }

        public XYPointModel()
        {
        }

        public XYPointModel(double argument, double value)
        {
            X = argument;
            Y = value;
        }
    }
}
