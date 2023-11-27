using Crud1.Entities;

namespace Crud1.Models
{
    public class ProductListViewModel
    {
        public IEnumerable<ProductViewModel> Products { get; set; }
        public IEnumerable<CategoryViewModel> Categories { get; set; }

    }
}
