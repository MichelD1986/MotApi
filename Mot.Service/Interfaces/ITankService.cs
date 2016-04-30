using Mot.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Mot.Service.Interfaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ITankService
    {

        [OperationContract]
        [WebInvoke(Method="GET", 
            ResponseFormat= WebMessageFormat.Json, 
            BodyStyle=WebMessageBodyStyle.Bare,
            UriTemplate = "GetPlayerTanks?server={server}&accountid={accountid}")]
        GetPlayerTanksModel GetPlayerTanks(string server, string accountid);
    }
 
}
