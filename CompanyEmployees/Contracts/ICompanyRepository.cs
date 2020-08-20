using Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAllCompanies(bool trackChanges);
    }
}
