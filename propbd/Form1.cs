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
    public partial class Mainform : Form
    {
        public Mainform()
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

                if (dt.Rows.Count != 0)
                {
                    dataGridView1.Visible = true;
                    dataGridView1.DataSource = dt;
                    dataGridView1.Update();

                }
                else
                {
                    dataGridView1.Visible = false;
                }
            }
        }

        private void del_bt_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.Show();
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
        //using (SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-TPQE6J4\SQLEXPRESS;Initial Catalog=Compiter Magazine;Integrated Security=True"))

        //Con.Open();
        // String query = "SELECT 'ФИО' = s.Surname + ' ' + s.Name + ' ' + s.MiddleName,'Должность' = s.Dolgnost,'Телефонный номер' = s.NumberPhone FROM Sotrydnik AS s ";


        //SqlCommand command = new SqlCommand(query, Con);
        //SqlDataReader reader = command.ExecuteReader();
        //DataTable dt = new DataTable();
        // dt.Load(reader);
        //Con.Close();

        // if (dt.Rows.Count != 0)
        //{
        // GridSotrydnik.Visible = true;
        // GridSotrydnik.DataSource = dt;
        // GridSotrydnik.Update();
        // GridSotrydnik.Columns[0].Width = 340; //ФИО
        // GridSotrydnik.Columns[1].Width = 250; //должность
        //GridSotrydnik.Columns[2].Width = 140; //номер
        // }
        //else
        //{
        //GridSotrydnik.Visible = false;
        //}

        private void Mainform_Load(object sender, EventArgs e)
        {
            SetRoundedShape(Newclient_bt, 20);
            SetRoundedShape(Edit_bt, 20);
            SetRoundedShape(del_bt, 20);
            SetRoundedShape(Sheare_bt, 20);
            SetRoundedShape(client_going_bt, 20);
            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-TPQE6J4\SQLEXPRESS;Initial Catalog=OPBD;Integrated Security=True");
            Con.Open();
            String query = "SELECT max(ID) FROM Client";
            SqlCommand command = new SqlCommand(query, Con);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int a = reader.GetInt32(0);
            Con.Close();
            check_lb.Text = $"0 из{Convert.ToString(a)}";
        }

        private void Sheare_bt_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-TPQE6J4\SQLEXPRESS;Initial Catalog=OPBD;Integrated Security=True");
            string FIO = FIO_tb.Text;
            string Numb = telephon_tb.Text;
            string Email = pocht_tb.Text;
            string gender = " AND GenderCode = ";
            string top = "Top ";
            Con.Open();
            String query = "SELECT max(ID) FROM Client";
            SqlCommand command = new SqlCommand(query, Con);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int a = reader.GetInt32(0);
            Con.Close();
            check_lb.Text = $"0 из{Convert.ToString(a)}";
            if (Convert.ToString(comboBox1.SelectedItem) == "All")
            { gender = "";}
            if(Convert.ToString(comboBox1.SelectedItem) == "Мужской")
            { gender = gender +"1";}
            if (Convert.ToString(comboBox1.SelectedItem) == "Женский")
            { gender = gender + "2";}
            if(Convert.ToString(comboBox2.SelectedItem) == "All")
            { top = "";
                check_lb.Text = $"{Convert.ToString(a)} из{Convert.ToString(a)}";
            }
            if (Convert.ToString(comboBox2.SelectedItem) == "10")
            { top = top+"10";
                check_lb.Text = $"10 из{Convert.ToString(a)}";
            }
            if (Convert.ToString(comboBox2.SelectedItem) == "50")
            { top = top + "50";
                check_lb.Text = $"50 из{Convert.ToString(a)}";
            }
            if (Convert.ToString(comboBox2.SelectedItem) == "100")
            { top = top + "100";
                check_lb.Text = $"100 из{Convert.ToString(a)}";
            }
            Con.Open();
            query = $"SELECT {top} [ID] = Client.ID, [Фамилия] = Client.LastName, [Имя] = Client.FirstName, [Отчество] = Client.Patronymic, [Пол] = Gender.Name, [Телефон] = Client.Phone, [Email] = Client.Email, [Дата рождения] = Client.Birthday, [Дата регистрации] = Client.RegistrationDate FROM Client INNER JOIN Gender ON Client.GenderCode = Gender.Code WHERE LastName LIKE '{FIO}%' AND Client.Phone LIKE '%{Numb}%' AND Client.Email LIKE '{Email}%'{gender} OR FirstName LIKE '{FIO}%'AND Client.Phone LIKE '%{Numb}%' AND Client.Email LIKE '{Email}%'{gender} OR Patronymic LIKE '{FIO}%' AND Client.Phone LIKE '%{Numb}%' AND Client.Email LIKE '{Email}%'{gender}";
            command = new SqlCommand(query, Con);
            reader = command.ExecuteReader();
            DataTable dt = new DataTable();
                dt.Load(reader);
                Con.Close();

                if (dt.Rows.Count != 0)
                {
                    dataGridView1.Visible = true;
                    dataGridView1.DataSource = dt;
                    dataGridView1.Update();
                }
                else
                {
                    dataGridView1.Visible = false;
                }
        }

        private void Newclient_bt_Click(object sender, EventArgs e)
        {
            AddForm adf = new AddForm();
            adf.Show();
        }

        private void client_going_bt_Click(object sender, EventArgs e)
        {
            Client_Going fm2 = new Client_Going();
            fm2.Show();
        }

        private void Edit_bt_Click(object sender, EventArgs e)
        {
            EDIT fm3 = new EDIT();
            fm3.Show();
        }
    }
    }

