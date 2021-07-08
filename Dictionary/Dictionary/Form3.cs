using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dictionary
{
    public partial class Form3 : Form
    {
        int chose;
        bool result=false;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            chose = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            chose = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = false;
            label5.Text = "";
            label4.Text = "Result :";
            using (StreamReader SR = new StreamReader("Dictionary.txt"))
            {
                while (!SR.EndOfStream)
                {
                    string line = SR.ReadLine();
                    if (line != "")
                    {
                        string[] parts = line.Split('$');
                        if(chose == 0)
                        {
                            if ((parts[0].ToLower()).Contains(textBox1.Text.ToLower()))
                            {
                                label4.Text = "Result : Yes";
                                label5.Text = label5.Text + parts[0] + " : " + parts[1]+"\n";
                                result = true;
                            }

                        }
                        if(chose == 1)
                        {
                            if ((parts[1].ToLower()).Contains(textBox1.Text.ToLower()))
                            {
                                label4.Text = "Result : Yes";
                                label5.Text = label5.Text + parts[0] + " : " + parts[1] + "\n";
                                result = true;
                            }

                        }


                    }
                }
            }
            if (result == false)
            {
                label4.Text = "Result : No\nThere is No synonym here !";
            }
            else
            {
                label5.Text = label5.Text + " ";
            }
        }
    }
}
