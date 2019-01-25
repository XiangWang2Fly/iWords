using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using iWords.Utility;

namespace iWords._1_Model
{
    public class Config
    {
        private DateTime exam = new DateTime();

        public DateTime Exam
        {
            get { return this.exam; }
        }

        // ----------------------------- 1st level methods ------------------------------
        public Config()
        {
            string file = "config.xml";
            if (File.Exists(file))
            {
                XDocument otherData = new XDocument();
                otherData = XDocument.Load(file);
                foreach (XElement ele in otherData.Root.Elements())
                {
                    if (ele.Name == "exam")
                    {
                        exam = Common.GetDate(ele.Value);
                    }
                }
            }
        }
    }
}
