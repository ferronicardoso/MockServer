using MockServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockServer.Repositories
{
    public class LogRepository : GenericRepository<Log>
    {
        public LogRepository()
            : base()
        {

        }

        public LogRepository(string connectionString)
            : base(connectionString)
        {

        }
    }
}
