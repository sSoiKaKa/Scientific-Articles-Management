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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker2.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker2.CustomFormat = "yyyy/MM/dd";
            this.dataGridView1.Rows.Add("00000", "Trần Quốc Tuấn", "19/08/2000", "Nam", "0123456789", "Xem", "Sửa", "Xoá");
            this.dataGridView1.Rows.Add("00001", "Nguyễn Lê Anh Minh", "19/08/2000", "Nam", "0123456789", "Xem", "Sửa", "Xoá");
            this.dataGridView1.Rows.Add("00002", "Nguyễn Đình Dũng", "19/08/2000", "Nam", "0123456789", "Xem", "Sửa", "Xoá");
            this.dataGridView1.Rows.Add("00003", "Trần Quốc Tuấn", "19/08/2000", "Nam", "0123456789", "Xem", "Sửa", "Xoá");
            this.dataGridView1.Rows.Add("00004", "Nguyễn Lê Anh Minh", "19/08/2000", "Nam", "0123456789", "Xem", "Sửa", "Xoá");
            this.dataGridView1.Rows.Add("00005", "Nguyễn Đình Dũng", "19/08/2000", "Nam", "0123456789", "Xem", "Sửa", "Xoá");
            this.dataGridView1.Rows.Add("00006", "Trần Quốc Tuấn", "19/08/2000", "Nam", "0123456789", "Xem", "Sửa", "Xoá");
            this.dataGridView1.Rows.Add("00007", "Nguyễn Lê Anh Minh", "19/08/2000", "Nam", "0123456789", "Xem", "Sửa", "Xoá");
            this.dataGridView1.Rows.Add("00008", "Nguyễn Đình Dũng", "19/08/2000", "Nam", "0123456789", "Xem", "Sửa", "Xoá");
            this.dataGridView1.Rows.Add("00009", "Trần Quốc Tuấn", "19/08/2000", "Nam", "0123456789", "Xem", "Sửa", "Xoá");
            this.dataGridView1.Rows.Add("00010", "Nguyễn Lê Anh Minh", "19/08/2000", "Nam", "0123456789", "Xem", "Sửa", "Xoá");
            this.dataGridView1.Rows.Add("00011", "Nguyễn Đình Dũng", "19/08/2000", "Nam", "0123456789", "Xem", "Sửa", "Xoá");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
