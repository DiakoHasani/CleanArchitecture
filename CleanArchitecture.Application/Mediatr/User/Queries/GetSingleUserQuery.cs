using CleanArchitecture.Application.Models.ViewModels.User;
using CleanArchitecture.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Mediatr.User.Queries
{
    public class GetSingleUserQuery : IRequest<UserViewModel>
    {
        public GetSingleUserQuery(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}
