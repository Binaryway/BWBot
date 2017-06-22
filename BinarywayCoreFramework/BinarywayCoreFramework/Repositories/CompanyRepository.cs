using BinarywayCoreFramework.EF;
using BinarywayCoreFramework.Repositories.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarywayCoreFramework.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        BWAnalyticsEntities bw = new BWAnalyticsEntities();
        public string GetName() {
            var dbData = bw.BWTests.SingleOrDefault();
            return dbData.NAME;
        }
    }
}
