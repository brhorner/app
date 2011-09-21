using System.Collections.Generic;

namespace nothinbutdotnetstore.web.application.catalogbrowsing
{
    public interface IFindProducts
    {
        IEnumerable<Product> get_products_using(ViewTheProductsOfADepartmentInput input_model);
    }
}