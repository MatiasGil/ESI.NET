using ESI.NET.Enumerations;

namespace ESI.NET
{
    public class EsiConfig
    {
        public string CallbackUrl { get; set; }
        public string ClientId { get; set; }
        public DataSource DataSource { get; set; }
        public string EsiUrl { get; set; }
        public string SecretKey { get; set; }
        public string UserAgent { get; set; }
    }
}