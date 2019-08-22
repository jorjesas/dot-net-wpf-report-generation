using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoCReports.Models
{
    [Table("Monochromator")]
    public class MonochromatorDao
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Filter { get; set; }
        public string DetectorType { get; set; }
        public bool Disabled { get; set; }
    }
}
