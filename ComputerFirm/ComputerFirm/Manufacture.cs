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
    public partial class Manufacture : Form
    {
        public Manufacture()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.st42DataSet);

        }

        private void Manufacture_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st42DataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.st42DataSet.Product);

        }

        private void Manufacture_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 Main = new Form1();
            this.Hide();
            Main.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            productBindingSource.MoveFirst();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            productBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            productBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            productBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            productBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            productBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.st42DataSet);
        }
    }
}
