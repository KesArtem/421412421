using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerFirm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Desktop desktop = new Desktop();
            this.Hide();
            desktop.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Notebook notebook = new Notebook();
            this.Hide();
            notebook.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Printer printer = new Printer();
            this.Hide();
            printer.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Manufacture manufacture = new Manufacture();
            this.Hide();
            manufacture.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
