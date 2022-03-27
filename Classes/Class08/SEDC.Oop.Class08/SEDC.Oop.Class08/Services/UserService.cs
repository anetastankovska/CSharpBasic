using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class08.Services
{
    public class UserService : BaseService
    {
        public void Login()
        {
            ValidateInteger(1);
        }

        public void Register()
        {
            ValidateString("");
        }
    }
}
