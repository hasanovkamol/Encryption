using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metroTextBox1.Visible = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
            if(metroComboBox1.Text== "Sezir Encryption")
            {
                richTextBox2.Text = SezirKey(matin.Text.ToUpper(), int.Parse(metroTextBox1.Text));
            }
            else if("Polibiy" == metroComboBox1.Text)
            {
                richTextBox2.Text = PloibiyaLog(matin.Text.ToUpper());
            }
        }
        
       /// <summary>
       /// Ecryption and unencrption For Sezir Log
       /// </summary>
       /// <param name="matin"></param>
       /// <param name="key"></param>
       /// <returns></returns>
        private string SezirKey(string matin, int key)
        {
            string keymatin = "";
            foreach (var item in matin)
            {
                if ((int)item>=65 && (int)item<=91)
                {

                    if(key>0)
                    {
                        if ((91 - (int)item) >= key)
                        {
                            keymatin += (char)((int)item + key);
                        }
                        else
                        {
                            keymatin += (char)(65 + (key - (91 - (int)item)));
                        }
                    }
                    else
                    {
                        if((int)item-65>=Math.Abs(key))
                        {
                            keymatin += (char)((int)item + key);
                        }
                        else
                        {
                            keymatin += (char)(91 + ((int)item - 65)+key);
                        }
                    }
                }
                else
                {
                    keymatin += item;
                }
               
            }
            return keymatin;
        }


        /// <summary>
        /// Encryption for Ploibiy Log
        /// </summary>
        /// <param name="PloibiyLog"></param>
        /// <param name="matin"></param>
        /// 
        private string PloibiyaLog(string matin)
        {
            int i = 0, j = 0;
            string keymatin = "";
            foreach (var item in matin)
            {
                if ((int)item>=65 && (int)item<=90)
                {

                    i = ((int)item - 65) / 5;
                    j = ((int)item - 65) % 5;
                    keymatin += (char)(65 + i);
                    keymatin += (char)(65 + j);
                }
                else
                {
                    keymatin += item;
                }

            }

            return keymatin;
        }

        /// <summary>
        /// unencryption for Ploibiya Log
        /// </summary>
        /// <param name="PloibyLog"></param>
        /// <param name="mation"></param>
        private string UnPloibyaLog(string matin)
        {
            int i = 0, j = 0;
            int k = 0;
            string keymatin = "";
            foreach (var item in matin)
            {
                if ((int)item >= 65 && (int)item <= 90)
                {
                    k++;
                    i = (int)item - 65;
                    if (k==2)
                    {
                        k = 0;
                        keymatin += (char)(65 + j * 5 + i);
                    }
                    else
                    {
                        j = i;
                    }

                }
                else
                {
                    keymatin += item;
                }
            }

            return keymatin;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(metroComboBox1.Text=="Sezir Encryption")
            {
                metroTextBox1.Visible = true;
                metroTextBox1.Text = "0";
            }
            else
            {
                metroTextBox1.Visible = false;
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            if (metroComboBox1.Text == "Sezir Encryption")
            {
                richTextBox2.Text = SezirKey(richTextBox2.Text, (-1)* int.Parse(metroTextBox1.Text));
            }
            else if(metroComboBox1.Text== "Polibiy")
            {
                richTextBox2.Text = UnPloibyaLog(richTextBox2.Text);
            }
        }
    }
}
