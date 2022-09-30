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
    public partial class Form18 : Form
    {
        private MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=car;charset=utf8;");
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=car;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form18()
        {
            InitializeComponent();
        }

        private void editback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form19 frm4 = new Form19();
            frm4.ShowDialog();
        }

        private void showEquiment() //แสดงข้อมูลของผู้ใช้
        {            
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM register WHERE Username = '" + Form1.UsernameloginS + "' or Username = '" + editusername.Text + "' ";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            showEquiment();
        }

        private void editdata_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();            
            String sql = "UPDATE register set Name = '" + editname.Text + "',Surname = '" + editsurname.Text + "'," +
                "Username = '" + editusername.Text + "',Password = '" + editpassword.Text + "',Phone = '" + editphone.Text + "',job = '" + editjob.Text + "' WHERE Username = '" + u_n + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            u_n = editusername.Text;
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("แก้ไขข้อมูลเรียบร้อย");
                showEquiment();
            }
        }
        string u_n;
        private void Form18_Shown(object sender, EventArgs e)
        {
            showEquiment();
            string sql2 = "SELECT * FROM register WHERE Username = '" + Form1.UsernameloginS+ "' AND Password = '" + Form1.PasswordloginS + "'";
            MySqlConnection conn3 = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=car;charset=utf8;");
            MySqlCommand cmd4 = new MySqlCommand(sql2, conn3);
            conn3.Open();
            DataTable dt4 = new DataTable();
            new MySqlDataAdapter(cmd4).Fill(dt4);
            MySqlDataReader xxxx = cmd4.ExecuteReader();

            if(xxxx.Read()) 
            {
                u_n= xxxx.GetString(3); //เอาข้อมูลตำแหน่งที่3ในDBมาเก็บใน u_n
                editname.Text = xxxx.GetString(1); //แสดง
                editsurname.Text = xxxx.GetString(2);
                editusername.Text = xxxx.GetString(3);
                editpassword.Text = xxxx.GetString(4);
                editphone.Text = xxxx.GetString(5);
                editjob.Text = xxxx.GetString(6);
            }
        }        
    }
}
