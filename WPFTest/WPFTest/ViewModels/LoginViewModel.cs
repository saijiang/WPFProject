using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFTest.Base;
using WPFTest.Models;

namespace WPFTest.ViewModels
{
    internal class LoginViewModel
    {
        // 绑定model 
        public UserModel userModel { get; set; } = new UserModel();

        public LoginViewModel()
        {
            userModel.UserName = "张三";
        }

        // 关闭窗口事件 和 xmal 绑定一定要是属性才可以
        private CommondBase _closeCommand;
        public CommondBase CloseCommand {
            get
            {
                if(_closeCommand == null)
                {
                    _closeCommand = new CommondBase();
                    _closeCommand.DoExecute = new Action<object>(obj =>
                    {
                            Console.WriteLine("传递的参数{0}",obj);
                        string str = obj.ToString();
                        if(str == "绑定的事件传递的参数")
                        {
                            Application.Current.Shutdown();//关闭窗口之后 整个应用完全是退出的状态
                        }
                    });

                }
                return _closeCommand;
            }
        }
        //登陆事件
        private CommondBase _loginCommand;
        public CommondBase LoginCommand { get; set; }

    }
}
