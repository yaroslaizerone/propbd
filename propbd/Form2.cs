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
    public partial class Client_Going : Form
    { 
        public Client_Going()
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
                SetRoundedShape(bt1, 20);
                SetRoundedShape(button1, 20);
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
        private void Mainform_Load(object sender, EventArgs e)
        {
            SetRoundedShape(bt1, 20);
            SetRoundedShape(button1, 20);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-TPQE6J4\SQLEXPRESS;Initial Catalog=OPBD;Integrated Security=True");
            String s = Convert.ToString(textBox1.Text);
            String[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name = words[1];
            string lastname = words[0];
            string patronic = words[2];
            Con.Open();
            String query = "Select [Курс]=ClientService.Comment, [Дата]=ClientService.StartTime " +
            "From ClientService " +
            "INNER JOIN Client " +
            "ON ClientService.ClientID = Client.ID " +
            $"Where Client.FirstName = '{name}' AND Client.LastName = '{lastname}' AND Client.Patronymic = '{patronic}';";
            SqlCommand command = new SqlCommand(query, Con);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string a = reader.GetString(0);
            DateTime b = reader.GetDateTime(1);
            Con.Close();
            listBox1.Items.Add($"Услуга:");
            listBox1.Items.Add(a);
            listBox1.Items.Add($"Дата посещения:");
            listBox1.Items.Add(b);
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            AddForm fm2 = new AddForm ();
            fm2.Close();
        }
    }
}
