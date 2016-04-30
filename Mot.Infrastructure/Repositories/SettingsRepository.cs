using Mot.Infrastructure.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mot.Infrastructure.Repositories
{
    public class SettingsRepository
    {
        public Setting GetSettings ()
        {
            using (MotDataContextDataContext context = new MotDataContextDataContext())
            {
                return context.Settings.First();
            }
        }
    }
}
