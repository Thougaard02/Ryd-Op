using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryd_Op
{
    class BootDevice
    {
        #region Propterites

        private string device;

        public string Device
        {
            get { return device; }
            set { device = value; }
        }
        #endregion

        #region Constructors

        public BootDevice()
        {

        }

        public BootDevice(string _device)
        {
            Device = _device;
        }
        #endregion
    }
}
