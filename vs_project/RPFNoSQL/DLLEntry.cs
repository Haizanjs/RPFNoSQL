using RGiesecke.DllExport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static RPFNoSQL_HandleInput_ClassContainer;
using static RPFNoSQL_WriteLogs_ClassContainer;

namespace RPFNoSQL
{
    public class DLLEntry
    {
        [DllExport("RVExtension", CallingConvention = CallingConvention.Winapi)]
        public static void RVExtension(StringBuilder output, int outputSize, [MarshalAs(UnmanagedType.LPStr)] string function)
        {

            RPFNoSQL_WriteLogs.HandleLog("SYSTEM", "RPFNoSQL >> Loaded >> Version " + RPFNoSQL_HandleInput.version.ToString());

            output.Append(RPFNoSQL_HandleInput.InputRequest(function));
        }
    }
}
