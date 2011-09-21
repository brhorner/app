using System.Web;
using nothinbutdotnetstore.web.core.utility;

namespace nothinbutdotnetstore.web.core.stubs
{
    public class StubRequestFactory : ICreateRequests
    {
        public IContainRequestInformation create_request_from(HttpContext context)
        {
            return Stub.with<StubRequest>();
        }

        class StubRequest : IContainRequestInformation
        {
            public InputModel map_a<InputModel>()
            {
                throw new System.NotImplementedException();
            }
        }
    }
}