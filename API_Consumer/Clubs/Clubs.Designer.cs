namespace API_Consumer.Clubs
{
    partial class Clubs
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
            this.dgvFinished = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_AutoDownload = new System.Windows.Forms.Button();
            this.btn_Activity = new System.Windows.Forms.Button();
            this.l_Registration = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.l_InProgress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_FinishedCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_NumPlayersValue = new System.Windows.Forms.Label();
            this.lbl_KlubNazivVrednost = new System.Windows.Forms.Label();
            this.lbl_NumPlayers = new System.Windows.Forms.Label();
            this.lbl_Klub = new System.Windows.Forms.Label();
            this.tabCtrl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvInProgress = new System.Windows.Forms.DataGridView();
            this.tab_Registration = new System.Windows.Forms.TabPage();
            this.dgv_Registrations = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinished)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabCtrl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInProgress)).BeginInit();
            this.tab_Registration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Registrations)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFinished
            // 
            this.dgvFinished.AllowUserToAddRows = false;
            this.dgvFinished.AllowUserToDeleteRows = false;
            this.dgvFinished.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFinished.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinished.Location = new System.Drawing.Point(4, 5);
            this.dgvFinished.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFinished.Name = "dgvFinished";
            this.dgvFinished.RowTemplate.Height = 24;
            this.dgvFinished.Size = new System.Drawing.Size(929, 393);
            this.dgvFinished.TabIndex = 4;
            this.dgvFinished.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFinished_CellContentDoubleClick);
            this.dgvFinished.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFinished_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_AutoDownload);
            this.panel1.Controls.Add(this.btn_Activity);
            this.panel1.Controls.Add(this.l_Registration);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.l_InProgress);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_FinishedCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_NumPlayersValue);
            this.panel1.Controls.Add(this.lbl_KlubNazivVrednost);
            this.panel1.Controls.Add(this.lbl_NumPlayers);
            this.panel1.Controls.Add(this.lbl_Klub);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 104);
            this.panel1.TabIndex = 6;
            // 
            // btn_AutoDownload
            // 
            this.btn_AutoDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AutoDownload.Location = new System.Drawing.Point(788, 76);
            this.btn_AutoDownload.Name = "btn_AutoDownload";
            this.btn_AutoDownload.Size = new System.Drawing.Size(131, 23);
            this.btn_AutoDownload.TabIndex = 11;
            this.btn_AutoDownload.Text = "Dodaj u automatiku";
            this.btn_AutoDownload.UseVisualStyleBackColor = true;
            this.btn_AutoDownload.Visible = false;
            this.btn_AutoDownload.Click += new System.EventHandler(this.btn_AutoDownload_Click);
            // 
            // btn_Activity
            // 
            this.btn_Activity.Location = new System.Drawing.Point(7, 76);
            this.btn_Activity.Name = "btn_Activity";
            this.btn_Activity.Size = new System.Drawing.Size(156, 23);
            this.btn_Activity.TabIndex = 10;
            this.btn_Activity.Text = "Aktivnost članova";
            this.btn_Activity.UseVisualStyleBackColor = true;
            this.btn_Activity.Click += new System.EventHandler(this.btn_Activity_Click);
            // 
            // l_Registration
            // 
            this.l_Registration.AutoSize = true;
            this.l_Registration.Location = new System.Drawing.Point(352, 57);
            this.l_Registration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_Registration.Name = "l_Registration";
            this.l_Registration.Size = new System.Drawing.Size(13, 13);
            this.l_Registration.TabIndex = 9;
            this.l_Registration.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Registracija otvorena:";
            // 
            // l_InProgress
            // 
            this.l_InProgress.AutoSize = true;
            this.l_InProgress.Location = new System.Drawing.Point(352, 32);
            this.l_InProgress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_InProgress.Name = "l_InProgress";
            this.l_InProgress.Size = new System.Drawing.Size(13, 13);
            this.l_InProgress.TabIndex = 7;
            this.l_InProgress.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Broj mečeva u toku:";
            // 
            // lbl_FinishedCount
            // 
            this.lbl_FinishedCount.AutoSize = true;
            this.lbl_FinishedCount.Location = new System.Drawing.Point(352, 8);
            this.lbl_FinishedCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_FinishedCount.Name = "lbl_FinishedCount";
            this.lbl_FinishedCount.Size = new System.Drawing.Size(13, 13);
            this.lbl_FinishedCount.TabIndex = 5;
            this.lbl_FinishedCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Broj završenih mečeva:";
            // 
            // lbl_NumPlayersValue
            // 
            this.lbl_NumPlayersValue.AutoSize = true;
            this.lbl_NumPlayersValue.Location = new System.Drawing.Point(76, 32);
            this.lbl_NumPlayersValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NumPlayersValue.Name = "lbl_NumPlayersValue";
            this.lbl_NumPlayersValue.Size = new System.Drawing.Size(13, 13);
            this.lbl_NumPlayersValue.TabIndex = 3;
            this.lbl_NumPlayersValue.Text = "0";
            // 
            // lbl_KlubNazivVrednost
            // 
            this.lbl_KlubNazivVrednost.AutoSize = true;
            this.lbl_KlubNazivVrednost.Location = new System.Drawing.Point(51, 8);
            this.lbl_KlubNazivVrednost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_KlubNazivVrednost.Name = "lbl_KlubNazivVrednost";
            this.lbl_KlubNazivVrednost.Size = new System.Drawing.Size(0, 13);
            this.lbl_KlubNazivVrednost.TabIndex = 2;
            // 
            // lbl_NumPlayers
            // 
            this.lbl_NumPlayers.AutoSize = true;
            this.lbl_NumPlayers.Location = new System.Drawing.Point(4, 32);
            this.lbl_NumPlayers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NumPlayers.Name = "lbl_NumPlayers";
            this.lbl_NumPlayers.Size = new System.Drawing.Size(60, 13);
            this.lbl_NumPlayers.TabIndex = 1;
            this.lbl_NumPlayers.Text = "Broj igrača:";
            // 
            // lbl_Klub
            // 
            this.lbl_Klub.AutoSize = true;
            this.lbl_Klub.Location = new System.Drawing.Point(4, 8);
            this.lbl_Klub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Klub.Name = "lbl_Klub";
            this.lbl_Klub.Size = new System.Drawing.Size(31, 13);
            this.lbl_Klub.TabIndex = 0;
            this.lbl_Klub.Text = "Klub:";
            // 
            // tabCtrl1
            // 
            this.tabCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtrl1.Controls.Add(this.tabPage1);
            this.tabCtrl1.Controls.Add(this.tabPage2);
            this.tabCtrl1.Controls.Add(this.tab_Registration);
            this.tabCtrl1.Location = new System.Drawing.Point(9, 150);
            this.tabCtrl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabCtrl1.Name = "tabCtrl1";
            this.tabCtrl1.SelectedIndex = 0;
            this.tabCtrl1.Size = new System.Drawing.Size(942, 427);
            this.tabCtrl1.TabIndex = 7;
            this.tabCtrl1.SelectedIndexChanged += new System.EventHandler(this.tabCtrl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvFinished);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(934, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Završeni";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvInProgress);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(934, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "U toku";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvInProgress
            // 
            this.dgvInProgress.AllowUserToAddRows = false;
            this.dgvInProgress.AllowUserToDeleteRows = false;
            this.dgvInProgress.AllowUserToOrderColumns = true;
            this.dgvInProgress.AllowUserToResizeRows = false;
            this.dgvInProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInProgress.Location = new System.Drawing.Point(2, 2);
            this.dgvInProgress.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInProgress.Name = "dgvInProgress";
            this.dgvInProgress.RowTemplate.Height = 24;
            this.dgvInProgress.Size = new System.Drawing.Size(932, 396);
            this.dgvInProgress.TabIndex = 0;
            this.dgvInProgress.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInProgress_CellContentDoubleClick);
            this.dgvInProgress.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInProgress_CellMouseClick);
            // 
            // tab_Registration
            // 
            this.tab_Registration.Controls.Add(this.dgv_Registrations);
            this.tab_Registration.Location = new System.Drawing.Point(4, 22);
            this.tab_Registration.Name = "tab_Registration";
            this.tab_Registration.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Registration.Size = new System.Drawing.Size(934, 401);
            this.tab_Registration.TabIndex = 2;
            this.tab_Registration.Text = "Registracije";
            this.tab_Registration.UseVisualStyleBackColor = true;
            // 
            // dgv_Registrations
            // 
            this.dgv_Registrations.AllowUserToAddRows = false;
            this.dgv_Registrations.AllowUserToDeleteRows = false;
            this.dgv_Registrations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Registrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Registrations.Location = new System.Drawing.Point(0, 0);
            this.dgv_Registrations.Name = "dgv_Registrations";
            this.dgv_Registrations.Size = new System.Drawing.Size(935, 401);
            this.dgv_Registrations.TabIndex = 0;
            this.dgv_Registrations.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Registrations_CellContentDoubleClick);
            this.dgv_Registrations.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Registrations_CellMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pregled mečeva";
            // 
            // Clubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 579);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabCtrl1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Clubs";
            this.Text = "Clubs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Clubs_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinished)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabCtrl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInProgress)).EndInit();
            this.tab_Registration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Registrations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFinished;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabCtrl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvInProgress;
        private System.Windows.Forms.Label lbl_NumPlayers;
        private System.Windows.Forms.Label lbl_Klub;
        private System.Windows.Forms.Label lbl_KlubNazivVrednost;
        private System.Windows.Forms.Label lbl_NumPlayersValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_FinishedCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_InProgress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l_Registration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tab_Registration;
        private System.Windows.Forms.DataGridView dgv_Registrations;
        private System.Windows.Forms.Button btn_Activity;
        private System.Windows.Forms.Button btn_AutoDownload;
    }
}