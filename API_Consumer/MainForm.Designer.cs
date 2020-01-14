namespace API_Consumer
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kluboviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_MyTeams = new System.Windows.Forms.ToolStripMenuItem();
            this.pretražiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timskiMečeviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automatikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.igračiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pretraziIgracaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lokalnaBazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.igračiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mnu_Locations = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kluboviToolStripMenuItem,
            this.timskiMečeviToolStripMenuItem,
            this.igračiToolStripMenuItem1,
            this.oProgramuToolStripMenuItem,
            this.lokalnaBazaToolStripMenuItem,
            this.igračiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kluboviToolStripMenuItem
            // 
            this.kluboviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_MyTeams,
            this.pretražiToolStripMenuItem});
            this.kluboviToolStripMenuItem.Name = "kluboviToolStripMenuItem";
            this.kluboviToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.kluboviToolStripMenuItem.Text = "Klubovi";
            // 
            // mnu_MyTeams
            // 
            this.mnu_MyTeams.Name = "mnu_MyTeams";
            this.mnu_MyTeams.Size = new System.Drawing.Size(135, 22);
            this.mnu_MyTeams.Text = "Moji timovi";
            this.mnu_MyTeams.Click += new System.EventHandler(this.mnu_MyTeams_Click);
            // 
            // pretražiToolStripMenuItem
            // 
            this.pretražiToolStripMenuItem.Name = "pretražiToolStripMenuItem";
            this.pretražiToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.pretražiToolStripMenuItem.Text = "Pretraži";
            this.pretražiToolStripMenuItem.Click += new System.EventHandler(this.pretražiToolStripMenuItem_Click);
            // 
            // timskiMečeviToolStripMenuItem
            // 
            this.timskiMečeviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem1,
            this.pregledToolStripMenuItem,
            this.automatikaToolStripMenuItem});
            this.timskiMečeviToolStripMenuItem.Name = "timskiMečeviToolStripMenuItem";
            this.timskiMečeviToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.timskiMečeviToolStripMenuItem.Text = "Timski mečevi";
            // 
            // dodajToolStripMenuItem1
            // 
            this.dodajToolStripMenuItem1.Name = "dodajToolStripMenuItem1";
            this.dodajToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.dodajToolStripMenuItem1.Text = "Dodaj";
            this.dodajToolStripMenuItem1.Visible = false;
            this.dodajToolStripMenuItem1.Click += new System.EventHandler(this.dodajToolStripMenuItem1_Click);
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pregledToolStripMenuItem.Text = "Pregled";
            this.pregledToolStripMenuItem.Click += new System.EventHandler(this.pregledToolStripMenuItem_Click_1);
            // 
            // automatikaToolStripMenuItem
            // 
            this.automatikaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timerDownload,
            this.pregledToolStripMenuItem1,
            this.mnu_Locations});
            this.automatikaToolStripMenuItem.Name = "automatikaToolStripMenuItem";
            this.automatikaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.automatikaToolStripMenuItem.Text = "Automatika";
            // 
            // timerDownload
            // 
            this.timerDownload.Name = "timerDownload";
            this.timerDownload.Size = new System.Drawing.Size(215, 22);
            this.timerDownload.Text = "Skini meč u zadato vrijeme";
            this.timerDownload.Click += new System.EventHandler(this.timerDownload_Click);
            // 
            // pregledToolStripMenuItem1
            // 
            this.pregledToolStripMenuItem1.Name = "pregledToolStripMenuItem1";
            this.pregledToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.pregledToolStripMenuItem1.Text = "Pregled";
            this.pregledToolStripMenuItem1.Click += new System.EventHandler(this.pregledToolStripMenuItem1_Click);
            // 
            // igračiToolStripMenuItem1
            // 
            this.igračiToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretraziIgracaMenuItem});
            this.igračiToolStripMenuItem1.Name = "igračiToolStripMenuItem1";
            this.igračiToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.igračiToolStripMenuItem1.Text = "Igrači";
            // 
            // pretraziIgracaMenuItem
            // 
            this.pretraziIgracaMenuItem.Name = "pretraziIgracaMenuItem";
            this.pretraziIgracaMenuItem.Size = new System.Drawing.Size(113, 22);
            this.pretraziIgracaMenuItem.Text = "Pretraži";
            this.pretraziIgracaMenuItem.Click += new System.EventHandler(this.pretraziIgracaMenuItem_Click);
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomoćToolStripMenuItem});
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            this.pomoćToolStripMenuItem.Click += new System.EventHandler(this.pomoćToolStripMenuItem_Click);
            // 
            // lokalnaBazaToolStripMenuItem
            // 
            this.lokalnaBazaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajToolStripMenuItem,
            this.obrišiToolStripMenuItem});
            this.lokalnaBazaToolStripMenuItem.Name = "lokalnaBazaToolStripMenuItem";
            this.lokalnaBazaToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.lokalnaBazaToolStripMenuItem.Text = "Lokalna baza";
            this.lokalnaBazaToolStripMenuItem.Visible = false;
            // 
            // kreirajToolStripMenuItem
            // 
            this.kreirajToolStripMenuItem.Name = "kreirajToolStripMenuItem";
            this.kreirajToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.kreirajToolStripMenuItem.Text = "Kreiraj";
            this.kreirajToolStripMenuItem.Click += new System.EventHandler(this.kreirajToolStripMenuItem_Click);
            // 
            // obrišiToolStripMenuItem
            // 
            this.obrišiToolStripMenuItem.Name = "obrišiToolStripMenuItem";
            this.obrišiToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.obrišiToolStripMenuItem.Text = "Obriši";
            // 
            // igračiToolStripMenuItem
            // 
            this.igračiToolStripMenuItem.Name = "igračiToolStripMenuItem";
            this.igračiToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(600, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mnu_Locations
            // 
            this.mnu_Locations.Name = "mnu_Locations";
            this.mnu_Locations.Size = new System.Drawing.Size(215, 22);
            this.mnu_Locations.Text = "Lokacije";
            this.mnu_Locations.Click += new System.EventHandler(this.mnu_Locations_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "API Consumer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lokalnaBazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrišiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kluboviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem igračiToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem timskiMečeviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretražiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem igračiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pretraziIgracaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_MyTeams;
        private System.Windows.Forms.ToolStripMenuItem automatikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerDownload;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnu_Locations;
    }
}

