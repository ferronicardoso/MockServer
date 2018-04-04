using MockServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockServer.Repositories
{
    public class RestMockRepository : GenericRepository<RestMock>
    {
        public RestMockRepository() 
            : base()
        {

        }

        public RestMockRepository(string connectionString) 
            : base(connectionString)
        {

        }

        public RestMock GetMatch(string url, string verb)
        {
            var mockList = base.List(x => x.Active && x.Verb.Contains(verb) && Utils.IsMatch(x.Path, url));
            var mock = mockList.FirstOrDefault();
            return mock;
        }
    }
}
