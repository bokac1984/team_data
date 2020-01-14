namespace API_Consumer.Clubs
{
    partial class ClubManagement
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
            this.gb_Pregled = new System.Windows.Forms.GroupBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tb_ClubName = new System.Windows.Forms.TextBox();
            this.gb_Grid = new System.Windows.Forms.GroupBox();
            this.btn_DeleteMyClub = new System.Windows.Forms.Button();
            this.dgv_Clubs = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l_Description = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.l_LastActivity = new System.Windows.Forms.Label();
            this.l_LastActivityName = new System.Windows.Forms.Label();
            this.l_Created = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pb_ClubIcon = new System.Windows.Forms.PictureBox();
            this.l_MembersCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.l_AvgDailyRating = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Pregled.SuspendLayout();
            this.gb_Grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clubs)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ClubIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Pregled
            // 
            this.gb_Pregled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Pregled.Controls.Add(this.btn_Add);
            this.gb_Pregled.Controls.Add(this.tb_ClubName);
            this.gb_Pregled.Location = new System.Drawing.Point(12, 12);
            this.gb_Pregled.Name = "gb_Pregled";
            this.gb_Pregled.Size = new System.Drawing.Size(346, 124);
            this.gb_Pregled.TabIndex = 0;
            this.gb_Pregled.TabStop = false;
            this.gb_Pregled.Text = "Dodaj novi";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(191, 57);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(121, 23);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Dodaj klub";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tb_ClubName
            // 
            this.tb_ClubName.Location = new System.Drawing.Point(7, 31);
            this.tb_ClubName.Name = "tb_ClubName";
            this.tb_ClubName.Size = new System.Drawing.Size(305, 20);
            this.tb_ClubName.TabIndex = 0;
            this.tb_ClubName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ClubName_KeyPress);
            // 
            // gb_Grid
            // 
            this.gb_Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Grid.Controls.Add(this.btn_DeleteMyClub);
            this.gb_Grid.Controls.Add(this.dgv_Clubs);
            this.gb_Grid.Location = new System.Drawing.Point(12, 142);
            this.gb_Grid.Name = "gb_Grid";
            this.gb_Grid.Size = new System.Drawing.Size(1091, 620);
            this.gb_Grid.TabIndex = 1;
            this.gb_Grid.TabStop = false;
            // 
            // btn_DeleteMyClub
            // 
            this.btn_DeleteMyClub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteMyClub.Location = new System.Drawing.Point(941, 19);
            this.btn_DeleteMyClub.Name = "btn_DeleteMyClub";
            this.btn_DeleteMyClub.Size = new System.Drawing.Size(144, 23);
            this.btn_DeleteMyClub.TabIndex = 1;
            this.btn_DeleteMyClub.Text = "Obriši klub";
            this.btn_DeleteMyClub.UseVisualStyleBackColor = true;
            this.btn_DeleteMyClub.Click += new System.EventHandler(this.btn_DeleteMyClub_Click);
            // 
            // dgv_Clubs
            // 
            this.dgv_Clubs.AllowUserToAddRows = false;
            this.dgv_Clubs.AllowUserToDeleteRows = false;
            this.dgv_Clubs.AllowUserToOrderColumns = true;
            this.dgv_Clubs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Clubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clubs.Location = new System.Drawing.Point(6, 50);
            this.dgv_Clubs.Name = "dgv_Clubs";
            this.dgv_Clubs.ReadOnly = true;
            this.dgv_Clubs.Size = new System.Drawing.Size(1079, 564);
            this.dgv_Clubs.TabIndex = 0;
            this.dgv_Clubs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Clubs_CellContentClick);
            this.dgv_Clubs.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Clubs_CellContentDoubleClick);
            this.dgv_Clubs.SelectionChanged += new System.EventHandler(this.dgv_Clubs_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.l_Description);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.l_LastActivity);
            this.groupBox1.Controls.Add(this.l_LastActivityName);
            this.groupBox1.Controls.Add(this.l_Created);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.pb_ClubIcon);
            this.groupBox1.Controls.Add(this.l_MembersCount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.l_AvgDailyRating);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.l_Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(364, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 124);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregled detalja";
            // 
            // l_Description
            // 
            this.l_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Description.Location = new System.Drawing.Point(491, 19);
            this.l_Description.Name = "l_Description";
            this.l_Description.Size = new System.Drawing.Size(236, 87);
            this.l_Description.TabIndex = 14;
            this.l_Description.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Opis kluba:";
            // 
            // l_LastActivity
            // 
            this.l_LastActivity.AutoSize = true;
            this.l_LastActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_LastActivity.Location = new System.Drawing.Point(216, 93);
            this.l_LastActivity.Name = "l_LastActivity";
            this.l_LastActivity.Size = new System.Drawing.Size(11, 13);
            this.l_LastActivity.TabIndex = 12;
            this.l_LastActivity.Text = "-";
            // 
            // l_LastActivityName
            // 
            this.l_LastActivityName.AutoSize = true;
            this.l_LastActivityName.Location = new System.Drawing.Point(90, 93);
            this.l_LastActivityName.Name = "l_LastActivityName";
            this.l_LastActivityName.Size = new System.Drawing.Size(89, 13);
            this.l_LastActivityName.TabIndex = 11;
            this.l_LastActivityName.Text = "Zadnja aktivnost:";
            // 
            // l_Created
            // 
            this.l_Created.AutoSize = true;
            this.l_Created.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Created.Location = new System.Drawing.Point(216, 75);
            this.l_Created.Name = "l_Created";
            this.l_Created.Size = new System.Drawing.Size(11, 13);
            this.l_Created.TabIndex = 8;
            this.l_Created.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(90, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Kreiran:";
            // 
            // pb_ClubIcon
            // 
            this.pb_ClubIcon.Location = new System.Drawing.Point(6, 31);
            this.pb_ClubIcon.Name = "pb_ClubIcon";
            this.pb_ClubIcon.Size = new System.Drawing.Size(65, 64);
            this.pb_ClubIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ClubIcon.TabIndex = 6;
            this.pb_ClubIcon.TabStop = false;
            this.pb_ClubIcon.Visible = false;
            // 
            // l_MembersCount
            // 
            this.l_MembersCount.AutoSize = true;
            this.l_MembersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_MembersCount.Location = new System.Drawing.Point(216, 38);
            this.l_MembersCount.Name = "l_MembersCount";
            this.l_MembersCount.Size = new System.Drawing.Size(11, 13);
            this.l_MembersCount.TabIndex = 5;
            this.l_MembersCount.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Broj članova:";
            // 
            // l_AvgDailyRating
            // 
            this.l_AvgDailyRating.AutoSize = true;
            this.l_AvgDailyRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_AvgDailyRating.Location = new System.Drawing.Point(216, 57);
            this.l_AvgDailyRating.Name = "l_AvgDailyRating";
            this.l_AvgDailyRating.Size = new System.Drawing.Size(11, 13);
            this.l_AvgDailyRating.TabIndex = 3;
            this.l_AvgDailyRating.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prosječan dnevni rejting";
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Name.Location = new System.Drawing.Point(216, 20);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(11, 13);
            this.l_Name.TabIndex = 1;
            this.l_Name.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // ClubManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 774);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_Grid);
            this.Controls.Add(this.gb_Pregled);
            this.Name = "ClubManagement";
            this.Text = "Moji klubovi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.ClubManagement_Shown);
            this.gb_Pregled.ResumeLayout(false);
            this.gb_Pregled.PerformLayout();
            this.gb_Grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clubs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ClubIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Pregled;
        private System.Windows.Forms.GroupBox gb_Grid;
        private System.Windows.Forms.DataGridView dgv_Clubs;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox tb_ClubName;
        private System.Windows.Forms.Button btn_DeleteMyClub;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.Label l_MembersCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label l_AvgDailyRating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_ClubIcon;
        private System.Windows.Forms.Label l_LastActivity;
        private System.Windows.Forms.Label l_LastActivityName;
        private System.Windows.Forms.Label l_Created;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label l_Description;
        private System.Windows.Forms.Label label4;
    }
}