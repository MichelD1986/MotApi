using Mot.Infrastructure.DBModel;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mot.Infrastructure.Repositories
{
    public class Url_RestApiRepository
    {
        public List<Url_RestApi> GetAllUrl_RestApis ()
        {
            var url_restApis = DBContextHelper.Instance.MotDataContextDataContext.Url_RestApis.ToList();
            return url_restApis;
        }
    }
}
