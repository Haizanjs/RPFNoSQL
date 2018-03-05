using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPFNoSQL_WriteLogs_ClassContainer;

public class RPFNoSQL_HandleInput_ClassContainer
{
    public partial class RPFNoSQL_HandleInput : RPFNoSQL_HandleInput_ClassContainer
    {

        public static double version = 0.1;
        public static char split_character = ':';

        public static string InputRequest(string inputString)
        {
            string returnMessage;
            string[] splitArgs = inputString.Split(split_character);
            if (splitArgs.Length < 2)
            {
                returnMessage = "RPFNoSQL >> Error >> Invalid Arugments";
            }
            else
            {
                switch (splitArgs[0].ToLower())
                {
                    case "version":
                        returnMessage = ("RPFNoSQL >> Version >> " + version.ToString());
                        break;
                    default:
                        returnMessage = "RPFNoSQL >> Error >> No arguments passed";
                        break;
                }
            }
            RPFNoSQL_WriteLogs.HandleLog("SYSTEM", returnMessage);
            return (returnMessage);
            // return result here
        }

    }
}

