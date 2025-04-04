namespace WinFormsApp5
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label6 = new Label();
            button3 = new Button();
            groupBox3 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            label7 = new Label();
            button4 = new Button();
            groupBox4 = new GroupBox();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            label8 = new Label();
            button5 = new Button();
            label9 = new Label();
            label10 = new Label();
            button6 = new Button();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            panel1 = new Panel();
            progressBar1 = new ProgressBar();
            panel2 = new Panel();
            panel3 = new Panel();
            darkModeToggle = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(20, 23);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 0;
            label1.Text = "Név:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(404, 23);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 1;
            label2.Text = "Osztály:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(78, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(276, 29);
            textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "12.A", "12.B", "12.C" });
            comboBox1.Location = new Point(489, 23);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 29);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 122, 204);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(264, 75);
            button1.Name = "button1";
            button1.Size = new Size(279, 42);
            button1.TabIndex = 4;
            button1.Text = "Teszt indítása";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(46, 204, 113);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(191, 140);
            button2.Name = "button2";
            button2.Size = new Size(100, 32);
            button2.TabIndex = 5;
            button2.Text = "Beküldés";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(20, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 187);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kérdés 1";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F);
            radioButton2.Location = new Point(192, 85);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 25);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Tégla";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F);
            radioButton1.Location = new Point(42, 85);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 25);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Hal";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(101, 35);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 6;
            label3.Text = "Melyik állat?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(14, 14);
            label4.Name = "label4";
            label4.Size = new Size(132, 32);
            label4.TabIndex = 7;
            label4.Text = "Pontszám:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 122, 204);
            label5.Location = new Point(155, 14);
            label5.Name = "label5";
            label5.Size = new Size(28, 32);
            label5.TabIndex = 8;
            label5.Text = "0";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(365, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(325, 187);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kérdés 2";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 12F);
            radioButton3.Location = new Point(192, 85);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(63, 25);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "Tégla";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 12F);
            radioButton4.Location = new Point(42, 85);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(51, 25);
            radioButton4.TabIndex = 7;
            radioButton4.TabStop = true;
            radioButton4.Text = "Hal";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(101, 35);
            label6.Name = "label6";
            label6.Size = new Size(119, 25);
            label6.TabIndex = 6;
            label6.Text = "Melyik állat?";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(46, 204, 113);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(191, 140);
            button3.Name = "button3";
            button3.Size = new Size(100, 32);
            button3.TabIndex = 5;
            button3.Text = "Beküldés";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(radioButton5);
            groupBox3.Controls.Add(radioButton6);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(button4);
            groupBox3.Location = new Point(20, 227);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(325, 187);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kérdés 3";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Segoe UI", 12F);
            radioButton5.Location = new Point(192, 85);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(63, 25);
            radioButton5.TabIndex = 8;
            radioButton5.TabStop = true;
            radioButton5.Text = "Tégla";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Font = new Font("Segoe UI", 12F);
            radioButton6.Location = new Point(42, 85);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(51, 25);
            radioButton6.TabIndex = 7;
            radioButton6.TabStop = true;
            radioButton6.Text = "Hal";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(101, 35);
            label7.Name = "label7";
            label7.Size = new Size(119, 25);
            label7.TabIndex = 6;
            label7.Text = "Melyik állat?";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(46, 204, 113);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(191, 140);
            button4.Name = "button4";
            button4.Size = new Size(100, 32);
            button4.TabIndex = 5;
            button4.Text = "Beküldés";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(radioButton7);
            groupBox4.Controls.Add(radioButton8);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(button5);
            groupBox4.Location = new Point(365, 227);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(325, 187);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kérdés 4";
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Font = new Font("Segoe UI", 12F);
            radioButton7.Location = new Point(192, 85);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(63, 25);
            radioButton7.TabIndex = 8;
            radioButton7.TabStop = true;
            radioButton7.Text = "Tégla";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Font = new Font("Segoe UI", 12F);
            radioButton8.Location = new Point(42, 85);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(51, 25);
            radioButton8.TabIndex = 7;
            radioButton8.TabStop = true;
            radioButton8.Text = "Hal";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(101, 35);
            label8.Name = "label8";
            label8.Size = new Size(119, 25);
            label8.TabIndex = 6;
            label8.Text = "Melyik állat?";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(46, 204, 113);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(191, 140);
            button5.Name = "button5";
            button5.Size = new Size(100, 32);
            button5.TabIndex = 5;
            button5.Text = "Beküldés";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(14, 64);
            label9.Name = "label9";
            label9.Size = new Size(176, 30);
            label9.TabIndex = 12;
            label9.Text = "Elért pontszám:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(231, 76, 60);
            label10.Location = new Point(108, 106);
            label10.Name = "label10";
            label10.Size = new Size(38, 45);
            label10.TabIndex = 13;
            label10.Text = "0";
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(231, 76, 60);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(197, 437);
            button6.Name = "button6";
            button6.Size = new Size(315, 42);
            button6.TabIndex = 14;
            button6.Text = "Teszt beküldése";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16F);
            label11.ForeColor = Color.FromArgb(64, 64, 64);
            label11.Location = new Point(29, 183);
            label11.Name = "label11";
            label11.Size = new Size(0, 30);
            label11.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(64, 64, 64);
            label12.Location = new Point(14, 245);
            label12.Name = "label12";
            label12.Size = new Size(129, 32);
            label12.TabIndex = 16;
            label12.Text = "Statisztika";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label13.ForeColor = Color.FromArgb(64, 64, 64);
            label13.Location = new Point(14, 290);
            label13.Name = "label13";
            label13.Size = new Size(214, 25);
            label13.TabIndex = 17;
            label13.Text = "Kitöltött tesztek száma:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(0, 122, 204);
            label14.Location = new Point(234, 290);
            label14.Name = "label14";
            label14.Size = new Size(23, 25);
            label14.TabIndex = 18;
            label14.Text = "0";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(250, 250, 250);
            panel1.Controls.Add(progressBar1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 140);
            panel1.TabIndex = 19;
            panel1.Paint += panel1_Paint;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(20, 123);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(984, 11);
            progressBar1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox4);
            panel2.Location = new Point(0, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(711, 493);
            panel2.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(245, 245, 245);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(darkModeToggle);
            panel3.Location = new Point(711, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(313, 493);
            panel3.TabIndex = 21;
            // 
            // darkModeToggle
            // 
            darkModeToggle.Appearance = Appearance.Button;
            darkModeToggle.BackColor = Color.White;
            darkModeToggle.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            darkModeToggle.FlatAppearance.CheckedBackColor = Color.FromArgb(52, 73, 94);
            darkModeToggle.FlatStyle = FlatStyle.Flat;
            darkModeToggle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            darkModeToggle.ForeColor = Color.FromArgb(52, 73, 94);
            darkModeToggle.ImageAlign = ContentAlignment.MiddleLeft;
            darkModeToggle.Location = new Point(14, 430);
            darkModeToggle.Name = "darkModeToggle";
            darkModeToggle.Size = new Size(149, 40);
            darkModeToggle.TabIndex = 19;
            darkModeToggle.Text = "  Sötét mód";
            darkModeToggle.TextAlign = ContentAlignment.MiddleCenter;
            darkModeToggle.UseVisualStyleBackColor = false;
            darkModeToggle.CheckedChanged += darkModeToggle_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1024, 633);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tudásteszt";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label6;
        private Button button3;
        private GroupBox groupBox3;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Label label7;
        private Button button4;
        private GroupBox groupBox4;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private Label label8;
        private Button button5;
        private Label label9;
        private Label label10;
        private Button button6;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private CheckBox darkModeToggle;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ProgressBar progressBar1;
    }
}