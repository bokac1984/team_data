namespace API_Consumer.ClubMatch
{
    partial class ClubMatchForm
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
            this.dgvMatch = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l_Description = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.l_TimedOutCount1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.l_TimedOutCount2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.l_BoardCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.l_MatchID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.l_MatchType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l_BanTim2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.l_BanTim1 = new System.Windows.Forms.Label();
            this.label_ban1 = new System.Windows.Forms.Label();
            this.l_Duration = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.l_ScoreTeam2 = new System.Windows.Forms.Label();
            this.l_Team2 = new System.Windows.Forms.Label();
            this.l_ScoreTeam1 = new System.Windows.Forms.Label();
            this.l_Team1 = new System.Windows.Forms.Label();
            this.l_EndTime = new System.Windows.Forms.Label();
            this.l_StartTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_GamePreview = new System.Windows.Forms.Button();
            this.p_NotRegisteredMatches = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pg_APIFetch = new System.Windows.Forms.ToolStripProgressBar();
            this.tsl_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.l_DisplayCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.l_Closed2 = new System.Windows.Forms.Label();
            this.l_Closed1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.p_NotRegisteredMatches.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMatch
            // 
            this.dgvMatch.AllowUserToAddRows = false;
            this.dgvMatch.AllowUserToDeleteRows = false;
            this.dgvMatch.AllowUserToOrderColumns = true;
            this.dgvMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatch.Location = new System.Drawing.Point(3, 41);
            this.dgvMatch.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMatch.Name = "dgvMatch";
            this.dgvMatch.ReadOnly = true;
            this.dgvMatch.RowTemplate.Height = 24;
            this.dgvMatch.Size = new System.Drawing.Size(1054, 451);
            this.dgvMatch.TabIndex = 0;
            this.dgvMatch.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatch_CellContentDoubleClick);
            this.dgvMatch.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMatch_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.l_Closed1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.l_Closed2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.l_Description);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.l_TimedOutCount1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.l_TimedOutCount2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.l_BoardCount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.l_MatchID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.l_MatchType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.l_BanTim2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.l_BanTim1);
            this.groupBox1.Controls.Add(this.label_ban1);
            this.groupBox1.Controls.Add(this.l_Duration);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.l_ScoreTeam2);
            this.groupBox1.Controls.Add(this.l_Team2);
            this.groupBox1.Controls.Add(this.l_ScoreTeam1);
            this.groupBox1.Controls.Add(this.l_Team1);
            this.groupBox1.Controls.Add(this.l_EndTime);
            this.groupBox1.Controls.Add(this.l_StartTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1052, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalji meča";
            // 
            // l_Description
            // 
            this.l_Description.AutoSize = true;
            this.l_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Description.Location = new System.Drawing.Point(69, 106);
            this.l_Description.Name = "l_Description";
            this.l_Description.Size = new System.Drawing.Size(66, 13);
            this.l_Description.TabIndex = 25;
            this.l_Description.Text = "Opis meča";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Opis:";
            // 
            // l_TimedOutCount1
            // 
            this.l_TimedOutCount1.AutoSize = true;
            this.l_TimedOutCount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_TimedOutCount1.Location = new System.Drawing.Point(720, 45);
            this.l_TimedOutCount1.Name = "l_TimedOutCount1";
            this.l_TimedOutCount1.Size = new System.Drawing.Size(14, 13);
            this.l_TimedOutCount1.TabIndex = 23;
            this.l_TimedOutCount1.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(627, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "TO (tim 1):";
            // 
            // l_TimedOutCount2
            // 
            this.l_TimedOutCount2.AutoSize = true;
            this.l_TimedOutCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_TimedOutCount2.Location = new System.Drawing.Point(720, 112);
            this.l_TimedOutCount2.Name = "l_TimedOutCount2";
            this.l_TimedOutCount2.Size = new System.Drawing.Size(14, 13);
            this.l_TimedOutCount2.TabIndex = 21;
            this.l_TimedOutCount2.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(627, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "TO (tim 2):";
            // 
            // l_BoardCount
            // 
            this.l_BoardCount.AutoSize = true;
            this.l_BoardCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_BoardCount.Location = new System.Drawing.Point(69, 77);
            this.l_BoardCount.Name = "l_BoardCount";
            this.l_BoardCount.Size = new System.Drawing.Size(14, 13);
            this.l_BoardCount.TabIndex = 19;
            this.l_BoardCount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Broj tabli:";
            // 
            // l_MatchID
            // 
            this.l_MatchID.AutoSize = true;
            this.l_MatchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_MatchID.Location = new System.Drawing.Point(270, 58);
            this.l_MatchID.Name = "l_MatchID";
            this.l_MatchID.Size = new System.Drawing.Size(11, 13);
            this.l_MatchID.TabIndex = 17;
            this.l_MatchID.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID:";
            // 
            // l_MatchType
            // 
            this.l_MatchType.AutoSize = true;
            this.l_MatchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_MatchType.Location = new System.Drawing.Point(302, 16);
            this.l_MatchType.Name = "l_MatchType";
            this.l_MatchType.Size = new System.Drawing.Size(11, 13);
            this.l_MatchType.TabIndex = 15;
            this.l_MatchType.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tip meča:";
            // 
            // l_BanTim2
            // 
            this.l_BanTim2.AutoSize = true;
            this.l_BanTim2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_BanTim2.Location = new System.Drawing.Point(720, 96);
            this.l_BanTim2.Name = "l_BanTim2";
            this.l_BanTim2.Size = new System.Drawing.Size(14, 13);
            this.l_BanTim2.TabIndex = 13;
            this.l_BanTim2.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Banovanih (tim 2):";
            // 
            // l_BanTim1
            // 
            this.l_BanTim1.AutoSize = true;
            this.l_BanTim1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_BanTim1.Location = new System.Drawing.Point(720, 30);
            this.l_BanTim1.Name = "l_BanTim1";
            this.l_BanTim1.Size = new System.Drawing.Size(14, 13);
            this.l_BanTim1.TabIndex = 11;
            this.l_BanTim1.Text = "0";
            // 
            // label_ban1
            // 
            this.label_ban1.AutoSize = true;
            this.label_ban1.Location = new System.Drawing.Point(627, 30);
            this.label_ban1.Name = "label_ban1";
            this.label_ban1.Size = new System.Drawing.Size(92, 13);
            this.label_ban1.TabIndex = 10;
            this.label_ban1.Text = "Banovanih (tim 1):";
            // 
            // l_Duration
            // 
            this.l_Duration.AutoSize = true;
            this.l_Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Duration.Location = new System.Drawing.Point(67, 58);
            this.l_Duration.Name = "l_Duration";
            this.l_Duration.Size = new System.Drawing.Size(28, 13);
            this.l_Duration.TabIndex = 9;
            this.l_Duration.Text = "190";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Trajanje:";
            // 
            // l_ScoreTeam2
            // 
            this.l_ScoreTeam2.AutoSize = true;
            this.l_ScoreTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ScoreTeam2.ForeColor = System.Drawing.Color.Red;
            this.l_ScoreTeam2.Location = new System.Drawing.Point(880, 74);
            this.l_ScoreTeam2.Name = "l_ScoreTeam2";
            this.l_ScoreTeam2.Size = new System.Drawing.Size(20, 22);
            this.l_ScoreTeam2.TabIndex = 7;
            this.l_ScoreTeam2.Text = "0";
            // 
            // l_Team2
            // 
            this.l_Team2.AutoSize = true;
            this.l_Team2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Team2.Location = new System.Drawing.Point(623, 74);
            this.l_Team2.Name = "l_Team2";
            this.l_Team2.Size = new System.Drawing.Size(66, 22);
            this.l_Team2.TabIndex = 6;
            this.l_Team2.Text = "Team2";
            // 
            // l_ScoreTeam1
            // 
            this.l_ScoreTeam1.AutoSize = true;
            this.l_ScoreTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ScoreTeam1.ForeColor = System.Drawing.Color.Red;
            this.l_ScoreTeam1.Location = new System.Drawing.Point(880, 7);
            this.l_ScoreTeam1.Name = "l_ScoreTeam1";
            this.l_ScoreTeam1.Size = new System.Drawing.Size(20, 22);
            this.l_ScoreTeam1.TabIndex = 5;
            this.l_ScoreTeam1.Text = "0";
            // 
            // l_Team1
            // 
            this.l_Team1.AutoSize = true;
            this.l_Team1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Team1.Location = new System.Drawing.Point(623, 7);
            this.l_Team1.Name = "l_Team1";
            this.l_Team1.Size = new System.Drawing.Size(66, 22);
            this.l_Team1.TabIndex = 4;
            this.l_Team1.Text = "Team1";
            // 
            // l_EndTime
            // 
            this.l_EndTime.AutoSize = true;
            this.l_EndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_EndTime.Location = new System.Drawing.Point(69, 37);
            this.l_EndTime.Name = "l_EndTime";
            this.l_EndTime.Size = new System.Drawing.Size(71, 13);
            this.l_EndTime.TabIndex = 3;
            this.l_EndTime.Text = "1900.01.01";
            // 
            // l_StartTime
            // 
            this.l_StartTime.AutoSize = true;
            this.l_StartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_StartTime.Location = new System.Drawing.Point(69, 16);
            this.l_StartTime.Name = "l_StartTime";
            this.l_StartTime.Size = new System.Drawing.Size(71, 13);
            this.l_StartTime.TabIndex = 2;
            this.l_StartTime.Text = "1900.01.01";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Završio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Počeo:";
            // 
            // btn_GamePreview
            // 
            this.btn_GamePreview.Location = new System.Drawing.Point(3, 3);
            this.btn_GamePreview.Name = "btn_GamePreview";
            this.btn_GamePreview.Size = new System.Drawing.Size(111, 23);
            this.btn_GamePreview.TabIndex = 2;
            this.btn_GamePreview.Text = "Pogledaj Partiju";
            this.btn_GamePreview.UseVisualStyleBackColor = true;
            this.btn_GamePreview.Click += new System.EventHandler(this.btn_GamePreview_Click);
            // 
            // p_NotRegisteredMatches
            // 
            this.p_NotRegisteredMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_NotRegisteredMatches.Controls.Add(this.btn_GamePreview);
            this.p_NotRegisteredMatches.Controls.Add(this.dgvMatch);
            this.p_NotRegisteredMatches.Location = new System.Drawing.Point(4, 166);
            this.p_NotRegisteredMatches.Name = "p_NotRegisteredMatches";
            this.p_NotRegisteredMatches.Size = new System.Drawing.Size(1057, 494);
            this.p_NotRegisteredMatches.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pg_APIFetch,
            this.tsl_Time,
            this.l_DisplayCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 663);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1061, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pg_APIFetch
            // 
            this.pg_APIFetch.Name = "pg_APIFetch";
            this.pg_APIFetch.Size = new System.Drawing.Size(300, 16);
            this.pg_APIFetch.Visible = false;
            // 
            // tsl_Time
            // 
            this.tsl_Time.Name = "tsl_Time";
            this.tsl_Time.Size = new System.Drawing.Size(12, 17);
            this.tsl_Time.Text = "-";
            // 
            // l_DisplayCount
            // 
            this.l_DisplayCount.Name = "l_DisplayCount";
            this.l_DisplayCount.Size = new System.Drawing.Size(12, 17);
            this.l_DisplayCount.Text = "-";
            this.l_DisplayCount.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(627, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Zatvoreni:";
            // 
            // l_Closed2
            // 
            this.l_Closed2.AutoSize = true;
            this.l_Closed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Closed2.Location = new System.Drawing.Point(721, 127);
            this.l_Closed2.Name = "l_Closed2";
            this.l_Closed2.Size = new System.Drawing.Size(14, 13);
            this.l_Closed2.TabIndex = 27;
            this.l_Closed2.Text = "0";
            // 
            // l_Closed1
            // 
            this.l_Closed1.AutoSize = true;
            this.l_Closed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Closed1.Location = new System.Drawing.Point(720, 58);
            this.l_Closed1.Name = "l_Closed1";
            this.l_Closed1.Size = new System.Drawing.Size(14, 13);
            this.l_Closed1.TabIndex = 29;
            this.l_Closed1.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(628, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Zatvoreni:";
            // 
            // ClubMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 685);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.p_NotRegisteredMatches);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClubMatchForm";
            this.Text = "Pregled detalja meča";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.ClubMatchForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.p_NotRegisteredMatches.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_EndTime;
        private System.Windows.Forms.Label l_StartTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_ScoreTeam2;
        private System.Windows.Forms.Label l_Team2;
        private System.Windows.Forms.Label l_ScoreTeam1;
        private System.Windows.Forms.Label l_Team1;
        private System.Windows.Forms.Label l_Duration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l_BanTim2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label l_BanTim1;
        private System.Windows.Forms.Label label_ban1;
        private System.Windows.Forms.Label l_MatchType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_MatchID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l_BoardCount;
        private System.Windows.Forms.Label l_TimedOutCount1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label l_TimedOutCount2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_GamePreview;
        private System.Windows.Forms.Panel p_NotRegisteredMatches;
        private System.Windows.Forms.Label l_Description;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsl_Time;
        private System.Windows.Forms.ToolStripProgressBar pg_APIFetch;
        private System.Windows.Forms.ToolStripStatusLabel l_DisplayCount;
        private System.Windows.Forms.Label l_Closed1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label l_Closed2;
        private System.Windows.Forms.Label label10;
    }
}