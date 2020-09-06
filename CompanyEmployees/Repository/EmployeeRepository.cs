using Contracts;
using Entities;
using Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
   public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public Employee GetEmployee(Guid companyId, Guid id, bool trackChanges) =>
            FindByCondition(x => x.CompanyId.Equals(companyId) && x.Id == id, trackChanges).SingleOrDefault();
       

        public IEnumerable<Employee> GetEmployees(Guid companyId, bool trackChanges)
        {
           return FindByCondition(s => s.CompanyId.Equals(companyId), trackChanges).OrderBy(s => s.Name);
        }

        public void CreateEmployeeForCompany(Guid companyId, Employee employee)
        {
            employee.CompanyId = companyId;
            Create(employee);
        }
    }
}
