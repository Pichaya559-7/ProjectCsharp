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
    
    public partial class Form17 : Form
    {
        Form22 F1; //เป็นการส่งข้อมูลด้วยตัวแปล F1
        public Form17(Form22 frm1)
        {
            InitializeComponent();
            this.F1 = frm1;
        }
        public string copycarname;
        private void Form17_Load(object sender, EventArgs e)
        {            
            textBox3.Text = copycarname;
            textBox2.Text = F1.txtprice.Text;
            textBox3.Text = F1.txtnamecar.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textdown.SelectedItem == null || textinstallment.SelectedItem == null)
            {
                MessageBox.Show("กรุณากรอกช่องว่างให้ครบ! ");                
            }            
            else //คำนวณงวดรถ
            {
                int a = int.Parse(textBox2.Text); //ราคารถ
                int b = int.Parse(textdown.Text); //ราคาดาวน์
                int c = int.Parse(textinstallment.Text); // ค่างวด
                int purchase = a - b; 
                int rateyear = (purchase * 8) / 100;
                int totalinterest = rateyear * c;
                int total = totalinterest + purchase;
                int ratemount = total / (c * 12);
                int total1 = ratemount + (7 / 100);
                calculateinstallment.Text = total1.ToString();
            }
        }

        private void backcarshow_Click(object sender, EventArgs e) //ปุ่มย้อนกลับ
        {
            this.Hide();
            Form21 wn = new Form21(); //ไปหน้าโชว์รูม
            wn.Show();
        }

        private void button2_Click(object sender, EventArgs e) //ปุ่มจอง
        {
            this.Hide();
            Form23 F2 = new Form23(this); //ไปหน้าจอง
            F2.copycarname = textBox3.Text;
            F2.ShowDialog();           
        }
    }
}
