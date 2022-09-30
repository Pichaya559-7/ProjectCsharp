namespace projectCar
{
    partial class Form17
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calculatecar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.calculateinstallment = new System.Windows.Forms.TextBox();
            this.backcarshow = new System.Windows.Forms.Button();
            this.textdown = new System.Windows.Forms.ComboBox();
            this.textinstallment = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(77, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ราคารถ (บาท)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(77, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "เงินดาวน์ (บาท)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(83, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "จำนวนงวด (ปี)";
            // 
            // calculatecar
            // 
            this.calculatecar.BackColor = System.Drawing.Color.OrangeRed;
            this.calculatecar.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatecar.Location = new System.Drawing.Point(297, 308);
            this.calculatecar.Name = "calculatecar";
            this.calculatecar.Size = new System.Drawing.Size(131, 72);
            this.calculatecar.TabIndex = 8;
            this.calculatecar.Text = "คำนวณ";
            this.calculatecar.UseVisualStyleBackColor = false;
            this.calculatecar.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(134, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "ค่างวด";
            // 
            // calculateinstallment
            // 
            this.calculateinstallment.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.calculateinstallment.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateinstallment.ForeColor = System.Drawing.Color.Black;
            this.calculateinstallment.Location = new System.Drawing.Point(279, 420);
            this.calculateinstallment.Name = "calculateinstallment";
            this.calculateinstallment.Size = new System.Drawing.Size(166, 31);
            this.calculateinstallment.TabIndex = 15;
            // 
            // backcarshow
            // 
            this.backcarshow.BackColor = System.Drawing.Color.MediumAquamarine;
            this.backcarshow.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backcarshow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.backcarshow.Location = new System.Drawing.Point(400, 489);
            this.backcarshow.Name = "backcarshow";
            this.backcarshow.Size = new System.Drawing.Size(145, 53);
            this.backcarshow.TabIndex = 17;
            this.backcarshow.Text = "กลับไปหน้าหลัก";
            this.backcarshow.UseVisualStyleBackColor = false;
            this.backcarshow.Click += new System.EventHandler(this.backcarshow_Click);
            // 
            // textdown
            // 
            this.textdown.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textdown.FormattingEnabled = true;
            this.textdown.Items.AddRange(new object[] {
            "5000",
            "10000",
            "50000",
            "100000",
            "150000",
            "200000"});
            this.textdown.Location = new System.Drawing.Point(259, 173);
            this.textdown.Name = "textdown";
            this.textdown.Size = new System.Drawing.Size(186, 35);
            this.textdown.TabIndex = 18;
            // 
            // textinstallment
            // 
            this.textinstallment.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textinstallment.FormattingEnabled = true;
            this.textinstallment.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.textinstallment.Location = new System.Drawing.Point(259, 246);
            this.textinstallment.Name = "textinstallment";
            this.textinstallment.Size = new System.Drawing.Size(186, 35);
            this.textinstallment.TabIndex = 19;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox2.Location = new System.Drawing.Point(259, 109);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(186, 36);
            this.textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox3.Location = new System.Drawing.Point(259, 46);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(186, 36);
            this.textBox3.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(84, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 27);
            this.label4.TabIndex = 24;
            this.label4.Text = "ชื่อรถ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Angsana New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.Location = new System.Drawing.Point(232, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 53);
            this.button2.TabIndex = 26;
            this.button2.Text = "จอง";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::projectCar.Properties.Resources.สีดำ_สีน้ำตาล_มันขลับและมืออาชีพ_พื้นฐาน_เรียบง่าย_งานนำเสนอ;
            this.ClientSize = new System.Drawing.Size(662, 575);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textinstallment);
            this.Controls.Add(this.textdown);
            this.Controls.Add(this.backcarshow);
            this.Controls.Add(this.calculateinstallment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.calculatecar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form17";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "คำนวณ";
            this.Load += new System.EventHandler(this.Form17_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calculatecar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox calculateinstallment;
        private System.Windows.Forms.Button backcarshow;
        private System.Windows.Forms.ComboBox textdown;
        private System.Windows.Forms.ComboBox textinstallment;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
    }
}