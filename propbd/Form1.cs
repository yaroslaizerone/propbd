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

namespace propbd
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void del_bt_Click(object sender, EventArgs e)
        {

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
            SetRoundedShape(Refreash_bt, 20);
            SetRoundedShape(client_going_bt, 20);
        }
    }
}
