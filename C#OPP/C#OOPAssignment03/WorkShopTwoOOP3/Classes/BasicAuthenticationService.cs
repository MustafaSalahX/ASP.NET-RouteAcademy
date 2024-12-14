using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopTwoOOP3.Interfaces;
using WorkShopTwoOOP3.Utilities;

namespace WorkShopTwoOOP3.Classes
{
    public class BasicAuthenticationService : IAuthenticationService
    {

        public bool AuthenticateUser(string username, string password)
        {
            if(username == AuthConstants.userName1 &&  password == AuthConstants.password1)
            {
                return true;
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if(username == AuthConstants.userName2 &&  role == AuthConstants.role2)
            {
                return true;
            }
            return false;
        }
    }
}
