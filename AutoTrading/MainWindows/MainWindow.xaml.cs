﻿using Kiwoom_Trading.Views;
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

namespace MainWindows
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnKiwoomConnect_Click(object sender, RoutedEventArgs e)
        {
            KhCtrlApi.Login();

            if(KhCtrlApi.IsConnected == true)
            {
                Trading_Main pop = new Trading_Main();
                pop.Show();
            }
        }

        private void popuptest_click(object sender, RoutedEventArgs e)
        {
            Trading_Main pop = new Trading_Main();
            pop.Show();
        }
    }
}
