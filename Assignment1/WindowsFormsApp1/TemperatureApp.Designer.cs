namespace WindowsFormsApp1
{
    partial class TemperatureApp
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
            this.c2fBox = new System.Windows.Forms.TextBox();
            this.f2cBox = new System.Windows.Forms.TextBox();
            this.c2fButton = new System.Windows.Forms.Button();
            this.f2cButton = new System.Windows.Forms.Button();
            this.sortBox = new System.Windows.Forms.TextBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.c2fResult = new System.Windows.Forms.Label();
            this.f2cResult = new System.Windows.Forms.Label();
            this.errBox = new System.Windows.Forms.Label();
            this.sortResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // c2fBox
            // 
            this.c2fBox.BackColor = System.Drawing.Color.White;
            this.c2fBox.Location = new System.Drawing.Point(29, 42);
            this.c2fBox.Name = "c2fBox";
            this.c2fBox.Size = new System.Drawing.Size(244, 20);
            this.c2fBox.TabIndex = 0;
            // 
            // f2cBox
            // 
            this.f2cBox.BackColor = System.Drawing.Color.White;
            this.f2cBox.Location = new System.Drawing.Point(29, 85);
            this.f2cBox.Name = "f2cBox";
            this.f2cBox.Size = new System.Drawing.Size(244, 20);
            this.f2cBox.TabIndex = 1;
            // 
            // c2fButton
            // 
            this.c2fButton.Location = new System.Drawing.Point(279, 42);
            this.c2fButton.Name = "c2fButton";
            this.c2fButton.Size = new System.Drawing.Size(75, 23);
            this.c2fButton.TabIndex = 2;
            this.c2fButton.Text = "From C to F";
            this.c2fButton.UseVisualStyleBackColor = true;
            this.c2fButton.Click += new System.EventHandler(this.convertToF);
            // 
            // f2cButton
            // 
            this.f2cButton.Location = new System.Drawing.Point(279, 85);
            this.f2cButton.Name = "f2cButton";
            this.f2cButton.Size = new System.Drawing.Size(75, 23);
            this.f2cButton.TabIndex = 3;
            this.f2cButton.Text = "From F to C";
            this.f2cButton.UseVisualStyleBackColor = true;
            this.f2cButton.Click += new System.EventHandler(this.convertToC);
            // 
            // sortBox
            // 
            this.sortBox.BackColor = System.Drawing.Color.White;
            this.sortBox.Location = new System.Drawing.Point(29, 128);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(325, 20);
            this.sortBox.TabIndex = 4;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(29, 154);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 23);
            this.sortButton.TabIndex = 5;
            this.sortButton.Text = "Sort String";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.SortItems);
            // 
            // c2fResult
            // 
            this.c2fResult.AutoSize = true;
            this.c2fResult.Location = new System.Drawing.Point(29, 66);
            this.c2fResult.Name = "c2fResult";
            this.c2fResult.Size = new System.Drawing.Size(37, 13);
            this.c2fResult.TabIndex = 6;
            this.c2fResult.Text = "Result";
            // 
            // f2cResult
            // 
            this.f2cResult.AutoSize = true;
            this.f2cResult.Location = new System.Drawing.Point(29, 108);
            this.f2cResult.Name = "f2cResult";
            this.f2cResult.Size = new System.Drawing.Size(37, 13);
            this.f2cResult.TabIndex = 7;
            this.f2cResult.Text = "Result";
            // 
            // errBox
            // 
            this.errBox.AutoSize = true;
            this.errBox.Location = new System.Drawing.Point(131, 159);
            this.errBox.Name = "errBox";
            this.errBox.Size = new System.Drawing.Size(0, 13);
            this.errBox.TabIndex = 8;
            // 
            // sortResult
            // 
            this.sortResult.AutoSize = true;
            this.sortResult.Location = new System.Drawing.Point(32, 184);
            this.sortResult.Name = "sortResult";
            this.sortResult.Size = new System.Drawing.Size(0, 13);
            this.sortResult.TabIndex = 9;
            // 
            // TemperatureApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(408, 253);
            this.Controls.Add(this.sortResult);
            this.Controls.Add(this.errBox);
            this.Controls.Add(this.f2cResult);
            this.Controls.Add(this.c2fResult);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.sortBox);
            this.Controls.Add(this.f2cButton);
            this.Controls.Add(this.c2fButton);
            this.Controls.Add(this.f2cBox);
            this.Controls.Add(this.c2fBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TemperatureApp";
            this.Text = "Temperature Conversion & Sorting App 😼";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox c2fBox;
        private System.Windows.Forms.TextBox f2cBox;
        private System.Windows.Forms.Button c2fButton;
        private System.Windows.Forms.Button f2cButton;
        private System.Windows.Forms.TextBox sortBox;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Label c2fResult;
        private System.Windows.Forms.Label f2cResult;
        private System.Windows.Forms.Label errBox;
        private System.Windows.Forms.Label sortResult;
    }
}

