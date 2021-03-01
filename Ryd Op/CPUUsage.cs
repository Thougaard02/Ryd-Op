using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryd_Op
{
    class CPUUsage
    {
        #region Properties
        private int processorTIme;

        public int ProcessorTime
        {
            get { return processorTIme; }
            set { processorTIme = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion

        #region Constructor
        public CPUUsage()
        {
        }
        public CPUUsage(int _processorTime, string _name)
        {
            ProcessorTime = _processorTime;
            Name = _name;
        }
        #endregion

    }
}
