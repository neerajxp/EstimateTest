using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLayer
{
    public interface IUserDetails
    {
         int UserId { get; set; }
         string UserName { get; set; }
         string UserPassword { get; set; }

    }


}
