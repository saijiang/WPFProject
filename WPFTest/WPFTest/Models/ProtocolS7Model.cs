using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTest.Models
{
    internal class ProtocolS7Model
    {
        //S7 协议 
        public string IP { get; set; }
        public int Port { get; set; } = 102;
        public int Rock { get; set; } = 0;
        public int Slot { get; set; } = 1;
    }
}
