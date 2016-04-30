using Mot.Infrastructure.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mot.Infrastructure
{
    public class DBContextHelper
    {
        private static DBContextHelper _instance;

        public static DBContextHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DBContextHelper();
                    _instance.MotDataContextDataContext = new MotDataContextDataContext();
                    
                }

                return _instance;
            }
        }

        public MotDataContextDataContext MotDataContextDataContext { get; set; }
    }
}
