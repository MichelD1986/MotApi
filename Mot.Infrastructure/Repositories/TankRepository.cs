using Mot.Domain.Models;
using Mot.Infrastructure.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mot.Infrastructure.Repositories
{
    public class TankRepository
    {
        public void SaveNewTanks(GetAllTanksModel getTanksModel)
        {
            var tanks = DBContextHelper.Instance.MotDataContextDataContext.Tanks.ToList();
            foreach (TankData tankModelData in getTanksModel.Data.Tanks)
            {
                if(!tanks.Any(r => r.TankId == tankModelData.tank_id ))
                {
                    Tank tank = new Tank();
                    tank.TankId = tankModelData.tank_id;
                    tank.ImageUrl = tankModelData.image;
                    tank.Name = tankModelData.name_i18n;
                    tank.Nation = tankModelData.nation;
                    tank.Tier = tankModelData.level;
                    tank.Type = tankModelData.type;
                  
                    DBContextHelper.Instance.MotDataContextDataContext.Tanks.InsertOnSubmit(tank);
                }
            }
            DBContextHelper.Instance.MotDataContextDataContext.SubmitChanges();
        }
    }
}
