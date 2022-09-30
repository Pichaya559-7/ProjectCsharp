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
    public partial class Form20 : Form
    {        
        public Form20()
        {
            InitializeComponent();
        }
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=car;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        private void button3_Click(object sender, EventArgs e) //อัพเดทข้อมูล
        {
            int selectedRow = dataGridView1.CurrentCell.RowIndex; //รับค่า index ของ cell ที่คลิก
            int edits = Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells["id"].Value); //ดึงข้อมูล id มาเก็บไว้ในตัวแปร
            MySqlConnection conn = databaseConnection();
            String sql1 = "UPDATE carstock SET carmodel = '" + textBox1.Text + "',Price = '" + txtprice.Text + "',length = '" + textBox13.Text + "',Fuel_type ='" + textBox6.Text + "',Seats ='" + textBox7.Text + "',Registration_type ='" + textBox8.Text + "',Key_type ='" + textBox16.Text + "',Insurance_end ='" + textBox10.Text + "',Used ='" + textBox11.Text + "',color ='" + textBox3.Text + "',Registration ='" + textBox12.Text + "',amount ='" + textBox2.Text + "',Manual ='" + textBox14.Text + "',tax_end ='" + textBox15.Text + "',Accident ='" + textBox9.Text + "' WHERE id = '" + edits + "'";
            MySqlCommand cmd = new MySqlCommand(sql1, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("แก้ไขข้อมูลเรียบร้อยแล้ว");
                showMyCar();
            }
        }
        private void showMyCar() //โชว์ข้อมูลที่แก้ไขแล้ว
        {
            try
            {
                MySqlConnection conn = databaseConnection();
                conn.Open();
                string Sql = $"SELECT * FROM `carstock`";
                var cmd = new MySqlCommand(Sql, conn);
                DataTable dt = new DataTable();
                new MySqlDataAdapter(cmd).Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
        }


        private void Form20_Load(object sender, EventArgs e)
        {
            showMyCar();
        }

        private void delete_Click(object sender, EventArgs e) //ลบข้อมูล
        {
            int selectedRow = dataGridView1.CurrentCell.RowIndex; //รับค่า index ของ cell ที่คลิก
            int deletes = Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells["id"].Value); //ดึงข้อมูล id มาเก็บไว้ในตัวแปร
            MySqlConnection conn = databaseConnection();
            String sql1 = "DELETE FROM carstock WHERE id = '" + deletes + "'";
            MySqlCommand cmd = new MySqlCommand(sql1, conn);
            conn.Open();
            if (MessageBox.Show("คุณต้องการที่จะลบหรือไม่", "ลบข้อมูลเรียบร้อย", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                if (rows > 0)
                {
                    MessageBox.Show("ลบข้อมูลเรียบร้อย");
                    showMyCar();
                }
            }
            else
            {
                MessageBox.Show("ข้อมูลไม่ถูกลบ", "Delete Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //เอาข้อมูลจากDBลงtextBox
        {
            dataGridView1.CurrentRow.Selected = true;
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["carmodel"].FormattedValue.ToString();
            txtprice.Text = dataGridView1.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
            textBox13.Text = dataGridView1.Rows[e.RowIndex].Cells["length"].FormattedValue.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["Fuel_type"].FormattedValue.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells["Seats"].FormattedValue.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells["Registration_type"].FormattedValue.ToString();
            textBox16.Text = dataGridView1.Rows[e.RowIndex].Cells["Key_type"].FormattedValue.ToString();
            textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells["Insurance_end"].FormattedValue.ToString();
            textBox11.Text = dataGridView1.Rows[e.RowIndex].Cells["Used"].FormattedValue.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["color"].FormattedValue.ToString();
            textBox12.Text = dataGridView1.Rows[e.RowIndex].Cells["Registration"].FormattedValue.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["amount"].FormattedValue.ToString();
            textBox14.Text = dataGridView1.Rows[e.RowIndex].Cells["Manual"].FormattedValue.ToString();
            textBox15.Text = dataGridView1.Rows[e.RowIndex].Cells["tax_end"].FormattedValue.ToString();
            textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells["Accident"].FormattedValue.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e) //ปุ่มย้อนกลับ
        {
            this.Hide();
            Ad frm4 = new Ad(); //ย้อนกลับไปหน้าแอดมิน
            frm4.ShowDialog();
        }

        private void searchcar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=car;charset=utf8;");
                MySqlCommand command;
                MySqlDataAdapter da;

                if (searchcar.Text != "")
                {
                    cn.Open();
                    command = new MySqlCommand($"SELECT * FROM `carstock` WHERE carmodel Like '%" + searchcar.Text + "%'", cn);
                    command.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    da = new MySqlDataAdapter(command);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt.DefaultView;
                    cn.Close();
                }
                else
                {
                    cn.Open();
                    command = new MySqlCommand($"SELECT * FROM `carstock`");
                    command.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    da = new MySqlDataAdapter(command);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt.DefaultView;
                    cn.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void add_Click(object sender, EventArgs e) //เพิ่มข้อมูล
        {
            MySqlConnection conn = databaseConnection();
            String sql = "INSERT INTO carstock (id,carmodel,Price,length,Fuel_type,Seats,Registration_type,Key_type,Insurance_end,Used,color,Registration,amount,Manual,tax_end,Accident) VALUES(NULL,'" + textBox1.Text + "','" + txtprice.Text + "','" + textBox13.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox16.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox3.Text + "','" + textBox12.Text + "','" + textBox2.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox9.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if(rows > 0)
            {
                MessageBox.Show("เพิ่มข้อมูลเรียบร้อย");
            }

        }
    }
}
