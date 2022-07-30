using AutoMapper;
using CleanArchitecture.Application.Models.ViewModels.User;
using CleanArchitecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region User
            CreateMap<UserViewModel, TblUser>();
            CreateMap<TblUser, UserViewModel>();

            CreateMap<AddUserViewModel, TblUser>();
            CreateMap<TblUser, AddUserViewModel>();
            #endregion
        }
    }
}
