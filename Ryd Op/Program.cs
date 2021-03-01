using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Ryd_Op
{
    class Program
    {
        static void Main(string[] args)
        {
            List<HardDrive> hardDriveList = SysManager.GetHardDriveData();
            List<HardDrive> serialNumberList = SysManager.GetHardDriveData("C");
            List<OperatingSystem> operatingSystems = SysManager.GetOS();
            List<Memory> memories = SysManager.GetMemory();
            List<BootDevice> bootDevices = SysManager.GetBootDevices();
            List<string> disks = DalManager.PopulateDisk();
            List<CPUUsage> cPUUsages = DalManager.CCPUsage();

            //Prints Drive infomation
            //foreach (HardDrive hardDrive in hardDriveList)
            //{
            //    Console.WriteLine($"Disk Name: {hardDrive.DiskName} ");

            //    Console.WriteLine($"FreeSpace: {hardDrive.FreeSpace}");

            //    Console.WriteLine($"Disk Size: {hardDrive.DiskSize}");

            //    Console.WriteLine("---------------------------------------------------");
            //}

            //Print drive serial number
            //foreach (HardDrive serialNumber in serialNumberList)
            //{
            //    Console.WriteLine(serialNumber.SerialNumber);
            //    //C - 4A700942
            //    //D = AECB132F
            //    //E - 76CB539A
            //}


            //Prints User, Ogranization and O/S
            //foreach (OperatingSystem os in operatingSystems)
            //{
            //    Console.WriteLine($"User: {os.User}");
            //    Console.WriteLine($"Org: {os.Organization}");
            //    Console.WriteLine($"O/S: {os.OS}");
            //    Console.WriteLine("---------------------------------------------------");
            //}

            ////Prints Total Visible Memory, Free Physical Memory, Total Virtual Memory and Free Virtual Memory
            //foreach (Memory memory in memories)
            //{
            //    Console.WriteLine($"Total Visible Memory: {memory.VisibleMemorySize} KB");
            //    Console.WriteLine($"Free Physical Memory: {memory.PhysicalMemory} KB");
            //    Console.WriteLine($"Total Virtual Memory: {memory.VirtualMemorySize} KB");
            //    Console.WriteLine($"Free Virtual Memory: {memory.VirtualMemory} KB");
            //    Console.WriteLine("---------------------------------------------------");
            //}

            //foreach (BootDevice bootDevice in bootDevices)
            //{
            //    Console.WriteLine($"BootDevice {bootDevice.Device}");
            //    Console.WriteLine("---------------------------------------------------");
            //}


            //Prints services
            //Console.WriteLine(SysManager.GetServices());

            //Prints disks
            //foreach (string disk in disks)
            //{
            //    Console.WriteLine(disk);
            //}

            //Print CPU Usages
            foreach (CPUUsage usage in cPUUsages)
            {
                Console.WriteLine($"{usage.ProcessorTime} : {usage.Name}");
            }
            Console.ReadKey();
        }
    }
}
