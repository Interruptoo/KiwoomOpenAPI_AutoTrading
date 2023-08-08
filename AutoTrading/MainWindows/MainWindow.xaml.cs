using Kiwoom_Trading.Views;
using Kiwoom_Trading.Models;
using Kiwoom_Trading.ViewModels;
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
        #region [Model Property]
        public WF_KiwoomLoginControl.KHCtrl khCtrlApiClass = new WF_KiwoomLoginControl.KHCtrl();
        Trading_Main_Models userInfo = new Trading_Main_Models();
        #endregion [Model Property]

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
            //KhCtrlApi.Login();
            khCtrlApiClass.Login();

            if (KhCtrlApi.IsConnected == true)
            {
                userInfo._accountListToString = khCtrlApiClass.userModel.Acclist;
                userInfo._serverGubn = khCtrlApiClass.userModel.Getservergubun;
                userInfo._userID = khCtrlApiClass.userModel.UserID;
                userInfo._userName = khCtrlApiClass.userModel.UserName;


                Trading_Main pop = new Trading_Main(userInfo);
                pop.Show();
            }
        }

        private void popuptest_click(object sender, RoutedEventArgs e)
        {
            userInfo._accountListToString = "123123123123;321321321321";
            userInfo._userName = "유민호";
            userInfo._userID = "ypu1312";
            userInfo._serverGubn = "0";


            Trading_Main pop = new Trading_Main(userInfo);
            pop.Show();
        }
    }
}
