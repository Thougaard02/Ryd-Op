using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Ryd_Op
{
    static class DalManager
    {
        public static List<OperatingSystem> GetOS()
        {
            List<OperatingSystem> osList = new List<OperatingSystem>();
            ObjectQuery osQuery = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher osSearcher = new ManagementObjectSearcher(osQuery);
            ManagementObjectCollection osResults = osSearcher.Get();
            foreach (ManagementObject result in osResults)
            {
                string user = result["RegisteredUser"].ToString();
                string organization = result["Organization"].ToString();
                string os = result["Name"].ToString();

                OperatingSystem osObject = new OperatingSystem(user, organization, os);
                osList.Add(osObject);
            }
            return osList;
        }

        public static List<BootDevice> GetBootDevice()
        {

            List<BootDevice> bootDeviceList = new List<BootDevice>();

            //Scope
            ManagementScope scope = new ManagementScope("\\\\.\\ROOT\\cimv2");

            //Create object query
            ObjectQuery bootQuery = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");

            //Create object searcher
            ManagementObjectSearcher bootSearcher = new ManagementObjectSearcher(scope, bootQuery);

            //get a collection of WMI objects
            ManagementObjectCollection bootCollection = bootSearcher.Get();

            //enumerate the collection.
            foreach (ManagementObject bootDevice in bootCollection)
            {
                string device = bootDevice["BootDevice"].ToString();

                BootDevice bootDeviceObj = new BootDevice(device);
                bootDeviceList.Add(bootDeviceObj);
            }
            return bootDeviceList;
        }
        public static List<Memory> GetMemory()
        {
            List<Memory> memoryList = new List<Memory>();
            ObjectQuery memoryQuery = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher memorySearcher = new ManagementObjectSearcher(memoryQuery);
            ManagementObjectCollection memoryCollection = memorySearcher.Get();

            foreach (ManagementObject result in memoryCollection)
            {
                double visibleMemorySize = double.Parse(result["TotalVisibleMemorySize"].ToString());
                double physicalMemory = double.Parse(result["FreePhysicalMemory"].ToString());
                double virtualMemorySize = double.Parse(result["TotalVirtualMemorySize"].ToString());
                double VirtualMemory = double.Parse(result["FreeVirtualMemory"].ToString());

                Memory memory = new Memory(visibleMemorySize, physicalMemory, virtualMemorySize, VirtualMemory);
                memoryList.Add(memory);
            }
            return memoryList;
        }
        public static List<HardDrive> GetHardDriveData()
        {
            List<HardDrive> hardDriveList = new List<HardDrive>();

            ManagementScope hardDriveScope = new ManagementScope();

            ObjectQuery objectQuery = new ObjectQuery("select FreeSpace,Size,Name from Win32_LogicalDisk where DriveType=3");

            ManagementObjectSearcher hardDriveObjectSearcher = new ManagementObjectSearcher(hardDriveScope, objectQuery);

            ManagementObjectCollection hardDriveObjectCollection = hardDriveObjectSearcher.Get();

            foreach (ManagementObject hardDrive in hardDriveObjectCollection)
            {
                string name = hardDrive["Name"].ToString();

                long freeSpace = long.Parse(hardDrive["FreeSpace"].ToString());

                long diskSize = long.Parse(hardDrive["Size"].ToString());

                HardDrive hardDriveObject = new HardDrive(name, freeSpace, diskSize);
                hardDriveList.Add(hardDriveObject);
            }
            return hardDriveList;
        }
        public static List<HardDrive> GetHardDiskSerialNumber(string drive)
        {
            List<HardDrive> hardDriveSerialNumberList = new List<HardDrive>();
            ManagementObject managementObject = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + drive + ":\"");

            managementObject.Get();

            string serialNumber = managementObject["VolumeSerialNumber"].ToString();
            HardDrive addSerialNumber = new HardDrive(serialNumber);
            hardDriveSerialNumberList.Add(addSerialNumber);

            return hardDriveSerialNumberList;
        }
        public static string GetServices()
        {
            string temp = "";
            ManagementObjectSearcher windowsServicesSearcher = new ManagementObjectSearcher("root\\cimv2", "SELECT * FROM Win32_Service");
            ManagementObjectCollection objectCollection = windowsServicesSearcher.Get();

            Console.WriteLine("There are {0} Windows services: ", objectCollection.Count);

            foreach (ManagementObject windowsService in objectCollection)
            {
                PropertyDataCollection serviceProperties = windowsService.Properties;
                foreach (PropertyData serviceProperty in serviceProperties)
                {
                    if (serviceProperty.Value != null)
                    {
                        temp += $"Windows service property name: {serviceProperty.Name} Windows service property value: {serviceProperty.Value}\n";
                    }
                }
            }
            return temp;
        }
        public static List<string> PopulateDisk()
        {
            List<string> disk = new List<string>();

            SelectQuery selectQuery = new SelectQuery("Win32_LogicalDisk");

            ManagementObjectSearcher mnagementObjectSearcher = new ManagementObjectSearcher(selectQuery);

            foreach (ManagementObject managementObject in mnagementObjectSearcher.Get())
            {
                disk.Add(managementObject.ToString());
            }
            return disk;
        }

        public static List<CPUUsage> CCPUsage()
        {
            List<CPUUsage> cPUUsagesList = new List<CPUUsage>();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_PerfFormattedData_PerfOS_Processor");
            foreach (ManagementObject cpuUsage in searcher.Get())
            {
                int precentProcessorTime = int.Parse(cpuUsage["PercentProcessorTime"].ToString());
                string usage = cpuUsage["Name"].ToString();

                CPUUsage cpuUsageObj = new CPUUsage(precentProcessorTime, usage);
                cPUUsagesList.Add(cpuUsageObj);
            }
            return cPUUsagesList;
        }
    }
}
