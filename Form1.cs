using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.International.Converters.PinYinConverter;
using System.IO;

namespace AddPhonetic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtFilePath.Text = openFileDialog1.FileName;
        }

        private void btnSavePath_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            txtSavePath.Text = saveFileDialog1.FileName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<List<string>> vCards = new List<List<string>>();
            List<string> vCard = new List<string>();

            string strFilePath = txtFilePath.Text;
            using (FileStream fs = new FileStream(strFilePath, FileMode.Open,FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string strTemp="";
                    string strUserName="";
                    bool isHavePhonFN = false;
                    bool isHavePhonLN = false;
                    while (!string.IsNullOrEmpty(strTemp = sr.ReadLine()))
                    {
                        if (strTemp.Trim().ToUpper() == "BEGIN:VCARD")
                        {
                            vCard = new List<string>();
                        }
                        else if (strTemp.Trim().ToUpper().IndexOf("FN:")==0)
                        {
                            strUserName = strTemp.Substring(3);
                        }
                        else if (strTemp.Trim().ToUpper().IndexOf("X-PHONETIC-FIRST-NAME:")==0)
                        {
                            isHavePhonFN = true;
                        }
                        else if (strTemp.Trim().ToUpper().IndexOf("X-PHONETIC-LAST-NAME:")==0)
                        {
                            isHavePhonFN = true;
                        }
                        else if (strTemp.Trim().ToUpper() == "END:VCARD")
                        {
                            string[] arrUserName = strUserName.Split(' ');
                            int l = arrUserName.Length;
                            if (!isHavePhonLN&&l>0)
                            {
                                string strLastName=arrUserName[l-1];
                                string strPinYin = GetPinYin(strLastName);
                                if (!string.IsNullOrEmpty(strPinYin))
                                {
                                    vCard.Add("X-PHONETIC-LAST-NAME:" + strPinYin);
                                }
                            }
                            if (!isHavePhonFN && l > 1)
                            {
                                string strPinYin = GetPinYin(arrUserName[0]);
                                if (!string.IsNullOrEmpty(strPinYin))
                                {
                                    vCard.Add("X-PHONETIC-FIRST-NAME:" + strPinYin);
                                }
                            }
                            vCard.Add(strTemp);
                            vCards.Add(vCard);

                            strTemp = "";
                            strUserName = "";
                            isHavePhonFN = false;
                            isHavePhonLN = false;
                            continue;
                        }
                        vCard.Add(strTemp);
                    }
                }
            }
            SaveFile(vCards);
            MessageBox.Show("保存成功");
        }

        private string GetPinYin(string str)
        {
            StringBuilder sbPinYin = new StringBuilder();
            foreach (char ch in str)
            {
                ChineseChar cc = new ChineseChar(ch);
                
                string strPinYin = cc.Pinyins[0].Trim();

                if (ch == '万') {
                    strPinYin = "WAN4";
                }

                strPinYin = strPinYin.Remove(strPinYin.Length - 1).ToLower();


                sbPinYin.Append(strPinYin.Substring(0, 1).ToUpper() + strPinYin.Substring(1));
            }
            return sbPinYin.ToString();
        }

        private void SaveFile(List<List<string>> vCards)
        {
            saveFileDialog1.DefaultExt = "vcf";
            saveFileDialog1.FileName = "new.vcf";
            saveFileDialog1.ShowDialog();
            txtSavePath.Text = saveFileDialog1.FileName;

            using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
            {
                foreach (List<string> vCard in vCards)
                {
                    foreach (string str in vCard)
                    {
                        sw.WriteLine(str);
                    }
                }
            }
        }
    }
}
