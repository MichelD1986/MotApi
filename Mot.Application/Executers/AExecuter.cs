using Mot.Application.Helpers;
using System;

namespace Mot.Application.Executers
{
    public abstract class AExecuter: IExecuter
    {
        public AExecuter()
        {

        }

        public AExecuter(string server)
        {
            Server = server;
        }

        public object Execute()
        {
            if(!string.IsNullOrEmpty(this.Server))
                RestCallHelper = new RestCallHelper(this.Server);

            return this.DoExecute();
        }

        protected abstract object DoExecute();
        protected RestCallHelper RestCallHelper { get; set; }

        protected string Server { get; set; }

        protected string ApiParameters {get;set;}
        
    }
}
