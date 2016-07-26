
using Grand.Core.Configuration;

namespace Grand.Plugin.Shipping.CanadaPost
{
    public class CanadaPostSettings : ISettings
    {
        public string Url { get; set; }

        public int Port { get; set; }

        public string CustomerId { get; set; }
    }
}