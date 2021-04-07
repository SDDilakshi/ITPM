using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.locationClasses
{
    class locationClass
    {
        public int locationID { get; set; }
        public string BuildingName { get; set; }
        public string RoomName { get; set; }
        public bool RoomType { get; set; }
        public string Capacity { get; set; }
        public int RowIndex { get; internal set; }

        ////////public int RowIndex { get; internal set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Selecting Data from Database
        public DataTable Select()
        {
            ///Step 1:Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string sql = "SELECT * FROM tbl_location";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        //Inserting Data into Database
        public bool Insert(locationClass l)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = true;

            //Step 1: Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try 
            {
                //Step 2: Create a SQL Query to insert Data
                string sql = "INSERT INTO tbl_location (BuidingName,RoomName,RoomType,Capacity)VALUES(@BuidingName, @RoomName, @RoomType, @Capacity)";
                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add data
                cmd.Parameters.AddWithValue("@BuidingName", l.BuildingName);
                cmd.Parameters.AddWithValue("@RoomName", l.RoomName);
                cmd.Parameters.AddWithValue("@RoomType", l.RoomType);
                cmd.Parameters.AddWithValue("@Capacity", l.Capacity);

                //Connection Open Here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query runs successfully then the value of rows will be greater than zero else its value will be 0
                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }


        //Method to update data in database from our application
        public bool Update(locationClass l)
        {
            //Create a default return type ans set its default value to false
            bool isSuccess = true;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQL to update data in our Database
                string sql = "UPDATE tbl_location SET BuildingName=@BuildingName, RoomName=@RoomName, RoomType=@RoomType, Capacity=@Capacity WHERE locationID=@locationID";

                //Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add value
                cmd.Parameters.AddWithValue("@BuildingName", l.BuildingName);
                cmd.Parameters.AddWithValue("@RoomName", l.RoomName);
                cmd.Parameters.AddWithValue("@RoomType", l.RoomType);
                cmd.Parameters.AddWithValue("@Capacity", l.Capacity);
                cmd.Parameters.AddWithValue("locationID", l.locationID);
                //Open Database Connection
                conn.Open();


                int rows = cmd.ExecuteNonQuery();
                //if the query runs sucessfully then the value of rows will be greater then zero
                if(rows>0)
                {
                    isSuccess = true;
                }
                else 
                {
                    isSuccess = false;
                }


            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }


        //Method to Delete Data from Database
        public bool Delete(locationClass l)
        {
            //Create a default   return value and set its value to false
            bool isSuccess = true;
            //Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQL To Delete Data
                string sql = "DELETE FROM tbl_location  WHERE locationID=@locationID";

                //Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@locationID", l.locationID);
                //Open Connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query run sucessfully then the value of rows is greater than zero else its value is 0
                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch(Exception ex)
            {

            }
            finally
            {
                //Close Connection
                conn.Close();
            }
            return isSuccess;
        }


    }
}
