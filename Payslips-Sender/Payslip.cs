using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslips_Sender
{
    class Payslip
    {
        //Data-There are two information in this class such as payslip templete path and datasource path
        private string _Temp_Path; //variable to store the templete path as a string.
        private string _Data_Path; //variable to store the datasource path as a string.

        //Constructor-There are two attribute or parameter in the constructor
        public Payslip(string tempPath, string dataPath)
        {
            this._Temp_Path = tempPath;
            this._Data_Path = dataPath;
        }

        //Property-There are two property in this class
        public string tempPath
        {
            get { return _Temp_Path; }
            set { value = tempPath; }
        }
        public string dataPath
        {
            get { return _Data_Path; }
            set { value = dataPath; }
        }
    }
}
