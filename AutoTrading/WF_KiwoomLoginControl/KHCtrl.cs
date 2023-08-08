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
        #region Property
        public bool IsConnected { get { return axKHOpenAPI.GetConnectState() != 0; } }
        //사용자정보 모델
        public KiwwomUserModel userModel = new KiwwomUserModel();
        #endregion Property

        public KHCtrl()
        {
            InitializeComponent();
            axKHOpenAPI.OnEventConnect += khAPI_OnEventConnect;


        }

        /// <summary>
        /// name         : 로그인이벤트
        /// desc         : 키움 OpenApi로그인 요청이 종료될 때 호출되는 이벤트
        /// author       : yuminho
        /// create date  : 2023-07-25
        /// update date  : 최종 수정일자 , 수정자, 수정개요
        /// </summary>
        private void khAPI_OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if(e.nErrCode == 0)
            {
                //로그인성공
                MessageBox.Show("로그인에 성공했습니다.", "Login", MessageBoxButtons.OK);
                selectUserInfo();
            }
            else
            {
                //로그인실패
                /*실패에 따른 error code를 ENUM으로 정리 후 사용하자*/
                MessageBox.Show("로그인에 실패했습니다.", "Login", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// name         : 로그인이벤트
        /// desc         : 키움 OpenApi로그인 화면을 호출한다.
        /// author       : yuminho
        /// create date  : 2023-07-25
        /// update date  : 최종 수정일자 , 수정자, 수정개요
        /// </summary>
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

        /// <summary>
        /// name         : 로그인한 계정의 사용자정보를 조회한다.
        /// desc         : 로그인한 계정의 사용자정보를 조회한다.
        /// author       : yuminho
        /// create date  : 2023-07-29
        /// update date  : 최종 수정일자 , 수정자, 수정개요
        /// </summary>
        public void selectUserInfo()
        {
            userModel.AccountCNT = axKHOpenAPI.GetLoginInfo("ACCOUNT_CNT");
            userModel.Acclist = axKHOpenAPI.GetLoginInfo("ACCLIST");
            userModel.UserID = axKHOpenAPI.GetLoginInfo("USER_ID");
            userModel.UserName = axKHOpenAPI.GetLoginInfo("USER_NAME");
            userModel.Getservergubun = axKHOpenAPI.GetLoginInfo("GetServerGubun");
            userModel.KeyBSecgb = axKHOpenAPI.GetLoginInfo("KEY_BSECGB");
            userModel.FirewSecgb = axKHOpenAPI.GetLoginInfo("FIREW_SECGB");
        }

        /// <summary>
        /// name         : 로그인한 계정의 예수금정보 조회
        /// desc         : 로그인한 계정의 예수금정보 조회
        /// author       : yuminho
        /// create date  : 2023-07-29
        /// update date  : 최종 수정일자 , 수정자, 수정개요
        /// </summary>
        public void getCashInfo(string accNo)
        {
            int result;
            axKHOpenAPI.SetInputValue("계좌번호", accNo);
            axKHOpenAPI.SetInputValue("비밀번호입력매체구분", "00");
            axKHOpenAPI.SetInputValue("조회구분", "2"); //2:일반조회, 3:추정조회

            result = axKHOpenAPI.CommRqData("예수금상세현황", "OPW00001", 0, "0");   //param1 : request_name, param2 : TR Code(OPW00001 = 예수금상세현황요청)

        }


    }
}
