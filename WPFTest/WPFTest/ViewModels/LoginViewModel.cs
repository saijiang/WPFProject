using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFTest.Base;
using WPFTest.Models;
using WPFTest.Service;

namespace WPFTest.ViewModels
{
    internal class LoginViewModel
    {

        LoginService loginService = new LoginService();

        // 绑定model 
        public UserModel userModel { get; set; } = new UserModel();



        public  LoginViewModel()
        {
            userModel.UserName = "admin";
            userModel.Password = "123456";
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
        public CommondBase LoginCommand {

            get
            {
                if (_loginCommand == null)
                {
                    _loginCommand = new CommondBase();
                    _loginCommand.DoExecute = new Action<object>(obj =>
                    {

                        // MessageBox.Show("账户号{0}，密码{1}",userModel.UserName,userModel.Password,"提示");
                        // 这里传递的是整个 loginwindow 窗口 window

                        userModel.ErrorMessage = "";

                        try
                        {
                            if (loginService.CheckLogin(userModel.UserName, userModel.Password))
                            {
                                (obj as Window).DialogResult = true; // 和 app.cs 中文件相对应  为true 隐藏登录窗口 显示主窗口
                            }
                            else
                            {
                                userModel.ErrorMessage = "用户名或密码错误了";
                            }
                        }
                        catch (Exception ex)
                        {
                            //抛出异常信息
                          //  throw ex;
                            userModel.ErrorMessage = ex.Message;
                        }



                    });
                }
                return _loginCommand;
            }
        
        }

    }
}
