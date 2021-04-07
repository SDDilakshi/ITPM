using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.locationClasses;

namespace WindowsFormsApp1
{
    public partial class formAddLocation : Form

    {
        

        public string BuildingName, RoomName, RoomType, Capacity;
        public formAddLocation()
        {
            InitializeComponent();
        }

         

        private void label1_Click(object sender, EventArgs e)
        {

        }
        locationClass l = new locationClass();
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RoomType = "LectureHall";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RoomType = "Laboratory";
        }

        private void formAddLocation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timeTableSystemDataSet1.tbl_location' table. You can move, or remove it, as needed.
            this.tbl_locationTableAdapter.Fill(this.timeTableSystemDataSet1.tbl_location);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            l.BuildingName = txtboxBuildingName.Text;
            l.RoomName = txtboxRoomName.Text;
            l.RoomType = radioButtonLectureHall.Checked;
            l.RoomType = radioButton2.Checked;
            l.Capacity = txtboxCapacity.Text;




       //Inserting Data into Database using the method we created 
            bool success = l.Insert(l);
            if(success==true)

            {
                //Successfully Inserted
                MessageBox.Show("'Succesfully Saved");
                Clear();
                
            }
            else 
            {
                //Failed to Save
                MessageBox.Show("Failed to Save.Try Again");
            }

           

                formManageLocation ml = new formManageLocation();
                ml.Show();
            

         }


        
        //Method to Clear fields
        public void Clear()
        {
            txtboxBuildingName.Text = "";
            txtboxRoomName.Text = "";
            radioButtonLectureHall.Checked = false;
            radioButton2.Checked = false;
            txtboxCapacity.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();

        }
    }
}
