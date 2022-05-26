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

      
        //设置一个集合 子元素为 LabelModel
        public List<LabelModel> RunLabels { get; set; } = new List<LabelModel>();

        public List<LabelModel> BaseLabels { get; set; } = new List<LabelModel>();



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

        }
    }
}
