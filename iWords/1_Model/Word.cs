using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using iWords.Utility;

namespace iWords._1_Model
{
    public class Word
    {
        private string chinese = string.Empty;
        private string english = string.Empty;
        private DateTime know = new DateTime();
        private DateTime confirm = new DateTime();
        private DateTime next = new DateTime();

        public string Chinese
        {
            get { return this.chinese; }
            set { this.chinese = value; }
        }

        public string English
        {
            get { return this.english; }
            set { this.english = value; }
        }

        public DateTime Know
        {
            get { return this.know; }
            set { this.know = value; }
        }

        public DateTime Confirm
        {
            get { return this.confirm; }
            set { this.confirm = value; }
        }

        public DateTime Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        //---------------------------- 1st level methods --------------------------------
        public Word(XElement ele)
        {
            if (ele.Attribute("chinese") != null)
            {
                this.chinese = ele.Attribute("chinese").Value.ToString();
            }

            if (ele.Attribute("english") != null)
            {
                this.english = ele.Attribute("english").Value.ToString();
            }

            if (ele.Attribute("know") != null)
            {
                this.know = Common.GetDate(ele.Attribute("know").Value);
            }

            if (ele.Attribute("confirm") != null)
            {
                this.confirm = Common.GetDate(ele.Attribute("confirm").Value);
            }


            if (ele.Attribute("next") != null)
            {
                this.next = Common.GetDate(ele.Attribute("next").Value);
            }
        }

        public Word()
        {
        }


    }
}
