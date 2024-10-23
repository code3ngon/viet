using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class Warehouse_Menu : Form
    {
        public Warehouse_Menu()
        {
            InitializeComponent();
        }

        private void Check_Stock_Click(object sender, EventArgs e)
        {
            Warehouse_CheckStock warehouse_CheckStock = new Warehouse_CheckStock();
            warehouse_CheckStock.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Warehouse_Import warehouse_Import = new Warehouse_Import();
            warehouse_Import.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Warehouse_Export warehouse_Export = new Warehouse_Export();
            warehouse_Export.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Warehouse_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
