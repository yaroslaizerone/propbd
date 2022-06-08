
namespace propbd
{
    partial class Mainform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Newclient_bt = new System.Windows.Forms.Button();
            this.Edit_bt = new System.Windows.Forms.Button();
            this.del_bt = new System.Windows.Forms.Button();
            this.Sheare_bt = new System.Windows.Forms.Button();
            this.Refreash_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FIO_tb = new System.Windows.Forms.TextBox();
            this.telephon_tb = new System.Windows.Forms.TextBox();
            this.pocht_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.check_lb = new System.Windows.Forms.Label();
            this.client_going_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 375);
            this.dataGridView1.TabIndex = 0;
            // 
            // Newclient_bt
            // 
            this.Newclient_bt.BackColor = System.Drawing.Color.Turquoise;
            this.Newclient_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Newclient_bt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Newclient_bt.ForeColor = System.Drawing.SystemColors.Control;
            this.Newclient_bt.Location = new System.Drawing.Point(27, 520);
            this.Newclient_bt.Name = "Newclient_bt";
            this.Newclient_bt.Size = new System.Drawing.Size(117, 23);
            this.Newclient_bt.TabIndex = 1;
            this.Newclient_bt.Text = "Новый клиент";
            this.Newclient_bt.UseVisualStyleBackColor = false;
            // 
            // Edit_bt
            // 
            this.Edit_bt.BackColor = System.Drawing.Color.Turquoise;
            this.Edit_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_bt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Edit_bt.ForeColor = System.Drawing.SystemColors.Control;
            this.Edit_bt.Location = new System.Drawing.Point(166, 520);
            this.Edit_bt.Name = "Edit_bt";
            this.Edit_bt.Size = new System.Drawing.Size(103, 23);
            this.Edit_bt.TabIndex = 2;
            this.Edit_bt.Text = "Редактировать";
            this.Edit_bt.UseVisualStyleBackColor = false;
            // 
            // del_bt
            // 
            this.del_bt.BackColor = System.Drawing.Color.Turquoise;
            this.del_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_bt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.del_bt.ForeColor = System.Drawing.SystemColors.Control;
            this.del_bt.Location = new System.Drawing.Point(302, 520);
            this.del_bt.Name = "del_bt";
            this.del_bt.Size = new System.Drawing.Size(91, 23);
            this.del_bt.TabIndex = 3;
            this.del_bt.Text = "Удалить";
            this.del_bt.UseVisualStyleBackColor = false;
            this.del_bt.Click += new System.EventHandler(this.del_bt_Click);
            // 
            // Sheare_bt
            // 
            this.Sheare_bt.BackColor = System.Drawing.Color.Turquoise;
            this.Sheare_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sheare_bt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sheare_bt.ForeColor = System.Drawing.SystemColors.Control;
            this.Sheare_bt.Location = new System.Drawing.Point(372, 98);
            this.Sheare_bt.Name = "Sheare_bt";
            this.Sheare_bt.Size = new System.Drawing.Size(86, 25);
            this.Sheare_bt.TabIndex = 4;
            this.Sheare_bt.Text = "Поиск";
            this.Sheare_bt.UseVisualStyleBackColor = false;
            // 
            // Refreash_bt
            // 
            this.Refreash_bt.BackColor = System.Drawing.Color.Turquoise;
            this.Refreash_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refreash_bt.ForeColor = System.Drawing.SystemColors.Control;
            this.Refreash_bt.Location = new System.Drawing.Point(907, 27);
            this.Refreash_bt.Name = "Refreash_bt";
            this.Refreash_bt.Size = new System.Drawing.Size(102, 41);
            this.Refreash_bt.TabIndex = 5;
            this.Refreash_bt.Text = "Обновить";
            this.Refreash_bt.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(100, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Клиенты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Поиск ФИО:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Телефон:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email:";
            // 
            // FIO_tb
            // 
            this.FIO_tb.Location = new System.Drawing.Point(26, 100);
            this.FIO_tb.Name = "FIO_tb";
            this.FIO_tb.Size = new System.Drawing.Size(100, 23);
            this.FIO_tb.TabIndex = 10;
            // 
            // telephon_tb
            // 
            this.telephon_tb.Location = new System.Drawing.Point(141, 99);
            this.telephon_tb.Name = "telephon_tb";
            this.telephon_tb.Size = new System.Drawing.Size(100, 23);
            this.telephon_tb.TabIndex = 11;
            // 
            // pocht_tb
            // 
            this.pocht_tb.Location = new System.Drawing.Point(257, 99);
            this.pocht_tb.Name = "pocht_tb";
            this.pocht_tb.Size = new System.Drawing.Size(100, 23);
            this.pocht_tb.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(816, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Пол:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(919, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Записи:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Мужской",
            "Женский"});
            this.comboBox1.Location = new System.Drawing.Point(850, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(62, 23);
            this.comboBox1.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "All",
            "10",
            "50",
            "100"});
            this.comboBox2.Location = new System.Drawing.Point(970, 98);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(62, 23);
            this.comboBox2.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::propbd.Properties.Resources.Google_Translate_icon_icons_com_75723;
            this.pictureBox1.Location = new System.Drawing.Point(28, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 63);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // check_lb
            // 
            this.check_lb.AutoSize = true;
            this.check_lb.Location = new System.Drawing.Point(971, 528);
            this.check_lb.Name = "check_lb";
            this.check_lb.Size = new System.Drawing.Size(38, 15);
            this.check_lb.TabIndex = 19;
            this.check_lb.Text = "label7";
            // 
            // client_going_bt
            // 
            this.client_going_bt.BackColor = System.Drawing.Color.Turquoise;
            this.client_going_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.client_going_bt.ForeColor = System.Drawing.SystemColors.Control;
            this.client_going_bt.Location = new System.Drawing.Point(771, 27);
            this.client_going_bt.Name = "client_going_bt";
            this.client_going_bt.Size = new System.Drawing.Size(130, 41);
            this.client_going_bt.TabIndex = 20;
            this.client_going_bt.Text = "Посещения клиента";
            this.client_going_bt.UseVisualStyleBackColor = false;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 554);
            this.Controls.Add(this.client_going_bt);
            this.Controls.Add(this.check_lb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pocht_tb);
            this.Controls.Add(this.telephon_tb);
            this.Controls.Add(this.FIO_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Refreash_bt);
            this.Controls.Add(this.Sheare_bt);
            this.Controls.Add(this.del_bt);
            this.Controls.Add(this.Edit_bt);
            this.Controls.Add(this.Newclient_bt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Mainform";
            this.Text = "Школа английского языка";
            this.Load += new System.EventHandler(this.Mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Newclient_bt;
        private System.Windows.Forms.Button Edit_bt;
        private System.Windows.Forms.Button del_bt;
        private System.Windows.Forms.Button Sheare_bt;
        private System.Windows.Forms.Button Refreash_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FIO_tb;
        private System.Windows.Forms.TextBox telephon_tb;
        private System.Windows.Forms.TextBox pocht_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label check_lb;
        private System.Windows.Forms.Button client_going_bt;
    }
}

