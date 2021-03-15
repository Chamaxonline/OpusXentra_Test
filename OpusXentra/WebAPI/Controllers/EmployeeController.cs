using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.EmployeeDomain;
using Domain.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;
        public EmployeeController(
             IEmployeeService employeeService,
            IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("AddCompany")]
        public async Task<IActionResult> AddCompany(EmployeeViewModel viewModel)
        {
            try
            {
                return Ok(await _employeeService.Add(viewModel));
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }

        }
        [HttpGet]
        [Route("GetCompany")]
        public async Task<IActionResult> GetCompany(int id)
        {
            try
            {
                return Ok(await _employeeService.Get(id));
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }

        }

        [HttpPut]
        [Route("UpdateCompany")]
        public async Task<IActionResult> UpdateCompany(EmployeeViewModel viewModel)
        {
            try
            {
                return Ok(await _employeeService.Update(viewModel));
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }

        }

        [HttpDelete]
        [Route("DeleteCompany")]
        public async Task<IActionResult> DeleteCompany(EmployeeViewModel viewModel)
        {
            try
            {
                _employeeService.Delete(viewModel);
                return Ok("Successfully Deleted");
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }

        }
    }
}
