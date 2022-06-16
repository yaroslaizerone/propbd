using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace propbd
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            using (SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-TPQE6J4\SQLEXPRESS;Initial Catalog=OPBD;Integrated Security=True"))
            {
                Con.Open();
                String query = "SELECT [ID] = Client.ID, [Фамилия] = Client.LastName, [Имя]=Client.FirstName, [Отчество]= Client.Patronymic,[Пол] = Gender.Name, [Телефон] = Client.Phone, [Email] = Client.Email, [Дата рождения] = Client.Birthday, [Дата регистрации] = Client.RegistrationDate FROM Client INNER JOIN Gender ON Client.GenderCode = Gender.Code";
                SqlCommand command = new SqlCommand(query, Con);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                Con.Close();
            }
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

        private void AddForm_Load(object sender, EventArgs e)
        {
            SetRoundedShape(button3, 20);
            SetRoundedShape(bt4, 20);
            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-TPQE6J4\SQLEXPRESS;Initial Catalog=OPBD;Integrated Security=True");
            Con.Open();
            String query = "SELECT max(ID) FROM Client";
            SqlCommand command = new SqlCommand(query, Con);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int a = reader.GetInt32(0)+1;
            Con.Close();
            label10.Text = Convert.ToString(a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           textBox1.Clear();
           textBox2.Clear();
           textBox3.Clear();
           textBox4.Clear();
           textBox5.Clear();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(label10.Text);
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
            string data_reg = (DateTime.Now.ToString("yyyy-MM-dd"));


            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-TPQE6J4\SQLEXPRESS;Initial Catalog=OPBD;Integrated Security=True");
            Con.Open();

            String query = "INSERT INTO [dbo].[Client] ([FirstName],[LastName],[Patronymic],[Birthday],[RegistrationDate],[Email],[Phone],[GenderCode],[PhotoPath])" +
            $"VALUES('{FirstName}', '{LastName}', '{Patr}', '{data}','{data_reg}','{Email}', '{phone}', '{gender}', NULL);";
            SqlCommand command = new SqlCommand(query, Con);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            Con.Close();
        }
    }
}
