namespace Form_homework
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
            this.btn_nameAndDate = new System.Windows.Forms.Button();
            this.richTextBox_nameAndDate = new System.Windows.Forms.RichTextBox();
            this.btn_nprintNameTenTimes = new System.Windows.Forms.Button();
            this.richTextBox_displayNameTenTimes = new System.Windows.Forms.RichTextBox();
            this.btn_oddOrEven = new System.Windows.Forms.Button();
            this.richTextBox_oddOrEvenNumber = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_firstSemester = new System.Windows.Forms.TextBox();
            this.tbx_secondSemester = new System.Windows.Forms.TextBox();
            this.tbx_thirdSemester = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_semesterMedian = new System.Windows.Forms.TextBox();
            this.btn_calculateMedian = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_celciusToFarenheit = new System.Windows.Forms.Button();
            this.tbx_celcius = new System.Windows.Forms.TextBox();
            this.tbx_fahrenheit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_nameAndDate
            // 
            this.btn_nameAndDate.Location = new System.Drawing.Point(61, 39);
            this.btn_nameAndDate.Name = "btn_nameAndDate";
            this.btn_nameAndDate.Size = new System.Drawing.Size(107, 23);
            this.btn_nameAndDate.TabIndex = 0;
            this.btn_nameAndDate.Text = "Name and Date";
            this.btn_nameAndDate.UseVisualStyleBackColor = true;
            this.btn_nameAndDate.Click += new System.EventHandler(this.btn_nameAndDate_Click);
            // 
            // richTextBox_nameAndDate
            // 
            this.richTextBox_nameAndDate.Location = new System.Drawing.Point(292, 39);
            this.richTextBox_nameAndDate.Name = "richTextBox_nameAndDate";
            this.richTextBox_nameAndDate.Size = new System.Drawing.Size(298, 23);
            this.richTextBox_nameAndDate.TabIndex = 1;
            this.richTextBox_nameAndDate.Text = "";
            this.richTextBox_nameAndDate.TextChanged += new System.EventHandler(this.richTextBox_nameAndDate_TextChanged);
            // 
            // btn_nprintNameTenTimes
            // 
            this.btn_nprintNameTenTimes.Location = new System.Drawing.Point(61, 86);
            this.btn_nprintNameTenTimes.Name = "btn_nprintNameTenTimes";
            this.btn_nprintNameTenTimes.Size = new System.Drawing.Size(107, 88);
            this.btn_nprintNameTenTimes.TabIndex = 2;
            this.btn_nprintNameTenTimes.Text = "Print name 10 times";
            this.btn_nprintNameTenTimes.UseVisualStyleBackColor = true;
            this.btn_nprintNameTenTimes.Click += new System.EventHandler(this.btn_nprintNameTenTimes_Click);
            // 
            // richTextBox_displayNameTenTimes
            // 
            this.richTextBox_displayNameTenTimes.Location = new System.Drawing.Point(292, 86);
            this.richTextBox_displayNameTenTimes.Name = "richTextBox_displayNameTenTimes";
            this.richTextBox_displayNameTenTimes.Size = new System.Drawing.Size(298, 88);
            this.richTextBox_displayNameTenTimes.TabIndex = 3;
            this.richTextBox_displayNameTenTimes.Text = "";
            this.richTextBox_displayNameTenTimes.TextChanged += new System.EventHandler(this.richTextBox_displayNameTenTimes_TextChanged);
            // 
            // btn_oddOrEven
            // 
            this.btn_oddOrEven.Location = new System.Drawing.Point(61, 214);
            this.btn_oddOrEven.Name = "btn_oddOrEven";
            this.btn_oddOrEven.Size = new System.Drawing.Size(107, 54);
            this.btn_oddOrEven.TabIndex = 4;
            this.btn_oddOrEven.Text = "Check if number is odd or even";
            this.btn_oddOrEven.UseVisualStyleBackColor = true;
            this.btn_oddOrEven.Click += new System.EventHandler(this.btn_oddOrEven_Click);
            // 
            // richTextBox_oddOrEvenNumber
            // 
            this.richTextBox_oddOrEvenNumber.Location = new System.Drawing.Point(292, 196);
            this.richTextBox_oddOrEvenNumber.Name = "richTextBox_oddOrEvenNumber";
            this.richTextBox_oddOrEvenNumber.Size = new System.Drawing.Size(96, 72);
            this.richTextBox_oddOrEvenNumber.TabIndex = 5;
            this.richTextBox_oddOrEvenNumber.Text = "";
            this.richTextBox_oddOrEvenNumber.TextChanged += new System.EventHandler(this.richTextBox_oddOrEvenNumber_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "First semester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Second semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Third semester";
            // 
            // txb_firstSemester
            // 
            this.txb_firstSemester.Location = new System.Drawing.Point(292, 343);
            this.txb_firstSemester.Name = "txb_firstSemester";
            this.txb_firstSemester.Size = new System.Drawing.Size(96, 23);
            this.txb_firstSemester.TabIndex = 9;
            this.txb_firstSemester.TextChanged += new System.EventHandler(this.txb_firstSemester_TextChanged);
            // 
            // tbx_secondSemester
            // 
            this.tbx_secondSemester.Location = new System.Drawing.Point(292, 372);
            this.tbx_secondSemester.Name = "tbx_secondSemester";
            this.tbx_secondSemester.Size = new System.Drawing.Size(96, 23);
            this.tbx_secondSemester.TabIndex = 10;
            this.tbx_secondSemester.TextChanged += new System.EventHandler(this.tbx_secondSemester_TextChanged);
            // 
            // tbx_thirdSemester
            // 
            this.tbx_thirdSemester.Location = new System.Drawing.Point(292, 400);
            this.tbx_thirdSemester.Name = "tbx_thirdSemester";
            this.tbx_thirdSemester.Size = new System.Drawing.Size(96, 23);
            this.tbx_thirdSemester.TabIndex = 11;
            this.tbx_thirdSemester.TextChanged += new System.EventHandler(this.tbx_thirdSemester_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Median of all semesters";
            // 
            // tbx_semesterMedian
            // 
            this.tbx_semesterMedian.Location = new System.Drawing.Point(494, 433);
            this.tbx_semesterMedian.Name = "tbx_semesterMedian";
            this.tbx_semesterMedian.Size = new System.Drawing.Size(96, 23);
            this.tbx_semesterMedian.TabIndex = 13;
            this.tbx_semesterMedian.TextChanged += new System.EventHandler(this.tbx_semesterMedian_TextChanged);
            // 
            // btn_calculateMedian
            // 
            this.btn_calculateMedian.Location = new System.Drawing.Point(292, 433);
            this.btn_calculateMedian.Name = "btn_calculateMedian";
            this.btn_calculateMedian.Size = new System.Drawing.Size(96, 39);
            this.btn_calculateMedian.TabIndex = 14;
            this.btn_calculateMedian.Text = "Calculate median";
            this.btn_calculateMedian.UseVisualStyleBackColor = true;
            this.btn_calculateMedian.Click += new System.EventHandler(this.btn_calculateMedian_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Enter temperature in Celcius";
            // 
            // btn_celciusToFarenheit
            // 
            this.btn_celciusToFarenheit.Location = new System.Drawing.Point(292, 524);
            this.btn_celciusToFarenheit.Name = "btn_celciusToFarenheit";
            this.btn_celciusToFarenheit.Size = new System.Drawing.Size(96, 53);
            this.btn_celciusToFarenheit.TabIndex = 16;
            this.btn_celciusToFarenheit.Text = "Convert Celcius to Fahrenheit";
            this.btn_celciusToFarenheit.UseVisualStyleBackColor = true;
            this.btn_celciusToFarenheit.Click += new System.EventHandler(this.btn_celciusToFarenheit_Click);
            // 
            // tbx_celcius
            // 
            this.tbx_celcius.Location = new System.Drawing.Point(61, 554);
            this.tbx_celcius.Name = "tbx_celcius";
            this.tbx_celcius.Size = new System.Drawing.Size(96, 23);
            this.tbx_celcius.TabIndex = 17;
            this.tbx_celcius.TextChanged += new System.EventHandler(this.tbx_celcius_TextChanged);
            // 
            // tbx_fahrenheit
            // 
            this.tbx_fahrenheit.Location = new System.Drawing.Point(494, 554);
            this.tbx_fahrenheit.Name = "tbx_fahrenheit";
            this.tbx_fahrenheit.Size = new System.Drawing.Size(96, 23);
            this.tbx_fahrenheit.TabIndex = 18;
            this.tbx_fahrenheit.TextChanged += new System.EventHandler(this.tbx_fahrenheit_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 755);
            this.Controls.Add(this.tbx_fahrenheit);
            this.Controls.Add(this.tbx_celcius);
            this.Controls.Add(this.btn_celciusToFarenheit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_calculateMedian);
            this.Controls.Add(this.tbx_semesterMedian);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_thirdSemester);
            this.Controls.Add(this.tbx_secondSemester);
            this.Controls.Add(this.txb_firstSemester);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_oddOrEvenNumber);
            this.Controls.Add(this.btn_oddOrEven);
            this.Controls.Add(this.richTextBox_displayNameTenTimes);
            this.Controls.Add(this.btn_nprintNameTenTimes);
            this.Controls.Add(this.richTextBox_nameAndDate);
            this.Controls.Add(this.btn_nameAndDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nameAndDate;
        private System.Windows.Forms.RichTextBox richTextBox_nameAndDate;
        private System.Windows.Forms.Button btn_nprintNameTenTimes;
        private System.Windows.Forms.RichTextBox richTextBox_displayNameTenTimes;
        private System.Windows.Forms.Button btn_oddOrEven;
        private System.Windows.Forms.RichTextBox richTextBox_oddOrEvenNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_firstSemester;
        private System.Windows.Forms.TextBox tbx_secondSemester;
        private System.Windows.Forms.TextBox tbx_thirdSemester;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_semesterMedian;
        private System.Windows.Forms.Button btn_calculateMedian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_celciusToFarenheit;
        private System.Windows.Forms.TextBox tbx_celcius;
        private System.Windows.Forms.TextBox tbx_fahrenheit;
    }
}
