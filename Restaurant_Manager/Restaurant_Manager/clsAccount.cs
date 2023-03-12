using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Manager
{
    public class clsAccount
    {
        public int accountid;
        public string uname;
        public string passwd;
        public int acctype;

        public int accID
        {
            get
            {
                return accountid;
            }
            set
            {
                accountid = value;
            }
        }

        public string Uname
        {
            get
            {
                return uname;
            }
            set
            {
                uname = value;
            }
        }

        public string Password
        {
            get
            {
                return passwd;
            }
            set
            {
                passwd = value;
            }
        }

        public int AccType
        {
            get
            {
                return acctype;
            }
            set
            {
                acctype = value;
            }
        }

        public clsAccount(int accountid, string uname, string passwd, int acctype)
        {
            this.accountid = accountid;
            this.uname = uname;
            this.passwd = passwd;
            this.acctype = acctype;
        }

        
    }
}
