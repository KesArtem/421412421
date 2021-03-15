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
    public partial class Printer : Form
    {
        public Printer()
        {
            InitializeComponent();
        }

        private void printerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.printerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.st42DataSet);

        }

        private void Printer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st42DataSet.Printer". При необходимости она может быть перемещена или удалена.
            this.printerTableAdapter.Fill(this.st42DataSet.Printer);

        }
        private void Printer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 Main = new Form1();
            this.Hide();
            Main.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printerBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printerBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printerBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printerBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            printerBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            printerBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.printerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.st42DataSet);
        }
    }
}
