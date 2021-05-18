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
    public partial class ManageLocations : Form
    {
        SqlConnection connection;

        public ManageLocations()
        {
            InitializeComponent();

            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Desktop\itpm1\ABC_Institute_M4\ABC_Institute_M4\ABCInstituteDB.mdf;Integrated Security=True");

        }

        private void ManageLocations_Load(object sender, EventArgs e)
        {

            try
            {
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadData()
        {

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT *  FROM dbo.[Location] ;", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                dgvShowResult.DataSource = null;
                dgvShowResult.Rows.Clear();
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    dgvShowResult.AutoGenerateColumns = false;
                    dgvShowResult.ColumnCount = 5;

                    dgvShowResult.Columns[0].HeaderText = "ID";
                    dgvShowResult.Columns[0].DataPropertyName = "ID";

                    dgvShowResult.Columns[1].HeaderText = "Building";
                    dgvShowResult.Columns[1].DataPropertyName = "Building";

                    dgvShowResult.Columns[2].HeaderText = "Room";
                    dgvShowResult.Columns[2].DataPropertyName = "Room";

                    dgvShowResult.Columns[3].HeaderText = "Room Type";
                    dgvShowResult.Columns[3].DataPropertyName = "Room_Type";

                    dgvShowResult.Columns[4].HeaderText = "Capacity";
                    dgvShowResult.Columns[4].DataPropertyName = "Capacity";



                    dgvShowResult.DataSource = table;
                    connection.Close();
                }
                else
                {
                    connection.Close();
                    MessageBox.Show("No Data about Locations!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void dgvShowResult_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvShowResult.Rows[e.RowIndex];
                    txtLocationID.Text = row.Cells[0].Value.ToString();
                    txtBuildingName.Text = row.Cells[1].Value.ToString();
                    txtRoomName.Text = row.Cells[2].Value.ToString();
                    txtCapacity.Text = row.Cells[4].Value.ToString();

                    string roomType = row.Cells[3].Value.ToString();

                    if( roomType=="Lecture Hall")
                    {
                        rbtLectureHall.Checked = true;
                        rbtLaboratory.Checked = false;
                    }
                    else
                    {
                        rbtLaboratory.Checked = true;
                        rbtLectureHall.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtBuildingName.Text == "" || txtRoomName.Text == "" || txtCapacity.Text == "")
                {
                    MessageBox.Show("Please insert all fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string roomType;

                    if (rbtLectureHall.Checked)
                    {
                        roomType = "Lecture Hall";
                    }
                    else
                    {
                        roomType = "Laboratory";
                    }

                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE dbo.[Location] SET Building='" + txtBuildingName.Text + "', Room='" + txtRoomName.Text + "', Room_Type='" + roomType + "', Capacity='" + txtCapacity.Text  + "' WHERE ID='" + txtLocationID.Text + "';", connection);

                    int i = command.ExecuteNonQuery();
                    if (i != 0)
                    {
                        clear();
                        dgvShowResult.DataSource = null;
                        dgvShowResult.Rows.Clear();
                        connection.Close();
                        loadData();

                        MessageBox.Show("Data Updated", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        connection.Close();
                        MessageBox.Show("Data Not Updated", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtLocationID.Text == "" )
                {
                    MessageBox.Show("Please Select a Location!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM dbo.[Location]  WHERE ID='" + txtLocationID.Text + "';", connection);

                    int i = command.ExecuteNonQuery();
                    if (i != 0)
                    {
                        clear();
                        dgvShowResult.DataSource = null;
                        dgvShowResult.Rows.Clear();
                        connection.Close();
                        loadData();

                        MessageBox.Show("Data Deleted", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        connection.Close();
                        MessageBox.Show("Data Not Deleted", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            try
            {
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clear()
        {
            txtLocationID.ResetText();
            txtBuildingName.ResetText();
            txtRoomName.ResetText();
            txtCapacity.ResetText();
            rbtLectureHall.Checked = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Visualize frm1 = new Visualize();
            frm1.Show();
            this.Hide();
        }

        private void dgvShowResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
