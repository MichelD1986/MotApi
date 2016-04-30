using Mot.Application.Executers;
using Mot.Application.Helpers;
using Mot.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mot.Application.Server.Executers
{
    public class GetServersExecuter : AExecuter
    {
        public GetServersExecuter()
            : base()
        {
            
        }

        protected override object DoExecute()
        {
            GetServersModel model = new GetServersModel();
            model.Servers = ServerUrlHelper.Instance.Urls.Select(r => r.Server).OrderBy(r => r).ToList();
            return model;
        }
    }
}
