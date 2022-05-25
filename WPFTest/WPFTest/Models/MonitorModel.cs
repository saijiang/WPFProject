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

        private Index _number;
        public Index Number
        {
            get { return _number; }
            set { _number = value; this.NotifyChanged(); }
        }

        private string _style;
        public string Style { 
            get { return _style; }
            set { _style = value; this.NotifyChanged(); }
        }


        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; this.NotifyChanged(); }
        }


        private string _sex;
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; this.NotifyChanged(); }
        }

        
        private string _memo;
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; this.NotifyChanged(); }
        }



        public MonitorModel()
        {
           
        }
     

    }
}
