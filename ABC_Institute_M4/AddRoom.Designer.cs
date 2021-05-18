namespace ABC_Institute_M4
{
    partial class AddRoom
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvShowResult = new System.Windows.Forms.DataGridView();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tabNotAvailable = new System.Windows.Forms.TabPage();
            this.tabConsecutive = new System.Windows.Forms.TabPage();
            this.dgvShowResult2 = new System.Windows.Forms.DataGridView();
            this.tabSession = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowResult)).BeginInit();
            this.tabConsecutive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowResult2)).BeginInit();
            this.tabSession.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 95);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "ADD LOCATIONS";
            // 
            // dgvShowResult
            // 
            this.dgvShowResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowResult.Location = new System.Drawing.Point(0, 0);
            this.dgvShowResult.Name = "dgvShowResult";
            this.dgvShowResult.RowHeadersWidth = 51;
            this.dgvShowResult.RowTemplate.Height = 24;
            this.dgvShowResult.Size = new System.Drawing.Size(1022, 302);
            this.dgvShowResult.TabIndex = 27;
            this.dgvShowResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowResult_CellContentClick);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.Green;
            this.btnAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(750, 484);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(152, 43);
            this.btnAddRoom.TabIndex = 29;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(920, 485);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(146, 43);
            this.btnRefresh.TabIndex = 28;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightGray;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnBack.Location = new System.Drawing.Point(33, 485);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 43);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tabNotAvailable
            // 
            this.tabNotAvailable.Location = new System.Drawing.Point(4, 27);
            this.tabNotAvailable.Name = "tabNotAvailable";
            this.tabNotAvailable.Padding = new System.Windows.Forms.Padding(3);
            this.tabNotAvailable.Size = new System.Drawing.Size(1025, 303);
            this.tabNotAvailable.TabIndex = 3;
            this.tabNotAvailable.Text = "Not Available Time";
            this.tabNotAvailable.UseVisualStyleBackColor = true;
            // 
            // tabConsecutive
            // 
            this.tabConsecutive.Controls.Add(this.dgvShowResult2);
            this.tabConsecutive.Location = new System.Drawing.Point(4, 27);
            this.tabConsecutive.Name = "tabConsecutive";
            this.tabConsecutive.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsecutive.Size = new System.Drawing.Size(1025, 303);
            this.tabConsecutive.TabIndex = 2;
            this.tabConsecutive.Text = "Consecutive";
            this.tabConsecutive.UseVisualStyleBackColor = true;
            // 
            // dgvShowResult2
            // 
            this.dgvShowResult2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowResult2.Location = new System.Drawing.Point(1, 1);
            this.dgvShowResult2.Name = "dgvShowResult2";
            this.dgvShowResult2.RowHeadersWidth = 51;
            this.dgvShowResult2.RowTemplate.Height = 24;
            this.dgvShowResult2.Size = new System.Drawing.Size(1022, 302);
            this.dgvShowResult2.TabIndex = 28;
            // 
            // tabSession
            // 
            this.tabSession.Controls.Add(this.dgvShowResult);
            this.tabSession.Location = new System.Drawing.Point(4, 27);
            this.tabSession.Name = "tabSession";
            this.tabSession.Padding = new System.Windows.Forms.Padding(3);
            this.tabSession.Size = new System.Drawing.Size(1025, 303);
            this.tabSession.TabIndex = 1;
            this.tabSession.Text = "Session";
            this.tabSession.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSession);
            this.tabControl.Controls.Add(this.tabConsecutive);
            this.tabControl.Controls.Add(this.tabNotAvailable);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(33, 120);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1033, 334);
            this.tabControl.TabIndex = 35;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 550);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel1);
            this.Name = "AddRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRoom";
            this.Load += new System.EventHandler(this.AddRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowResult)).EndInit();
            this.tabConsecutive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowResult2)).EndInit();
            this.tabSession.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvShowResult;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabPage tabNotAvailable;
        private System.Windows.Forms.TabPage tabConsecutive;
        private System.Windows.Forms.DataGridView dgvShowResult2;
        private System.Windows.Forms.TabPage tabSession;
        private System.Windows.Forms.TabControl tabControl;
    }
}