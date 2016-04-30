﻿using Mot.Application.Account.Executers;
using Mot.Domain.Models;
using Mot.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Mot.Service.Implementations
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class AccountService : IAccountService
    {
        public GetAccountsModel GetAccounts(string server, string nickname)
        {
            GetAccountsExecuter executer = new GetAccountsExecuter(server, nickname);
            return executer.Execute() as GetAccountsModel;
        }
    }
}