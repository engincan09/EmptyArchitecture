using Application.Services.Repositories.Users;
using Core.CrossCuttingConcerns.Exceptions;
using Core.Persistence.Paging;
using Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Users.Rules
{
    public class UserBusinessRules
    {
        private readonly IUserRepository _userRepository;

        public UserBusinessRules(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task UserNameCanNotBeDuplicatedWhenInserted(string userName)
        {
            IPaginate<User> result = await _userRepository.GetListAsync(b => b.UserName == userName && b.DataStatus == Core.Persistence.Repositories.DataStatus.Activated);
            if (result.Items.Any()) throw new BusinessException("Böyle bir kullanıcı adı zaten mevcut!");
        }

 
    }
}
