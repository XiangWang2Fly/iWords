//---------------------------------------------------------------------------------------
// <copyright file="MainForm.cs" company="WangXiang">
//     Company copyright for iWords
// </copyright>
//---------------------------------------------------------------------------------------
namespace iWords._1_Model
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;


    public class Training
    {
        List<Word> words = new List<Word>();
        private int confirm = 0;
        bool edit = false;

        public List<Word> Words
        {
            get { return this.words; }
        }

        public int Confirm
        {
            get { return this.confirm; }
        }

        public bool Edit
        {
            set { this.edit = value; }
        }

        //---------------------------- 1st level methods --------------------------------
        public void Load()
        {
            this.words.Clear();
            string file = "words.xml";
            if (File.Exists(file))
            {
                XDocument otherData = new XDocument();
                otherData = XDocument.Load(file);
                foreach (XElement ele in otherData.Root.Elements())
                {
                    this.words.Add(new Word(ele));
                }
            }
        }

        public void Calc()
        {
            confirm = 0;
            foreach (Word word in this.words)
            {
                if (word.Confirm.Date > (new DateTime()).Date)
                {
                    confirm++;
                }
            }
        }

        public Word GetNext()
        {
            Random ran = new Random();
            Word word;
            int max = this.words.Count;
            do
            {
                int i = ran.Next(0, this.Words.Count);
                word = this.Words[i];

                // not confirm yet
                if (word.Confirm == (new DateTime()).Date)
                {
                    // not show today
                    if (word.Next.Date <= DateTime.Now.Date)
                    {
                        break;
                    }
                }

                max--;
            } while (max > 0);
            
            if (max <= 0)
            {
                word = new Word();
            }

            return word;
        }

        public void Add(Word word)
        {
            word.Next = DateTime.Now.AddDays(7);
            if (words.FindIndex(u=>u.English == word.English) == -1)
            {
                this.words.Add(word);
            }
        }

        public void Save()
        {
            if (this.edit)
            {
                string file = "words.xml";
                XDocument xd = new XDocument();
                xd = XDocument.Load(file);
                xd.Root.RemoveAll();
                foreach (Word word in this.words)
                {
                    xd.Root.Add(new XElement("word",
                                    new XAttribute("chinese", word.Chinese),
                                    new XAttribute("english", word.English),
                                    new XAttribute("next", word.Next.ToShortDateString()),
                                    new XAttribute("know", word.Know.ToShortDateString()),
                                    new XAttribute("confirm", word.Confirm.ToShortDateString())
                                    ));
                }

                xd.Save(file);
            }
        }
    }
}
