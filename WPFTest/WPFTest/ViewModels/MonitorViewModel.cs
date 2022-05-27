using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTest.Base;
using WPFTest.Models;

namespace WPFTest.ViewModels
{
    internal class MonitorViewModel: NotifyBase
    {


      // 数值绑定
        //设置一个集合 子元素为 LabelModel
        public List<LabelModel> RunLabels { get; set; } = new List<LabelModel>();

        public List<LabelModel> BaseLabels { get; set; } = new List<LabelModel>();

        // 列表 如果需要时对集合内的子元素进行改变时（增删改查等）需要使用的是 ObservableCollection
        public ObservableCollection<MonitorModel> Monitors { get; set; } = new ObservableCollection<MonitorModel>();

        public MonitorViewModel()
        {

            // 集合赋值
            // 给运行状态集合内添加元素
            RunLabels.Add(new LabelModel { Text = "当前状态", Value = "运行" });
            RunLabels.Add(new LabelModel { Text = "周运行时长", Value = "80h" });
            RunLabels.Add(new LabelModel { Text = "周关机时长", Value = "10h" });
            RunLabels.Add(new LabelModel { Text = "周待机时长", Value = "20h" });
            RunLabels.Add(new LabelModel { Text = "周故障时长", Value = "2h" });
            RunLabels.Add(new LabelModel { Text = "健康状态", Value = "良好" });

            //基本信息
            BaseLabels.Add(new LabelModel { Text = "最大工作范围", Value = "1.44m"});
            BaseLabels.Add(new LabelModel { Text = "有效载荷", Value = "20Kg" });
            BaseLabels.Add(new LabelModel { Text = "有效轴数", Value = "6J" });
            BaseLabels.Add(new LabelModel { Text = "重复定位精确度", Value = "0.001cm" });
            BaseLabels.Add(new LabelModel { Text = "额定功率", Value = "2500w" });
            BaseLabels.Add(new LabelModel { Text = "承重能力", Value = "5kg" });
            BaseLabels.Add(new LabelModel { Text = "J6轴最大速度", Value = "2.1m/s" });
            BaseLabels.Add(new LabelModel { Text = "电源电压", Value = "200-600v" });
            BaseLabels.Add(new LabelModel { Text = "净重", Value = "225kg" });

            // griddata 数据集合
            Monitors.Add(new MonitorModel { Index = 1, DataType="类型1", RecordTime="2022-01-01",DeviceName="机器1",Value="100",Status="正常"});
            Monitors.Add(new MonitorModel { Index = 2, DataType = "类型2", RecordTime = "2022-01-02", DeviceName = "机器2", Value = "100", Status = "正常" });
            Monitors.Add(new MonitorModel { Index = 3, DataType = "类型3", RecordTime = "2022-01-03", DeviceName = "机器3", Value = "100", Status = "正常" });
            Monitors.Add(new MonitorModel { Index = 4, DataType = "类型4", RecordTime = "2022-01-04", DeviceName = "机器4", Value = "100", Status = "正常" });
            Monitors.Add(new MonitorModel { Index = 5, DataType = "类型5", RecordTime = "2022-01-05", DeviceName = "机器5", Value = "100", Status = "正常" });

        }
    }
}
