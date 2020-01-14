namespace API_Consumer.Clubs
{
    partial class ClubView
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
            this.btn_Pregled = new System.Windows.Forms.Button();
            this.tb_ClubName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Pregled
            // 
            this.btn_Pregled.Location = new System.Drawing.Point(364, 46);
            this.btn_Pregled.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Pregled.Name = "btn_Pregled";
            this.btn_Pregled.Size = new System.Drawing.Size(110, 44);
            this.btn_Pregled.TabIndex = 2;
            this.btn_Pregled.Text = "Pregled";
            this.btn_Pregled.UseVisualStyleBackColor = true;
            this.btn_Pregled.Click += new System.EventHandler(this.btnPregled_Click);
            // 
            // tb_ClubName
            // 
            this.tb_ClubName.Location = new System.Drawing.Point(9, 58);
            this.tb_ClubName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ClubName.Name = "tb_ClubName";
            this.tb_ClubName.Size = new System.Drawing.Size(331, 20);
            this.tb_ClubName.TabIndex = 1;
            this.tb_ClubName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ClubName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Unesite naziv kluba (iz linka za klub)";
            // 
            // ClubView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 146);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ClubName);
            this.Controls.Add(this.btn_Pregled);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClubView";
            this.Text = "Pregled Kluba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Pregled;
        private System.Windows.Forms.TextBox tb_ClubName;
        private System.Windows.Forms.Label label1;
    }
}