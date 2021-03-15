using AutoMapper;
using Domain.ViewModel;
using Entity.Models;
using Newtonsoft.Json;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.EmployeeDomain
{
    public class EmployeeService: Profile, IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(
            IEmployeeRepository employeeRepository,
            IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
            CreateMap<EmployeeViewModel, Employee>();
        }

        public async Task<int> Add(EmployeeViewModel viewmodel)
        {
            var entity = new Employee();

            entity = JsonConvert.DeserializeObject<Employee>(JsonConvert.SerializeObject(viewmodel));

            return await _employeeRepository.Add(entity);
        }

        public async Task<EmployeeViewModel> Get(int Id)
        {
            var entity = await _employeeRepository.GetById(Id);
            return JsonConvert.DeserializeObject<EmployeeViewModel>(JsonConvert.SerializeObject(entity));
        }

        public async Task<int> Update(EmployeeViewModel viewmodel)
        {
            var entity = new Employee();
            entity = JsonConvert.DeserializeObject<Employee>(JsonConvert.SerializeObject(viewmodel));
            return await _employeeRepository.Update(entity);
        }
        public async Task Delete(EmployeeViewModel viewmodel)
        {
            var entity = new Employee();
            entity = JsonConvert.DeserializeObject<Employee>(JsonConvert.SerializeObject(viewmodel));
            await _employeeRepository.Remove(entity);
        }
    }
}
