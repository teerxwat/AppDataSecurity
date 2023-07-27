using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataSecurity
{
    static class Global
    {
        private static string _globalVar = "";
        private static string _globalVar1 = "";

        public static string GlobalVar
        {
            get { return _globalVar; }
            set { _globalVar = value; }
        }
        public static string GlobalVar1
        {
            get { return _globalVar1; }
            set { _globalVar1 = value; }
        }
    }
}
