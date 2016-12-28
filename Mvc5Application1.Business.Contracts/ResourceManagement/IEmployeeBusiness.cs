using Mvc5Application1.Data.Model.ResourceManagement;
using System.Collections.Generic;
using EmployeeBasicInfo = Mvc5Application1.Data.Model.hrm_t_employee_base;

namespace Mvc5Application1.Business.Contracts.ResourceManagement
{
    public interface IEmployeeBusiness
    {
        void SaveEmployee(EmployeeBasicInfo employee);

        List<EmployeeSearchResult> SearchEmployees(SearchEmployeeCriteria criteria);

        void DeleteEmployee(int id);

        void DeleteEmployee(string employeeCode);

        EmployeeBasicInfo GetEmployeeDetailsById(int id);
    }
}