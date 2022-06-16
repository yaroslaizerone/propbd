using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace propbd
{
    public partial class EDIT : Form
    {
        public EDIT()
        {
            InitializeComponent();
        }
        public static void SetRoundedShape(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddLine(radius, 0, control.Width - radius, 0);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, control.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            control.Region = new Region(path);
        }
        private void EDIT_Load(object sender, EventArgs e)
        {
            SetRoundedShape(button3, 20);
            SetRoundedShape(bt4, 20);
        }

        private void Sheare_bt_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-TPQE6J4\SQLEXPRESS;Initial Catalog=OPBD;Integrated Security=True");
            String s = Convert.ToString(textBox6.Text);
            String[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string lastname = words[0];
            string name = words[1];
            string patronic = words[2];
            Con.Open();
            String query = "Select [имя]=Client.FirstName, [фамилия]=Client.LastName, [Отчество]= Client.Patronymic, [Пол]= Client.GenderCode, [Телефон]= Client.Phone, [Еmail]= Client.Email, [День рождения]= Client.Birthday " +
            "From Client " +
            $"Where Client.FirstName = '{name}' AND Client.LastName = '{lastname}' AND Client.Patronymic = '{patronic}'";
            SqlCommand command = new SqlCommand(query, Con);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            
            textBox1.Text = reader.GetString(1);
            textBox2.Text = reader.GetString(0);
            textBox3.Text = reader.GetString(2);
            if (reader.GetString(3) == "1")
            {
                comboBox1.SelectedIndex = 0;
            }
            else if(reader.GetString(3) == "2")
            {
                comboBox1.SelectedIndex = 1;
            }
            textBox4.Text = reader.GetString(4);
            textBox5.Text = reader.GetString(5);
            string dat = reader.GetString(6);
            string[] data = dat.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            DateTime data1 = new DateTime (Convert.ToInt32(data[0]), Convert.ToInt32(data[1]), Convert.ToInt32(data[2]), 0, 0, 0);
            dateTimePicker1.Value = data1;
            Con.Close();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            string LastName = textBox1.Text;
            string FirstName = textBox2.Text;
            string Patr = textBox3.Text;
            int gender = 0;

            if (Convert.ToString(comboBox1.SelectedItem) == "Мужской")
            { gender++; }
            if (Convert.ToString(comboBox1.SelectedItem) == "Женский")
            { gender = gender + 2; }

            string phone = textBox4.Text;
            string Email = textBox5.Text;
            string data = Convert.ToString(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-TPQE6J4\SQLEXPRESS;Initial Catalog=OPBD;Integrated Security=True");

            String s = Convert.ToString(textBox6.Text);
            String[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string lastname = words[0];
            string name = words[1];
            string patronic = words[2];

            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите изменить данные?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Con.Open();
                String query = "UPDATE Client" +
    $"SET FirstName = '{FirstName}', LastName = '{LastName}', Patronymic = '{Patr}', GenderCode = '{gender}', Phone = '{phone}', Email = '{Email}', Birthday = {data}'" +
    $"Where FirstName = '{name}' and LastName = '{lastname}' and Patronymic = '{patronic}'";
                SqlCommand command = new SqlCommand(query, Con);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                Con.Close();
                MessageBox.Show($"В базе были сделанны изменения для клиента {name} {lastname} {patronic}");
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
