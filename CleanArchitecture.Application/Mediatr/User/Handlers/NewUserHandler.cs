using AutoMapper;
using CleanArchitecture.Application.Mediatr.User.Commands;
using CleanArchitecture.Application.Models.ViewModels.User;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Mediatr.User.Handlers
{
    public class NewUserHandler : IRequestHandler<NewUserCommand, AddUserViewModel>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public NewUserHandler(IUserRepository userRepository,
            IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<AddUserViewModel> Handle(NewUserCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<TblUser>(request.Model);
            _userRepository.Add(user);
            await _userRepository.SaveChangesAsync();
            return request.Model;
        }
    }
}
