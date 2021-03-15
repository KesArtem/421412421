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
    public partial class TableDesktop : Form
    {
        public TableDesktop()
        {
            InitializeComponent();
        }

        private void productAllBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productAllBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.st42DataSet);

        }

        private void TableDesktop_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st42DataSet.ProductAll". При необходимости она может быть перемещена или удалена.
            this.productAllTableAdapter.Fill(this.st42DataSet.ProductAll);
        }
        private System.Windows.Forms.DataGridViewColumn COL;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            COL = new System.Windows.Forms.DataGridViewColumn();
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    COL = dataGridViewTextBoxColumn1;

                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn2;

                    break;
                case 2:
                    COL = dataGridViewTextBoxColumn3;

                    break;
                case 3:
                    COL = dataGridViewTextBoxColumn4;

                    break;
                case 4:
                    COL = dataGridViewTextBoxColumn5;

                    break;
                case 5:
                    COL = dataGridViewTextBoxColumn6;

                    break;
                case 6:
                    COL = dataGridViewTextBoxColumn7;

                    break;
                case 7:
                    COL = dataGridViewTextBoxColumn8;

                    break;
            }
                    if (radioButton1.Checked)
                productAllDataGridView.Sort(COL,
                System.ComponentModel.ListSortDirection.Ascending);
            else
                productAllDataGridView.Sort(COL,
                System.ComponentModel.ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productAllBindingSource.Filter = "LModel='" + comboBox1.Text + "'";
            productAllBindingSource.Filter = "PCModel='" + comboBox1.Text + "'";
            productAllBindingSource.Filter = "PrintModel='" + comboBox1.Text + "'";
            productAllBindingSource.Filter = "LPrice='" + comboBox1.Text + "'";
            productAllBindingSource.Filter = "PCPrice='" + comboBox1.Text + "'";
            productAllBindingSource.Filter = "PrintPrice='" + comboBox1.Text + "'";
            productAllBindingSource.Filter = "Maker='" + comboBox1.Text + "'";
            productAllBindingSource.Filter = "type='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            productAllBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < productAllDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < productAllDataGridView.RowCount - 1; j++)
                {
                    productAllDataGridView[i, j].Style.BackColor = Color.White;
                    productAllDataGridView[i, j].Style.ForeColor = Color.Black;

                }
            }
            for (int i = 0; i < productAllDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < productAllDataGridView.RowCount - 1; j++)
                {
                    if (productAllDataGridView[i,
                    j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        productAllDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        productAllDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
