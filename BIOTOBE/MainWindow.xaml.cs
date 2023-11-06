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
using System.Diagnostics;

namespace BIOTOBE
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.ToString());
            e.Handled = true;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MinimizedButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void IceButton_Click(object sender, RoutedEventArgs e)
        {
            // กำหนด URL ที่คุณต้องการเปิด
            string url = "https://linktr.ee/xumarker3120?utm_source=linktree_profile_share&ltsid=c6d1fdd3-6305-41f1-9e6a-8629b9be677a";

            // เปิด URL ในเบราวเซอร์
            System.Diagnostics.Process.Start(url);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Process.Start("Explorer.exe", "fivem://connect/49.0.79.181:30120");
        }

    }
}



