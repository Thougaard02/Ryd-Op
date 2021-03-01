using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryd_Op
{
    class OperatingSystem
    {
        #region Properties
        private string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        private string organization;

        public string Organization
        {
            get { return organization; }
            set { organization = value; }
        }

        private string  os;

        public string  OS
        {
            get { return os; }
            set { os = value; }
        }
        #endregion

        #region Constructor

        public OperatingSystem()
        {

        }

        public OperatingSystem(string _user, string _organization, string _os)
        {
            User = _user;
            Organization = _organization;
            OS = _os;
        }
        #endregion
    }
}
