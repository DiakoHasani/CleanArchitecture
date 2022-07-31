using CleanArchitecture.Application.Models.General;
using CleanArchitecture.Application.Models.ViewModels.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Mediatr.User.Commands
{
    public class UpdateUserCommand : IRequest<MessageViewModel>
    {
        public UpdateUserCommand(UpdateUserViewModel model)
        {
            Model = model;
        }

        public UpdateUserViewModel Model { get; }
    }
}
