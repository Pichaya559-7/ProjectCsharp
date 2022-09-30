namespace projectCar
{
    partial class Ad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datacustomer = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.searchcar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datacustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // datacustomer
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bodoni MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.datacustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datacustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datacustomer.Location = new System.Drawing.Point(50, 98);
            this.datacustomer.Name = "datacustomer";
            this.datacustomer.RowHeadersWidth = 51;
            this.datacustomer.RowTemplate.Height = 24;
            this.datacustomer.Size = new System.Drawing.Size(786, 378);
            this.datacustomer.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(858, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "ออกจากระบบ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(59, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "ตารางการจองของลูกค้า";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.SaddleBrown;
            this.Menu.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu.Location = new System.Drawing.Point(858, 228);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(124, 69);
            this.Menu.TabIndex = 3;
            this.Menu.Text = "กลับไปหน้าหลัก";
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Olive;
            this.button2.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(858, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 69);
            this.button2.TabIndex = 4;
            this.button2.Text = "คลังสินค้า";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchcar
            // 
            this.searchcar.Location = new System.Drawing.Point(488, 42);
            this.searchcar.Multiline = true;
            this.searchcar.Name = "searchcar";
            this.searchcar.Size = new System.Drawing.Size(348, 33);
            this.searchcar.TabIndex = 13;
            this.searchcar.TextChanged += new System.EventHandler(this.searchcar_TextChanged);
            // 
            // Ad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = global::projectCar.Properties.Resources.สีดำ_สีน้ำตาล_มันขลับและมืออาชีพ_พื้นฐาน_เรียบง่าย_งานนำเสนอ;
            this.ClientSize = new System.Drawing.Size(1024, 505);
            this.Controls.Add(this.searchcar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datacustomer);
            this.Name = "Ad";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form18_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datacustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datacustomer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox searchcar;
    }
}