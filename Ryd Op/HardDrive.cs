using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryd_Op
{
    class HardDrive
    {

        #region Properties

        private string diskName;

        public string DiskName
        {
            get { return diskName; }
            set { diskName = value; }
        }

        private long freeSpace;

        public long FreeSpace
        {
            get { return freeSpace; }
            set { freeSpace = value; }
        }

        private long diskSize;

        public long DiskSize
        {
            get { return diskSize; }
            set { diskSize = value; }
        }

        private string serialNumber;

        public string SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }

        private int amountOfDisks;

        public int AmountOfDisks
        {
            get { return amountOfDisks; }
            set { amountOfDisks = value; }
        }


        #endregion

        #region Constructors

        public HardDrive()
        {

        }
        public HardDrive(string _diskName, long _freeSpace, long _diskSize)
        {
            DiskName = _diskName;
            FreeSpace = _freeSpace;
            DiskSize = _diskSize;
        }

        public HardDrive(string _serialNumber)
        {
            SerialNumber = _serialNumber;
        }

        public HardDrive(int _amountOfDisks)
        {
            AmountOfDisks = _amountOfDisks;
        }
        #endregion
    }
}
