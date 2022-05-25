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

        public MonitorModel monitorModel { get; set; } = new MonitorModel();

        ObservableCollection<MonitorModel> userData = new ObservableCollection<MonitorModel>();
        public ObservableCollection<MonitorModel> UserData
        {

            get { return userData; }
            set
            {
                userData = value;
                this.NotifyChanged();
            }
        }



        public MonitorViewModel()
        {
            userData.Add(new MonitorModel() { Number = 1, Style = "盖伦", Age = 25, Sex = "12", Memo = "德玛西亚之力" });
            userData.Add(new MonitorModel() { Number = 2, Style = "伊泽瑞尔", Age = 20, Sex = "23", Memo = "冒险家" });
            userData.Add(new MonitorModel() { Number = 3, Style = "阿卡丽", Age = 20, Sex = "34", Memo = "忍者" });
            userData.Add(new MonitorModel() { Number = 4, Style = "亚托克斯", Age = 500, Sex = "45", Memo = "暗裔，恶魔" });
            userData.Add(new MonitorModel() { Number = 5, Style = "亚索", Age = 25, Sex = "56", Memo = "疾风剑豪" });

        }
    }
}
