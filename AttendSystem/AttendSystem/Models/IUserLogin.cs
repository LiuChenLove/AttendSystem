using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendSystem.Models
{
    public interface IUserLogin
    {
        void SearchUser(UserLoginRequest request);

    }
}
