namespace WindowsFormsApp1
{
    partial class formAddLocation
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.radioButtonLectureHall = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtboxBuildingName = new System.Windows.Forms.TextBox();
            this.txtboxRoomName = new System.Windows.Forms.TextBox();
            this.txtboxCapacity = new System.Windows.Forms.TextBox();
            this.tbllocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeTableSystemDataSet1 = new WindowsFormsApp1.TimeTableSystemDataSet1();
            this.tbl_locationTableAdapter = new WindowsFormsApp1.TimeTableSystemDataSet1TableAdapters.tbl_locationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbllocationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableSystemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonLectureHall
            // 
            this.radioButtonLectureHall.AutoSize = true;
            this.radioButtonLectureHall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLectureHall.Location = new System.Drawing.Point(306, 360);
            this.radioButtonLectureHall.Name = "radioButtonLectureHall";
            this.radioButtonLectureHall.Size = new System.Drawing.Size(143, 28);
            this.radioButtonLectureHall.TabIndex = 1;
            this.radioButtonLectureHall.TabStop = true;
            this.radioButtonLectureHall.Text = "Lecture Hall";
            this.radioButtonLectureHall.UseVisualStyleBackColor = true;
            this.radioButtonLectureHall.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(306, 419);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(129, 28);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Laboratory";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(859, 84);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "ADD LOCATIONS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add Rooms Building wise:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Building Name  :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Room Name  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Room Type  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(101, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Capacity  :";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGray;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnClear.Location = new System.Drawing.Point(306, 578);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(146, 43);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGray;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.Location = new System.Drawing.Point(587, 578);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 43);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtboxBuildingName
            // 
            this.txtboxBuildingName.Location = new System.Drawing.Point(306, 192);
            this.txtboxBuildingName.Name = "txtboxBuildingName";
            this.txtboxBuildingName.Size = new System.Drawing.Size(433, 22);
            this.txtboxBuildingName.TabIndex = 12;
            this.txtboxBuildingName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtboxRoomName
            // 
            this.txtboxRoomName.Location = new System.Drawing.Point(306, 284);
            this.txtboxRoomName.Name = "txtboxRoomName";
            this.txtboxRoomName.Size = new System.Drawing.Size(433, 22);
            this.txtboxRoomName.TabIndex = 13;
            // 
            // txtboxCapacity
            // 
            this.txtboxCapacity.Location = new System.Drawing.Point(306, 483);
            this.txtboxCapacity.Name = "txtboxCapacity";
            this.txtboxCapacity.Size = new System.Drawing.Size(433, 22);
            this.txtboxCapacity.TabIndex = 14;
            // 
            // tbllocationBindingSource
            // 
            this.tbllocationBindingSource.DataMember = "tbl_location";
            this.tbllocationBindingSource.DataSource = this.timeTableSystemDataSet1;
            // 
            // timeTableSystemDataSet1
            // 
            this.timeTableSystemDataSet1.DataSetName = "TimeTableSystemDataSet1";
            this.timeTableSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_locationTableAdapter
            // 
            this.tbl_locationTableAdapter.ClearBeforeFill = true;
            // 
            // formAddLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(858, 754);
            this.Controls.Add(this.txtboxCapacity);
            this.Controls.Add(this.txtboxRoomName);
            this.Controls.Add(this.txtboxBuildingName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButtonLectureHall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAddLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD LOCATIONS";
            this.Load += new System.EventHandler(this.formAddLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbllocationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableSystemDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.RadioButton radioButtonLectureHall;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtboxBuildingName;
        private System.Windows.Forms.TextBox txtboxRoomName;
        private System.Windows.Forms.TextBox txtboxCapacity;
        private TimeTableSystemDataSet1 timeTableSystemDataSet1;
        private System.Windows.Forms.BindingSource tbllocationBindingSource;
        private TimeTableSystemDataSet1TableAdapters.tbl_locationTableAdapter tbl_locationTableAdapter;
    }
}