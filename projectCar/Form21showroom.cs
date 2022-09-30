using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projectCar
{
    public partial class Form21 : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=car;charset=utf8;");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        public Form21()
        {
            InitializeComponent();
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            try //โชว์ดาต้ากิตวิว
            {
                conn.Open();
                string Sql = $"SELECT * FROM `carstock`";
                var cmd = new MySqlCommand(Sql, conn);
                DataTable dt = new DataTable();
                new MySqlDataAdapter(cmd).Fill(dt);
                datastockcar.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
        }

        private void datastockcar_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            datastockcar.CurrentRow.Selected = true;
            Path.Text = datastockcar.Rows[e.RowIndex].Cells["Path"].FormattedValue.ToString();
            pictureBox1.ImageLocation = $@"{Path.Text}";
        }

        private void dataGridView1_CellBoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form22 myForm = new Form22(); //คลิ๊กรถไปหน้าข้อมูล
            myForm.txtnamecar.Text = datastockcar.CurrentRow.Cells[1].Value.ToString();
            myForm.textBox2.Text = datastockcar.CurrentRow.Cells[2].Value.ToString();
            myForm.textBox3.Text = datastockcar.CurrentRow.Cells[3].Value.ToString();
            myForm.txtprice.Text = datastockcar.CurrentRow.Cells[5].Value.ToString();
            myForm.textBox6.Text = datastockcar.CurrentRow.Cells[6].Value.ToString();
            myForm.textBox7.Text = datastockcar.CurrentRow.Cells[7].Value.ToString();
            myForm.textBox8.Text = datastockcar.CurrentRow.Cells[8].Value.ToString();
            myForm.textBox9.Text = datastockcar.CurrentRow.Cells[9].Value.ToString();
            myForm.textBox10.Text = datastockcar.CurrentRow.Cells[10].Value.ToString();
            myForm.textBox11.Text = datastockcar.CurrentRow.Cells[11].Value.ToString();
            myForm.textBox12.Text = datastockcar.CurrentRow.Cells[12].Value.ToString();
            myForm.textBox13.Text = datastockcar.CurrentRow.Cells[13].Value.ToString();
            myForm.textBox14.Text = datastockcar.CurrentRow.Cells[14].Value.ToString();
            myForm.textBox15.Text = datastockcar.CurrentRow.Cells[15].Value.ToString();
            myForm.textBox16.Text = datastockcar.CurrentRow.Cells[16].Value.ToString();
            myForm.pictureBox1.ImageLocation = datastockcar.CurrentRow.Cells[4].Value.ToString();
            myForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) //ปุ่มย้อนกลับ
        {
            this.Hide();
            Form19 frm4 = new Form19(); //ไปหน้าเมนู
            frm4.ShowDialog();
        }
    }
}
