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

            DirectoryInfo dirInfo = new DirectoryInfo(TempPathDirectory);

            DateTime datetime_s = Convert.ToDateTime(DateTime.Now.ToString());
            string day = datetime_s.Day.ToString();
            string month = datetime_s.Month.ToString();
            string year = datetime_s.Year.ToString();
            string combined = string.Format("{0}-{1}-{2}",day,month,year);


            if (!DirectoryExist(TempPathDirectory + year))
            {
                DirectoryInfo dirSub = dirInfo.CreateSubdirectory(year);
            }

            string fileDir = string.Format(@"{0}\{1}\{2}.txt",TempPathDirectory,year,combined);
            if (File.Exists(fileDir))
            {
                using (TextWriter tw = File.AppendText(fileDir))
                {
                    tw.WriteLine(DateTime.Now.ToString() + " : RPFNoSQL >> {" + logtype + "} >> " + logdata);
                }
            } else
            {
                using (TextWriter tw = new StreamWriter(fileDir))
                {
                    tw.WriteLine(DateTime.Now.ToString()+" : RPFNoSQL >> Log file created!");
                }
            }

            return true;
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

