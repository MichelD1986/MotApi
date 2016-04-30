using Mot.Application.Executers;
using Mot.Application.Helpers;
using Mot.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mot.Application.Account.Executers
{
    public class GetPlayerTanksExecuter : AExecuter
    {
        public GetPlayerTanksExecuter(string server, string accountid)
            : base(server)
        {
            TanksHelper tankshelper = new Helpers.TanksHelper(Server);
            _accountid = accountid;
        }

        protected TanksHelper TanksHelper { get; set; }
        private string _accountid { get; set; }

        protected override object DoExecute()
        {

            GetPlayerTanksModel getplayerTanksModel = RestCallHelper.GetCall<GetPlayerTanksModel>(String.Format("account/tanks/?application_id={0}&account_id={1}", ServerUrlHelper.Instance.GetApplicationId(Server), _accountid));
            foreach(PlayerTankData playerTankData in getplayerTanksModel.Data.TanksDataList)
            {
                playerTankData.TankData = new TankData();
                playerTankData.TankData.level = 6666;
                
                //TanksHelper.GetTanksModel.Data.Tanks.First(r => r.tank_id == playerTankData.tank_id);
            }

            return getplayerTanksModel;
        }
    }
}
