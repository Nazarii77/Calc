namespace Calc
{
    partial class Calc
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
            this.expression_input = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1number = new System.Windows.Forms.Button();
            this.button2number = new System.Windows.Forms.Button();
            this.button3number = new System.Windows.Forms.Button();
            this.button4number = new System.Windows.Forms.Button();
            this.button5number = new System.Windows.Forms.Button();
            this.button6number = new System.Windows.Forms.Button();
            this.button7number = new System.Windows.Forms.Button();
            this.button8number = new System.Windows.Forms.Button();
            this.button9number = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0number = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.calculate_expression = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expression";
            // 
            // expression_input
            // 
            this.expression_input.Location = new System.Drawing.Point(117, 13);
            this.expression_input.Name = "expression_input";
            this.expression_input.Size = new System.Drawing.Size(263, 22);
            this.expression_input.TabIndex = 1;
            this.expression_input.Text = "";
            this.expression_input.Enter += new System.EventHandler(this.calculate);
            this.expression_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calculate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Result";
            // 
            // result
            // 
            this.result.Enabled = false;
            this.result.Location = new System.Drawing.Point(117, 51);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(263, 22);
            this.result.TabIndex = 3;
            this.result.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Editing";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "(";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = ")";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(184, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 30);
            this.button3.TabIndex = 7;
            this.button3.Text = "Backspace";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(290, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 30);
            this.button4.TabIndex = 8;
            this.button4.Text = "C";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1number
            // 
            this.button1number.Location = new System.Drawing.Point(31, 177);
            this.button1number.Name = "button1number";
            this.button1number.Size = new System.Drawing.Size(39, 30);
            this.button1number.TabIndex = 9;
            this.button1number.Text = "1";
            this.button1number.UseVisualStyleBackColor = true;
            this.button1number.Click += new System.EventHandler(this.button1number_Click);
            // 
            // button2number
            // 
            this.button2number.Location = new System.Drawing.Point(87, 177);
            this.button2number.Name = "button2number";
            this.button2number.Size = new System.Drawing.Size(39, 30);
            this.button2number.TabIndex = 10;
            this.button2number.Text = "2";
            this.button2number.UseVisualStyleBackColor = true;
            this.button2number.Click += new System.EventHandler(this.button2number_Click);
            // 
            // button3number
            // 
            this.button3number.Location = new System.Drawing.Point(144, 177);
            this.button3number.Name = "button3number";
            this.button3number.Size = new System.Drawing.Size(39, 30);
            this.button3number.TabIndex = 11;
            this.button3number.Text = "3";
            this.button3number.UseVisualStyleBackColor = true;
            this.button3number.Click += new System.EventHandler(this.button3number_Click);
            // 
            // button4number
            // 
            this.button4number.Location = new System.Drawing.Point(31, 225);
            this.button4number.Name = "button4number";
            this.button4number.Size = new System.Drawing.Size(39, 30);
            this.button4number.TabIndex = 12;
            this.button4number.Text = "4";
            this.button4number.UseVisualStyleBackColor = true;
            this.button4number.Click += new System.EventHandler(this.button4number_Click);
            // 
            // button5number
            // 
            this.button5number.Location = new System.Drawing.Point(87, 225);
            this.button5number.Name = "button5number";
            this.button5number.Size = new System.Drawing.Size(39, 30);
            this.button5number.TabIndex = 13;
            this.button5number.Text = "5";
            this.button5number.UseVisualStyleBackColor = true;
            this.button5number.Click += new System.EventHandler(this.button5number_Click);
            // 
            // button6number
            // 
            this.button6number.Location = new System.Drawing.Point(144, 225);
            this.button6number.Name = "button6number";
            this.button6number.Size = new System.Drawing.Size(39, 30);
            this.button6number.TabIndex = 14;
            this.button6number.Text = "6";
            this.button6number.UseVisualStyleBackColor = true;
            this.button6number.Click += new System.EventHandler(this.button6number_Click);
            // 
            // button7number
            // 
            this.button7number.Location = new System.Drawing.Point(31, 274);
            this.button7number.Name = "button7number";
            this.button7number.Size = new System.Drawing.Size(39, 30);
            this.button7number.TabIndex = 15;
            this.button7number.Text = "7";
            this.button7number.UseVisualStyleBackColor = true;
            this.button7number.Click += new System.EventHandler(this.button7number_Click);
            // 
            // button8number
            // 
            this.button8number.Location = new System.Drawing.Point(87, 274);
            this.button8number.Name = "button8number";
            this.button8number.Size = new System.Drawing.Size(39, 30);
            this.button8number.TabIndex = 16;
            this.button8number.Text = "8";
            this.button8number.UseVisualStyleBackColor = true;
            this.button8number.Click += new System.EventHandler(this.button8number_Click);
            // 
            // button9number
            // 
            this.button9number.Location = new System.Drawing.Point(144, 274);
            this.button9number.Name = "button9number";
            this.button9number.Size = new System.Drawing.Size(39, 30);
            this.button9number.TabIndex = 17;
            this.button9number.Text = "9";
            this.button9number.UseVisualStyleBackColor = true;
            this.button9number.Click += new System.EventHandler(this.button9number_Click);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(199, 177);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 30);
            this.button5.TabIndex = 18;
            this.button5.Text = "/";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(199, 225);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(39, 30);
            this.button6.TabIndex = 19;
            this.button6.Text = "*";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.Red;
            this.button7.Location = new System.Drawing.Point(199, 274);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(39, 30);
            this.button7.TabIndex = 20;
            this.button7.Text = "-";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.Color.Red;
            this.button8.Location = new System.Drawing.Point(199, 321);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(39, 30);
            this.button8.TabIndex = 21;
            this.button8.Text = "+";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.ForeColor = System.Drawing.Color.Red;
            this.button9.Location = new System.Drawing.Point(144, 321);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(39, 30);
            this.button9.TabIndex = 22;
            this.button9.Text = "mod";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0number
            // 
            this.button0number.Location = new System.Drawing.Point(87, 321);
            this.button0number.Name = "button0number";
            this.button0number.Size = new System.Drawing.Size(39, 30);
            this.button0number.TabIndex = 23;
            this.button0number.Text = "0";
            this.button0number.UseVisualStyleBackColor = true;
            this.button0number.Click += new System.EventHandler(this.button0number_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(31, 321);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(39, 30);
            this.button10.TabIndex = 24;
            this.button10.Text = "+/-";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // calculate_expression
            // 
            this.calculate_expression.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculate_expression.ForeColor = System.Drawing.Color.Red;
            this.calculate_expression.Location = new System.Drawing.Point(290, 321);
            this.calculate_expression.Name = "calculate_expression";
            this.calculate_expression.Size = new System.Drawing.Size(39, 30);
            this.calculate_expression.TabIndex = 25;
            this.calculate_expression.Text = "=";
            this.calculate_expression.UseVisualStyleBackColor = true;
            this.calculate_expression.Click += new System.EventHandler(this.calculate);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.ForeColor = System.Drawing.Color.Blue;
            this.button12.Location = new System.Drawing.Point(290, 177);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(39, 30);
            this.button12.TabIndex = 26;
            this.button12.Text = "MR";
            this.button12.UseCompatibleTextRendering = true;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.ForeColor = System.Drawing.Color.Blue;
            this.button13.Location = new System.Drawing.Point(290, 224);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(39, 31);
            this.button13.TabIndex = 27;
            this.button13.Text = "M+";
            this.button13.UseCompatibleTextRendering = true;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.ForeColor = System.Drawing.Color.Blue;
            this.button14.Location = new System.Drawing.Point(290, 276);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(39, 30);
            this.button14.TabIndex = 28;
            this.button14.Text = "MC";
            this.button14.UseCompatibleTextRendering = true;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 377);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.calculate_expression);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button0number);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button9number);
            this.Controls.Add(this.button8number);
            this.Controls.Add(this.button7number);
            this.Controls.Add(this.button6number);
            this.Controls.Add(this.button5number);
            this.Controls.Add(this.button4number);
            this.Controls.Add(this.button3number);
            this.Controls.Add(this.button2number);
            this.Controls.Add(this.button1number);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.expression_input);
            this.Controls.Add(this.label1);
            this.Name = "Calc";
            this.Text = "Calc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox expression_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1number;
        private System.Windows.Forms.Button button2number;
        private System.Windows.Forms.Button button3number;
        private System.Windows.Forms.Button button4number;
        private System.Windows.Forms.Button button5number;
        private System.Windows.Forms.Button button6number;
        private System.Windows.Forms.Button button7number;
        private System.Windows.Forms.Button button8number;
        private System.Windows.Forms.Button button9number;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0number;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button calculate_expression;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
    }
}

