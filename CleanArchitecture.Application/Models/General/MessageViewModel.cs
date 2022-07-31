using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Models.General
{
    public class MessageViewModel
    {
        public int Code { get; set; }
        public string Message { get; set; } = "";
        public bool Result { get; set; } = false;
    }
}
