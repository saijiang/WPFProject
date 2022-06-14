using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTest.Base;

namespace WPFTest.Models
{
    internal class DeviceModel: NotifyBase
    {
        // 编辑指令  打开编辑窗口
        private CommondBase _editCommand;
        public CommondBase EditCommand { 
            get { 
                if(_editCommand == null)
                {
                    _editCommand = new CommondBase();
                    _editCommand.DoExecute = new Action<object>(obj =>
                    {
                        WindowManager.ShowDialog("DeviceEditWindow",this);
                    });
                }
                return _editCommand; 
            } 
        }
        //左按钮
        private CommondBase _leftCommand;
        public CommondBase LeftCommand
        {
            get
            {
                if (_leftCommand == null)
                {
                    _leftCommand = new CommondBase();
                    _leftCommand.DoExecute = new Action<object>(obj =>
                    {
                       
                    });
                         
                }
                return _leftCommand;
            }
           
        }
        // 右按钮
        private CommondBase _rightCommand;
        public CommondBase RightCommand
        {
            get
            {
                if (_rightCommand == null)
                {
                    _rightCommand = new CommondBase();
                    _rightCommand.DoExecute = new Action<object>(obj =>
                    {
                       
                    });
                }
                return _rightCommand;
            }
        }


        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; this.NotifyChanged(); }
        }

        private string _sn;
        public string SN
        {
            get { return _sn; }
            set { _sn = value; this.NotifyChanged(); }
        }



        // 通信方式 或者 通信协议
        public int ProtocolType { set; get; }

        public ProtocolS7Model S7 { set; get; } // 某种协议 s7协议类型

        public ProtocolModbus Modbus { set; get; }

        public ObservableCollection<MonitorValueModel> MonitorValueList { get; set; } = new ObservableCollection<MonitorValueModel>();

        // 报警信息提示
    }


}
