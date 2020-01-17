namespace API_Consumer.Clubs
{
    partial class MemberActivity
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
            this.label1 = new System.Windows.Forms.Label();
            this.l_Weekly = new System.Windows.Forms.Label();
            this.l_AllTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l_Monthly = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_Info = new System.Windows.Forms.DataGridView();
            this.btn_ShowInfo = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pg_APIFetch = new System.Windows.Forms.ToolStripProgressBar();
            this.progress_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusna_labela = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_ExcelExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Info)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aktivnih na sedmičnom nivou:";
            // 
            // l_Weekly
            // 
            this.l_Weekly.AutoSize = true;
            this.l_Weekly.Location = new System.Drawing.Point(179, 45);
            this.l_Weekly.Name = "l_Weekly";
            this.l_Weekly.Size = new System.Drawing.Size(13, 13);
            this.l_Weekly.TabIndex = 1;
            this.l_Weekly.Text = "0";
            // 
            // l_AllTime
            // 
            this.l_AllTime.AutoSize = true;
            this.l_AllTime.Location = new System.Drawing.Point(663, 45);
            this.l_AllTime.Name = "l_AllTime";
            this.l_AllTime.Size = new System.Drawing.Size(13, 13);
            this.l_AllTime.TabIndex = 3;
            this.l_AllTime.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aktivnih ikada:";
            // 
            // l_Monthly
            // 
            this.l_Monthly.AutoSize = true;
            this.l_Monthly.Location = new System.Drawing.Point(404, 45);
            this.l_Monthly.Name = "l_Monthly";
            this.l_Monthly.Size = new System.Drawing.Size(13, 13);
            this.l_Monthly.TabIndex = 5;
            this.l_Monthly.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Aktivnih na mjesečnom nivou:";
            // 
            // dgv_Info
            // 
            this.dgv_Info.AllowUserToAddRows = false;
            this.dgv_Info.AllowUserToDeleteRows = false;
            this.dgv_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Info.Location = new System.Drawing.Point(30, 125);
            this.dgv_Info.Name = "dgv_Info";
            this.dgv_Info.ReadOnly = true;
            this.dgv_Info.Size = new System.Drawing.Size(826, 549);
            this.dgv_Info.TabIndex = 6;
            this.dgv_Info.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Info_CellContentDoubleClick);
            this.dgv_Info.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Info_CellMouseClick);
            // 
            // btn_ShowInfo
            // 
            this.btn_ShowInfo.Location = new System.Drawing.Point(30, 92);
            this.btn_ShowInfo.Name = "btn_ShowInfo";
            this.btn_ShowInfo.Size = new System.Drawing.Size(146, 27);
            this.btn_ShowInfo.TabIndex = 7;
            this.btn_ShowInfo.Text = "Prikaži interne podatke";
            this.btn_ShowInfo.UseVisualStyleBackColor = true;
            this.btn_ShowInfo.Click += new System.EventHandler(this.btn_ShowInfo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pg_APIFetch,
            this.progress_Label,
            this.statusna_labela});
            this.statusStrip1.Location = new System.Drawing.Point(0, 687);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(868, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pg_APIFetch
            // 
            this.pg_APIFetch.Name = "pg_APIFetch";
            this.pg_APIFetch.RightToLeftLayout = true;
            this.pg_APIFetch.Size = new System.Drawing.Size(300, 16);
            // 
            // progress_Label
            // 
            this.progress_Label.Name = "progress_Label";
            this.progress_Label.Size = new System.Drawing.Size(0, 17);
            this.progress_Label.Visible = false;
            // 
            // statusna_labela
            // 
            this.statusna_labela.Name = "statusna_labela";
            this.statusna_labela.Size = new System.Drawing.Size(0, 17);
            // 
            // btn_ExcelExport
            // 
            this.btn_ExcelExport.Enabled = false;
            this.btn_ExcelExport.Location = new System.Drawing.Point(710, 92);
            this.btn_ExcelExport.Name = "btn_ExcelExport";
            this.btn_ExcelExport.Size = new System.Drawing.Size(146, 27);
            this.btn_ExcelExport.TabIndex = 10;
            this.btn_ExcelExport.Text = "Export u Excel";
            this.btn_ExcelExport.UseVisualStyleBackColor = true;
            this.btn_ExcelExport.Click += new System.EventHandler(this.btn_ExcelExport_Click);
            // 
            // MemberActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 709);
            this.Controls.Add(this.btn_ExcelExport);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_ShowInfo);
            this.Controls.Add(this.dgv_Info);
            this.Controls.Add(this.l_Monthly);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.l_AllTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l_Weekly);
            this.Controls.Add(this.label1);
            this.Name = "MemberActivity";
            this.Text = "MemberActivity";
            this.Shown += new System.EventHandler(this.MemberActivity_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Info)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_Weekly;
        private System.Windows.Forms.Label l_AllTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_Monthly;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_Info;
        private System.Windows.Forms.Button btn_ShowInfo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar pg_APIFetch;
        private System.Windows.Forms.ToolStripStatusLabel progress_Label;
        private System.Windows.Forms.Button btn_ExcelExport;
        private System.Windows.Forms.ToolStripStatusLabel statusna_labela;
    }
}