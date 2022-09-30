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
    public partial class Ad : Form
    {
        private MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=car;charset=utf8;");
        public Ad()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open(); //ลงกิตวิว
                string Sql = $"SELECT `Name`, `Surname`, `Phone`, `Car_model`, `Time`, `Date1`, `payment` FROM `reserve`";
                var cmd = new MySqlCommand(Sql, conn);
                DataTable dt = new DataTable();
                new MySqlDataAdapter(cmd).Fill(dt);
                datacustomer.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e) //ปุ่มออกจากระบบ
        {
            this.Hide();
            Form1 frm4 = new Form1();//ไปlogin
            frm4.ShowDialog();
        }

        private void Menu_Click(object sender, EventArgs e) //ปุ่มหน้าหลัก
        {
            this.Hide();
            Form19 frm4 = new Form19();//ไปหน้าเมนู
            frm4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) //ปุ่มคลังสินค้า
        {
            this.Hide();
            Form20 frm4 = new Form20();//ไปหน้าstock
            frm4.ShowDialog();
        }

        private void searchcar_TextChanged(object sender, EventArgs e) //พิมพ์หาข้อมูล
        {
            try
            {
                MySqlConnection cn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=car;charset=utf8;");
                MySqlCommand command;
                MySqlDataAdapter da;

                if (searchcar.Text != "")
                {
                    cn.Open();
                    command = new MySqlCommand($"SELECT * FROM `reserve` WHERE Car_model Like '%" + searchcar.Text + "%'", cn);
                    command.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    da = new MySqlDataAdapter(command);
                    da.Fill(dt);
                    datacustomer.DataSource = dt.DefaultView;
                    cn.Close();
                }
                else
                {
                    cn.Open();
                    command = new MySqlCommand($"SELECT * FROM `reserve`");
                    command.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    da = new MySqlDataAdapter(command);
                    da.Fill(dt);
                    datacustomer.DataSource = dt.DefaultView;
                    cn.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
