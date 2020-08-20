using Contracts;
using Entities;
using Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
   public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }


        public IEnumerable<Company> GetAllCompanies(bool trackChanges) => FindAll(trackChanges)
            .OrderBy(c => c.Name).ToList();

       
    }
}
