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
    internal class MainViewModel
    {

       public MainModel mainModel { get; set; } = new MainModel();
        
        // 关闭 按钮事件
        private CommondBase _closeCommand;
        public CommondBase CloseCommand
        {
            get {
                if(_closeCommand == null)
                {
                    _closeCommand = new CommondBase();
                    _closeCommand.DoExecute = new Action<object>(obj =>
                    {

                        (obj as System.Windows.Window).DialogResult = true;
                        //(obj as System.Windows.Window).Close();  第二种写法

                    });
                }
                return _closeCommand;
            }
            set { _closeCommand = value; }
        }
        // 窗口最小化
        private CommondBase _minWindows;
        public CommondBase MinWindows
        {
            get {
                if (_minWindows == null)
                {
                    _minWindows = new CommondBase();
                    _minWindows.DoExecute = new Action<object>(obj =>
                    {
                        (obj as System.Windows.Window).WindowState = WindowState.Minimized;
                    });
                }
                return _minWindows; 
            }
            set { _minWindows = value; }
        }

        // 窗口 最大化 或者 还原窗口原来的大小
        private CommondBase _bigWindows;
        public CommondBase BigWindows
        {
            get { 
                if(_bigWindows == null)
                {
                    _bigWindows = new CommondBase();
                    _bigWindows.DoExecute = new Action<object>(obj =>
                    {
                        if ((obj as System.Windows.Window).WindowState == WindowState.Maximized)
                        {
                            (obj as System.Windows.Window).WindowState = WindowState.Normal;
                            mainModel.BigNormalIcon = "&#xea6b;";
                        }
                        else
                        {
                            (obj as System.Windows.Window).WindowState = WindowState.Maximized;
                            mainModel.BigNormalIcon = "&#xe645;";

                        }
                    });
                }
                return _bigWindows; 
            }
            set { _bigWindows = value; }
        }

        // 四个 tabbar 按钮事件
        private CommondBase _menuItemCommand;
        public CommondBase MenuItemCommand
        {
            get { 
                if(_menuItemCommand == null)
                {
                    _menuItemCommand = new CommondBase();
                    _menuItemCommand.DoExecute = new Action<object>(obj =>
                    {
                        //反射 拿到对应的页面
                        Type type = Type.GetType(obj.ToString());
                        this.mainModel.MainContent = (System.Windows.UIElement)Activator.CreateInstance(type);
                    });
                }
                return _menuItemCommand;
            }
            set { _menuItemCommand = value; }
        }

        public void NavPage(string name)
        {
            //反射 拿到对应的页面
            Type type = Type.GetType(name);
            this.mainModel.MainContent = (System.Windows.UIElement)Activator.CreateInstance(type);
        }

        // ctor 可以自动插入构造函数
        public MainViewModel()
        {
            // 从全局缓存中获取用户信息 设置给页面展示
            mainModel.BigNormalIcon = "&#xea6b;";
            //设置默认页面
            this.NavPage("WPFTest.Views.MonitorView");

            Task.Run(async () =>
            {
                while (true)
                {
                    await Task.Delay(500);
                    string nowTime = DateTime.Now.ToString("yyyy-MM-dd HH-mm ss");
                    mainModel.Time = nowTime;
                }
            });
        }



    }
}
