using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployees.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        
        public EmployeesController(IRepositoryManager repositoryManager,ILoggerManager logger, IMapper mapper)
        {
            _repository = repositoryManager;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetEmployeesForCompany(Guid companyId)
        {
            var company = _repository.Company.GetCompany(companyId, trackChanges: false);
            if (company == null) 
            { 
                _logger.LogInfo($"Company with id: {companyId} doesn't exist in the database.");
                return NotFound();
            }
            else
            {
                var employeesFromDb = _repository.Employee.GetEmployees(companyId, trackChanges: false);
                return Ok(employeesFromDb);
            }
        }

    }
}
