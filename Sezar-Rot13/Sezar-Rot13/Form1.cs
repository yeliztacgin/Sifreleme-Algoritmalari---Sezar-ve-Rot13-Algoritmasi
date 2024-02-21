using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sezar_Rot13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Ceaser(textBox1.Text, int.Parse(textBox2.Text));
        }

        private static string Ceaser(string text, int key)
        {
            ///key=3 A=65+3=68=D   B=66+3=69=E C=67+3=70=F
            StringBuilder builder = new StringBuilder();
            foreach (char item in text)
            {
                builder.Append(Convert.ToChar(Convert.ToInt32(item) + key));
            }



            return builder.ToString();
        }

    }
}
