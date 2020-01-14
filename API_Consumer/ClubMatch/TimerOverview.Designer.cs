namespace API_Consumer.ClubMatch
{
    partial class TimerOverview
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
            this.dgv_CronData = new System.Windows.Forms.DataGridView();
            this.btn_NewMatch = new System.Windows.Forms.Button();
            this.btn_StopTimer = new System.Windows.Forms.Button();
            this.btn_StartTimer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pg_Working = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusPoruka = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CronData)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_CronData
            // 
            this.dgv_CronData.AllowUserToAddRows = false;
            this.dgv_CronData.AllowUserToDeleteRows = false;
            this.dgv_CronData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CronData.Location = new System.Drawing.Point(12, 67);
            this.dgv_CronData.Name = "dgv_CronData";
            this.dgv_CronData.ReadOnly = true;
            this.dgv_CronData.Size = new System.Drawing.Size(776, 300);
            this.dgv_CronData.TabIndex = 0;
            // 
            // btn_NewMatch
            // 
            this.btn_NewMatch.Location = new System.Drawing.Point(655, 23);
            this.btn_NewMatch.Name = "btn_NewMatch";
            this.btn_NewMatch.Size = new System.Drawing.Size(133, 23);
            this.btn_NewMatch.TabIndex = 1;
            this.btn_NewMatch.Text = "Dodaj novi meč";
            this.btn_NewMatch.UseVisualStyleBackColor = true;
            this.btn_NewMatch.Click += new System.EventHandler(this.btn_NewMatch_Click);
            // 
            // btn_StopTimer
            // 
            this.btn_StopTimer.Enabled = false;
            this.btn_StopTimer.Location = new System.Drawing.Point(166, 23);
            this.btn_StopTimer.Name = "btn_StopTimer";
            this.btn_StopTimer.Size = new System.Drawing.Size(133, 23);
            this.btn_StopTimer.TabIndex = 2;
            this.btn_StopTimer.Text = "Zaustavi timer";
            this.btn_StopTimer.UseVisualStyleBackColor = true;
            this.btn_StopTimer.Click += new System.EventHandler(this.btn_StopTimer_Click);
            // 
            // btn_StartTimer
            // 
            this.btn_StartTimer.Location = new System.Drawing.Point(12, 23);
            this.btn_StartTimer.Name = "btn_StartTimer";
            this.btn_StartTimer.Size = new System.Drawing.Size(133, 23);
            this.btn_StartTimer.TabIndex = 3;
            this.btn_StartTimer.Text = "Pokreni timer";
            this.btn_StartTimer.UseVisualStyleBackColor = true;
            this.btn_StartTimer.Click += new System.EventHandler(this.btn_StartTimer_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pg_Working
            // 
            this.pg_Working.Location = new System.Drawing.Point(315, 28);
            this.pg_Working.MarqueeAnimationSpeed = 20;
            this.pg_Working.Name = "pg_Working";
            this.pg_Working.Size = new System.Drawing.Size(305, 10);
            this.pg_Working.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pg_Working.TabIndex = 4;
            this.pg_Working.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusPoruka});
            this.statusStrip1.Location = new System.Drawing.Point(0, 381);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(802, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusPoruka
            // 
            this.StatusPoruka.Name = "StatusPoruka";
            this.StatusPoruka.Size = new System.Drawing.Size(0, 17);
            // 
            // TimerOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 403);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pg_Working);
            this.Controls.Add(this.btn_StartTimer);
            this.Controls.Add(this.btn_StopTimer);
            this.Controls.Add(this.btn_NewMatch);
            this.Controls.Add(this.dgv_CronData);
            this.MaximizeBox = false;
            this.Name = "TimerOverview";
            this.Text = "Pregled mečeva za download";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TimerOverview_FormClosed);
            this.Shown += new System.EventHandler(this.TimerOverview_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CronData)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_CronData;
        private System.Windows.Forms.Button btn_NewMatch;
        private System.Windows.Forms.Button btn_StopTimer;
        private System.Windows.Forms.Button btn_StartTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pg_Working;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusPoruka;
    }
}