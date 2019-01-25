//---------------------------------------------------------------------------------------
// <copyright file="MainForm.cs" company="WangXiang">
//     Company copyright for iWords
// </copyright>
//---------------------------------------------------------------------------------------
namespace iWords
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using iWords._1_Model;
    using iWords.Utility;


    public partial class MainForm : Form
    {
        #region //-------------------- private field ------------------------------------
        private Training training = new Training();
        private Config config = new Config();
        private Word word = new Word();
        private int preSelect = 0;
        #endregion


        // ----------------------------- 1st level methods ------------------------------
        public MainForm()
        {
            InitializeComponent();
            this.Text = Common.Version;
            this.dateTimePickerExam.Value = config.Exam;
            this.training.Load();
            this.training.Calc();
            this.labelDay.Text = (this.config.Exam.Date - DateTime.Now.Date).Days.ToString();
            this.labelConfirm.Text = this.training.Confirm.ToString();
            this.labelTotal.Text = this.training.Words.Count.ToString();
            if (this.training.Words.Count > 0)
            {
                this.labelRate.Text = string.Format("{0:F1} %", (float)this.training.Confirm / this.training.Words.Count);
            }

            this.ShowNextWord();
        }

        private void ShowNextWord()
        {
            word = this.training.GetNext();
            this.labelChinese.Text = word.Chinese;
            this.labelEnglish.Text = string.Empty;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (this.labelChinese.Text != string.Empty)
            {
                this.preSelect = 2;
                this.labelEnglish.Text = word.English;
                this.Refresh();
            }
        }

        private void buttonVague_Click(object sender, EventArgs e)
        {
            if (this.labelChinese.Text != string.Empty)
            {
                this.preSelect = 1;
                this.labelEnglish.Text = word.English;
                this.Refresh();
            }
        }

        private void buttonUnknown_Click(object sender, EventArgs e)
        {
            if (this.labelChinese.Text != string.Empty)
            {
                this.preSelect = 0;
                this.labelEnglish.Text = word.English;
                this.Refresh();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (this.textBoxEnglish.Text != string.Empty && this.textBoxChinese.Text != string.Empty)
            {
                Word word = new Word();
                word.English = this.textBoxEnglish.Text;
                word.Chinese = this.textBoxChinese.Text;
                this.training.Add(word);
                this.textBoxEnglish.Text = string.Empty;
                this.textBoxChinese.Text = string.Empty;
                this.training.Edit = true;
                this.labelTotal.Text = this.training.Words.Count.ToString();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.training.Save();
            Environment.Exit(0);
        }

        private void buttonWrong_Click(object sender, EventArgs e)
        {
            if (this.labelEnglish.Text != string.Empty)
            {
                this.ShowNextWord();
                this.preSelect = -1;
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (this.labelEnglish.Text != string.Empty)
            {
                switch (preSelect)
                {
                    case 0:
                        word.Next = DateTime.Now.AddDays(7);
                        this.training.Edit = true;
                        break;
                    case 1:
                        word.Next = DateTime.Now.AddDays(14);
                        this.training.Edit = true;
                        break;
                    case 2:
                        if (word.Know.Date == (new DateTime()).Date)
                        {
                            word.Know = DateTime.Now;
                            word.Next = DateTime.Now.AddDays(21);
                        }
                        else
                        {
                            word.Confirm = DateTime.Now;
                        }
                        this.training.Edit = true;
                        break;
                    default:
                        break;

                }

                this.ShowNextWord();
                this.preSelect = -1;
            }
        }
    }
}
