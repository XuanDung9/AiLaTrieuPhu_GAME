namespace AiLaTrieuPhu.PRL
{
    partial class GameForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            groupBox1 = new GroupBox();
            lb_Money = new Label();
            lb_Time = new Label();
            ptb_5050 = new PictureBox();
            ptb_Viewer = new PictureBox();
            ptb_Pro = new PictureBox();
            ptb_Change = new PictureBox();
            grb_Cauhoi = new GroupBox();
            btn_Play = new Button();
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            btn_4 = new Button();
            btn_5 = new Button();
            btn_6 = new Button();
            btn_7 = new Button();
            btn_8 = new Button();
            btn_9 = new Button();
            btn_10 = new Button();
            btn_11 = new Button();
            btn_12 = new Button();
            btn_13 = new Button();
            btn_14 = new Button();
            btn_15 = new Button();
            groupBox3 = new GroupBox();
            btn_D = new Button();
            btn_C = new Button();
            btn_B = new Button();
            btn_A = new Button();
            txt_Question = new TextBox();
            time_Limit = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_5050).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Viewer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Pro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Change).BeginInit();
            grb_Cauhoi.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_Money);
            groupBox1.Controls.Add(lb_Time);
            groupBox1.Controls.Add(ptb_5050);
            groupBox1.Controls.Add(ptb_Viewer);
            groupBox1.Controls.Add(ptb_Pro);
            groupBox1.Controls.Add(ptb_Change);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(917, 316);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thời gian , quyền trợ giúp và tiền thưởng đang có";
            // 
            // lb_Money
            // 
            lb_Money.AutoSize = true;
            lb_Money.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Money.Location = new Point(508, 228);
            lb_Money.Name = "lb_Money";
            lb_Money.Size = new Size(92, 31);
            lb_Money.TabIndex = 8;
            lb_Money.Text = "000000";
            // 
            // lb_Time
            // 
            lb_Time.AutoSize = true;
            lb_Time.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Time.Location = new Point(73, 228);
            lb_Time.Name = "lb_Time";
            lb_Time.Size = new Size(40, 31);
            lb_Time.TabIndex = 7;
            lb_Time.Text = "30";
            // 
            // ptb_5050
            // 
            ptb_5050.Image = (Image)resources.GetObject("ptb_5050.Image");
            ptb_5050.Location = new Point(73, 44);
            ptb_5050.Name = "ptb_5050";
            ptb_5050.Size = new Size(134, 106);
            ptb_5050.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_5050.TabIndex = 6;
            ptb_5050.TabStop = false;
            // 
            // ptb_Viewer
            // 
            ptb_Viewer.Image = (Image)resources.GetObject("ptb_Viewer.Image");
            ptb_Viewer.Location = new Point(293, 44);
            ptb_Viewer.Name = "ptb_Viewer";
            ptb_Viewer.Size = new Size(140, 106);
            ptb_Viewer.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Viewer.TabIndex = 5;
            ptb_Viewer.TabStop = false;
            ptb_Viewer.Click += ptb_Viewer_Click;
            // 
            // ptb_Pro
            // 
            ptb_Pro.Image = (Image)resources.GetObject("ptb_Pro.Image");
            ptb_Pro.Location = new Point(508, 44);
            ptb_Pro.Name = "ptb_Pro";
            ptb_Pro.Size = new Size(151, 106);
            ptb_Pro.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Pro.TabIndex = 4;
            ptb_Pro.TabStop = false;
            ptb_Pro.Click += ptb_Pro_Click;
            // 
            // ptb_Change
            // 
            ptb_Change.Image = (Image)resources.GetObject("ptb_Change.Image");
            ptb_Change.Location = new Point(728, 44);
            ptb_Change.Name = "ptb_Change";
            ptb_Change.Size = new Size(155, 106);
            ptb_Change.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Change.TabIndex = 3;
            ptb_Change.TabStop = false;
            ptb_Change.Click += ptb_Change_Click;
            // 
            // grb_Cauhoi
            // 
            grb_Cauhoi.BackColor = SystemColors.ActiveCaption;
            grb_Cauhoi.Controls.Add(btn_Play);
            grb_Cauhoi.Controls.Add(btn_1);
            grb_Cauhoi.Controls.Add(btn_2);
            grb_Cauhoi.Controls.Add(btn_3);
            grb_Cauhoi.Controls.Add(btn_4);
            grb_Cauhoi.Controls.Add(btn_5);
            grb_Cauhoi.Controls.Add(btn_6);
            grb_Cauhoi.Controls.Add(btn_7);
            grb_Cauhoi.Controls.Add(btn_8);
            grb_Cauhoi.Controls.Add(btn_9);
            grb_Cauhoi.Controls.Add(btn_10);
            grb_Cauhoi.Controls.Add(btn_11);
            grb_Cauhoi.Controls.Add(btn_12);
            grb_Cauhoi.Controls.Add(btn_13);
            grb_Cauhoi.Controls.Add(btn_14);
            grb_Cauhoi.Controls.Add(btn_15);
            grb_Cauhoi.Location = new Point(965, 12);
            grb_Cauhoi.Name = "grb_Cauhoi";
            grb_Cauhoi.Size = new Size(336, 650);
            grb_Cauhoi.TabIndex = 1;
            grb_Cauhoi.TabStop = false;
            grb_Cauhoi.Text = "Danh sách 15 câu hỏi và các mức thưởng ";
            // 
            // btn_Play
            // 
            btn_Play.BackColor = Color.Red;
            btn_Play.Location = new Point(13, 596);
            btn_Play.Name = "btn_Play";
            btn_Play.Size = new Size(317, 54);
            btn_Play.TabIndex = 17;
            btn_Play.Text = "BẮT ĐẦU CHƠI ";
            btn_Play.UseVisualStyleBackColor = false;
            // 
            // btn_1
            // 
            btn_1.BackColor = SystemColors.ActiveCaption;
            btn_1.Location = new Point(14, 564);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(317, 31);
            btn_1.TabIndex = 16;
            btn_1.Text = "1:1.000.000";
            btn_1.UseVisualStyleBackColor = false;
            // 
            // btn_2
            // 
            btn_2.BackColor = SystemColors.ActiveCaption;
            btn_2.Location = new Point(14, 527);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(317, 31);
            btn_2.TabIndex = 15;
            btn_2.Text = "2:2..000.000";
            btn_2.UseVisualStyleBackColor = false;
            // 
            // btn_3
            // 
            btn_3.BackColor = SystemColors.ActiveCaption;
            btn_3.Location = new Point(14, 490);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(317, 31);
            btn_3.TabIndex = 14;
            btn_3.Text = "3:3.000.000";
            btn_3.UseVisualStyleBackColor = false;
            // 
            // btn_4
            // 
            btn_4.BackColor = SystemColors.ActiveCaption;
            btn_4.Location = new Point(14, 450);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(317, 31);
            btn_4.TabIndex = 13;
            btn_4.Text = "4:5.000.000";
            btn_4.UseVisualStyleBackColor = false;
            // 
            // btn_5
            // 
            btn_5.BackColor = SystemColors.ActiveCaption;
            btn_5.Location = new Point(14, 413);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(317, 31);
            btn_5.TabIndex = 12;
            btn_5.Text = "5:10.000.000";
            btn_5.UseVisualStyleBackColor = false;
            // 
            // btn_6
            // 
            btn_6.BackColor = SystemColors.ActiveCaption;
            btn_6.Location = new Point(14, 376);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(317, 31);
            btn_6.TabIndex = 11;
            btn_6.Text = "6:15.000.000";
            btn_6.UseVisualStyleBackColor = false;
            // 
            // btn_7
            // 
            btn_7.BackColor = SystemColors.ActiveCaption;
            btn_7.Location = new Point(14, 339);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(317, 31);
            btn_7.TabIndex = 10;
            btn_7.Text = "7:23.000.000";
            btn_7.UseVisualStyleBackColor = false;
            // 
            // btn_8
            // 
            btn_8.BackColor = SystemColors.ActiveCaption;
            btn_8.Location = new Point(14, 302);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(317, 31);
            btn_8.TabIndex = 9;
            btn_8.Text = "8:40.000.000";
            btn_8.UseVisualStyleBackColor = false;
            // 
            // btn_9
            // 
            btn_9.BackColor = SystemColors.ActiveCaption;
            btn_9.Location = new Point(14, 265);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(317, 31);
            btn_9.TabIndex = 8;
            btn_9.Text = "9:60.000.000";
            btn_9.UseVisualStyleBackColor = false;
            // 
            // btn_10
            // 
            btn_10.BackColor = SystemColors.ActiveCaption;
            btn_10.Location = new Point(14, 228);
            btn_10.Name = "btn_10";
            btn_10.Size = new Size(317, 31);
            btn_10.TabIndex = 7;
            btn_10.Text = "10:100.000.000";
            btn_10.UseVisualStyleBackColor = false;
            // 
            // btn_11
            // 
            btn_11.BackColor = SystemColors.ActiveCaption;
            btn_11.Location = new Point(14, 193);
            btn_11.Name = "btn_11";
            btn_11.Size = new Size(317, 31);
            btn_11.TabIndex = 6;
            btn_11.Text = "11:150.000.000";
            btn_11.UseVisualStyleBackColor = false;
            // 
            // btn_12
            // 
            btn_12.BackColor = SystemColors.ActiveCaption;
            btn_12.Location = new Point(14, 156);
            btn_12.Name = "btn_12";
            btn_12.Size = new Size(317, 31);
            btn_12.TabIndex = 5;
            btn_12.Text = "12:200.000.000";
            btn_12.UseVisualStyleBackColor = false;
            // 
            // btn_13
            // 
            btn_13.BackColor = SystemColors.ActiveCaption;
            btn_13.Location = new Point(14, 119);
            btn_13.Name = "btn_13";
            btn_13.Size = new Size(317, 31);
            btn_13.TabIndex = 4;
            btn_13.Text = "13:400.000.000";
            btn_13.UseVisualStyleBackColor = false;
            // 
            // btn_14
            // 
            btn_14.BackColor = SystemColors.ActiveCaption;
            btn_14.Location = new Point(14, 81);
            btn_14.Name = "btn_14";
            btn_14.Size = new Size(317, 31);
            btn_14.TabIndex = 3;
            btn_14.Text = "14:600.000.000";
            btn_14.UseVisualStyleBackColor = false;
            // 
            // btn_15
            // 
            btn_15.BackColor = SystemColors.ActiveCaption;
            btn_15.Location = new Point(14, 44);
            btn_15.Name = "btn_15";
            btn_15.Size = new Size(317, 31);
            btn_15.TabIndex = 2;
            btn_15.Text = "15:999.999.999";
            btn_15.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_D);
            groupBox3.Controls.Add(btn_C);
            groupBox3.Controls.Add(btn_B);
            groupBox3.Controls.Add(btn_A);
            groupBox3.Controls.Add(txt_Question);
            groupBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 346);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(917, 316);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Câu hỏi và các đáp án ";
            // 
            // btn_D
            // 
            btn_D.BackColor = SystemColors.ActiveCaption;
            btn_D.Location = new Point(449, 231);
            btn_D.Name = "btn_D";
            btn_D.Size = new Size(462, 62);
            btn_D.TabIndex = 4;
            btn_D.Text = "D";
            btn_D.UseVisualStyleBackColor = false;
            btn_D.Click += btn_D_Click;
            // 
            // btn_C
            // 
            btn_C.BackColor = SystemColors.ActiveCaption;
            btn_C.Location = new Point(6, 231);
            btn_C.Name = "btn_C";
            btn_C.Size = new Size(437, 62);
            btn_C.TabIndex = 3;
            btn_C.Text = "C";
            btn_C.UseVisualStyleBackColor = false;
            btn_C.Click += btn_C_Click;
            // 
            // btn_B
            // 
            btn_B.BackColor = SystemColors.ActiveCaption;
            btn_B.Location = new Point(449, 140);
            btn_B.Name = "btn_B";
            btn_B.Size = new Size(462, 62);
            btn_B.TabIndex = 2;
            btn_B.Text = "B";
            btn_B.UseVisualStyleBackColor = false;
            btn_B.Click += btn_B_Click;
            // 
            // btn_A
            // 
            btn_A.BackColor = SystemColors.ActiveCaption;
            btn_A.Location = new Point(6, 140);
            btn_A.Name = "btn_A";
            btn_A.Size = new Size(437, 62);
            btn_A.TabIndex = 1;
            btn_A.Text = "A";
            btn_A.UseVisualStyleBackColor = false;
            btn_A.Click += btn_A_Click;
            // 
            // txt_Question
            // 
            txt_Question.BackColor = Color.FromArgb(224, 224, 224);
            txt_Question.Enabled = false;
            txt_Question.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Question.HideSelection = false;
            txt_Question.Location = new Point(6, 50);
            txt_Question.Multiline = true;
            txt_Question.Name = "txt_Question";
            txt_Question.PlaceholderText = "Câu hỏi ở đây ";
            txt_Question.Size = new Size(905, 97);
            txt_Question.TabIndex = 0;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 665);
            Controls.Add(groupBox3);
            Controls.Add(grb_Cauhoi);
            Controls.Add(groupBox1);
            Name = "GameForm";
            Text = "GameForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_5050).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Viewer).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Pro).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Change).EndInit();
            grb_Cauhoi.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox grb_Cauhoi;
        private GroupBox groupBox3;
        private TextBox txt_Question;
        private Button btn_D;
        private Button btn_C;
        private Button btn_B;
        private Button btn_A;
        private Label lb_Money;
        private Label lb_Time;
        private PictureBox ptb_5050;
        private PictureBox ptb_Viewer;
        private PictureBox ptb_Pro;
        private PictureBox ptb_Change;
        private Button btn_Play;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_4;
        private Button btn_5;
        private Button btn_6;
        private Button btn_7;
        private Button btn_8;
        private Button btn_9;
        private Button btn_10;
        private Button btn_11;
        private Button btn_12;
        private Button btn_13;
        private Button btn_14;
        private Button btn_15;
        private System.Windows.Forms.Timer time_Limit;
    }
}