﻿using Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
   public interface IEmployeeRepository
    {
        IEnumerable<Company> GetAllCompanies(bool trackChanges);
    }
}
