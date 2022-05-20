using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPFTest.Views; //引用文件

namespace WPFTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //后台代码
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // 首先是登陆窗口  然后才是主窗口
            if(new LoginWindow().ShowDialog() == true)
            {
                new MainWindow().ShowDialog();//模态窗口形式打开窗口
            }
            Application.Current.Shutdown();//关闭窗口之后 整个应用完全是退出的状态
        }
    }
}
