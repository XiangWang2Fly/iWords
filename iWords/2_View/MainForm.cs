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
        private RememberStatus preSelect = RememberStatus.Invaild;
        #endregion


        // ----------------------------- 1st level methods ------------------------------
        public MainForm()
        {
            InitializeComponent();
            this.Text = Common.Version;
            this.buttonWrong.Visible = false;
            this.buttonRight.Visible = false;
            this.buttonNext.Visible = false;
            this.training.Load();
            this.training.Calc();
            this.labelConfirm.Text = this.training.Confirm.ToString();
            this.labelTotal.Text = this.training.Words.Count.ToString();
            if (this.training.Words.Count > 0)
            {
                this.labelRate.Text = string.Format("{0:F1} %", (float)this.training.Confirm / this.training.Words.Count * 100);
            }

            this.ShowNextWord();
        }



        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (this.labelChinese.Text != string.Empty)
            {
                this.preSelect = RememberStatus.Known;
                this.labelEnglish.Text = word.English;
                this.buttonWrong.Visible = true;
                this.buttonRight.Visible = true;
                this.buttonNext.Visible = false;
                this.Refresh();
            }
        }

        private void buttonVague_Click(object sender, EventArgs e)
        {
            if (this.labelChinese.Text != string.Empty)
            {
                this.preSelect = RememberStatus.Vague;
                this.labelEnglish.Text = word.English;
                this.buttonWrong.Visible = false;
                this.buttonRight.Visible = false;
                this.buttonNext.Visible = true;
                this.Refresh();
            }
        }

        private void buttonUnknown_Click(object sender, EventArgs e)
        {
            if (this.labelChinese.Text != string.Empty)
            {
                this.preSelect = RememberStatus.Unkonwn;
                this.labelEnglish.Text = word.English;
                this.buttonWrong.Visible = false;
                this.buttonRight.Visible = false;
                this.buttonNext.Visible = true;
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
                if (this.training.Words.Exists(u=>u.English == word.English))
                {
                    MessageBox.Show("The English exists!");
                    this.textBoxEnglish.Text = string.Empty;
                    this.textBoxChinese.Text = string.Empty;
                }
                else
                {
                    this.training.Add(word);
                    this.textBoxEnglish.Text = string.Empty;
                    this.textBoxChinese.Text = string.Empty;
                    this.training.Edit = true;
                    this.labelTotal.Text = this.training.Words.Count.ToString();
                }
                
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
                this.preSelect = RememberStatus.Invaild;
                this.buttonWrong.Visible = false;
                this.buttonRight.Visible = false;
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (this.labelEnglish.Text != string.Empty)
            {
                switch (preSelect)
                {
                    case RememberStatus.Unkonwn:
                        word.Next = DateTime.Now.AddDays(6);
                        this.training.Edit = true;
                        break;
                    case RememberStatus.Vague:
                        word.Next = DateTime.Now.AddDays(6);
                        this.training.Edit = true;
                        break;
                    case RememberStatus.Known:
                        if (word.Know.Date == (new DateTime()).Date)
                        {
                            word.Know = DateTime.Now;
                            word.Next = DateTime.Now.AddDays(31);
                        }
                        else
                        {
                            word.Confirm = DateTime.Now;
                            word.Next = DateTime.Now.AddDays(62);
                        }
                        this.training.Edit = true;
                        break;
                    default:
                        break;

                }

                this.ShowNextWord();
                this.preSelect = RememberStatus.Invaild;
                this.buttonWrong.Visible = false;
                this.buttonRight.Visible = false;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.ShowNextWord();
            this.preSelect = RememberStatus.Invaild;
            this.buttonNext.Visible = false;
        }

        #region //-------------------- 2nd level methods --------------------------------
        private void ShowNextWord()
        {
            word = this.training.GetNext();
            this.labelChinese.Text = word.Chinese;
            this.labelEnglish.Text = string.Empty;
        }

        enum RememberStatus
        {
            Invaild,
            Unkonwn,
            Vague,
            Known
        }

        #endregion
    }
}
