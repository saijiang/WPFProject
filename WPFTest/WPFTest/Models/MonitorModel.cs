using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        private int _recordTime;
        public int RecordTime
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


        public MonitorModel()
        {
           
        }
     

    }
}
