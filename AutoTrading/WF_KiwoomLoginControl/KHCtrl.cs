using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_KiwoomLoginControl
{
    public partial class KHCtrl : UserControl
    {
        #region ViewModel        
        public bool IsConnected { get { return axKHOpenAPI.GetConnectState() != 0; } }
        #endregion

        public KHCtrl()
        {
            InitializeComponent();
            axKHOpenAPI.OnEventConnect += khAPI_OnEventConnect;


        }

        private void khAPI_OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if(e.nErrCode == 0)
            {
                //로그인성공
                MessageBox.Show("로그인에 성공했습니다.", "Login", MessageBoxButtons.OK);
            }
            else
            {
                //로그인실패
                /*실패에 따른 error code를 ENUM으로 정리 후 사용하자*/
                MessageBox.Show("로그인에 실패했습니다.", "Login", MessageBoxButtons.OK);
            }
        }

        public void Login()
        {
            if (!IsConnected)
            {

                if(axKHOpenAPI.CommConnect() != 0)
                {
                    
                }
            }
            else
            {
                
            }
            

        }
    }
}
