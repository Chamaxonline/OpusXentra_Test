using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.CompanyDomain;
using Domain.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        private readonly IMapper _mapper;

        public CompanyController(
            ICompanyService companyService,
            IMapper mapper)
        {
            _companyService = companyService;
            _mapper = mapper;
        }

        [HttpPost]
        [Authorize]
        [Route("AddCompany")]
        public async Task<IActionResult> AddCompany(CompanyViewModel viewModel)
        {
            try
            {
                return Ok(await _companyService.Add(viewModel));
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
                return Ok(await _companyService.Get(id));
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }

        }

        [HttpPut]
        [Route("UpdateCompany")]
        public async Task<IActionResult> UpdateCompany(CompanyViewModel viewModel)
        {
            try
            {
                return Ok(await _companyService.Update(viewModel));
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }

        }

        [HttpDelete]
        [Route("DeleteCompany")]
        public async Task<IActionResult> DeleteCompany(CompanyViewModel viewModel)
        {
            try
            {
                _companyService.Delete(viewModel);
                return Ok("Successfully Deleted");
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }

        }
    }
}
