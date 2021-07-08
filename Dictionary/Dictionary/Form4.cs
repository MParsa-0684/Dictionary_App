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
    public partial class Form4 : Form
    {
        Random rnd = new Random();
        public int mmm;
        int[] items;
        string[] main;
        string[] answer;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            items = new int[4];
            for(int m=0; m < 4; m++)
            {
                items[m] = rnd.Next(1,mmm-1);
            }
            int j = 1;
            string line;
            string[] parts;
            main = new string[4];
            answer = new string[4];
            for(int c=0; c<4; c++)
            {
                j = 0;
                using (StreamReader Sr = new StreamReader("Dictionary.txt"))
                {
                    while (!Sr.EndOfStream)
                    {
                        line = Sr.ReadLine();
                        if (line != "" )
                        {
                            if (items[c] == j)
                            {
                                parts = line.Split('$');
                                main[c] = parts[0];
                                answer[c] = parts[1];
                                break;
                            }
                            else
                            {
                                j++;
                            }
                        }
                    }
                }
            }
            label2.Text = "1. "+main[0];
            label3.Text = "2. "+main[1];
            label5.Text = "3. "+main[2];
            label4.Text = "4. "+main[3];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((answer[0].ToLower()).Contains(textBox1.Text.ToLower()))
            {
                label10.Text = "✔";
            }
            else
            {
                label10.Text = "❌";
            }
            if ((answer[1].ToLower()).Contains(textBox2.Text.ToLower()))
            {
                label9.Text = "✔";
            }
            else
            {
                label9.Text = "❌";
            }
            if ((answer[2].ToLower()).Contains(textBox3.Text.ToLower()))
            {
                label8.Text = "✔";
            }
            else
            {
                label8.Text = "❌";
            }
            if ((answer[3].ToLower()).Contains(textBox4.Text.ToLower()))
            {
                label7.Text = "✔";
            }
            else
            {
                label7.Text = "❌";
            }
        }
    }
}
