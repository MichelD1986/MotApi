using Mot.Infrastructure.DBModel;
using Mot.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mot.Application.Helpers
{
    public class ServerUrlHelper
    {
        private static ServerUrlHelper _instance;

        public static ServerUrlHelper Instance
        {
            get
            {
                if (_instance == null || _instance.Urls == null)
                {
                    _instance = new ServerUrlHelper();
                    _instance.Urls = new Url_RestApiRepository().GetAllUrl_RestApis();
                }

                return _instance;
            }
        }
        public List<Url_RestApi> Urls;

        public String GetUrlPrefix(string server)
        {
            return Urls.First(r => r.Server == server).Api_Prefix;
        }

        public String GetApplicationId(string server)
        {
            return Urls.First(r => r.Server == server).Setting.Application_ID;
        }
    }
}
