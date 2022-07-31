using AutoMapper;
using CleanArchitecture.Application.Mediatr.User.Commands;
using CleanArchitecture.Application.Models.General;
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
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, MessageViewModel>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UpdateUserHandler(IUserRepository userRepository,
            IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<MessageViewModel> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.Model.Id);
            if (user == null)
            {
                return new MessageViewModel { Message = "چنین کاربری یافت نشد" };
            }

            _mapper.Map(request.Model, user);
            _userRepository.Update(user);
            if (await _userRepository.SaveChangesAsync() > 0)
            {
                return new MessageViewModel
                {
                    Result = true,
                    Message = "عملیات با موفقیت انجام شد"
                };
            }
            else
            {
                return new MessageViewModel { Message = "خطای رخ داده است" };
            }
        }
    }
}
