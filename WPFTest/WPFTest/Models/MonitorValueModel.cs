using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTest.Base;

namespace WPFTest.Models
{
    internal class MonitorValueModel: NotifyBase
    {
        public string ValueId { get; set; }
        public string ValueName { get; set; }
        public string Address { get; set; }
        public string DataType { get; set; }
        public string Unit { get; set; }
        private object _value;

        public object Value
        {
            get { return _value; }
            set
            {
                _value = value;
                this.NotifyChanged();
            }
        }


        // 设置 需要设置的报警信息

    }
}
