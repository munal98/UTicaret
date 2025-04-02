using Eticaret.Core.Entities;
using Eticaret.Data.Entities;
using System.Net;

namespace Eticaret.WebUI.Models
{
    public class CheckOutViewModel
    {
        public List<CartLine>? CartProducts { get; set; }
        public decimal TotalPrice { get; set; }
        public List<Address>? Addresses { get; set; }
    }
}
