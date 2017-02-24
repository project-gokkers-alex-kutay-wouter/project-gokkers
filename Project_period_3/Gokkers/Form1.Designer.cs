namespace Gokkers
{
    partial class Form1
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
            this.rbtn_sietse = new System.Windows.Forms.RadioButton();
            this.rbtn_Lidy = new System.Windows.Forms.RadioButton();
            this.rbtn_fer = new System.Windows.Forms.RadioButton();
            this.btn_bet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Value_bet = new System.Windows.Forms.NumericUpDown();
            this.Zebra_num = new System.Windows.Forms.NumericUpDown();
            this.btn_run = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.balans_Sieste = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.balans_Lidy = new System.Windows.Forms.Label();
            this.balans_Fer = new System.Windows.Forms.Label();
            this.bettting = new System.Windows.Forms.Label();
            this.bet_status_Sieste = new System.Windows.Forms.Label();
            this.bet_status_Lidy = new System.Windows.Forms.Label();
            this.bet_status_Fer = new System.Windows.Forms.Label();
            this.tmr_run_Zebra = new System.Windows.Forms.Timer(this.components);
            this.Zebra5 = new System.Windows.Forms.PictureBox();
            this.Zebra4 = new System.Windows.Forms.PictureBox();
            this.Zebra3 = new System.Windows.Forms.PictureBox();
            this.Zebra2 = new System.Windows.Forms.PictureBox();
            this.Zebra1 = new System.Windows.Forms.PictureBox();
            this.running_course = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Value_bet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zebra_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zebra5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zebra4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zebra3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zebra2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zebra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.running_course)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtn_sietse
            // 
            this.rbtn_sietse.AutoSize = true;
            this.rbtn_sietse.Location = new System.Drawing.Point(13, 322);
            this.rbtn_sietse.Name = "rbtn_sietse";
            this.rbtn_sietse.Size = new System.Drawing.Size(54, 17);
            this.rbtn_sietse.TabIndex = 1;
            this.rbtn_sietse.TabStop = true;
            this.rbtn_sietse.Text = "Sietse";
            this.rbtn_sietse.UseVisualStyleBackColor = true;
            // 
            // rbtn_Lidy
            // 
            this.rbtn_Lidy.AutoSize = true;
            this.rbtn_Lidy.Location = new System.Drawing.Point(13, 345);
            this.rbtn_Lidy.Name = "rbtn_Lidy";
            this.rbtn_Lidy.Size = new System.Drawing.Size(44, 17);
            this.rbtn_Lidy.TabIndex = 2;
            this.rbtn_Lidy.TabStop = true;
            this.rbtn_Lidy.Text = "Lidy";
            this.rbtn_Lidy.UseVisualStyleBackColor = true;
            // 
            // rbtn_fer
            // 
            this.rbtn_fer.AutoSize = true;
            this.rbtn_fer.Location = new System.Drawing.Point(13, 368);
            this.rbtn_fer.Name = "rbtn_fer";
            this.rbtn_fer.Size = new System.Drawing.Size(40, 17);
            this.rbtn_fer.TabIndex = 3;
            this.rbtn_fer.TabStop = true;
            this.rbtn_fer.Text = "Fer";
            this.rbtn_fer.UseVisualStyleBackColor = true;
            // 
            // btn_bet
            // 
            this.btn_bet.Location = new System.Drawing.Point(12, 423);
            this.btn_bet.Name = "btn_bet";
            this.btn_bet.Size = new System.Drawing.Size(75, 23);
            this.btn_bet.TabIndex = 4;
            this.btn_bet.Text = "Wed";
            this.btn_bet.UseVisualStyleBackColor = true;
            this.btn_bet.Click += new System.EventHandler(this.btn_bet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "euro op zebra nummer";
            // 
            // Value_bet
            // 
            this.Value_bet.Location = new System.Drawing.Point(93, 426);
            this.Value_bet.Name = "Value_bet";
            this.Value_bet.Size = new System.Drawing.Size(55, 20);
            this.Value_bet.TabIndex = 7;
            this.Value_bet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Value_bet.ValueChanged += new System.EventHandler(this.Value_bet_ValueChanged);
            // 
            // Zebra_num
            // 
            this.Zebra_num.Location = new System.Drawing.Point(272, 426);
            this.Zebra_num.Name = "Zebra_num";
            this.Zebra_num.Size = new System.Drawing.Size(55, 20);
            this.Zebra_num.TabIndex = 8;
            this.Zebra_num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Zebra_num.ValueChanged += new System.EventHandler(this.Zebra_num_ValueChanged);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(935, 320);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 23);
            this.btn_run.TabIndex = 19;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "heeft €";
            // 
            // balans_Sieste
            // 
            this.balans_Sieste.AutoSize = true;
            this.balans_Sieste.Location = new System.Drawing.Point(121, 322);
            this.balans_Sieste.Name = "balans_Sieste";
            this.balans_Sieste.Size = new System.Drawing.Size(19, 13);
            this.balans_Sieste.TabIndex = 22;
            this.balans_Sieste.Text = "25";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "heeft €";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "heeft €";
            // 
            // balans_Lidy
            // 
            this.balans_Lidy.AutoSize = true;
            this.balans_Lidy.Location = new System.Drawing.Point(121, 345);
            this.balans_Lidy.Name = "balans_Lidy";
            this.balans_Lidy.Size = new System.Drawing.Size(19, 13);
            this.balans_Lidy.TabIndex = 25;
            this.balans_Lidy.Text = "25";
            // 
            // balans_Fer
            // 
            this.balans_Fer.AutoSize = true;
            this.balans_Fer.Location = new System.Drawing.Point(121, 370);
            this.balans_Fer.Name = "balans_Fer";
            this.balans_Fer.Size = new System.Drawing.Size(19, 13);
            this.balans_Fer.TabIndex = 26;
            this.balans_Fer.Text = "25";
            this.balans_Fer.Click += new System.EventHandler(this.balans_Fer_Click);
            // 
            // bettting
            // 
            this.bettting.AutoSize = true;
            this.bettting.Location = new System.Drawing.Point(45, 475);
            this.bettting.Name = "bettting";
            this.bettting.Size = new System.Drawing.Size(95, 13);
            this.bettting.TabIndex = 27;
            this.bettting.Text = "Weddenschappen";
            // 
            // bet_status_Sieste
            // 
            this.bet_status_Sieste.AutoSize = true;
            this.bet_status_Sieste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bet_status_Sieste.Location = new System.Drawing.Point(9, 503);
            this.bet_status_Sieste.Name = "bet_status_Sieste";
            this.bet_status_Sieste.Size = new System.Drawing.Size(195, 15);
            this.bet_status_Sieste.TabIndex = 31;
            this.bet_status_Sieste.Text = "Sietse heeft € gebied op Zebra nummer";
            this.bet_status_Sieste.Click += new System.EventHandler(this.bet_status_Sieste_Click);
            // 
            // bet_status_Lidy
            // 
            this.bet_status_Lidy.AutoSize = true;
            this.bet_status_Lidy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bet_status_Lidy.Location = new System.Drawing.Point(10, 526);
            this.bet_status_Lidy.Name = "bet_status_Lidy";
            this.bet_status_Lidy.Size = new System.Drawing.Size(185, 15);
            this.bet_status_Lidy.TabIndex = 34;
            this.bet_status_Lidy.Text = "Lidy heeft € gebied op Zebra nummer";
            // 
            // bet_status_Fer
            // 
            this.bet_status_Fer.AutoSize = true;
            this.bet_status_Fer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bet_status_Fer.Location = new System.Drawing.Point(9, 548);
            this.bet_status_Fer.Name = "bet_status_Fer";
            this.bet_status_Fer.Size = new System.Drawing.Size(181, 15);
            this.bet_status_Fer.TabIndex = 35;
            this.bet_status_Fer.Text = "Fer heeft € gebied op Zebra nummer";
            // 
            // tmr_run_Zebra
            // 
            this.tmr_run_Zebra.Interval = 1;
            this.tmr_run_Zebra.Tick += new System.EventHandler(this.tmr_run_Zebra_Tick);
            // 
            // Zebra5
            // 
            this.Zebra5.Image = global::Gokkers.Properties.Resources.Zebra1;
            this.Zebra5.Location = new System.Drawing.Point(23, 252);
            this.Zebra5.Name = "Zebra5";
            this.Zebra5.Size = new System.Drawing.Size(100, 50);
            this.Zebra5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zebra5.TabIndex = 20;
            this.Zebra5.TabStop = false;
            this.Zebra5.WaitOnLoad = true;
            // 
            // Zebra4
            // 
            this.Zebra4.Image = global::Gokkers.Properties.Resources.Zebra1;
            this.Zebra4.Location = new System.Drawing.Point(23, 196);
            this.Zebra4.Name = "Zebra4";
            this.Zebra4.Size = new System.Drawing.Size(100, 50);
            this.Zebra4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zebra4.TabIndex = 16;
            this.Zebra4.TabStop = false;
            this.Zebra4.WaitOnLoad = true;
            // 
            // Zebra3
            // 
            this.Zebra3.Image = global::Gokkers.Properties.Resources.Zebra1;
            this.Zebra3.Location = new System.Drawing.Point(23, 140);
            this.Zebra3.Name = "Zebra3";
            this.Zebra3.Size = new System.Drawing.Size(100, 50);
            this.Zebra3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zebra3.TabIndex = 15;
            this.Zebra3.TabStop = false;
            this.Zebra3.WaitOnLoad = true;
            // 
            // Zebra2
            // 
            this.Zebra2.Image = global::Gokkers.Properties.Resources.Zebra1;
            this.Zebra2.Location = new System.Drawing.Point(23, 84);
            this.Zebra2.Name = "Zebra2";
            this.Zebra2.Size = new System.Drawing.Size(100, 50);
            this.Zebra2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zebra2.TabIndex = 14;
            this.Zebra2.TabStop = false;
            this.Zebra2.WaitOnLoad = true;
            // 
            // Zebra1
            // 
            this.Zebra1.Image = global::Gokkers.Properties.Resources.Zebra1;
            this.Zebra1.Location = new System.Drawing.Point(23, 28);
            this.Zebra1.Name = "Zebra1";
            this.Zebra1.Size = new System.Drawing.Size(100, 50);
            this.Zebra1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zebra1.TabIndex = 9;
            this.Zebra1.TabStop = false;
            this.Zebra1.WaitOnLoad = true;
            this.Zebra1.Click += new System.EventHandler(this.zebra1_Click);
            // 
            // running_course
            // 
            this.running_course.Location = new System.Drawing.Point(13, 13);
            this.running_course.Name = "running_course";
            this.running_course.Size = new System.Drawing.Size(1001, 300);
            this.running_course.TabIndex = 0;
            this.running_course.TabStop = false;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(854, 319);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 36;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 580);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.bet_status_Fer);
            this.Controls.Add(this.bet_status_Lidy);
            this.Controls.Add(this.bet_status_Sieste);
            this.Controls.Add(this.bettting);
            this.Controls.Add(this.balans_Fer);
            this.Controls.Add(this.balans_Lidy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.balans_Sieste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Zebra5);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.Zebra4);
            this.Controls.Add(this.Zebra3);
            this.Controls.Add(this.Zebra2);
            this.Controls.Add(this.Zebra1);
            this.Controls.Add(this.Zebra_num);
            this.Controls.Add(this.Value_bet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_bet);
            this.Controls.Add(this.rbtn_fer);
            this.Controls.Add(this.rbtn_Lidy);
            this.Controls.Add(this.rbtn_sietse);
            this.Controls.Add(this.running_course);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Value_bet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zebra_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zebra5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zebra4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zebra3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zebra2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zebra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.running_course)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox running_course;
        private System.Windows.Forms.RadioButton rbtn_Lidy;
        private System.Windows.Forms.RadioButton rbtn_fer;
        private System.Windows.Forms.Button btn_bet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Value_bet;
        private System.Windows.Forms.NumericUpDown Zebra_num;
        private System.Windows.Forms.PictureBox Zebra1;
        private System.Windows.Forms.PictureBox Zebra2;
        private System.Windows.Forms.PictureBox Zebra3;
        private System.Windows.Forms.PictureBox Zebra4;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.PictureBox Zebra5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label balans_Sieste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label balans_Lidy;
        private System.Windows.Forms.Label balans_Fer;
        private System.Windows.Forms.Label bettting;
        private System.Windows.Forms.Label bet_status_Lidy;
        private System.Windows.Forms.Label bet_status_Fer;
        private System.Windows.Forms.Timer tmr_run_Zebra;
        public System.Windows.Forms.Label bet_status_Sieste;
        public System.Windows.Forms.RadioButton rbtn_sietse;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_reset;
    }
}

