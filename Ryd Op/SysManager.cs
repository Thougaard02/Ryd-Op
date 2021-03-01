using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Ryd_Op
{
    static class SysManager
    {
        public static List<HardDrive> GetHardDriveData()
        {
            return DalManager.GetHardDriveData();
        }

        public static List<HardDrive> GetHardDriveData(string drive)
        {
            return DalManager.GetHardDiskSerialNumber(drive);
        }

        public static List<OperatingSystem> GetOS()
        {
            return DalManager.GetOS();
        }

        public static List<Memory> GetMemory()
        {
            return DalManager.GetMemory();
        }

        public static List<BootDevice> GetBootDevices()
        {
            return DalManager.GetBootDevice();
        }

        public static string GetServices()
        {
            return DalManager.GetServices();
        }

        public static List<string> PopulateDisk()
        {
            return DalManager.PopulateDisk();
        }
        public static List<CPUUsage> cPUUsages()
        {
            return DalManager.CCPUsage();
        }
    }
}
