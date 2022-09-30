namespace projectCar
{
    partial class Form19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form19));
            this.Menu = new System.Windows.Forms.Button();
            this.Editregister = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Menu.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Location = new System.Drawing.Point(167, 140);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(162, 77);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "ไปหน้าหลัก";
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Editregister
            // 
            this.Editregister.BackColor = System.Drawing.Color.DarkOrange;
            this.Editregister.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editregister.Location = new System.Drawing.Point(167, 261);
            this.Editregister.Name = "Editregister";
            this.Editregister.Size = new System.Drawing.Size(162, 77);
            this.Editregister.TabIndex = 1;
            this.Editregister.Text = "แก้ไขข้อมูล";
            this.Editregister.UseVisualStyleBackColor = false;
            this.Editregister.Click += new System.EventHandler(this.Editregister_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Red;
            this.logout.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(167, 381);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(162, 77);
            this.logout.TabIndex = 2;
            this.logout.Text = "ออกจากระบบ";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "CARSHOW";
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.Editregister);
            this.Controls.Add(this.Menu);
            this.Name = "Form19";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button Editregister;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label1;
    }
}