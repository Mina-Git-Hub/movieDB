namespace WindowsFormsApp7
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.typeCB = new System.Windows.Forms.ComboBox();
            this.yeartx = new System.Windows.Forms.TextBox();
            this.titletx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ratetx = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ratetx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.typeCB);
            this.groupBox1.Controls.Add(this.yeartx);
            this.groupBox1.Controls.Add(this.titletx);
            this.groupBox1.Location = new System.Drawing.Point(63, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 470);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Previewed";
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(158, 346);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(54, 24);
            this.rb2.TabIndex = 38;
            this.rb2.TabStop = true;
            this.rb2.Text = "No";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(158, 316);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(62, 24);
            this.rb1.TabIndex = 37;
            this.rb1.TabStop = true;
            this.rb1.Text = "Yes";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(293, 406);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 38);
            this.button4.TabIndex = 36;
            this.button4.Text = "New";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(500, 406);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 38);
            this.button6.TabIndex = 35;
            this.button6.Text = "Insert";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Type: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Year:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Title: ";
            // 
            // typeCB
            // 
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Location = new System.Drawing.Point(158, 168);
            this.typeCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.typeCB.MaxDropDownItems = 9;
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(180, 28);
            this.typeCB.TabIndex = 27;
            // 
            // yeartx
            // 
            this.yeartx.Location = new System.Drawing.Point(158, 128);
            this.yeartx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yeartx.Name = "yeartx";
            this.yeartx.Size = new System.Drawing.Size(180, 26);
            this.yeartx.TabIndex = 26;
            // 
            // titletx
            // 
            this.titletx.Location = new System.Drawing.Point(158, 92);
            this.titletx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titletx.Name = "titletx";
            this.titletx.Size = new System.Drawing.Size(496, 26);
            this.titletx.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(866, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 42);
            this.button1.TabIndex = 27;
            this.button1.Text = "Top Rated";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(894, 589);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 75);
            this.button2.TabIndex = 28;
            this.button2.Text = "Hits OF Year";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(866, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 42);
            this.button3.TabIndex = 29;
            this.button3.Text = "Gender";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Rate";
            // 
            // ratetx
            // 
            this.ratetx.Location = new System.Drawing.Point(158, 251);
            this.ratetx.Name = "ratetx";
            this.ratetx.Size = new System.Drawing.Size(180, 26);
            this.ratetx.TabIndex = 41;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 706);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeCB;
        private System.Windows.Forms.TextBox yeartx;
        private System.Windows.Forms.TextBox titletx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.TextBox ratetx;
        private System.Windows.Forms.Label label5;
    }
}