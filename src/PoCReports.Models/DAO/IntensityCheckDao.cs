using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PoCReports.Models
{
    [Table("IntensityCheck")]
    public class IntensityCheckDao
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Channel { get; set; }
        public decimal? Ratio { get; set; }
        public decimal? Initial { get; set; }
        public decimal? Current { get; set; }
        public DateTime? LastModified { get; set; }
        public bool Status { get; set; }
    }
}
