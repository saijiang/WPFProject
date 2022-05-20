using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTest.Base;

namespace WPFTest.Models
{
    // userModel model 模型类 继承于 通知的类 NotifyBase
    internal class UserModel:NotifyBase
    {
        private string _userName;
        public string UserName {
            get { return _userName; }
            set {
                _userName = value;
                this.NotifyChanged(); // 调用全局通知函数
            } 
        }

        private string _password;
        public string Password {
            get { return _password; }
            set { _password = value; this.NotifyChanged(); }
        }
    }
}
