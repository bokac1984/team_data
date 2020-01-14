namespace API_Consumer.Cron
{
    partial class CronFileLocations
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Excel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Cron = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(446, 192);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(220, 88);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Snimi";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Excel
            // 
            this.tb_Excel.Location = new System.Drawing.Point(42, 61);
            this.tb_Excel.Name = "tb_Excel";
            this.tb_Excel.Size = new System.Drawing.Size(624, 20);
            this.tb_Excel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Excel fajlovi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Automatski download fajlova (putanja do fajla sa spiskom)";
            // 
            // tb_Cron
            // 
            this.tb_Cron.Location = new System.Drawing.Point(42, 136);
            this.tb_Cron.Name = "tb_Cron";
            this.tb_Cron.Size = new System.Drawing.Size(624, 20);
            this.tb_Cron.TabIndex = 3;
            // 
            // CronFileLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 300);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Cron);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Excel);
            this.Controls.Add(this.btn_Save);
            this.Name = "CronFileLocations";
            this.Text = "Putanje";
            this.Shown += new System.EventHandler(this.CronFileLocations_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Excel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Cron;
    }
}