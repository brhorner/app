using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using developwithpassion.specifications.rhinomocks;
using nothinbutdotnetstore.web.core.stubs;
using nothinbutdotnetstore.web.core.utility;

namespace nothinbutdotnetstore.specs
{
    [Subject(typeof (Stub))]
    public class StubSpec
    {
        public abstract class concern : Observes
        {

        }

        public class when_requesting_a_stub_from_the_stub_generator : concern
        {

            private Because b = () => result = Stub.with<StubDisplayEngine>();

            private It should_return_the_stub_to_the_caller = () =>
                                                                 result.ShouldBeOfType<StubDisplayEngine>();

            static StubDisplayEngine result;
        }
    }
}
