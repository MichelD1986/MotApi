using Mot.Domain.Models;
using Mot.Infrastructure.DBModel;
using Mot.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mot.Application.Helpers
{
    public class TanksHelper
    {
        public TanksHelper(string server)
        {
            _server = server;
            
            if (GetTanksModel == null)
            {
                GetAllTanks();
                new TankRepository().SaveNewTanks(GetTanksModel);
            }
        }

        private string _server;

        public void GetAllTanks()
        {
            RestCallHelper restcallHelper = new RestCallHelper("eu");
            GetTanksModel = restcallHelper.GetCall<GetAllTanksModel>(String.Format
                        ("encyclopedia/tanks/?application_id={0}&fields=name_i18n,level,tank_id,nation,level,image,type", ServerUrlHelper.Instance.GetApplicationId(_server)));
        }
        public static GetAllTanksModel GetTanksModel { get; set; }
    }
}
