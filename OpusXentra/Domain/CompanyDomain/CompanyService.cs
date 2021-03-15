using AutoMapper;
using Domain.ViewModel;
using Entity.Models;
using Newtonsoft.Json;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CompanyDomain
{
    public class CompanyService : Profile, ICompanyService
    {
        private readonly ICompanyRepository _companiesRepository;
        private readonly IMapper _mapper;
        public CompanyService(
            ICompanyRepository companiesRepository,
            IMapper mapper)
        {
            _companiesRepository = companiesRepository;
            _mapper = mapper;
            CreateMap<CompanyViewModel, Company>();
        }

        public async Task<int> Add(CompanyViewModel viewmodel)
        {
            var company = new Company();

            company = JsonConvert.DeserializeObject<Company>(JsonConvert.SerializeObject(viewmodel));

            return await _companiesRepository.Add(company);
        }

        public async Task<CompanyViewModel> Get(int Id)
        {
            var company = await _companiesRepository.GetById(Id);

            return JsonConvert.DeserializeObject<CompanyViewModel>(JsonConvert.SerializeObject(company));
        }

        public async Task<int> Update(CompanyViewModel viewmodel)
        {
            var company = new Company();
            company = JsonConvert.DeserializeObject<Company>(JsonConvert.SerializeObject(viewmodel));
            return await _companiesRepository.Update(company);
        }

        public async void Delete(CompanyViewModel viewmodel)
        {
            var company = new Company();
            company = JsonConvert.DeserializeObject<Company>(JsonConvert.SerializeObject(viewmodel));
            await _companiesRepository.Remove(company);
        }
    }
}
