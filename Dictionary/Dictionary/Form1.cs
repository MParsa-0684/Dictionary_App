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
    public partial class Form1 : Form
    {
        public int i;
        Size label2size;
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            i = 1;
            label3.Text = "";
            label2size = label2.Size;
            using (StreamReader SR = new StreamReader("Dictionary.txt"))
            {
                while (!SR.EndOfStream)
                {
                    string line =SR.ReadLine();
                    if (line != "")
                    {
                        string[] parts = line.Split('$');
                        label3.Text = label3.Text +i+". " + parts[0] + " : " + parts[1] + "\n";
                        if (i >= 18)
                        {
                            label2.Size = new Size(label2.Size.Width, label2.Size.Height + 26);
                        }
                        if(i == 29)
                        {
                            label2.Size = new Size(label2.Size.Width, label2.Size.Height + 26);
                        }
                        i++;
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void randomQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            form4.mmm = i;
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i = 1;
            label3.Text = "";
            label2.Size = label2size;
            using (StreamReader SR = new StreamReader("Dictionary.txt"))
            {
                while (!SR.EndOfStream)
                {
                    string line = SR.ReadLine();
                    if (line != "")
                    {
                        string[] parts = line.Split('$');
                        label3.Text = label3.Text + i + ". " + parts[0] + " : " + parts[1] + "\n";
                        if (i >= 18)
                        {
                            label2.Size = new Size(label2.Size.Width, label2.Size.Height + 26);
                        }
                        if (i == 29)
                        {
                            label2.Size = new Size(label2.Size.Width, label2.Size.Height + 26);
                        }
                        i++;
                    }
                }
            }
        }
    }
}
