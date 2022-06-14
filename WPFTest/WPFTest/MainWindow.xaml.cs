using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFTest.Base;
using WPFTest.ViewModels;
using WPFTest.Views;

namespace WPFTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();

            //注册弹框页面 DeviceEditWindow
            WindowManager.Register<DeviceEditWindow>("DeviceEditWindow");
        }

        private void Grid_MouseLeftButton(object sender, MouseButtonEventArgs e)
        {
            this.DragMove(); // 鼠标拖动事件 可以拖动窗口
        }

        private void bigBtn_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.normalBtn.Visibility = Visibility.Visible;
                this.bigBtn.Visibility = Visibility.Collapsed;
            }
            else
            {
                this.normalBtn.Visibility = Visibility.Collapsed;
                this.bigBtn.Visibility = Visibility.Visible;
            }

        }
    }
}
