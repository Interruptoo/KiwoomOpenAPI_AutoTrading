using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_KiwoomLoginControl
{
    public class KiwwomUserModel
    {
        private string account_CNT;
        /// <summary>
        ///  name : 보유계좌 갯수
        /// </summary>
        public string AccountCNT
        {
            get { return account_CNT; }
            set { account_CNT = value; }
        }

        private string acclist;
        /// <summary>
        ///  name : 구분자 ';'로 연결된 보유계좌 목록
        /// </summary>
        public string Acclist
        {
            get { return acclist; }
            set { acclist = value; }
        }

        private string user_id;
        /// <summary>
        ///  name : 사용자 ID
        /// </summary>
        public string UserID
        {
            get { return user_id; }
            set { user_id = value; }
        }

        private string user_name;        
        /// <summary>
        ///  name : 사용자 이름
        /// </summary>
        public string UserName
        {
            get { return user_name; }
            set
            {
                user_name = value;
            }
        }

        private string getservergubun;
        /// <summary>
        ///  name : 접속서버 구분(1 : 모의투자, 나머지 : 실거래서버)
        /// </summary>
        public string Getservergubun
        {
            get { return getservergubun; }
            set
            {
                getservergubun = value;
            }
        }

        private string key_bsecgb;
        /// <summary>
        ///  name : 키보드 보안 해지여부(0 : 정상, 1 : 해지)
        /// </summary>
        public string KeyBSecgb
        {
            get { return key_bsecgb; }
            set
            {
                key_bsecgb = value;
            }
        }

        private string firew_secgb;
        /// <summary>
        ///  name : 방화벽 설정여부(0 : 미설정, 1 : 설정, 2 : 해지)
        /// </summary>
        public string FirewSecgb
        {
            get { return firew_secgb; }
            set
            {
                firew_secgb = value;
            }
        }

        private int deposit_Received;
        /// <summary>
        ///  name : 예수금
        /// </summary>
        public int DepositReceived
        {
            get { return deposit_Received; }
            set { deposit_Received = value; }
        }

    }
}
