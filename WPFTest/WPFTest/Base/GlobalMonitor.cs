using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTest.Models;
using WPFTest.Service;

namespace WPFTest.Base
{
    internal class GlobalMonitor
    {
        public static ObservableCollection<DeviceModel> DeviceList { get; set; } = new ObservableCollection<DeviceModel>();
        bool isRunning = true;
        Task mainTask = null;

        public void Start()
        {
            Task.Run(async () =>
            {
                // 获取设备信息
                DeviceService deviceService = new DeviceService();
                var list = deviceService.GetDevices();
                if (list != null)
                {
                    DeviceList = new ObservableCollection<DeviceModel> (list);
                    while (isRunning)
                    {
                        await Task.Delay(100);
                        foreach(var item in DeviceList)
                        {
                            if (item.ProtocolType == 2)
                            {
                                // 创建S7通信对象

                            }
                        }
                    }

                }
            });
        }
    }
}
