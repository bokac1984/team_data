namespace API_Consumer.ClubMatch
{
    partial class TimerDownlaod
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbMatchId = new System.Windows.Forms.TextBox();
            this.cb_Registrations = new System.Windows.Forms.CheckBox();
            this.btn_StartTimer = new System.Windows.Forms.Button();
            this.tm_picker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Meč ID";
            // 
            // tbMatchId
            // 
            this.tbMatchId.Location = new System.Drawing.Point(23, 68);
            this.tbMatchId.Name = "tbMatchId";
            this.tbMatchId.Size = new System.Drawing.Size(100, 20);
            this.tbMatchId.TabIndex = 4;
            // 
            // cb_Registrations
            // 
            this.cb_Registrations.AutoSize = true;
            this.cb_Registrations.Checked = true;
            this.cb_Registrations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Registrations.Enabled = false;
            this.cb_Registrations.Location = new System.Drawing.Point(129, 71);
            this.cb_Registrations.Name = "cb_Registrations";
            this.cb_Registrations.Size = new System.Drawing.Size(111, 17);
            this.cb_Registrations.TabIndex = 7;
            this.cb_Registrations.Text = "U toku registracija";
            this.cb_Registrations.UseVisualStyleBackColor = true;
            // 
            // btn_StartTimer
            // 
            this.btn_StartTimer.Location = new System.Drawing.Point(23, 122);
            this.btn_StartTimer.Name = "btn_StartTimer";
            this.btn_StartTimer.Size = new System.Drawing.Size(215, 92);
            this.btn_StartTimer.TabIndex = 8;
            this.btn_StartTimer.Text = "Sačuvaj";
            this.btn_StartTimer.UseVisualStyleBackColor = true;
            this.btn_StartTimer.Click += new System.EventHandler(this.btn_StartTimer_Click);
            // 
            // tm_picker
            // 
            this.tm_picker.CustomFormat = "HH:mm";
            this.tm_picker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tm_picker.Location = new System.Drawing.Point(115, 21);
            this.tm_picker.Name = "tm_picker";
            this.tm_picker.ShowUpDown = true;
            this.tm_picker.Size = new System.Drawing.Size(74, 20);
            this.tm_picker.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Odaberite vrijeme";
            // 
            // TimerDownlaod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 230);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tm_picker);
            this.Controls.Add(this.btn_StartTimer);
            this.Controls.Add(this.cb_Registrations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMatchId);
            this.Name = "TimerDownlaod";
            this.Text = "TimerDownlaod";
            this.Shown += new System.EventHandler(this.TimerDownlaod_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMatchId;
        private System.Windows.Forms.CheckBox cb_Registrations;
        private System.Windows.Forms.Button btn_StartTimer;
        private System.Windows.Forms.DateTimePicker tm_picker;
        private System.Windows.Forms.Label label4;
    }
}