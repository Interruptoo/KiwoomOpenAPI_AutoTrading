using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiwoom_Trading.Models;
using Kiwoom_Trading.Views;

namespace Kiwoom_Trading.ViewModels
{
    public class Trading_Main_ViewModels
    {
        #region [Consts]

        #endregion [Consts]

        #region [Constructor]
        public Trading_Main_ViewModels()
        {
            
        }

        public Trading_Main_ViewModels(Trading_Main_Models obj)
        {
            //초기화
            this.Init();
        }
        #endregion [Constructor]

        #region [Model Property]
        public Trading_Main_Models Model = new Trading_Main_Models();
        public WF_KiwoomLoginControl.KiwwomUserModel userObject = new WF_KiwoomLoginControl.KiwwomUserModel();
        #endregion [Model Propery]        

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
            Model.accountList = userObject.Acclist.Split(';');
        }
        #endregion [Method]
    }
}
