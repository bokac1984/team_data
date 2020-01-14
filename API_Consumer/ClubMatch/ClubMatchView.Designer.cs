namespace API_Consumer.ClubMatch
{
    partial class ClubMatchView
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
            this.tb_matchId = new System.Windows.Forms.TextBox();
            this.btn_Pregled = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Registration = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tb_matchId
            // 
            this.tb_matchId.Location = new System.Drawing.Point(25, 34);
            this.tb_matchId.Margin = new System.Windows.Forms.Padding(2);
            this.tb_matchId.Name = "tb_matchId";
            this.tb_matchId.Size = new System.Drawing.Size(134, 20);
            this.tb_matchId.TabIndex = 0;
            this.tb_matchId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_matchId_KeyPress);
            // 
            // btn_Pregled
            // 
            this.btn_Pregled.Location = new System.Drawing.Point(179, 34);
            this.btn_Pregled.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Pregled.Name = "btn_Pregled";
            this.btn_Pregled.Size = new System.Drawing.Size(126, 37);
            this.btn_Pregled.TabIndex = 1;
            this.btn_Pregled.Text = "Pregled";
            this.btn_Pregled.UseVisualStyleBackColor = true;
            this.btn_Pregled.Click += new System.EventHandler(this.btn_Pregled_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unesite ID meča sa sajta";
            // 
            // cb_Registration
            // 
            this.cb_Registration.AutoSize = true;
            this.cb_Registration.Location = new System.Drawing.Point(25, 59);
            this.cb_Registration.Name = "cb_Registration";
            this.cb_Registration.Size = new System.Drawing.Size(134, 17);
            this.cb_Registration.TabIndex = 3;
            this.cb_Registration.Text = "Meč u fazi registracije?";
            this.cb_Registration.UseVisualStyleBackColor = true;
            // 
            // ClubMatchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 104);
            this.Controls.Add(this.cb_Registration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Pregled);
            this.Controls.Add(this.tb_matchId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClubMatchView";
            this.Text = "Pregled Meča";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_matchId;
        private System.Windows.Forms.Button btn_Pregled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_Registration;
    }
}