using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iWords.Utility
{
    public class Common
    {
        /// <summary>
        /// version of current program
        /// </summary>
        public static string Version = "Ver.2";

        /// <summary>
        /// convert string to int
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static DateTime GetDate(string str)
        {
            DateTime x = new DateTime();

            if (str != string.Empty)
            {
                DateTime.TryParse(str, out x);
            }

            return x;
        }
    }
}
