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
    public partial class Form22 : Form
    {
       
        public Form22()
        {
            InitializeComponent();           
        }

        private void buttoncal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form17 f2 = new Form17(this); //ไปหน้าคำนวณ
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form21 frm4 = new Form21(); //ไปหน้าโชว์รูม
            frm4.ShowDialog();
        }
    }
}
