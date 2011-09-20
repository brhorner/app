using System.Collections.Generic;

namespace nothinbutdotnetstore.specs
{
    public interface IDepartmentProvider
    {
        IEnumerable<IDepartment> get_all_departments();
    }
}