namespace Ivy_s_Browser
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mathInput1 = new System.Windows.Forms.TextBox();
            this.mathInput2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mathResult = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.encryptResult = new System.Windows.Forms.Label();
            this.encryptInput = new System.Windows.Forms.TextBox();
            this.decryptResult = new System.Windows.Forms.Label();
            this.decryptInput = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 38);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1175, 592);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://www.google.com/", System.UriKind.Absolute);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1093, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Search or type a url";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1112, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mathInput1
            // 
            this.mathInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mathInput1.Location = new System.Drawing.Point(861, 498);
            this.mathInput1.Name = "mathInput1";
            this.mathInput1.Size = new System.Drawing.Size(107, 20);
            this.mathInput1.TabIndex = 3;
            // 
            // mathInput2
            // 
            this.mathInput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mathInput2.Location = new System.Drawing.Point(974, 498);
            this.mathInput2.Name = "mathInput2";
            this.mathInput2.Size = new System.Drawing.Size(100, 20);
            this.mathInput2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(939, 545);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Sub);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lavender;
            this.button3.Location = new System.Drawing.Point(861, 545);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Add);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1009, 545);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "*";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Mult);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1080, 545);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "/";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Div);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(949, 586);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "=";
            // 
            // mathResult
            // 
            this.mathResult.AutoSize = true;
            this.mathResult.BackColor = System.Drawing.Color.White;
            this.mathResult.Location = new System.Drawing.Point(987, 586);
            this.mathResult.Name = "mathResult";
            this.mathResult.Size = new System.Drawing.Size(37, 13);
            this.mathResult.TabIndex = 9;
            this.mathResult.Text = "Result";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1080, 495);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Swap";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Switch);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(971, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Calculator";
            // 
            // encryptResult
            // 
            this.encryptResult.AutoSize = true;
            this.encryptResult.BackColor = System.Drawing.Color.White;
            this.encryptResult.Location = new System.Drawing.Point(29, 526);
            this.encryptResult.Name = "encryptResult";
            this.encryptResult.Size = new System.Drawing.Size(37, 13);
            this.encryptResult.TabIndex = 13;
            this.encryptResult.Text = "Result";
            // 
            // encryptInput
            // 
            this.encryptInput.Location = new System.Drawing.Point(23, 498);
            this.encryptInput.Name = "encryptInput";
            this.encryptInput.Size = new System.Drawing.Size(245, 20);
            this.encryptInput.TabIndex = 14;
         
            // 
            // decryptResult
            // 
            this.decryptResult.AutoSize = true;
            this.decryptResult.BackColor = System.Drawing.Color.White;
            this.decryptResult.Location = new System.Drawing.Point(29, 581);
            this.decryptResult.Name = "decryptResult";
            this.decryptResult.Size = new System.Drawing.Size(37, 13);
            this.decryptResult.TabIndex = 15;
            this.decryptResult.Text = "Result";
            // 
            // decryptInput
            // 
            this.decryptInput.Location = new System.Drawing.Point(23, 554);
            this.decryptInput.Name = "decryptInput";
            this.decryptInput.Size = new System.Drawing.Size(245, 20);
            this.decryptInput.TabIndex = 16;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(274, 495);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "Encrypt";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Encrypt);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(274, 551);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "Decrypt";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Decrypt);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1199, 642);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.decryptInput);
            this.Controls.Add(this.decryptResult);
            this.Controls.Add(this.encryptInput);
            this.Controls.Add(this.encryptResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.mathResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mathInput2);
            this.Controls.Add(this.mathInput1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mathInput1;
        private System.Windows.Forms.TextBox mathInput2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mathResult;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label encryptResult;
        private System.Windows.Forms.TextBox encryptInput;
        private System.Windows.Forms.Label decryptResult;
        private System.Windows.Forms.TextBox decryptInput;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

