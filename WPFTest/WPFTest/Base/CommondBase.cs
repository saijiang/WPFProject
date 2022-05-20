using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFTest.Base
{
    internal class CommondBase : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            // throw new NotImplementedException();
            return true;//  意思是关联绑定的按钮是否可以点击
        }

        public void Execute(object? parameter)
        {
            // throw new NotImplementedException();
            DoExecute?.Invoke(parameter);// 使用委托代理 将方法暴漏出来
        }

        /// <summary>
        /// 声明一个事件
        /// </summary>
        public Action<Object>? DoExecute { get; set; }// 委托
    }
}
