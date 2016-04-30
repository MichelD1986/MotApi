using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mot.Domain.Models
{
    public class GetPlayerTanksModel
    {
        public string status { get; set; }

        [JsonProperty("data")]
        public PlayerVehicleContainer Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class PlayerVehicleContainer
    {
        
        [JsonExtensionData]
        IDictionary<string, JToken> TanksInGarage { get; set; }

        public List<PlayerTankData> TanksDataList
        {
            get
            {
                return TanksInGarage.First().Value.Select(i => i.ToObject<PlayerTankData>()).ToList();
            }
            set
            {
                
            }
        }
    }

    public class PlayerTankData
    {
        [JsonProperty("mark_of_mastery")]
        public string mark_of_mastery { get; set; }

        [JsonProperty("tank_id")]
        public int tank_id { get; set; }

        [JsonProperty("statistics")]
        public Statistics Statistics { get; set; }

        public TankData TankData { get; set; }

    }

    public class Statistics
    {
        [JsonProperty("wins")]
        public string wins { get; set; }

        [JsonProperty("battles")]
        public string battles { get; set; }

    }
}
