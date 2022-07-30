using CleanArchitecture.Application.Models.ViewModels.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Mediatr.User.Commands
{
    public class NewUserCommand : IRequest<AddUserViewModel>
    {
        public NewUserCommand(AddUserViewModel model)
        {
            Model = model;
        }

        public AddUserViewModel Model { get; }
    }
}
