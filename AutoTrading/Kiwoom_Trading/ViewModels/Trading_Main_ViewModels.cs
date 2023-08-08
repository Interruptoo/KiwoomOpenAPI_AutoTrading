using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiwoom_Trading.Bases;
using Kiwoom_Trading.Models;
using Kiwoom_Trading.Views;
using WF_KiwoomLoginControl;

namespace Kiwoom_Trading.ViewModels
{
    public class Trading_Main_ViewModels : ViewModelBase
    {
        #region [Consts]

        #endregion [Consts]

        #region [Property]
        public Trading_Main_Models inputOtherScreen = new Trading_Main_Models();
        //public Trading_Main_Models userInfo;
        private Trading_Main_Models userInfo;
        public Trading_Main_Models _userInfo
        {
            get { return userInfo; }
            set { userInfo = value; }
        }
        #endregion [Property]

        #region [Constructor]
        public Trading_Main_ViewModels()
        {
            
        }

        public Trading_Main_ViewModels(object obj)
        {
            inputOtherScreen = obj as Trading_Main_Models;
            //초기화
            this.Init();
        }
        #endregion [Constructor]        

        #region [Command]

        #endregion [Command]

        #region [Method]
        /// <summary>
        /// name         : 초기화
        /// desc         : 화면 초기화 한다.
        /// author       : yuminho
        /// create date  : 2023-07-29
        /// update date  : 최종 수정일자 , 수정자, 수정개요
        /// </summary>
        private void Init()
        {
            _userInfo = new Trading_Main_Models();
            _userInfo._accountList = inputOtherScreen._accountListToString.Split(';');
            _userInfo._serverGubn = inputOtherScreen._serverGubn;
            _userInfo._userID = inputOtherScreen._userID;
            _userInfo._userName = inputOtherScreen._userName;
        }
        #endregion [Method]
    }
}
