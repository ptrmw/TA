using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA
{
    public partial class Form1 : Form
    {
        int x = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                timer1.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = 2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            serialPort1.WriteLine(x.ToString());
        }
    }
}
