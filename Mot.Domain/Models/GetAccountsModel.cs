namespace Mot.Domain.Models
{
    public class GetAccountsModel
    {
        public string status { get; set; }
        public long count { get; set; }

        public Data[] data { get; set; }

    }

    public class Data 
    {
        public string nickname { get; set; }
        public long account_id { get; set; } 
    }
}
