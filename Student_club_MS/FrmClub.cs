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
using System.Xml.Linq;

namespace Student_club_MS
{
    public partial class FrmClub : Form
    {
        string connStr = "Data Source=DESKTOP-QF8532H\\SQLEXPRESS;Initial Catalog=Student_MS;Integrated Security=True";
        string sqlStr = "SELECT * FROM CLUBS";
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF8532H\\SQLEXPRESS;Initial Catalog=Student_MS;Integrated Security=True");

        DataTable dt = new DataTable();

        int rowIndex = 0;

        public FrmClub()
        {
            InitializeComponent();
        }

        private void FrmClub_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_MSDataSet.CLUB' table. You can move, or remove it, as needed.
            //this.cLUBTableAdapter.Fill(this.student_MSDataSet.CLUB);
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, connStr);

            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            sda.Dispose();

        }


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

            newRow["ClubID"] = txtClubID.Text;
            newRow["ClubName"] = txtClubName.Text;
            newRow["ClubDetails"] = txtClubDetail.Text;
            newRow["Location"] = txtLocation.Text;
            newRow["PresidentID"] = txtPresidentID.Text;


            //After data is inserted into the new row, the Add method is used to add the row to the DataRowCollection.
            dt.Rows.Add(newRow);

            //The Save method is called to save the new row and display the result.
            Save();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow newRow = dt.NewRow();

            //manipulate with the cells individually,  the index of the targetted cell was used to specifies the position of the cell row wise
            //and the name of the column was used to determine the cell's position column wise.

            dt.Rows[rowIndex]["ClubID"] = txtClubID.Text;
            dt.Rows[rowIndex]["ClubName"] = txtClubName.Text;
            dt.Rows[rowIndex]["ClubDetails"] = txtClubDetail.Text;
            dt.Rows[rowIndex]["Location"] = txtLocation.Text;
            dt.Rows[rowIndex]["PresidentID"] = txtPresidentID.Text;

            

            //The IndexOf method is used to update the cells of a row.
            dt.Rows.IndexOf(newRow);

            Save();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DataRow newRow = dt.NewRow();

            txtClubID.Text = "";
            txtClubName.Text = "";
            txtClubDetail.Text = "";
            txtLocation.Text = "";
            txtPresidentID.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dt.Rows[rowIndex].Delete();
            Save();
        }



        //SEARCH BUTTON ----------> Searching student ID

        private void UpdateTextBoxes()
        {


            txtClubID.Text = dt.Rows[rowIndex]["ClubID"].ToString();
            txtClubName.Text = dt.Rows[rowIndex]["ClubName"].ToString();
            txtClubDetail.Text = dt.Rows[rowIndex]["ClubDetails"].ToString();
            txtLocation.Text = dt.Rows[rowIndex]["Location"].ToString();
            txtPresidentID.Text = dt.Rows[rowIndex]["PresidentID"].ToString();

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            int search = int.Parse(txtSearch.Text);
            bool found = false;

            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                if (dt.Rows[i]["ClubID"].Equals(search))
                {
                    found = true;
                    rowIndex = i;
                    UpdateTextBoxes();
                }
            }
            if (!found)
                MessageBox.Show($"Club ID {search} NOT found !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
