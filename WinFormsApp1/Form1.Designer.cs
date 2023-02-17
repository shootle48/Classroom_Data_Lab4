namespace WinFormsApp1
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxgpa = new System.Windows.Forms.TextBox();
            this.textBoxBY = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxAvg = new System.Windows.Forms.TextBox();
            this.textBoxListName = new System.Windows.Forms.TextBox();
            this.textBoxMaxName = new System.Windows.Forms.TextBox();
            this.textBoxMinName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAgeAll = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(116, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(150, 31);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxgpa
            // 
            this.textBoxgpa.Location = new System.Drawing.Point(116, 90);
            this.textBoxgpa.Name = "textBoxgpa";
            this.textBoxgpa.Size = new System.Drawing.Size(150, 31);
            this.textBoxgpa.TabIndex = 1;
            // 
            // textBoxBY
            // 
            this.textBoxBY.Location = new System.Drawing.Point(116, 137);
            this.textBoxBY.Name = "textBoxBY";
            this.textBoxBY.Size = new System.Drawing.Size(150, 31);
            this.textBoxBY.TabIndex = 2;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(132, 191);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(112, 34);
            this.buttonEnter.TabIndex = 3;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(396, 39);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(150, 31);
            this.textBoxMax.TabIndex = 4;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(396, 86);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(150, 31);
            this.textBoxMin.TabIndex = 5;
            // 
            // textBoxAvg
            // 
            this.textBoxAvg.Location = new System.Drawing.Point(396, 137);
            this.textBoxAvg.Name = "textBoxAvg";
            this.textBoxAvg.Size = new System.Drawing.Size(150, 31);
            this.textBoxAvg.TabIndex = 6;
            // 
            // textBoxListName
            // 
            this.textBoxListName.Location = new System.Drawing.Point(396, 243);
            this.textBoxListName.Multiline = true;
            this.textBoxListName.Name = "textBoxListName";
            this.textBoxListName.Size = new System.Drawing.Size(178, 141);
            this.textBoxListName.TabIndex = 7;
            // 
            // textBoxMaxName
            // 
            this.textBoxMaxName.Location = new System.Drawing.Point(670, 35);
            this.textBoxMaxName.Name = "textBoxMaxName";
            this.textBoxMaxName.Size = new System.Drawing.Size(150, 31);
            this.textBoxMaxName.TabIndex = 8;
            // 
            // textBoxMinName
            // 
            this.textBoxMinName.Location = new System.Drawing.Point(670, 88);
            this.textBoxMinName.Name = "textBoxMinName";
            this.textBoxMinName.Size = new System.Drawing.Size(150, 31);
            this.textBoxMinName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "ชื่อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "GPA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "ปีเกิด";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "GPA Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "GPA Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "GPA Avg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(614, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "ชื่อ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(614, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "ชื่อ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(330, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "รายชื่อ";
            // 
            // textBoxAgeAll
            // 
            this.textBoxAgeAll.Location = new System.Drawing.Point(396, 188);
            this.textBoxAgeAll.Name = "textBoxAgeAll";
            this.textBoxAgeAll.Size = new System.Drawing.Size(150, 31);
            this.textBoxAgeAll.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "อายุรวมในห้อง";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxAgeAll);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMinName);
            this.Controls.Add(this.textBoxMaxName);
            this.Controls.Add(this.textBoxListName);
            this.Controls.Add(this.textBoxAvg);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxBY);
            this.Controls.Add(this.textBoxgpa);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxgpa;
        private TextBox textBoxBY;
        private Button buttonEnter;
        private TextBox textBoxMax;
        private TextBox textBoxMin;
        private TextBox textBoxAvg;
        private TextBox textBoxListName;
        private TextBox textBoxMaxName;
        private TextBox textBoxMinName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxAgeAll;
        private Label label10;
    }
}