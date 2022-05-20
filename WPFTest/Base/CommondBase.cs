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
            return true;
        }

        public void Execute(object? parameter)
        {
            // throw new NotImplementedException();
            DoExecute?.Invoke(parameter);
        }

        public Action<Object>? DoExecute { get; set; }// 委托
    }
}
