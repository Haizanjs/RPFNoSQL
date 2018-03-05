using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RPFNoSQL_HandleInput_ClassContainer
{
    public partial class RPFNoSQL_HandleInput : RPFNoSQL_HandleInput_ClassContainer
    {
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
                    case "downloadurl":
                        returnMessage = "";
                        break;
                    default:
                        returnMessage = "RPFNoSQL >> Error >> No arguments passed";
                        break;
                }
            }
            return (returnMessage);
            // return result here
        }

    }
}

