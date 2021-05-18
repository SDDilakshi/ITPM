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
    public partial class AddRoom : Form
    {
        SqlConnection connection;

        public AddRoom()
        {
            InitializeComponent();

            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Desktop\itpm1\ABC_Institute_M4\ABC_Institute_M4\ABCInstituteDB.mdf;Integrated Security=True");

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                AddLocations frm1 = new AddLocations();
                frm1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            try
            {
                loadSessions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void loadSessions()
        {

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT *  FROM dbo.[Session] ;", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                dgvShowResult.DataSource = null;
                dgvShowResult.Rows.Clear();
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    dgvShowResult.AutoGenerateColumns = false;
                    dgvShowResult.ColumnCount = 10;

                    dgvShowResult.Columns[0].HeaderText = "ID";
                    dgvShowResult.Columns[0].DataPropertyName = "ID";

                    dgvShowResult.Columns[1].HeaderText = "Lecturer 1";
                    dgvShowResult.Columns[1].DataPropertyName = "Lecturer_1";

                    dgvShowResult.Columns[2].HeaderText = "Lecturer 2";
                    dgvShowResult.Columns[2].DataPropertyName = "Lecturer_2";

                    dgvShowResult.Columns[3].HeaderText = "Subject Code";
                    dgvShowResult.Columns[3].DataPropertyName = "Subject_Code";

                    dgvShowResult.Columns[4].HeaderText = "Subject Name";
                    dgvShowResult.Columns[4].DataPropertyName = "Subject_Name";

                    dgvShowResult.Columns[5].HeaderText = "Group ID";
                    dgvShowResult.Columns[5].DataPropertyName = "Group_ID";

                    dgvShowResult.Columns[6].HeaderText = "Tag";
                    dgvShowResult.Columns[6].DataPropertyName = "Tag";

                    dgvShowResult.Columns[7].HeaderText = "Student Count";
                    dgvShowResult.Columns[7].DataPropertyName = "Student_Count";

                    dgvShowResult.Columns[8].HeaderText = "Duration";
                    dgvShowResult.Columns[8].DataPropertyName = "Duration";

                    dgvShowResult.Columns[9].HeaderText = "Room";
                    dgvShowResult.Columns[9].DataPropertyName = "Room";

                    dgvShowResult.DataSource = table;
                    connection.Close();
                }
                else
                {
                    connection.Close();
                    MessageBox.Show("No Data about Sessions!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void loadConsecutives()
        {
            try
            {
                connection.Open();
               
                SqlCommand command = new SqlCommand("SELECT S.ID, S.Lecturer_1, S.Lecturer_2, S.Subject_Code, S.Subject_Name, S.Group_ID, S.Tag, S.Student_Count, S.Duration, S.Room FROM Session AS S LEFT JOIN TagOrder O ON O.Tag = S.Tag WHERE S.Subject_Name IN (SELECT Subject_Name  FROM Session GROUP BY Subject_Name HAVING COUNT(*) > 1 ) ORDER BY O.OrderNo; ", connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                dgvShowResult2.DataSource = null;
                dgvShowResult2.Rows.Clear();
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    dgvShowResult2.AutoGenerateColumns = false;
                    dgvShowResult2.ColumnCount = 10;

                    dgvShowResult2.Columns[0].HeaderText = "ID";
                    dgvShowResult2.Columns[0].DataPropertyName = "ID";

                    dgvShowResult2.Columns[1].HeaderText = "Lecturer 1";
                    dgvShowResult2.Columns[1].DataPropertyName = "Lecturer_1";

                    dgvShowResult2.Columns[2].HeaderText = "Lecturer 2";
                    dgvShowResult2.Columns[2].DataPropertyName = "Lecturer_2";

                    dgvShowResult2.Columns[3].HeaderText = "Subject Code";
                    dgvShowResult2.Columns[3].DataPropertyName = "Subject_Code";

                    dgvShowResult2.Columns[4].HeaderText = "Subject Name";
                    dgvShowResult2.Columns[4].DataPropertyName = "Subject_Name";

                    dgvShowResult2.Columns[5].HeaderText = "Group ID";
                    dgvShowResult2.Columns[5].DataPropertyName = "Group_ID";

                    dgvShowResult2.Columns[6].HeaderText = "Tag";
                    dgvShowResult2.Columns[6].DataPropertyName = "Tag";

                    dgvShowResult2.Columns[7].HeaderText = "Student Count";
                    dgvShowResult2.Columns[7].DataPropertyName = "Student_Count";

                    dgvShowResult2.Columns[8].HeaderText = "Duration";
                    dgvShowResult2.Columns[8].DataPropertyName = "Duration";

                    dgvShowResult2.Columns[9].HeaderText = "Room";
                    dgvShowResult2.Columns[9].DataPropertyName = "Room";

                    dgvShowResult2.DataSource = table;
                    connection.Close();
                }
                else
                {
                    connection.Close();
                    MessageBox.Show("No Data about Sessions!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            try
            {
                ManageSessionRooms frm2 = new ManageSessionRooms();
                frm2.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                tabControl.SelectTab(tabSession);
                loadSessions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.SelectedIndex == 0)
                {

                    loadSessions();

                }
                if (tabControl.SelectedIndex == 1)
                {

                    loadConsecutives();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void dgvShowResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
