using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Repositories;
using CleanArchitecture.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<TblUser>, IUserRepository
    {
        public UserRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
