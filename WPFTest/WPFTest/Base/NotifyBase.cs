using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFTest.Base
{
    internal class NotifyBase : INotifyPropertyChanged
    {
        //通知属性基础类    model 模型变量 父类
        public event PropertyChangedEventHandler? PropertyChanged;

        public void NotifyChanged([CallerMemberName] string propName = "")
        {
            //全局通知
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }



    }
}
