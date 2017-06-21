using BinarywayCoreFramework.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarywayCoreFramework
{
    public class BWConnections
    {
        public bool TestConnection()
        {
            return true;
        }

        public string FetchDataFromDB() {
            BWAnalyticsEntities bw = new BWAnalyticsEntities();
            var dbData = bw.BWTests.SingleOrDefault();
            return dbData.NAME;
        }

    }
}
