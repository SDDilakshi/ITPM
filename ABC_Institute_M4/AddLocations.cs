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
    public partial class AddLocations : Form
    {
        public AddLocations()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if(txtBuildingName.Text == "" || txtRoomName.Text=="" || txtCapacity.Text == "")
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

                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Desktop\itpm1\ABC_Institute_M4\ABC_Institute_M4\ABCInstituteDB.mdf;Integrated Security=True");

                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO  dbo.[Location](Building, Room, Room_Type, Capacity) " + " VALUES ('" + txtBuildingName.Text + "','" + txtRoomName.Text + "','" + roomType + "','" + txtCapacity.Text + "')", connection);
                   
                    int i = command.ExecuteNonQuery();
                    
                    if (i != 0 )
                    {
                        clear();
                        connection.Close();
                        MessageBox.Show("Data Saved");
                        ManageLocations frm2 = new ManageLocations();
                        frm2.Show();
                        this.Hide();
                    }
                    else
                    {
                        connection.Close();
                        MessageBox.Show("Data not Saved", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void clear()
        {
            txtBuildingName.ResetText();
            txtRoomName.ResetText();
            txtCapacity.ResetText();
            rbtLectureHall.Checked = true;
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


        private void btnBack_Click(object sender, EventArgs e)
        {
        }
    }
}
