using System.Collections.Generic;
using Machine.Specifications;
using developwithpassion.specifications.rhinomocks;
using developwithpassion.specifications.extensions;
using nothinbutdotnetstore.web.application.catalogbrowsing;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{
    [Subject(typeof(ViewTheMainDepartments))]
    public class ViewTheMainDepartmentsSpecs
    {
        public abstract class concern : Observes<IOrchestrateAnApplicationFeature,
                                            ViewTheMainDepartments>
        {
        }

        public class when_run : concern
        {
            //Arrange
            Establish c = () =>
            {
                request = fake.an<IContainRequestInformation>();
                department_repository = depends.on<IDepartmentProvider>();
            };

            //Act
            Because b = () =>
                sut.process(request);

            //Assert
            private It should_return_a_list_of_departments = () => 
                department_repository.received(x => x.get_all_departments());

            static IContainRequestInformation request;
            static IDepartmentProvider department_repository;
        }
    }
}