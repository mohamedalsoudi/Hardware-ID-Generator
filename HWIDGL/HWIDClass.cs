using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace HWIDGL
{
    public class HWIDClass
    {
        //Convert Date To Serial
        public static String dateSerial(String dateTime)
        {
            DateTime convertedDateTime;
            convertedDateTime = Convert.ToDateTime(dateTime);
            String DateSN = convertedDateTime.ToOADate().ToString();
            return DateSN;
        }

        //Get CPU ID
        public static string getCPUID()
        {
            string cpuInfo = "";
            ManagementClass managClass = new ManagementClass("win32_processor");
            ManagementObjectCollection managCollec = managClass.GetInstances();

            foreach (ManagementObject managObj in managCollec)
            {
                if (cpuInfo == "")
                {
                    //Get first CPU ID
                    cpuInfo = managObj.Properties["processorID"].Value.ToString();
                    break;
                }
            }
            return cpuInfo;
        }

        public static string getVolumeSerial(string drive)
        {
            ManagementObject disk = new ManagementObject(@"win32_logicaldisk.deviceid=""" + drive + @":""");
            disk.Get();

            string volumeSerial = disk["VolumeSerialNumber"].ToString();
            disk.Dispose();

            return volumeSerial;
        }

        public static string getUniqueID(string drive, DateTime dateTime)
        {
            if (drive == string.Empty)
            {
                //Find first drive
                foreach (DriveInfo compDrive in DriveInfo.GetDrives())
                {
                    if (compDrive.IsReady)
                    {
                        drive = compDrive.RootDirectory.ToString();
                        break;
                    }
                }
            }

            if (drive.EndsWith(":\\"))
            {
                drive = drive.Substring(0, drive.Length - 2);
            }

            string volumeSerial = getVolumeSerial(drive);
            string cpuID = getCPUID();

            //Mix All Strings From CPU ID, Volume Serial, Date Serial
            return cpuID.Substring(12) + "-" + cpuID.Substring(0, 4) + "-" + volumeSerial + "-" + cpuID.Substring(5, 4) + "-" + dateSerial(dateTime.ToString("dd/MM/yyyy"));
        }
    }
}
