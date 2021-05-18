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

namespace ABC_Institute_M4
{
    public partial class Statics : Form
    {
        SqlConnection connection;
        public int type;

        public Statics()
        {
            InitializeComponent();

            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Desktop\itpm1\ABC_Institute_M4\ABC_Institute_M4\ABCInstituteDB.mdf;Integrated Security=True");

        }

        private void Statics_Load(object sender, EventArgs e)
        {
            try
            {
                if(type== 1)
                {
                    loadChartData("Lecturer", "Subject");
                    lblStatistics.Text = "Registerd Lecturers";
                    this.chrtPie.Titles.Add("Registerd Lecturers By Subject");
                }
                else if(type == 2)
                {
                    
                    loadStudentData();
                    lblStatistics.Text = "Registerd Students";
                    this.chrtPie.Titles.Add("Registerd Students By Subject");
                }
                else if (type == 3)
                {
                    loadChartData("Subject", "Offered_Year");
                    lblStatistics.Text = "Registerd Subjects";
                    this.chrtPie.Titles.Add("Registerd Subjects By Offered Year");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadChartData(string table, String column)
        {

            try
            {
                SqlCommand command1 = new SqlCommand("SELECT COUNT(*) AS Counts, " + column + " FROM " + table + " GROUP BY " + column + ";", connection);
                connection.Open();

                SqlDataReader read = command1.ExecuteReader();

                while (read.Read())
                {
                    string seriesName = read[column].ToString();

                    int index = chrtPie.Series["Series1"].Points.AddY(Convert.ToInt32(read["Counts"].ToString()));
                    chrtPie.Series["Series1"].Points[index].Label = seriesName + " - " + Convert.ToInt32(read["Counts"].ToString());
                }
                read.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadStudentData()
        {

            try
            {
                SqlCommand command1 = new SqlCommand("SELECT Student_Count AS Counts, Subject_Name FROM Session;", connection);
                connection.Open();

                SqlDataReader read = command1.ExecuteReader();

                while (read.Read())
                {
                    string subjectName = read["Subject_Name"].ToString();

                    int index = chrtPie.Series["Series1"].Points.AddY(Convert.ToInt32(read["Counts"].ToString()));
                    chrtPie.Series["Series1"].Points[index].Label = subjectName + " : #PERCENT{P2}";
                }
                read.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Visualize frm1 = new Visualize();
            frm1.Show();
            this.Hide();
        }
    }
}
