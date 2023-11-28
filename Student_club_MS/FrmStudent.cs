using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_club_MS
{


    public partial class FrmStudent : Form
    {
        string connStr = "Data Source=DESKTOP-QF8532H\\SQLEXPRESS;Initial Catalog=Student_MS;Integrated Security=True";
        string sqlStr = "SELECT * FROM STUDENTS";
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF8532H\\SQLEXPRESS;Initial Catalog=Student_MS;Integrated Security=True");

        DataTable dt = new DataTable();
        
        int rowIndex = 0;
  

        public FrmStudent()
        {
            InitializeComponent();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, connStr);

            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            sda.Dispose();
            
            

        }



        // ADD BUTTON ------->  Adding a new student record

        private void Save()
        {
            
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, connStr);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
            sda.Dispose();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //Working with the rows to add a new club record.
            //Declare a new variable as type DataRow.
            //A new DataRow object will be returned when the NewRow Method is called.
            //The DataTable then creates the DataRow object based on the structure of the table.

            //create a new row by calling the NewRow method.
            DataRow newRow = dt.NewRow();

            //manipulate the newly added row using the column name with the corresponding text box as value.

            newRow["StudentID"] = txtID.Text;
            newRow["StudentName"] = txtName.Text;
            newRow["ContactNo"] = txtContact.Text;
            newRow["EmailAddress"] = txtAddress.Text;

            //After data is inserted into the new row, the Add method is used to add the row to the DataRowCollection.
            dt.Rows.Add(newRow);

            //The Save method is called to save the new row and display the result.
            Save();

        }



        //UPDATE BUTTON ---------->  Updating an existing student record


        private void btnUpdate_Click(object sender, EventArgs e)
        {

            DataRow newRow = dt.NewRow();

            //manipulate with the cells individually,  the index of the targetted cell was used to specifies the position of the cell row wise
            //and the name of the column was used to determine the cell's position column wise.

            dt.Rows[rowIndex]["StudentID"] = txtID.Text;
             dt.Rows[rowIndex]["StudentName"] = txtName.Text;
             dt.Rows[rowIndex]["ContactNo"] = txtContact.Text;
             dt.Rows[rowIndex]["EmailAddress"] = txtAddress.Text;

            //The IndexOf method is used to update the cells of a row.
            dt.Rows.IndexOf(newRow);

            Save();

        }




        //SEARCH BUTTON ----------> Searching student ID

        private void UpdateTextBoxes()
        {


            txtID.Text = dt.Rows[rowIndex]["StudentID"].ToString();
            txtName.Text = dt.Rows[rowIndex]["StudentName"].ToString();
            txtContact.Text = dt.Rows[rowIndex]["ContactNo"].ToString();
            txtAddress.Text = dt.Rows[rowIndex]["EmailAddress"].ToString();

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            int search = int.Parse(txtSearch.Text);
            bool found = false;

            for(int i= 0; i<=dt.Rows.Count - 1; i++)
            {
                if (dt.Rows[i]["StudentID"].Equals(search))
                {
                    found = true;
                    rowIndex = i;
                    UpdateTextBoxes();
                }
            }
            if (!found)
                MessageBox.Show($"Student ID {search} NOT found !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }





        //DELETE BUTTON ----------> 

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dt.Rows[rowIndex].Delete();  
            Save();
        }

        private void studentBindingNavigator_SaveItems(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.student_MSDataSet);
        }





        // LOGOUT BUTTON ---------->

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin login = new FrmLogin();
            login.Show();
        }





        // CLEAR BUTTON ----------->

        private void btnClear_Click(object sender, EventArgs e)
        {
           // DataRow newRow = dt.NewRow();

            txtID.Text = "";
            txtName.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
           



        }
    }
}
