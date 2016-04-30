using Mot.Domain.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace Mot.Application.Helpers
{
    public class RestCallHelper
    {
        public RestCallHelper(string server)
        {
            _server = server;
        }

        private string _server;

        public T GetCall<T>(string url)
        {
            HttpWebRequest request = WebRequest.Create(String.Format("{0}{1}", ServerUrlHelper.Instance.GetUrlPrefix(_server), url)) as HttpWebRequest;
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception(String.Format(
                    "Server error (HTTP {0}: {1}).",
                    response.StatusCode,
                    response.StatusDescription));
                
                using (var reader = new System.IO.StreamReader(response.GetResponseStream()))
                {
                    string responseText = reader.ReadToEnd();

                    object objResponse = JsonConvert.DeserializeObject<T>(responseText);
                    return (T)Convert.ChangeType(objResponse, typeof(T));
                }
            }
        }
    }
}
