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
    public partial class Form23 : Form
    {
        Form17 F1;
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=car;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        
        public Form23(Form17 frm1)
        {
            InitializeComponent();
            this.F1 = frm1;
        }

        private void Bookcarattain_Click(object sender, EventArgs e) //ปุ่มจองรถ
        {
            pictureBox1.Visible = true;
            button2.Visible = true;
            if (string.IsNullOrEmpty(booktime.Text) || string.IsNullOrEmpty(dateTimePicker1.Text) || string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("กรุณากรอกช่องข้อมูลให้ครบ!");
            }           
        }
      
        
        public string copyname, copysurname, copyphone, copycarmodel, copyday, copytime, copypay, copycarname;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=car;";
            string iquery = "INSERT INTO  `reserve`(`ID`, `Name`, `Surname`, `Phone`, `Car_model`, `Time`, `Date1`, `payment`) VALUES (NULL,'" + bookname.Text + "','" + booksurname.Text + "', '" + bookphone.Text + "', '" + bookcarmodel.Text + "','" + booktime.Text + "','" + dateTimePicker1.Value.ToString() + "','" + comboBox2.Text + "')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(iquery, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("เพิ่มข้อมูลของคุณเรียบร้อยแล้วค่ะ");

            Form3 edit = new Form3();
            edit.copyname = bookname.Text;
            edit.copysurname = booksurname.Text;
            edit.copyphone = bookphone.Text;
            edit.copycarmodel = bookcarmodel.Text;
            edit.copyday = dateTimePicker1.Text;
            edit.copytime = booktime.Text;
            edit.copypay = comboBox2.Text;
            edit.copycarname = bookcarmodel.Text;
            edit.ShowDialog();
            this.Hide();
        }

        private void Form23_Shown(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            button2.Visible = false;
            MySqlConnection conn = databaseConnection(); //ทำการเลือกดึงข้อมูลเฉพาะชื่อใช้มา
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM register WHERE Username = '{Form1.instance.Usernamelogin.Text}'";  
            MySqlDataReader row = cmd.ExecuteReader();
            string bookname2 = ""; //สร้างตัวแปร
            string booksurname2 = "";
            string bookphone2 = "";

            while (row.Read()) //ดึงข้อมูลจากdatabase
            {
                bookname2 = row.GetString(1);
                booksurname2 = row.GetString(2);
                bookphone2 = row.GetString(5);
            }
            bookname.Text = bookname2.ToString(); //เอาข้อมูลมาแสดง
            booksurname.Text = booksurname2.ToString();
            bookphone.Text = bookphone2.ToString();
            conn.Close();
            bookcarmodel.Text = copycarname;
        }
    }
}
