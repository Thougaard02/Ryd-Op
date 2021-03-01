using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryd_Op
{
    class Memory
    {
        #region Properties
        private double visibleMemorySize;

        public double VisibleMemorySize
        {
            get { return visibleMemorySize; }
            set { visibleMemorySize = value; }
        }

        private double physicalMemory;

        public double PhysicalMemory
        {
            get { return physicalMemory; }
            set { physicalMemory = value; }
        }

        private double virtualMemorySize;

        public double VirtualMemorySize
        {
            get { return virtualMemorySize; }
            set { virtualMemorySize = value; }
        }

        private double virtualMemory;

        public double VirtualMemory
        {
            get { return virtualMemory; }
            set { virtualMemory = value; }
        }

        #endregion

        #region Constructor
        public Memory()
        {

        }

        public Memory(double _visibleMemorySize, double _physicalMemory, double _virtualMemorySize, double _virtualMemory)
        {
            VisibleMemorySize = _visibleMemorySize;
            PhysicalMemory = _physicalMemory;
            virtualMemorySize = _virtualMemorySize;
            VirtualMemory = _virtualMemory;
        }
        #endregion
    }
}
