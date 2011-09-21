using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;
using nothinbutdotnetstore.web.application.catalogbrowsing;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{
    [Subject(typeof(ViewDepartmentsForDepartment))]
    public class ViewDepartmentsForDepartmentSpec
    {
        public abstract class concern : Observes<IOrchestrateAnApplicationFeature, ViewDepartmentsForDepartment>
        {
            
        }

        public class when_run : concern
        {
            Establish c = () =>
                              {
                                  the_department_departments = new List<Department>();
                                  request = fake.an<IContainRequestInformation>();
                                  display_engine = depends.on<IDisplayReports>();
                                  department_repository = depends.on<IFindDepartments>();

                                  department_repository.setup(x => x.get_departments_for_department(request.department))
                                        .Return(the_department_departments);
                              };

            Because b = () =>
                sut.process(request);

            It should_display_the_sub_departments = () =>
                display_engine.received(x => x.display(the_department_departments));

            static IEnumerable<Department> the_department_departments;
            static IContainRequestInformation request;
            static IDisplayReports display_engine;
            static IFindDepartments department_repository;
        }
    }
}
