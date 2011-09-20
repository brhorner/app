using System.Web;
using nothinbutdotnetstore.web.application.catalogbrowsing;

namespace nothinbutdotnetstore.web.core.stubs
{
    public class StubRequestFactory : ICreateRequests
    {
        public IContainRequestInformation create_request_from(HttpContext context)
        {
            return new StubRequest();
        }

        class StubRequest : IContainRequestInformation
        {
            #region Implementation of IContainRequestInformation

            public Department department
            {
                get { return new Department(); }
                set { throw new System.NotImplementedException(); }
            }

            #endregion
        }
    }
}