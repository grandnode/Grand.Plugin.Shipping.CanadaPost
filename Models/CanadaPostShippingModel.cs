using Grand.Web.Framework;

namespace Grand.Plugin.Shipping.CanadaPost.Models
{
    public class CanadaPostShippingModel
    {
        [GrandResourceDisplayName("Plugins.Shipping.CanadaPost.Fields.Url")]
        public string Url { get; set; }

        [GrandResourceDisplayName("Plugins.Shipping.CanadaPost.Fields.Port")]
        public int Port { get; set; }

        [GrandResourceDisplayName("Plugins.Shipping.CanadaPost.Fields.CustomerId")]
        public string CustomerId { get; set; }
    }
}