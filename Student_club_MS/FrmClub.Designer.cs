namespace Student_club_MS
{
    partial class FrmClub
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtClubID = new System.Windows.Forms.TextBox();
            this.lblClubID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtClubDetail = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtClubName = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblClubDetail = new System.Windows.Forms.Label();
            this.lblClubName = new System.Windows.Forms.Label();
            this.txtPresidentID = new System.Windows.Forms.TextBox();
            this.lblPresident = new System.Windows.Forms.Label();
            this.student_MSDataSet = new Student_club_MS.Student_MSDataSet();
            this.cLUBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Student_club_MS.Student_MSDataSetTableAdapters.TableAdapterManager();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clubIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presidentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.student_MSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLUBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1514, 39);
            this.panel2.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClear.Location = new System.Drawing.Point(90, 593);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(308, 38);
            this.btnClear.TabIndex = 38;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtClubID
            // 
            this.txtClubID.BackColor = System.Drawing.Color.White;
            this.txtClubID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClubID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClubID.ForeColor = System.Drawing.Color.Black;
            this.txtClubID.Location = new System.Drawing.Point(193, 107);
            this.txtClubID.Name = "txtClubID";
            this.txtClubID.Size = new System.Drawing.Size(208, 20);
            this.txtClubID.TabIndex = 37;
            // 
            // lblClubID
            // 
            this.lblClubID.AutoSize = true;
            this.lblClubID.ForeColor = System.Drawing.Color.Black;
            this.lblClubID.Location = new System.Drawing.Point(86, 111);
            this.lblClubID.Name = "lblClubID";
            this.lblClubID.Size = new System.Drawing.Size(56, 16);
            this.lblClubID.TabIndex = 36;
            this.lblClubID.Text = "Club ID :";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDelete.Location = new System.Drawing.Point(90, 661);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(308, 38);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdate.Location = new System.Drawing.Point(90, 520);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(308, 38);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.Location = new System.Drawing.Point(89, 446);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(309, 38);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtClubDetail
            // 
            this.txtClubDetail.Location = new System.Drawing.Point(90, 351);
            this.txtClubDetail.Multiline = true;
            this.txtClubDetail.Name = "txtClubDetail";
            this.txtClubDetail.Size = new System.Drawing.Size(311, 70);
            this.txtClubDetail.TabIndex = 32;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(193, 212);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(205, 22);
            this.txtLocation.TabIndex = 31;
            // 
            // txtClubName
            // 
            this.txtClubName.BackColor = System.Drawing.Color.White;
            this.txtClubName.Location = new System.Drawing.Point(193, 157);
            this.txtClubName.Name = "txtClubName";
            this.txtClubName.Size = new System.Drawing.Size(205, 22);
            this.txtClubName.TabIndex = 30;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.ForeColor = System.Drawing.Color.Black;
            this.lblLocation.Location = new System.Drawing.Point(87, 218);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(64, 16);
            this.lblLocation.TabIndex = 29;
            this.lblLocation.Text = "Location :";
            // 
            // lblClubDetail
            // 
            this.lblClubDetail.AutoSize = true;
            this.lblClubDetail.ForeColor = System.Drawing.Color.Black;
            this.lblClubDetail.Location = new System.Drawing.Point(89, 332);
            this.lblClubDetail.Name = "lblClubDetail";
            this.lblClubDetail.Size = new System.Drawing.Size(78, 16);
            this.lblClubDetail.TabIndex = 28;
            this.lblClubDetail.Text = "Club Detail :";
            // 
            // lblClubName
            // 
            this.lblClubName.AutoSize = true;
            this.lblClubName.ForeColor = System.Drawing.Color.Black;
            this.lblClubName.Location = new System.Drawing.Point(87, 163);
            this.lblClubName.Name = "lblClubName";
            this.lblClubName.Size = new System.Drawing.Size(80, 16);
            this.lblClubName.TabIndex = 27;
            this.lblClubName.Text = "Club Name :";
            // 
            // txtPresidentID
            // 
            this.txtPresidentID.Location = new System.Drawing.Point(193, 271);
            this.txtPresidentID.Name = "txtPresidentID";
            this.txtPresidentID.Size = new System.Drawing.Size(205, 22);
            this.txtPresidentID.TabIndex = 40;
            // 
            // lblPresident
            // 
            this.lblPresident.AutoSize = true;
            this.lblPresident.ForeColor = System.Drawing.Color.Black;
            this.lblPresident.Location = new System.Drawing.Point(87, 277);
            this.lblPresident.Name = "lblPresident";
            this.lblPresident.Size = new System.Drawing.Size(86, 16);
            this.lblPresident.TabIndex = 39;
            this.lblPresident.Text = "President ID :";
            // 
            // student_MSDataSet
            // 
            this.student_MSDataSet.DataSetName = "Student_MSDataSet";
            this.student_MSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLUBBindingSource
            // 
            this.cLUBBindingSource.DataMember = "CLUB";
            this.cLUBBindingSource.DataSource = this.student_MSDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLUBS_REGISTRATIONTableAdapter = null;
            this.tableAdapterManager.CLUBSTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.STUDENTSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Student_club_MS.Student_MSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(988, 684);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(936, 638);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(72, 16);
            this.lblSearch.TabIndex = 43;
            this.lblSearch.Text = "Search ID :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1029, 632);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 42;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clubIDDataGridViewTextBoxColumn,
            this.clubNameDataGridViewTextBoxColumn,
            this.clubDetailsDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.presidentIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cLUBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(554, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(846, 479);
            this.dataGridView1.TabIndex = 45;
            // 
            // clubIDDataGridViewTextBoxColumn
            // 
            this.clubIDDataGridViewTextBoxColumn.DataPropertyName = "ClubID";
            this.clubIDDataGridViewTextBoxColumn.HeaderText = "ClubID";
            this.clubIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clubIDDataGridViewTextBoxColumn.Name = "clubIDDataGridViewTextBoxColumn";
            this.clubIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // clubNameDataGridViewTextBoxColumn
            // 
            this.clubNameDataGridViewTextBoxColumn.DataPropertyName = "ClubName";
            this.clubNameDataGridViewTextBoxColumn.HeaderText = "ClubName";
            this.clubNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clubNameDataGridViewTextBoxColumn.Name = "clubNameDataGridViewTextBoxColumn";
            this.clubNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // clubDetailsDataGridViewTextBoxColumn
            // 
            this.clubDetailsDataGridViewTextBoxColumn.DataPropertyName = "ClubDetails";
            this.clubDetailsDataGridViewTextBoxColumn.HeaderText = "ClubDetails";
            this.clubDetailsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clubDetailsDataGridViewTextBoxColumn.Name = "clubDetailsDataGridViewTextBoxColumn";
            this.clubDetailsDataGridViewTextBoxColumn.Width = 125;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // presidentIDDataGridViewTextBoxColumn
            // 
            this.presidentIDDataGridViewTextBoxColumn.DataPropertyName = "PresidentID";
            this.presidentIDDataGridViewTextBoxColumn.HeaderText = "PresidentID";
            this.presidentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.presidentIDDataGridViewTextBoxColumn.Name = "presidentIDDataGridViewTextBoxColumn";
            this.presidentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 783);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtPresidentID);
            this.Controls.Add(this.lblPresident);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtClubID);
            this.Controls.Add(this.lblClubID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtClubDetail);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtClubName);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblClubDetail);
            this.Controls.Add(this.lblClubName);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClub";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmClub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.student_MSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtClubID;
        private System.Windows.Forms.Label lblClubID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtClubDetail;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtClubName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblClubDetail;
        private System.Windows.Forms.Label lblClubName;
        private System.Windows.Forms.TextBox txtPresidentID;
        private System.Windows.Forms.Label lblPresident;
        private Student_MSDataSet student_MSDataSet;
        private System.Windows.Forms.BindingSource cLUBBindingSource;
        
        private Student_MSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presidentIDDataGridViewTextBoxColumn;
    }
}