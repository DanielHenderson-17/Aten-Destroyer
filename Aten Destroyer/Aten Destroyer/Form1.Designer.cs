
namespace Aten_Destroyer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.player = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.rock_1 = new System.Windows.Forms.PictureBox();
            this.rock_2 = new System.Windows.Forms.PictureBox();
            this.e_1 = new System.Windows.Forms.PictureBox();
            this.e_2 = new System.Windows.Forms.PictureBox();
            this.e_3 = new System.Windows.Forms.PictureBox();
            this.e_1_bullet = new System.Windows.Forms.PictureBox();
            this.e_2_bullet = new System.Windows.Forms.PictureBox();
            this.e_3_bullet = new System.Windows.Forms.PictureBox();
            this.lbl_kill = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_over = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_1_bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_2_bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_3_bullet)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Image = global::Aten_Destroyer.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(15, 160);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(60, 80);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.Image = global::Aten_Destroyer.Properties.Resources.bullet;
            this.bullet.Location = new System.Drawing.Point(78, 173);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(100, 50);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet.TabIndex = 2;
            this.bullet.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aten_Destroyer.Properties.Resources.star;
            this.pictureBox1.Location = new System.Drawing.Point(532, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "star";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Aten_Destroyer.Properties.Resources.star;
            this.pictureBox2.Location = new System.Drawing.Point(378, 219);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "star";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Aten_Destroyer.Properties.Resources.star;
            this.pictureBox3.Location = new System.Drawing.Point(532, 272);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "star";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Aten_Destroyer.Properties.Resources.star;
            this.pictureBox4.Location = new System.Drawing.Point(346, 321);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(15, 15);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "star";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Aten_Destroyer.Properties.Resources.star;
            this.pictureBox5.Location = new System.Drawing.Point(324, 97);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(15, 15);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "star";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Aten_Destroyer.Properties.Resources.star;
            this.pictureBox6.Location = new System.Drawing.Point(449, 54);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(15, 15);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "star";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Aten_Destroyer.Properties.Resources.star;
            this.pictureBox7.Location = new System.Drawing.Point(610, 54);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(15, 15);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "star";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Aten_Destroyer.Properties.Resources.star;
            this.pictureBox8.Location = new System.Drawing.Point(645, 201);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(15, 15);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 10;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "star";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Aten_Destroyer.Properties.Resources.star;
            this.pictureBox9.Location = new System.Drawing.Point(665, 321);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(15, 15);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 11;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "star";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Aten_Destroyer.Properties.Resources.star;
            this.pictureBox10.Location = new System.Drawing.Point(491, 381);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(15, 15);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 12;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "star";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Aten_Destroyer.Properties.Resources.star;
            this.pictureBox11.Location = new System.Drawing.Point(729, 22);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(15, 15);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 13;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "star";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::Aten_Destroyer.Properties.Resources.star;
            this.pictureBox12.Location = new System.Drawing.Point(250, 22);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(15, 15);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 14;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "star";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::Aten_Destroyer.Properties.Resources.star;
            this.pictureBox13.Location = new System.Drawing.Point(188, 111);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(15, 15);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 15;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "star";
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::Aten_Destroyer.Properties.Resources.star;
            this.pictureBox14.Location = new System.Drawing.Point(69, 22);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(28, 22);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 16;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "star";
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::Aten_Destroyer.Properties.Resources.star;
            this.pictureBox15.Location = new System.Drawing.Point(238, 289);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(15, 15);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 17;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "star";
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::Aten_Destroyer.Properties.Resources.star;
            this.pictureBox16.Location = new System.Drawing.Point(141, 372);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(15, 15);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 18;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "star";
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = global::Aten_Destroyer.Properties.Resources.star;
            this.pictureBox17.Location = new System.Drawing.Point(35, 416);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(15, 15);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 19;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "star";
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::Aten_Destroyer.Properties.Resources.star;
            this.pictureBox18.Location = new System.Drawing.Point(295, 402);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(28, 22);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 20;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "star";
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = global::Aten_Destroyer.Properties.Resources.star;
            this.pictureBox19.Location = new System.Drawing.Point(610, 402);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(15, 15);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox19.TabIndex = 21;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Tag = "star";
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = global::Aten_Destroyer.Properties.Resources.star;
            this.pictureBox20.Location = new System.Drawing.Point(87, 263);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(15, 15);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 22;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Tag = "star";
            // 
            // rock_1
            // 
            this.rock_1.Image = global::Aten_Destroyer.Properties.Resources.rock_1;
            this.rock_1.Location = new System.Drawing.Point(491, 87);
            this.rock_1.Name = "rock_1";
            this.rock_1.Size = new System.Drawing.Size(90, 90);
            this.rock_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock_1.TabIndex = 23;
            this.rock_1.TabStop = false;
            this.rock_1.Tag = "enemy";
            // 
            // rock_2
            // 
            this.rock_2.Image = global::Aten_Destroyer.Properties.Resources.rock_2;
            this.rock_2.Location = new System.Drawing.Point(284, 348);
            this.rock_2.Name = "rock_2";
            this.rock_2.Size = new System.Drawing.Size(90, 90);
            this.rock_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock_2.TabIndex = 24;
            this.rock_2.TabStop = false;
            this.rock_2.Tag = "enemy";
            // 
            // e_1
            // 
            this.e_1.BackColor = System.Drawing.Color.Transparent;
            this.e_1.Image = global::Aten_Destroyer.Properties.Resources.e_1;
            this.e_1.Location = new System.Drawing.Point(691, 22);
            this.e_1.Name = "e_1";
            this.e_1.Size = new System.Drawing.Size(50, 60);
            this.e_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_1.TabIndex = 25;
            this.e_1.TabStop = false;
            this.e_1.Tag = "enemy";
            // 
            // e_2
            // 
            this.e_2.Image = global::Aten_Destroyer.Properties.Resources.e_2;
            this.e_2.Location = new System.Drawing.Point(691, 219);
            this.e_2.Name = "e_2";
            this.e_2.Size = new System.Drawing.Size(50, 60);
            this.e_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_2.TabIndex = 26;
            this.e_2.TabStop = false;
            this.e_2.Tag = "enemy";
            // 
            // e_3
            // 
            this.e_3.Image = global::Aten_Destroyer.Properties.Resources.e_3;
            this.e_3.Location = new System.Drawing.Point(707, 364);
            this.e_3.Name = "e_3";
            this.e_3.Size = new System.Drawing.Size(50, 60);
            this.e_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_3.TabIndex = 27;
            this.e_3.TabStop = false;
            this.e_3.Tag = "enemy";
            // 
            // e_1_bullet
            // 
            this.e_1_bullet.BackColor = System.Drawing.Color.Transparent;
            this.e_1_bullet.Image = global::Aten_Destroyer.Properties.Resources.e_1_bullet;
            this.e_1_bullet.Location = new System.Drawing.Point(629, 37);
            this.e_1_bullet.Name = "e_1_bullet";
            this.e_1_bullet.Size = new System.Drawing.Size(56, 28);
            this.e_1_bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_1_bullet.TabIndex = 28;
            this.e_1_bullet.TabStop = false;
            this.e_1_bullet.Tag = "enemy";
            // 
            // e_2_bullet
            // 
            this.e_2_bullet.BackColor = System.Drawing.Color.Transparent;
            this.e_2_bullet.Image = global::Aten_Destroyer.Properties.Resources.e_2_bullet;
            this.e_2_bullet.Location = new System.Drawing.Point(629, 238);
            this.e_2_bullet.Name = "e_2_bullet";
            this.e_2_bullet.Size = new System.Drawing.Size(56, 28);
            this.e_2_bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_2_bullet.TabIndex = 29;
            this.e_2_bullet.TabStop = false;
            this.e_2_bullet.Tag = "enemy";
            // 
            // e_3_bullet
            // 
            this.e_3_bullet.BackColor = System.Drawing.Color.Transparent;
            this.e_3_bullet.Image = global::Aten_Destroyer.Properties.Resources.e_3_bullet;
            this.e_3_bullet.Location = new System.Drawing.Point(645, 381);
            this.e_3_bullet.Name = "e_3_bullet";
            this.e_3_bullet.Size = new System.Drawing.Size(56, 28);
            this.e_3_bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_3_bullet.TabIndex = 30;
            this.e_3_bullet.TabStop = false;
            this.e_3_bullet.Tag = "enemy";
            // 
            // lbl_kill
            // 
            this.lbl_kill.AutoSize = true;
            this.lbl_kill.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kill.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_kill.ForeColor = System.Drawing.Color.Silver;
            this.lbl_kill.Location = new System.Drawing.Point(12, 9);
            this.lbl_kill.Name = "lbl_kill";
            this.lbl_kill.Size = new System.Drawing.Size(114, 32);
            this.lbl_kill.TabIndex = 31;
            this.lbl_kill.Text = "Killed : 0";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_score.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_score.Location = new System.Drawing.Point(324, 11);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(112, 32);
            this.lbl_score.TabIndex = 32;
            this.lbl_score.Text = "Score : 0";
            // 
            // lbl_over
            // 
            this.lbl_over.AutoSize = true;
            this.lbl_over.BackColor = System.Drawing.Color.Transparent;
            this.lbl_over.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_over.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_over.Location = new System.Drawing.Point(275, 201);
            this.lbl_over.Name = "lbl_over";
            this.lbl_over.Size = new System.Drawing.Size(215, 50);
            this.lbl_over.TabIndex = 33;
            this.lbl_over.Text = "Game Over";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Aten_Destroyer.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lbl_over);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_kill);
            this.Controls.Add(this.e_3);
            this.Controls.Add(this.e_2);
            this.Controls.Add(this.e_1);
            this.Controls.Add(this.e_3_bullet);
            this.Controls.Add(this.e_2_bullet);
            this.Controls.Add(this.e_1_bullet);
            this.Controls.Add(this.player);
            this.Controls.Add(this.rock_2);
            this.Controls.Add(this.rock_1);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_1_bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_2_bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_3_bullet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox rock_1;
        private System.Windows.Forms.PictureBox rock_2;
        private System.Windows.Forms.PictureBox e_1;
        private System.Windows.Forms.PictureBox e_2;
        private System.Windows.Forms.PictureBox e_3;
        private System.Windows.Forms.PictureBox e_1_bullet;
        private System.Windows.Forms.PictureBox e_2_bullet;
        private System.Windows.Forms.PictureBox e_3_bullet;
        private System.Windows.Forms.Label lbl_kill;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_over;
    }
}

