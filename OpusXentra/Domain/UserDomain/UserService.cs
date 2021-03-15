using AutoMapper;
using Entity.Models;
using Newtonsoft.Json;
using Repository.Interfaces;
using SmartERP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UserDomain
{
    public class UserService:Profile,IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository,IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            CreateMap<ApplicationUserModel, ApplicationUser>();
        }

        public Task<int> Add(ApplicationUserModel viewmodel)
        {
            throw new NotImplementedException();
        }

        public Task Delete(ApplicationUserModel viewmodel)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUserModel> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<string> Update(ApplicationUserModel viewmodel)
        {
            var entity = new ApplicationUser();
            entity = JsonConvert.DeserializeObject<ApplicationUser>(JsonConvert.SerializeObject(viewmodel));
            return await _userRepository.Update(entity);
        }
    }
}
