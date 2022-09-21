namespace caculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Breset = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.Bplus = new System.Windows.Forms.Button();
            this.Bminus = new System.Windows.Forms.Button();
            this.Badded = new System.Windows.Forms.Button();
            this.Bdevide = new System.Windows.Forms.Button();
            this.Bequals = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Breset
            // 
            this.Breset.BackColor = System.Drawing.Color.Yellow;
            this.Breset.Location = new System.Drawing.Point(1, 68);
            this.Breset.Name = "Breset";
            this.Breset.Size = new System.Drawing.Size(75, 45);
            this.Breset.TabIndex = 1;
            this.Breset.Text = "C";
            this.Breset.UseVisualStyleBackColor = false;
            this.Breset.Click += new System.EventHandler(this.C_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(1, 119);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 2;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button2_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(82, 119);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 23);
            this.b2.TabIndex = 3;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button3_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(163, 119);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 23);
            this.b3.TabIndex = 4;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1278, -154);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(1, 148);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(75, 23);
            this.b4.TabIndex = 6;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.button6_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(82, 148);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(75, 23);
            this.b5.TabIndex = 7;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.button7_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(163, 148);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(75, 23);
            this.b6.TabIndex = 8;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.button8_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(1, 177);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(75, 23);
            this.b7.TabIndex = 9;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.button1_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(82, 177);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(75, 23);
            this.b8.TabIndex = 10;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.button9_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(163, 177);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(75, 23);
            this.b9.TabIndex = 11;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.button10_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(1, 206);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(75, 23);
            this.b0.TabIndex = 12;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.button11_Click);
            // 
            // Bplus
            // 
            this.Bplus.BackColor = System.Drawing.Color.Red;
            this.Bplus.Location = new System.Drawing.Point(203, 206);
            this.Bplus.Name = "Bplus";
            this.Bplus.Size = new System.Drawing.Size(35, 54);
            this.Bplus.TabIndex = 13;
            this.Bplus.Text = "+";
            this.Bplus.UseVisualStyleBackColor = false;
            this.Bplus.Click += new System.EventHandler(this.button12_Click);
            // 
            // Bminus
            // 
            this.Bminus.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Bminus.Location = new System.Drawing.Point(163, 206);
            this.Bminus.Name = "Bminus";
            this.Bminus.Size = new System.Drawing.Size(35, 54);
            this.Bminus.TabIndex = 14;
            this.Bminus.Text = "_";
            this.Bminus.UseVisualStyleBackColor = false;
            this.Bminus.Click += new System.EventHandler(this.button13_Click);
            // 
            // Badded
            // 
            this.Badded.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Badded.Location = new System.Drawing.Point(123, 206);
            this.Badded.Name = "Badded";
            this.Badded.Size = new System.Drawing.Size(34, 54);
            this.Badded.TabIndex = 15;
            this.Badded.Text = "X";
            this.Badded.UseVisualStyleBackColor = false;
            this.Badded.Click += new System.EventHandler(this.button14_Click);
            // 
            // Bdevide
            // 
            this.Bdevide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Bdevide.Location = new System.Drawing.Point(82, 206);
            this.Bdevide.Name = "Bdevide";
            this.Bdevide.Size = new System.Drawing.Size(35, 54);
            this.Bdevide.TabIndex = 16;
            this.Bdevide.Text = "/";
            this.Bdevide.UseVisualStyleBackColor = false;
            this.Bdevide.Click += new System.EventHandler(this.button15_Click);
            // 
            // Bequals
            // 
            this.Bequals.BackColor = System.Drawing.Color.Chartreuse;
            this.Bequals.Location = new System.Drawing.Point(163, 68);
            this.Bequals.Name = "Bequals";
            this.Bequals.Size = new System.Drawing.Size(75, 45);
            this.Bequals.TabIndex = 17;
            this.Bequals.Text = "=";
            this.Bequals.UseVisualStyleBackColor = false;
            this.Bequals.Click += new System.EventHandler(this.Bequals_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(45, 274);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 272);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Bequals);
            this.Controls.Add(this.Bdevide);
            this.Controls.Add(this.Badded);
            this.Controls.Add(this.Bminus);
            this.Controls.Add(this.Bplus);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.Breset);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Breset;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button Bplus;
        private System.Windows.Forms.Button Bminus;
        private System.Windows.Forms.Button Badded;
        private System.Windows.Forms.Button Bdevide;
        private System.Windows.Forms.Button Bequals;
        private System.Windows.Forms.TextBox textBox2;
    }
}

