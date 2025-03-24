namespace Student_Registration_Application
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
            Lname = new TextBox();
            Fname = new TextBox();
            label3 = new Label();
            Mname = new TextBox();
            label4 = new Label();
            label5 = new Label();
            Male = new RadioButton();
            Female = new RadioButton();
            label6 = new Label();
            Day = new ComboBox();
            Month = new ComboBox();
            Year = new ComboBox();
            label7 = new Label();
            Program = new ComboBox();
            Register = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 5);
            label1.Name = "label1";
            label1.Size = new Size(272, 30);
            label1.TabIndex = 0;
            label1.Text = "Student Registration Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 40);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 1;
            label2.Text = "Last name *";
            // 
            // Lname
            // 
            Lname.Font = new Font("Segoe UI", 12F);
            Lname.Location = new Point(17, 64);
            Lname.Name = "Lname";
            Lname.Size = new Size(257, 29);
            Lname.TabIndex = 2;
            // 
            // Fname
            // 
            Fname.Font = new Font("Segoe UI", 12F);
            Fname.Location = new Point(15, 122);
            Fname.Name = "Fname";
            Fname.Size = new Size(257, 29);
            Fname.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 98);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 3;
            label3.Text = "First name *";
            // 
            // Mname
            // 
            Mname.Font = new Font("Segoe UI", 12F);
            Mname.Location = new Point(15, 180);
            Mname.Name = "Mname";
            Mname.Size = new Size(257, 29);
            Mname.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 156);
            label4.Name = "label4";
            label4.Size = new Size(122, 21);
            label4.TabIndex = 5;
            label4.Text = "Middle name *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 215);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 7;
            label5.Text = "Gender *";
            // 
            // Male
            // 
            Male.AutoSize = true;
            Male.Font = new Font("Segoe UI", 12F);
            Male.Location = new Point(95, 215);
            Male.Name = "Male";
            Male.Size = new Size(62, 25);
            Male.TabIndex = 8;
            Male.TabStop = true;
            Male.Text = "Male";
            Male.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            Female.AutoSize = true;
            Female.Font = new Font("Segoe UI", 12F);
            Female.Location = new Point(155, 215);
            Female.Name = "Female";
            Female.Size = new Size(78, 25);
            Female.TabIndex = 9;
            Female.TabStop = true;
            Female.Text = "Female";
            Female.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(13, 243);
            label6.Name = "label6";
            label6.Size = new Size(118, 21);
            label6.TabIndex = 10;
            label6.Text = "Date of Birth *";
            // 
            // Day
            // 
            Day.Font = new Font("Segoe UI", 12F);
            Day.FormattingEnabled = true;
            Day.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            Day.Location = new Point(16, 270);
            Day.Name = "Day";
            Day.Size = new Size(73, 29);
            Day.TabIndex = 11;
            Day.Text = "-Day-";
            Day.SelectedIndexChanged += Day_SelectedIndexChanged;
            // 
            // Month
            // 
            Month.Font = new Font("Segoe UI", 12F);
            Month.FormattingEnabled = true;
            Month.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            Month.Location = new Point(94, 270);
            Month.Name = "Month";
            Month.Size = new Size(86, 29);
            Month.TabIndex = 12;
            Month.Text = "-Month-";
            Month.SelectedIndexChanged += Month_SelectedIndexChanged;
            // 
            // Year
            // 
            Year.Font = new Font("Segoe UI", 12F);
            Year.FormattingEnabled = true;
            Year.Items.AddRange(new object[] { "1900", "1901", "1902", "1903", "1904", "1905", "1906", "1907", "1908", "1909", "1910", "1911", "1912", "1913", "1914", "1915", "1916", "1917", "1918", "1919", "1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025" });
            Year.Location = new Point(186, 270);
            Year.Name = "Year";
            Year.Size = new Size(86, 29);
            Year.TabIndex = 13;
            Year.Text = "-Year-";
            Year.SelectedIndexChanged += Year_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(11, 302);
            label7.Name = "label7";
            label7.Size = new Size(154, 21);
            label7.TabIndex = 14;
            label7.Text = "Program to apply *";
            // 
            // Program
            // 
            Program.Font = new Font("Segoe UI", 12F);
            Program.FormattingEnabled = true;
            Program.Items.AddRange(new object[] { "Bachelor of Science in Computer Science", "Bachelor of Science in Information Technology", "Bachelor of Science in Information Systems", "Bachelor of Science in Computer Engineering" });
            Program.Location = new Point(15, 326);
            Program.Name = "Program";
            Program.Size = new Size(344, 29);
            Program.TabIndex = 15;
            Program.Text = "-Select program-";
            Program.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Register
            // 
            Register.BackColor = Color.Crimson;
            Register.Font = new Font("Segoe UI", 12F);
            Register.ForeColor = Color.White;
            Register.Location = new Point(14, 359);
            Register.Name = "Register";
            Register.Size = new Size(160, 42);
            Register.TabIndex = 16;
            Register.Text = "Register Student";
            Register.UseVisualStyleBackColor = false;
            Register.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 410);
            Controls.Add(Register);
            Controls.Add(Program);
            Controls.Add(label7);
            Controls.Add(Year);
            Controls.Add(Month);
            Controls.Add(Day);
            Controls.Add(label6);
            Controls.Add(Female);
            Controls.Add(Male);
            Controls.Add(label5);
            Controls.Add(Mname);
            Controls.Add(label4);
            Controls.Add(Fname);
            Controls.Add(label3);
            Controls.Add(Lname);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Student Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Lname;
        private TextBox Fname;
        private Label label3;
        private TextBox Mname;
        private Label label4;
        private Label label5;
        private RadioButton Male;
        private RadioButton Female;
        private Label label6;
        private ComboBox Day;
        private ComboBox Month;
        private ComboBox Year;
        private Label label7;
        private ComboBox Program;
        private Button Register;
    }
}
