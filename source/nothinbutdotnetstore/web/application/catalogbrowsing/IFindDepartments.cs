using System.Collections.Generic;

namespace nothinbutdotnetstore.web.application.catalogbrowsing
{
    public interface IFindDepartments
    {
        IEnumerable<Department> get_the_main_departments_in_the_store();
        IEnumerable<Department> get_departments_for_department(Department selected_department);
    }
}