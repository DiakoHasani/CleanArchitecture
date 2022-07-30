using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Entities
{
    public class TblUser : BaseEntity
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
    }
}
