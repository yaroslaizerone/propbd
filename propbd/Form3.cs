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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            SetRoundedShape(del_bt, 20);
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

        private void del_bt_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-TPQE6J4\SQLEXPRESS;Initial Catalog=OPBD;Integrated Security=True");
            String s = Convert.ToString(textBox1.Text);
            String[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string lastname = words[0];
            string name = words[1];
            string patronic = words[2];
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить данные?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Con.Open();
                String query = "DELETE Client" +
                    $"Where FirstName = '{name}' and LastName = '{lastname}' and Patronymic = '{patronic}'";
                SqlCommand command = new SqlCommand(query, Con);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                Con.Close();
                MessageBox.Show($"В базе были удалены данные {name} {lastname} {patronic}");
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
   
}
