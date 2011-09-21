using System.Collections.Generic;
using Machine.Specifications;
using Rhino.Mocks;
using developwithpassion.specifications.rhinomocks;
using developwithpassion.specifications.extensions;
using nothinbutdotnetstore.web.application.catalogbrowsing;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{
    [Subject(typeof(ViewTheProductsOfADepartment))]
    public class ViewTheProductsOfADepartmentSpecs
    {
        public abstract class concern : Observes<IOrchestrateAnApplicationFeature,
                                            ViewTheProductsOfADepartment>
        {
        }

        public class when_run : concern
        {
            Establish c = () =>
            {

                product_repository = depends.on<IFindProducts>();
                display_engine = depends.on<IDisplayReports>();

                request = fake.an<IContainRequestInformation>();

                var input_model = new ViewTheProductsOfADepartmentInput();
                request.setup(x => x.map_a<ViewTheProductsOfADepartmentInput>())
                    .Return(input_model);

                department_products = new List<Product> { new Product() };

                product_repository.setup(x => x.get_products_using(input_model))
                    .Return(department_products);
            };

            Because b = () =>
                sut.process(request);

            It show_products_in_a_department = () =>
                display_engine.received(x => x.display(department_products));

            static IFindProducts product_repository;
            static IDisplayReports display_engine;
            static IContainRequestInformation request;
            static IEnumerable<Product> department_products;
        }
    }
}