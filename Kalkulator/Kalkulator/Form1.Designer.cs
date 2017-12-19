namespace Kalkulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.substract = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.leftBracket = new System.Windows.Forms.Button();
            this.rightBracket = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(12, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(330, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(12, 39);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(50, 50);
            this.b7.TabIndex = 1;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(68, 39);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(50, 50);
            this.b8.TabIndex = 2;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(124, 39);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(50, 50);
            this.b9.TabIndex = 3;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(180, 39);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(50, 50);
            this.add.TabIndex = 4;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.operatorClick);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(68, 95);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(50, 50);
            this.b5.TabIndex = 5;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(124, 95);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(50, 50);
            this.b6.TabIndex = 5;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(12, 95);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(50, 50);
            this.b4.TabIndex = 5;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b_Click);
            // 
            // substract
            // 
            this.substract.Location = new System.Drawing.Point(180, 95);
            this.substract.Name = "substract";
            this.substract.Size = new System.Drawing.Size(50, 50);
            this.substract.TabIndex = 6;
            this.substract.Text = "-";
            this.substract.UseVisualStyleBackColor = true;
            this.substract.Click += new System.EventHandler(this.operatorClick);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 151);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(50, 50);
            this.b1.TabIndex = 7;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(68, 151);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(50, 50);
            this.b2.TabIndex = 8;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(124, 151);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(50, 50);
            this.b3.TabIndex = 9;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(180, 151);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(50, 50);
            this.multiply.TabIndex = 10;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.operatorClick);
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(12, 207);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(50, 50);
            this.point.TabIndex = 11;
            this.point.Text = ",";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.period_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(68, 207);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(50, 50);
            this.b0.TabIndex = 12;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b_Click);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(236, 149);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(106, 106);
            this.equals.TabIndex = 13;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.solve);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(180, 207);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(50, 50);
            this.divide.TabIndex = 14;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.operatorClick);
            // 
            // leftBracket
            // 
            this.leftBracket.Location = new System.Drawing.Point(236, 39);
            this.leftBracket.Name = "leftBracket";
            this.leftBracket.Size = new System.Drawing.Size(50, 50);
            this.leftBracket.TabIndex = 15;
            this.leftBracket.Text = "(";
            this.leftBracket.UseVisualStyleBackColor = true;
            this.leftBracket.Click += new System.EventHandler(this.leftBracket_Click);
            // 
            // rightBracket
            // 
            this.rightBracket.Location = new System.Drawing.Point(236, 95);
            this.rightBracket.Name = "rightBracket";
            this.rightBracket.Size = new System.Drawing.Size(50, 50);
            this.rightBracket.TabIndex = 16;
            this.rightBracket.Text = ")";
            this.rightBracket.UseVisualStyleBackColor = true;
            this.rightBracket.Click += new System.EventHandler(this.rightBracket_Click);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(292, 39);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(50, 50);
            this.C.TabIndex = 17;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // CE
            // 
            this.CE.Location = new System.Drawing.Point(292, 95);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(50, 50);
            this.CE.TabIndex = 18;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // power
            // 
            this.power.Location = new System.Drawing.Point(124, 207);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(50, 50);
            this.power.TabIndex = 19;
            this.power.Text = "^";
            this.power.UseVisualStyleBackColor = true;
            this.power.Click += new System.EventHandler(this.operatorClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(352, 267);
            this.Controls.Add(this.power);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.C);
            this.Controls.Add(this.rightBracket);
            this.Controls.Add(this.leftBracket);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.point);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.substract);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.add);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button substract;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button leftBracket;
        private System.Windows.Forms.Button rightBracket;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button power;
    }
}

