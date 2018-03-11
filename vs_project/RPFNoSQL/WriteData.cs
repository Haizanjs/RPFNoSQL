using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using Newtonsoft.Json;
using static RPFNoSQL_WriteLogs_ClassContainer;

public class RPFNoSQL_WriteData_ClassContainer
{
    public partial class RPFNoSQL_WriteData : RPFNoSQL_WriteData_ClassContainer
    {

        public static string HandleData(string inputString)
        {

            string[] splitArgs = inputString.Split(':');

            DirectoryInfo dirInfo = new DirectoryInfo(RPFNoSQL_WriteLogs.TempPathDirectory);
            if (!RPFNoSQL_WriteLogs.DirectoryExist(RPFNoSQL_WriteLogs.TempPathDirectory + "DB"))
            {
                DirectoryInfo dirSub = dirInfo.CreateSubdirectory("DB");
            }

            string fileDir = string.Format(@"{0}\DB\{1}.json", RPFNoSQL_WriteLogs.TempPathDirectory,splitArgs[4]);
            if (!File.Exists(fileDir))
            {
                // create empty json file first time..
            } else
            {
                // check if entry exist args 1,
            }

            if (splitArgs.Length == 5)
            {

                string command = splitArgs[0];
                string jsontitle = splitArgs[1];
                string jsondata = splitArgs[2];
                string jsondatatype = splitArgs[3];
                string filename = splitArgs[4];

                switch (jsondatatype.ToString())
                {
                    case "string":
                        break;
                    case "str":
                        break;
                    case "boolean":
                        break;
                    case "bool":
                        break;
                    case "number":
                        break;
                    case "scalar":
                        break;
                    case "array":
                        break;
                    default:
                        break;
                }

            }

            return "";
            // return result here
        }

        public static string JsonWrite()
        {
            
            return "";
        }

    }
}

