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
    public class GetAccountsExecuter : AExecuter
    {
        public GetAccountsExecuter(string server, string nickname) :base(server)
        {
            _nickname = nickname;
        }

        private string _nickname { get; set; }


        protected override object DoExecute()
        {
            ApiParameters = String.Format("account/list/?application_id={0}&search={1}", ServerUrlHelper.Instance.GetApplicationId(Server), _nickname);
            GetAccountsModel model = RestCallHelper.GetCall<GetAccountsModel>(ApiParameters);
            return model;
        }
    }
}
