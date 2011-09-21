using nothinbutdotnetstore.web.application.catalogbrowsing;
using nothinbutdotnetstore.web.core;
using nothinbutdotnetstore.web.core.stubs;

namespace nothinbutdotnetstore.specs
{
    public class ViewTheProductsOfADepartment : IOrchestrateAnApplicationFeature
    {
        private readonly IDisplayReports display_engine;
        private readonly IFindProducts product_repository;
        public ViewTheProductsOfADepartment(IDisplayReports display_engine, IFindProducts product_repository)
        {
            this.display_engine = display_engine;
            this.product_repository = product_repository;
        }

        public ViewTheProductsOfADepartment()
            : this(Stub.with<StubDisplayEngine>(), Stub.with<StubProductRepository>())
        {
        }

        public void process(IContainRequestInformation request)
        {
            var products = product_repository.get_products_using(request.map_a<ViewTheProductsOfADepartmentInput>());
            display_engine.display(products);
        }

    }
}