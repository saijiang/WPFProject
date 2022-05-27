using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using WPFTest.Base;

namespace WPFTest.Models
{
    internal class MonitorModel: NotifyBase
    {

        private Index _index;
        public Index Index
        {
            get { return _index; }
            set { _index = value; this.NotifyChanged(); }
        }

        private string _dataType;
        public string DataType { 
            get { return _dataType; }
            set { _dataType = value; this.NotifyChanged(); }
        }


        private string _recordTime;
        public string RecordTime
        {
            get { return _recordTime; }
            set { _recordTime = value; this.NotifyChanged(); }
        }


        private string _deviceName;
        public string DeviceName
        {
            get { return _deviceName; }
            set { _deviceName = value; this.NotifyChanged(); }
        }

        
        private string _value;
        public string Value
        {
            get { return _value; }
            set { _value = value; this.NotifyChanged(); }
        }

        private string _status;
        public string Status { get { return _status; } set { _status = value; this.NotifyChanged(); } }




        //事件绑定

        private CommondBase _detailCommand;
        public CommondBase DetailCommand
        {
            get
            {

                if (_detailCommand == null)
                {
                    _detailCommand = new CommondBase();
                    _detailCommand.DoExecute = new Action<object>(ShowDetail);
                }

                return _detailCommand;
            }

        }

        // 详情点击委托方法
        private void ShowDetail(object obj)
        {
            MessageBox.Show(this.Index.ToString());
        }





        public MonitorModel()
        {
           
        }
     

    }
}
