using AutoMapper;
using CleanArchitecture.Application.Mediatr.User.Queries;
using CleanArchitecture.Application.Models.ViewModels.User;
using CleanArchitecture.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Mediatr.User.Handlers
{
    public class GetSingleUserHandler : IRequestHandler<GetSingleUserQuery, UserViewModel>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public GetSingleUserHandler(IUserRepository userRepository,
            IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<UserViewModel> Handle(GetSingleUserQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<UserViewModel>(await _userRepository.GetByIdAsync(request.Id));
        }
    }
}
