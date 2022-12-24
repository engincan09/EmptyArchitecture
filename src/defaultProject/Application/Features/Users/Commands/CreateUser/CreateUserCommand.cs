using Application.Features.Users.Dtos;
using Application.Features.Users.Rules;
using Application.Services.Repositories.Users;
using AutoMapper;
using Domain.Entities.Users;
using MediatR;

namespace Application.Features.Users.Commands.CreateUser
{
    public partial class CreateUserCommand : IRequest<CreateUserDto>
    {
        public string Name { get; set; }

        public class CreateBrandCommandHandler : IRequestHandler<CreateUserCommand, CreateUserDto>
        {
            private readonly IUserRepository _brandRepository;
            private readonly IMapper _mapper;
            private readonly UserBusinessRules _userBusinessRules;

            public CreateBrandCommandHandler(IUserRepository userRepository, IMapper mapper, UserBusinessRules userBusinessRules)
            {
                _brandRepository = userRepository;
                _mapper = mapper;
                _userBusinessRules = userBusinessRules;
            }

            public async Task<CreateUserDto> Handle(CreateUserCommand request, CancellationToken cancellationToken)
            {
                User mappedUser = _mapper.Map<User>(request);
                User createdBrand = await _brandRepository.AddAsync(mappedUser);
                CreateUserDto createdBrandDto = _mapper.Map<CreateUserDto>(createdBrand);

                return createdBrandDto;

            }
        }
    }
}
