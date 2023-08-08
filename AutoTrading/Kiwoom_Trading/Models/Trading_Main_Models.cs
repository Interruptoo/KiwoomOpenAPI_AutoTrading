using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_KiwoomLoginControl;

namespace Kiwoom_Trading.Models
{
    public class Trading_Main_Models : ObservableObject
    {
        #region[Private Model]        
        private string[] accountlist;   //계좌번호리스트
        private string accountListToString; //; 으로 연결된 계좌번호 리스트
        private string userid;
        private string username;
        private string servergubn;
        private string addAccountNO;
        #endregion [Private Model]

        #region [Public Model]
        /// <summary>
        ///  name : 계좌번호 List
        /// </summary>
        public string[] _accountList
        {
            get { return accountlist; }
            set { accountlist = value; }
        }

        /// <summary>
        ///  name : ; 으로 연결된 계좌번호 리스트
        /// </summary>
        public string _accountListToString
        {
            get { return accountListToString; }
            set { accountListToString = value; }
        }

        /// <summary>
        ///  name : user_ID
        /// </summary>
        public string _userID
        {
            get { return userid; }
            set { userid = value; }
        }

        /// <summary>
        ///  name : userName
        /// </summary>
        public string _userName
        {
            get { return username; }
            set { username = value; }
        }

        /// <summary>
        ///  name : 서버구분
        /// </summary>
        public string _serverGubn
        {
            get { return servergubn; }
            set
            {
                servergubn = value;
            }
        }

        /// <summary>
        ///  name : 추가 계좌번호 끝 2자리
        /// </summary>
        public string _addAccountNO
        {
            get { return addAccountNO; }
            set { addAccountNO = value; }
        }
        #endregion [Public Model]


    }
}
