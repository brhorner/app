using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nothinbutdotnetstore.web.application.catalogbrowsing;

namespace nothinbutdotnetstore.web.core.stubs
{
    public class StubProductRepository : IFindProducts
    {
        public IEnumerable<Product> get_products_using(ViewTheProductsOfADepartmentInput input_model)
        {
            return Enumerable.Range(1, 100).Select(x => new Product() { name = x.ToString("Product 0") });
        }
    }
}
