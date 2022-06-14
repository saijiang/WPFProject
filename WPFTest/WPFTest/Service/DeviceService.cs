using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTest.DataAccess;
using WPFTest.Models;

namespace WPFTest.Service
{
    internal class DeviceService
    {
        // 通过对象 访问数据库里的信息
        SqlServerAccess sqlServerAccess = new SqlServerAccess();

        public List<DeviceModel> GetDevices()
        {
            List<DeviceModel> deviceModels = new List<DeviceModel>();
            // 获取设备信息
            var d_info = sqlServerAccess.GetDevices();
            foreach(var item in d_info.AsEnumerable())
            {
                DeviceModel deviceModel = new DeviceModel();
                deviceModel.Name = item.Field<string>("d_name");
                deviceModel.SN = item.Field<string>("d_sn");
                deviceModel.ProtocolType = (int)item.Field<Int64>("comm_type");

                deviceModels.Add(deviceModel);

                // 根据每条设备信息 获取对应的（协议信息 / 点位）
                var p_info = sqlServerAccess.GetProtocolSettings(item.Field<string>("d_id"),deviceModel.ProtocolType);
                if (deviceModel.ProtocolType == 1) // Mobdus
                {
                    deviceModel.Modbus = new ProtocolModbus()
                    {
                        IP = item.Field<string>("d_ip"),
                        Port = (int)item.Field<Int64>("d_port"),
                        // 其他属性
                        BaudRate = (int)item.Field<Int64>("baudrate")

                    };

                }else if (deviceModel.ProtocolType == 2)// s7
                {
                    deviceModel.S7 = new ProtocolS7Model()
                    {
                        IP = item.Field<string>("d_ip"),
                        Port = (int)item.Field<Int64>("d_port"),
                        Rock = (int)item.Field<Int64>("d_rock"),
                        Slot = (int)item.Field<Int64>("d_slot")
                    };
                }


                // 获取点位 信息
                var v_info = sqlServerAccess.GetMonitorValues(item.Field<string>("d_id"));

                List<MonitorValueModel> vList = (from q in v_info.AsEnumerable()
                                                 select new MonitorValueModel
                                                 {
                                                     ValueName = q.Field<string>("tag_name"),
                                                     Address = q.Field<string>("address"),
                                                     DataType = q.Field<string>("data_type"),
                                                     Unit = q.Field<string>("unit")
                                                 }).ToList();
                deviceModel.MonitorValueList = new System.Collections.ObjectModel.ObservableCollection<MonitorValueModel>(vList);
            }

            return deviceModels;
        }




    }
}
