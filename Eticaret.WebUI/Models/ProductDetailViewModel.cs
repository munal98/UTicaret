using Eticaret.Data.Entities;
using System.Collections;

namespace Eticaret.WebUI.Models
{
    public class ProductDetailViewModel
    {
        public Product? Product { get; set; }

        public IEnumerable<Product>? RelatedProducts { get; set; }
    }
}
