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
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        public static string UsernameloginS, PasswordloginS;
        private void Login_Click(object sender, EventArgs e) //เช็คว่าผู้ใช้กรอกตรงตามDB ไหม
        {
            string sql = "SELECT * FROM register WHERE Username = '" + Usernamelogin.Text + "' AND Password = '" + Passwordlogin.Text + "'"; 

            MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=car;charset=utf8;");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read()) //เอาไปเก็บในตัวแปล
            {
                UsernameloginS = Usernamelogin.Text;
                PasswordloginS = Passwordlogin.Text;
                this.Hide(); 
                Form19 wn = new Form19(); //ไปหน้าเมนู
                wn.Show(); ;
            }
            else
            {
                MessageBox.Show("กรุณาตรวจสอบข้อมูลให้ถูกต้อง", "ตรวจสอบความถูกต้องข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
        }

        private void Register_Click(object sender, EventArgs e) 
        {
            this.Hide();
            Form2 wn = new Form2(); //ไปหน้าลงทะเบียน
            wn.Show();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            {
                string sql = "SELECT * FROM admin WHERE Username = '" + Usernamelogin.Text + "' AND Password = '" + Passwordlogin.Text + "'";

                MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=car;charset=utf8;");
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    this.Hide(); 
                    Ad wn = new Ad(); //ไปหน้าแอดมิน
                    wn.Show();
                }
                else
                {
                    MessageBox.Show("กรุณาตรวจสอบข้อมูลให้ถูกต้อง", "ตรวจสอบความถูกต้องข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }  
    }
}
