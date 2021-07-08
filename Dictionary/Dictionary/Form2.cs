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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string synonyms = File.ReadAllText("Dictionary.txt");
            using(StreamWriter SW = new StreamWriter("Dictionary.txt"))
            {
                SW.Write(synonyms+"\n"+ textBox1.Text + "$" + textBox2.Text + "$");
                SW.Close();
            }
            this.Close();
        }
    }
}
