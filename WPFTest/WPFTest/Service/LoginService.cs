using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTest.DataAccess;

namespace WPFTest.Service
{
    internal class LoginService
    {
        SqlServerAccess sqlServerAccess = new SqlServerAccess();
        public bool CheckLogin(string userName, string password)
        {
            return sqlServerAccess.CheckUserInfo(userName, password);
        }
    }
}
