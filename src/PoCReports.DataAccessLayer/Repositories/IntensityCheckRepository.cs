using PoCReports.Models;
using System.Linq;

namespace PoCReports.DataAccessLayer.Repositories
{
    public class IntensityCheckRepository : AbstractRepository<IntensityCheckDao>
    {
        public IntensityCheckRepository(ReportDBContext context) : base(context)
        {
        }

        public override IQueryable<IntensityCheckDao> GetAll()
        {
            return _dbSet;
        }
    }
}
