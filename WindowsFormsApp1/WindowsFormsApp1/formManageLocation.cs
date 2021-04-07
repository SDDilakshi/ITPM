using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.locationClasses;

namespace WindowsFormsApp1
{
    public partial class formManageLocation : Form
    {
        
        public int locationID;
        public string BuildingName, RoomName, RoomType, Capacity;

        public object txtboxBuildingName { get; private set; }
        public object txtboxRoomName { get; private set; }
        public object txtboxCapacity { get; private set; }
        public object radioButton1RoomType { get; private set; }
        public object radioButton2RoomType { get; private set; }

        public formManageLocation()
        {
            InitializeComponent();

            
        }


        locationClass l = new locationClass();
       
        private object txtboxlocationID;

     private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            l.locationID = Convert.ToInt32(locationID);



            bool success = l.Delete(l);
            if (success == true)
            {

                MessageBox.Show("Successfully Deleted.");

                DataTable dt = l.Select();
                dataGridView1.DataSource = dt;

                Clear();



            }
            else
            {
                MessageBox.Show("Failed to Delete.Try Again!");
            }

    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

         }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = l.RowIndex;
            txtboxlocationID.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            txtboxBuildingName.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            txtboxRoomName.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            radioButton1RoomType.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            radioButton2RoomType.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            txtboxRoomName.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString(); ;


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RoomType = "LectureHall";
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RoomType = "Laboratory";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();


        }
        private void formManageLocation_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timeTableSystemDataSet.tbl_location' table. You can move, or remove it, as needed.
            this.tbl_locationTableAdapter.Fill(this.timeTableSystemDataSet.tbl_location);

            DataTable dt = l.Select();
            dataGridView1.DataSource = dt;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            l.locationID = int.Parse(txtboxlocationID.Text);
            l.BuildingName = txtboxBuildingName.Text;
            l.RoomName = txtboxRoomName.Text;
            l.RoomType = radioButton1.Checked;
            l.RoomType = radioButton2.Checked;
            l.Capacity = txtboxCapacity.Text;

            //Update 
            bool success = l.Update(l);
            if (success == true)
            {

                MessageBox.Show("Successfully Updated.");

                DataTable dt = l.Select();
                dataGridView1.DataSource = dt;

                Clear();

            }
            else
            {
                MessageBox.Show("Failed to Update.Try Again!");
            }

            

            formVisualize fv = new formVisualize();
            fv.Show();



        }


        //Method to clear
        public void Clear()
        {
            txtboxBuildingName.Text = "";
            txtboxRoomName.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtboxCapacity.Text = "";

        }

        private class txtlocationID
        {
            internal static int Text;
        }


    }
}
