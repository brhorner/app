using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.application.catalogbrowsing
{
    public class ViewDepartmentsForDepartment : IOrchestrateAnApplicationFeature
    {
        IFindDepartments department_repository;
        IDisplayReports display_engine;

        public ViewDepartmentsForDepartment(IFindDepartments department_repository, IDisplayReports display_engine)
        {
            this.department_repository = department_repository;
            this.display_engine = display_engine;
        }

        #region Implementation of IOrchestrateAnApplicationFeature

        public void process(IContainRequestInformation request)
        {
            display_engine.display(department_repository.get_departments_for_department(request.department));
        }

        #endregion
    }
}