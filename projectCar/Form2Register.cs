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
using System.Text.RegularExpressions;

namespace projectCar
{
    public partial class Form2 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;

        public Form2()
        {
            InitializeComponent();
        }
        private void memberregister_Click(object sender, EventArgs e) //ปุ่มลงทะเบียน
        {
            connection.Open();
            string selectQuery = "SELECT * FROM car.register WHERE Username = '" + textBoxusername.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            var hasMiniMaxChars = new Regex(@".{8,20}");
            if (mdr.Read())
            {
                MessageBox.Show("ชื่อผู้ใช้นี้ถูกใช้แล้ว!");
            }
            else if (!hasMiniMaxChars.IsMatch(Passwordregister.Text))
            {
                MessageBox.Show("กรุณากรอกจำนวนให้ครบ!");
            }         
            else
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=car;";
                string iquery = "INSERT INTO register(`Name`, `Surname`, `Username`, `Password`, `Phone`, `job`, `address`) VALUES ('" + Nameregister.Text + "', '" + Surnameregister.Text + "', '" + textBoxusername.Text + "', '" + Passwordregister.Text + "', '" + callregister.Text + "', '" + jobregister.Text + "', '" + addressregister.Text + "')";

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

                MessageBox.Show("ทำการลงบทะเบียนเรียบร้อยแล้วค่ะ!");
                this.Hide();
                Form1 wn = new Form1(); //ไปหน้าlogin
                wn.Show();
            }
            connection.Close();

            if (string.IsNullOrEmpty(Nameregister.Text) || string.IsNullOrEmpty(Surnameregister.Text) || string.IsNullOrEmpty(textBoxusername.Text) || string.IsNullOrEmpty(Passwordregister.Text) || string.IsNullOrEmpty(callregister.Text))
            {
                MessageBox.Show("กรุณากรอกช่องว่างให้ครบ!");
            }          
        }
    }
}
