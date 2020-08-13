using Contracts;
using Entities;
using Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
   public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }
    }
}
