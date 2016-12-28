using Mvc5Application1.Data.Contracts;
using Mvc5Application1.Data.Model;
using EmployeeBasicInfo = Mvc5Application1.Data.Model.hrm_t_employee_base;

namespace Mvc5Application1.Data.Repository
{
    public class EmployeeRepository : Repository<EmployeeBasicInfo>, IEmployeeRepository
    {
        public EmployeeRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}