using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

public class RPFNoSQL_WriteLogs_ClassContainer
{
    public partial class RPFNoSQL_WriteLogs : RPFNoSQL_WriteLogs_ClassContainer
    {

        public static string TempPathDirectory = (Path.GetTempPath() + "RPFNoSQL_Temp" + "Logs");

        public static bool HandleLog(string logtype, string logdata)
        {

            // Do Bool check for folder existing folders..
            if (!DirectoryExist(TempPathDirectory))
            {
                // Create logging folder if it didn't exist
                Directory.CreateDirectory(TempPathDirectory);
            }

            DateTime datetimenow = new DateTime();

            if (!DirectoryExist(TempPathDirectory + datetimenow.Year.ToString()))
            {
                Directory.CreateDirectory(TempPathDirectory + datetimenow.Year.ToString());
            }

            return true;
        }

        public static string WriteLog(string logtype, string logdata)
        {
            return "";
        }


        // Check if directory exists
        public static bool DirectoryExist(string DirectoryPath)
        {

            if (Directory.Exists(DirectoryPath))
            {
                return true;
            }
            else
            {
                return false;
            }

        }



    }
}

