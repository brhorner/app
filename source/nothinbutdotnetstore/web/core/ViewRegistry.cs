using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nothinbutdotnetstore.web.core
{
    public class ViewRegistry : IFindViewForModel
    {
        public IDisplayAReport get_view_for<ReportModel>(ReportModel report_model)
        {
            throw new NotImplementedException();
        }
    }
}
