using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAHTTT
{
    public partial class QuanLyQuangCao : Form
    {
        public QuanLyQuangCao()
        {
            InitializeComponent();
            this.dataGridView1.Rows.Add("ADS0001", "Harry Potter 7", "Top, Left", "20:00 01/05/2020 - 20:00 31/05/2020", "Xem", "Xoá");
            this.dataGridView1.Rows.Add("ADS0002", "Fast and Furious 3", "Top", "20:00 01/06/2020 - 20:00 31/06/2020", "Xem", "Xoá");
            this.dataGridView1.Rows.Add("ADS0001", "Alice in Wonderland", "Top, Left Right", "20:00 01/07/2020 - Now", "Xem", "Xoá");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
