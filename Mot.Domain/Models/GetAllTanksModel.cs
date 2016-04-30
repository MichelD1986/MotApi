using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mot.Domain.Models
{
    //http://stackoverflow.com/questions/25052293/deserialize-json-to-c-sharp-classes
    public class GetAllTanksModel
    {
        public string status { get; set; }

       [JsonProperty("data")]
        public TankDataContainer Data { get; set; }
        
    }
    [JsonObject(MemberSerialization.OptIn)]
    public class TankDataContainer
    {
        [JsonExtensionData]
        IDictionary<string, JToken> Tankdata { get; set; }

        public IEnumerable<TankData> Tanks
        {
            get
            {
                return Tankdata.Values.Select(i => i.ToObject<TankData>());
            }
        }
    }
   
    public class TankData
    {
        [JsonProperty("level")]
        public int level { get; set; }

        [JsonProperty("image")]
        public string image { get; set; }

        [JsonProperty("nation")]
        public string nation { get; set; }

        [JsonProperty("name_i18n")]
        public string name_i18n { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("tank_id")]
        public int tank_id { get; set; }
    }
   
}
