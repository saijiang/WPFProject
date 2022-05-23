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
            // 这里设置一个固定的用户名账号 为 admin 密码 123456
            if(userName == "admin" && password == "123456")
            {
                return true;
            }
            else
            return sqlServerAccess.CheckUserInfo(userName, password);
        }
    }
}
