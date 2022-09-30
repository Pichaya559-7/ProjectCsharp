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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=car;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        public string copyname, copysurname, copyphone, copycarmodel, copyday, copytime, copypay, copycarname; //ประกาศตัวแปร public
        private void Form3_Load(object sender, EventArgs e)
        {
            bookname1.Text = copyname;
            booksurname1.Text = copysurname;
            bookphone1.Text = copyphone;
            bookcarmodel1.Text = copycarmodel;
            day.Text = copyday;
            time.Text = copytime;
            pay.Text = copypay;
            bookcarmodel1.Text = copycarname;

            MySqlConnection conn = databaseConnection(); //ดึงข้อมูลคิวมาจาก DB
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM reserve ORDER BY id DESC LIMIT 1"; 
            MySqlDataReader row = cmd.ExecuteReader();
            if (row.HasRows)
            {
                while (row.Read())
                {
                    textBox3.Text = row.GetString(0);
                }
            }
            conn.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm4 = new Form1(); //ออกจากระบบ
            frm4.ShowDialog();
        }
    }
}
