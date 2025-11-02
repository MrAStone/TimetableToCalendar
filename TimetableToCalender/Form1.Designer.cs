namespace TimetableToCalender
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
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            dateTimePicker5 = new DateTimePicker();
            dateTimePicker6 = new DateTimePicker();
            dateTimePicker7 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnSetDates = new Button();
            button2 = new Button();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(190, 115);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(190, 153);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(228, 27);
            dateTimePicker2.TabIndex = 0;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(190, 197);
            dateTimePicker3.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(228, 27);
            dateTimePicker3.TabIndex = 0;
            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged_1;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(190, 235);
            dateTimePicker4.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(228, 27);
            dateTimePicker4.TabIndex = 0;
            dateTimePicker4.ValueChanged += dateTimePicker4_ValueChanged;
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.Location = new Point(190, 277);
            dateTimePicker5.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new Size(228, 27);
            dateTimePicker5.TabIndex = 0;
            dateTimePicker5.ValueChanged += dateTimePicker5_ValueChanged;
            // 
            // dateTimePicker6
            // 
            dateTimePicker6.Location = new Point(190, 315);
            dateTimePicker6.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker6.Name = "dateTimePicker6";
            dateTimePicker6.Size = new Size(228, 27);
            dateTimePicker6.TabIndex = 0;
            // 
            // dateTimePicker7
            // 
            dateTimePicker7.Location = new Point(190, 41);
            dateTimePicker7.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker7.Name = "dateTimePicker7";
            dateTimePicker7.Size = new Size(228, 27);
            dateTimePicker7.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 46);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 1;
            label1.Text = "Start of Term";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 120);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 1;
            label2.Text = "October Half Term";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 158);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 1;
            label3.Text = "Christmas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 202);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 1;
            label4.Text = "Feb Half Term";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 240);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 1;
            label5.Text = "Easter";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 282);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 1;
            label6.Text = "May Half Term";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(82, 320);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 1;
            label7.Text = "Summer";
            // 
            // btnSetDates
            // 
            btnSetDates.Location = new Point(64, 369);
            btnSetDates.Margin = new Padding(3, 4, 3, 4);
            btnSetDates.Name = "btnSetDates";
            btnSetDates.Size = new Size(354, 76);
            btnSetDates.TabIndex = 2;
            btnSetDates.Text = "Set Term Times";
            btnSetDates.UseVisualStyleBackColor = true;
            btnSetDates.Click += btnSetDates_Click;
            // 
            // button2
            // 
            button2.Location = new Point(499, 59);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(190, 74);
            button2.TabIndex = 3;
            button2.Text = "Load Timetable File";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.Location = new Point(474, 158);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(225, 105);
            label8.TabIndex = 4;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(151, 86);
            label9.Name = "label9";
            label9.Size = new Size(267, 20);
            label9.TabIndex = 5;
            label9.Text = "Select the first Monday of each holiday";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 504);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(btnSetDates);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker6);
            Controls.Add(dateTimePicker5);
            Controls.Add(dateTimePicker4);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker7);
            Controls.Add(dateTimePicker1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "timetableSetter";
            Load += timetableSetter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private DateTimePicker dateTimePicker5;
        private DateTimePicker dateTimePicker6;
        private DateTimePicker dateTimePicker7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnSetDates;
        private Button button2;
        private Label label8;
        private Label label9;
    }
}
