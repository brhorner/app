using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using developwithpassion.specifications.rhinomocks;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{
    [Subject(typeof(ViewRegistry))]  
    public class ViewRegistrySpecs
    {
        public abstract class concern : Observes<IFindViewForModel, ViewRegistry>
        {

        }

        public class when_finding_a_view_for_a_model : concern
        {
            Establish c = () =>
            {
                //request = fake.an<IContainRequestInformation>();
                //depends.on<RequestMatch>(x => x.Equals(request));
            };

            Because b = () =>
                result = sut.get_view_for(new FakeViewModel());


            It should_return_the_view = () =>
                result.ShouldBeOfType<FakeView>();

            private static IDisplayAReport result;


            //static bool result;
            //static IContainRequestInformation request;
        }

    }

    internal class FakeView : IDisplayAReport
    {
        private FakeViewModel view_model;

        public FakeView(FakeViewModel viewModel)
        {
            view_model = viewModel;
        }

        public void render()
        {
            throw new NotImplementedException();
        }
    }


    internal class FakeViewModel
    {
    }
}
