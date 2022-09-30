using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectCar
{
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }
        private void Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form21 frm4 = new Form21(); //ไปหน้าโชว์รูมรถ
            frm4.ShowDialog();
        }
        private void Editregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form18 frm4 = new Form18(); //ไปหน้าแก้ไขข้อมูล
            frm4.ShowDialog();
        }
        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm4 = new Form1(); //ออกจากระบบ
            frm4.ShowDialog();
        }
    }
}
