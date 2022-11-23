using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdbGUI
{
    internal class AdbCmd
    {
        static public void adb_shell(string deviceID)
        {
            Utils.CreateCmd("adb", "-s " + deviceID + " shell");
        }
        static public ArrayList adb_devices()
        {
            ArrayList abdList = new ArrayList();

            string result = Utils.ExecuteCmd("adb","devices");
            int index = result.IndexOf("List of devices attached\r\n");
            if (index == -1){
                return abdList;
            }
            result = result.Substring(index+26);
            string[] vec_Line = result.Split("\r\n");
            if(vec_Line.Length <= 1){
                return abdList;
            }
            foreach(string eLine in vec_Line) {
                string[] tmpArray = eLine.Split("\t");
                if(tmpArray.Length != 2){
                    continue;
                }
                abdList.Add(tmpArray[0]);
            }
            return abdList;
        }
    }
}
