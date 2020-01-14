namespace API_Consumer.Players
{
    partial class PlayerViewById
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Pretrazi = new System.Windows.Forms.Button();
            this.tb_PlayerName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.l_highestDailyRating = new System.Windows.Forms.Label();
            this.l_GamesCount = new System.Windows.Forms.Label();
            this.l_HighestRatingDate = new System.Windows.Forms.Label();
            this.l_HighestRating = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.l_DailyRating = new System.Windows.Forms.Label();
            this.l_RD_Chess_Daily = new System.Windows.Forms.Label();
            this.l_DailyDate = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.l_IgraVec = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_status = new System.Windows.Forms.Label();
            this.l_location = new System.Windows.Forms.Label();
            this.l_joined = new System.Windows.Forms.Label();
            this.l_lastOnline = new System.Windows.Forms.Label();
            this.l_name = new System.Windows.Forms.Label();
            this.l_username = new System.Windows.Forms.Label();
            this.pb_ProfileImage = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.l_TOCount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.l_TimePerMove = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.l_Chess960_DailyTimePerMove = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.l_Chess960_DailyTOCount = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.l_highestChess960_DailyRating = new System.Windows.Forms.Label();
            this.l_Chess960_DailyGamesCount = new System.Windows.Forms.Label();
            this.l_Chess960_DailyHighestRatingDate = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.l_Chess960_DailyRating = new System.Windows.Forms.Label();
            this.l_RD_Chess960_Daily = new System.Windows.Forms.Label();
            this.l_Chess960_DailyDate = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ProfileImage)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kopirajte naziv iz URL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Pretrazi);
            this.groupBox1.Controls.Add(this.tb_PlayerName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unesite ime igrača";
            // 
            // btn_Pretrazi
            // 
            this.btn_Pretrazi.Location = new System.Drawing.Point(346, 30);
            this.btn_Pretrazi.Name = "btn_Pretrazi";
            this.btn_Pretrazi.Size = new System.Drawing.Size(75, 23);
            this.btn_Pretrazi.TabIndex = 2;
            this.btn_Pretrazi.Text = "Pogledaj";
            this.btn_Pretrazi.UseVisualStyleBackColor = true;
            this.btn_Pretrazi.Click += new System.EventHandler(this.btn_Pretrazi_Click);
            // 
            // tb_PlayerName
            // 
            this.tb_PlayerName.Location = new System.Drawing.Point(140, 32);
            this.tb_PlayerName.Name = "tb_PlayerName";
            this.tb_PlayerName.Size = new System.Drawing.Size(188, 20);
            this.tb_PlayerName.TabIndex = 1;
            this.tb_PlayerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_PlayerName_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Location = new System.Drawing.Point(16, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 253);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dnevni šah";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.l_TimePerMove);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.l_TOCount);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.l_highestDailyRating);
            this.groupBox6.Controls.Add(this.l_GamesCount);
            this.groupBox6.Controls.Add(this.l_HighestRatingDate);
            this.groupBox6.Controls.Add(this.l_HighestRating);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.l_DailyRating);
            this.groupBox6.Controls.Add(this.l_RD_Chess_Daily);
            this.groupBox6.Controls.Add(this.l_DailyDate);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Location = new System.Drawing.Point(23, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(236, 221);
            this.groupBox6.TabIndex = 29;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Standard";
            // 
            // l_highestDailyRating
            // 
            this.l_highestDailyRating.AutoSize = true;
            this.l_highestDailyRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_highestDailyRating.Location = new System.Drawing.Point(57, 81);
            this.l_highestDailyRating.Name = "l_highestDailyRating";
            this.l_highestDailyRating.Size = new System.Drawing.Size(35, 13);
            this.l_highestDailyRating.TabIndex = 28;
            this.l_highestDailyRating.Text = "1500";
            // 
            // l_GamesCount
            // 
            this.l_GamesCount.AutoSize = true;
            this.l_GamesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_GamesCount.Location = new System.Drawing.Point(71, 135);
            this.l_GamesCount.Name = "l_GamesCount";
            this.l_GamesCount.Size = new System.Drawing.Size(14, 13);
            this.l_GamesCount.TabIndex = 32;
            this.l_GamesCount.Text = "1";
            // 
            // l_HighestRatingDate
            // 
            this.l_HighestRatingDate.AutoSize = true;
            this.l_HighestRatingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_HighestRatingDate.Location = new System.Drawing.Point(57, 99);
            this.l_HighestRatingDate.Name = "l_HighestRatingDate";
            this.l_HighestRatingDate.Size = new System.Drawing.Size(106, 13);
            this.l_HighestRatingDate.TabIndex = 29;
            this.l_HighestRatingDate.Text = "2010.11.12 15:00:00";
            // 
            // l_HighestRating
            // 
            this.l_HighestRating.AutoSize = true;
            this.l_HighestRating.Location = new System.Drawing.Point(6, 81);
            this.l_HighestRating.Name = "l_HighestRating";
            this.l_HighestRating.Size = new System.Drawing.Size(41, 13);
            this.l_HighestRating.TabIndex = 30;
            this.l_HighestRating.Text = "Najviši:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "RD:";
            // 
            // l_DailyRating
            // 
            this.l_DailyRating.AutoSize = true;
            this.l_DailyRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_DailyRating.Location = new System.Drawing.Point(57, 22);
            this.l_DailyRating.Name = "l_DailyRating";
            this.l_DailyRating.Size = new System.Drawing.Size(35, 13);
            this.l_DailyRating.TabIndex = 22;
            this.l_DailyRating.Text = "1500";
            // 
            // l_RD_Chess_Daily
            // 
            this.l_RD_Chess_Daily.AutoSize = true;
            this.l_RD_Chess_Daily.Location = new System.Drawing.Point(55, 54);
            this.l_RD_Chess_Daily.Name = "l_RD_Chess_Daily";
            this.l_RD_Chess_Daily.Size = new System.Drawing.Size(19, 13);
            this.l_RD_Chess_Daily.TabIndex = 26;
            this.l_RD_Chess_Daily.Text = "10";
            // 
            // l_DailyDate
            // 
            this.l_DailyDate.AutoSize = true;
            this.l_DailyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_DailyDate.Location = new System.Drawing.Point(55, 38);
            this.l_DailyDate.Name = "l_DailyDate";
            this.l_DailyDate.Size = new System.Drawing.Size(106, 13);
            this.l_DailyDate.TabIndex = 23;
            this.l_DailyDate.Text = "2010.11.12 15:00:00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Rejting:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.l_IgraVec);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.l_status);
            this.groupBox4.Controls.Add(this.l_location);
            this.groupBox4.Controls.Add(this.l_joined);
            this.groupBox4.Controls.Add(this.l_lastOnline);
            this.groupBox4.Controls.Add(this.l_name);
            this.groupBox4.Controls.Add(this.l_username);
            this.groupBox4.Controls.Add(this.pb_ProfileImage);
            this.groupBox4.Location = new System.Drawing.Point(16, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(558, 153);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Osnovni podaci";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Igra šah:";
            // 
            // l_IgraVec
            // 
            this.l_IgraVec.AutoSize = true;
            this.l_IgraVec.Location = new System.Drawing.Point(407, 80);
            this.l_IgraVec.Name = "l_IgraVec";
            this.l_IgraVec.Size = new System.Drawing.Size(10, 13);
            this.l_IgraVec.TabIndex = 13;
            this.l_IgraVec.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tip korisnika:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Lokacija:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pristupio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Online bio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ime i prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username:";
            // 
            // l_status
            // 
            this.l_status.AutoSize = true;
            this.l_status.Location = new System.Drawing.Point(226, 124);
            this.l_status.Name = "l_status";
            this.l_status.Size = new System.Drawing.Size(10, 13);
            this.l_status.TabIndex = 6;
            this.l_status.Text = "-";
            // 
            // l_location
            // 
            this.l_location.AutoSize = true;
            this.l_location.Location = new System.Drawing.Point(226, 96);
            this.l_location.Name = "l_location";
            this.l_location.Size = new System.Drawing.Size(10, 13);
            this.l_location.TabIndex = 5;
            this.l_location.Text = "-";
            // 
            // l_joined
            // 
            this.l_joined.AutoSize = true;
            this.l_joined.Location = new System.Drawing.Point(407, 47);
            this.l_joined.Name = "l_joined";
            this.l_joined.Size = new System.Drawing.Size(10, 13);
            this.l_joined.TabIndex = 4;
            this.l_joined.Text = "-";
            // 
            // l_lastOnline
            // 
            this.l_lastOnline.AutoSize = true;
            this.l_lastOnline.Location = new System.Drawing.Point(407, 19);
            this.l_lastOnline.Name = "l_lastOnline";
            this.l_lastOnline.Size = new System.Drawing.Size(10, 13);
            this.l_lastOnline.TabIndex = 3;
            this.l_lastOnline.Text = "-";
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Location = new System.Drawing.Point(217, 48);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(10, 13);
            this.l_name.TabIndex = 2;
            this.l_name.Text = "-";
            // 
            // l_username
            // 
            this.l_username.AutoSize = true;
            this.l_username.Location = new System.Drawing.Point(217, 19);
            this.l_username.Name = "l_username";
            this.l_username.Size = new System.Drawing.Size(10, 13);
            this.l_username.TabIndex = 1;
            this.l_username.Text = "-";
            // 
            // pb_ProfileImage
            // 
            this.pb_ProfileImage.Location = new System.Drawing.Point(6, 19);
            this.pb_ProfileImage.Name = "pb_ProfileImage";
            this.pb_ProfileImage.Size = new System.Drawing.Size(109, 118);
            this.pb_ProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ProfileImage.TabIndex = 0;
            this.pb_ProfileImage.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Broj partija:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "TimeOut:";
            // 
            // l_TOCount
            // 
            this.l_TOCount.AutoSize = true;
            this.l_TOCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_TOCount.Location = new System.Drawing.Point(74, 162);
            this.l_TOCount.Name = "l_TOCount";
            this.l_TOCount.Size = new System.Drawing.Size(14, 13);
            this.l_TOCount.TabIndex = 35;
            this.l_TOCount.Text = "2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Vrijeme/potez:";
            // 
            // l_TimePerMove
            // 
            this.l_TimePerMove.AutoSize = true;
            this.l_TimePerMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_TimePerMove.Location = new System.Drawing.Point(91, 190);
            this.l_TimePerMove.Name = "l_TimePerMove";
            this.l_TimePerMove.Size = new System.Drawing.Size(14, 13);
            this.l_TimePerMove.TabIndex = 37;
            this.l_TimePerMove.Text = "0";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.l_Chess960_DailyTimePerMove);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.l_Chess960_DailyTOCount);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.l_highestChess960_DailyRating);
            this.groupBox5.Controls.Add(this.l_Chess960_DailyGamesCount);
            this.groupBox5.Controls.Add(this.l_Chess960_DailyHighestRatingDate);
            this.groupBox5.Controls.Add(this.label36);
            this.groupBox5.Controls.Add(this.label37);
            this.groupBox5.Controls.Add(this.l_Chess960_DailyRating);
            this.groupBox5.Controls.Add(this.l_RD_Chess960_Daily);
            this.groupBox5.Controls.Add(this.l_Chess960_DailyDate);
            this.groupBox5.Controls.Add(this.label41);
            this.groupBox5.Location = new System.Drawing.Point(297, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(240, 221);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "960";
            // 
            // l_Chess960_DailyTimePerMove
            // 
            this.l_Chess960_DailyTimePerMove.AutoSize = true;
            this.l_Chess960_DailyTimePerMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Chess960_DailyTimePerMove.Location = new System.Drawing.Point(91, 190);
            this.l_Chess960_DailyTimePerMove.Name = "l_Chess960_DailyTimePerMove";
            this.l_Chess960_DailyTimePerMove.Size = new System.Drawing.Size(14, 13);
            this.l_Chess960_DailyTimePerMove.TabIndex = 37;
            this.l_Chess960_DailyTimePerMove.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "Vrijeme/potez:";
            // 
            // l_Chess960_DailyTOCount
            // 
            this.l_Chess960_DailyTOCount.AutoSize = true;
            this.l_Chess960_DailyTOCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Chess960_DailyTOCount.Location = new System.Drawing.Point(74, 162);
            this.l_Chess960_DailyTOCount.Name = "l_Chess960_DailyTOCount";
            this.l_Chess960_DailyTOCount.Size = new System.Drawing.Size(14, 13);
            this.l_Chess960_DailyTOCount.TabIndex = 35;
            this.l_Chess960_DailyTOCount.Text = "2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 162);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "TimeOut:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 135);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "Broj partija:";
            // 
            // l_highestChess960_DailyRating
            // 
            this.l_highestChess960_DailyRating.AutoSize = true;
            this.l_highestChess960_DailyRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_highestChess960_DailyRating.Location = new System.Drawing.Point(57, 81);
            this.l_highestChess960_DailyRating.Name = "l_highestChess960_DailyRating";
            this.l_highestChess960_DailyRating.Size = new System.Drawing.Size(35, 13);
            this.l_highestChess960_DailyRating.TabIndex = 28;
            this.l_highestChess960_DailyRating.Text = "1500";
            // 
            // l_Chess960_DailyGamesCount
            // 
            this.l_Chess960_DailyGamesCount.AutoSize = true;
            this.l_Chess960_DailyGamesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Chess960_DailyGamesCount.Location = new System.Drawing.Point(71, 135);
            this.l_Chess960_DailyGamesCount.Name = "l_Chess960_DailyGamesCount";
            this.l_Chess960_DailyGamesCount.Size = new System.Drawing.Size(14, 13);
            this.l_Chess960_DailyGamesCount.TabIndex = 32;
            this.l_Chess960_DailyGamesCount.Text = "1";
            // 
            // l_Chess960_DailyHighestRatingDate
            // 
            this.l_Chess960_DailyHighestRatingDate.AutoSize = true;
            this.l_Chess960_DailyHighestRatingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Chess960_DailyHighestRatingDate.Location = new System.Drawing.Point(57, 99);
            this.l_Chess960_DailyHighestRatingDate.Name = "l_Chess960_DailyHighestRatingDate";
            this.l_Chess960_DailyHighestRatingDate.Size = new System.Drawing.Size(106, 13);
            this.l_Chess960_DailyHighestRatingDate.TabIndex = 29;
            this.l_Chess960_DailyHighestRatingDate.Text = "2010.11.12 15:00:00";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 81);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(41, 13);
            this.label36.TabIndex = 30;
            this.label36.Text = "Najviši:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(23, 54);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(26, 13);
            this.label37.TabIndex = 27;
            this.label37.Text = "RD:";
            // 
            // l_Chess960_DailyRating
            // 
            this.l_Chess960_DailyRating.AutoSize = true;
            this.l_Chess960_DailyRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Chess960_DailyRating.Location = new System.Drawing.Point(57, 22);
            this.l_Chess960_DailyRating.Name = "l_Chess960_DailyRating";
            this.l_Chess960_DailyRating.Size = new System.Drawing.Size(35, 13);
            this.l_Chess960_DailyRating.TabIndex = 22;
            this.l_Chess960_DailyRating.Text = "1500";
            // 
            // l_RD_Chess960_Daily
            // 
            this.l_RD_Chess960_Daily.AutoSize = true;
            this.l_RD_Chess960_Daily.Location = new System.Drawing.Point(55, 54);
            this.l_RD_Chess960_Daily.Name = "l_RD_Chess960_Daily";
            this.l_RD_Chess960_Daily.Size = new System.Drawing.Size(19, 13);
            this.l_RD_Chess960_Daily.TabIndex = 26;
            this.l_RD_Chess960_Daily.Text = "10";
            // 
            // l_Chess960_DailyDate
            // 
            this.l_Chess960_DailyDate.AutoSize = true;
            this.l_Chess960_DailyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Chess960_DailyDate.Location = new System.Drawing.Point(55, 38);
            this.l_Chess960_DailyDate.Name = "l_Chess960_DailyDate";
            this.l_Chess960_DailyDate.Size = new System.Drawing.Size(106, 13);
            this.l_Chess960_DailyDate.TabIndex = 23;
            this.l_Chess960_DailyDate.Text = "2010.11.12 15:00:00";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(6, 22);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(43, 13);
            this.label41.TabIndex = 24;
            this.label41.Text = "Rejting:";
            // 
            // PlayerViewById
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 525);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PlayerViewById";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji o igraču";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ProfileImage)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Pretrazi;
        private System.Windows.Forms.TextBox tb_PlayerName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pb_ProfileImage;
        private System.Windows.Forms.Label l_username;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.Label l_status;
        private System.Windows.Forms.Label l_location;
        private System.Windows.Forms.Label l_joined;
        private System.Windows.Forms.Label l_lastOnline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label l_IgraVec;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label l_highestDailyRating;
        private System.Windows.Forms.Label l_GamesCount;
        private System.Windows.Forms.Label l_HighestRatingDate;
        private System.Windows.Forms.Label l_HighestRating;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label l_DailyRating;
        private System.Windows.Forms.Label l_RD_Chess_Daily;
        private System.Windows.Forms.Label l_DailyDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label l_TOCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label l_TimePerMove;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label l_Chess960_DailyTimePerMove;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label l_Chess960_DailyTOCount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label l_highestChess960_DailyRating;
        private System.Windows.Forms.Label l_Chess960_DailyGamesCount;
        private System.Windows.Forms.Label l_Chess960_DailyHighestRatingDate;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label l_Chess960_DailyRating;
        private System.Windows.Forms.Label l_RD_Chess960_Daily;
        private System.Windows.Forms.Label l_Chess960_DailyDate;
        private System.Windows.Forms.Label label41;
    }
}