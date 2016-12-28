using Mvc5Application1.Business.Contracts.ResourceManagement;
using Mvc5Application1.Data.Contracts;
using Mvc5Application1.Data.Model;
using Mvc5Application1.Data.Model.ResourceManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeBasicInfo = Mvc5Application1.Data.Model.hrm_t_employee_base;

namespace Mvc5Application1.Business.ResourceManagement
{
    public class EmployeeBusiness : IEmployeeBusiness
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<EmployeeBasicInfo> _employeeRepos;

        public EmployeeBusiness(IUnitOfWork unitOfWork,
            IEmployeeRepository employeeRepository,
            IRepository<EmployeeBasicInfo> employeeRepos)
        {
            _employeeRepository = employeeRepository;
            _employeeRepos = employeeRepos;
            _unitOfWork = unitOfWork;
        }

        public void DeleteEmployee(int id)
        {
            _employeeRepository.Delete(id);
            _unitOfWork.SaveChanges();
        }

        public void DeleteEmployee(string employeeCode)
        {
            try
            {
                var deleteSql = string.Format("DELETE FROM [dbo].[hrm_t_employee_base] WHERE employee_code = {0}", employeeCode);

                using (var dbContext = new DBContextBase())
                {
                    dbContext.Database.ExecuteSqlCommand(deleteSql);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EmployeeBasicInfo GetEmployeeDetailsById(int id)
        {
            return _employeeRepos.GetById(id);
        }

        public void SaveEmployee(EmployeeBasicInfo employee)
        {
            _employeeRepos.Add(employee);
            _unitOfWork.SaveChanges();
        }

        public List<EmployeeSearchResult> SearchEmployees(SearchEmployeeCriteria criteria)
        {
            return _employeeRepository.ExecuteSearch<EmployeeSearchResult>("SearchEmployees", criteria);
        }

        public List<EmployeeBasicInfo> GetAllEmployees()
        {
            return _employeeRepos.GetAll().ToList();
        }
    }
}