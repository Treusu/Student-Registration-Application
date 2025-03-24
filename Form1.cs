using System.Collections;

namespace Student_Registration_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Day_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int day = 0; day < 31; day++)
            {
                Day.Items.Add(day);
            }
        }

        private void Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int month = 0; month < 12; month++)
            {
                Month.Items.Add(month);
            }
        }

        private void Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Years = DateTime.Now.Year;
            for (int year = 1900; year <= Years; year++)
            {
                Year.Items.Add(year);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList programs = new ArrayList
            {
                "Bachelor of Science in Computer Science",
                "Bachelor of Science in Information Technology",
                "Bachelor of Science in Information Systems",
                "Bachelor of Science in Computer Engineering"
            };

            foreach (string program in programs)
            {
                Program.Items.Add(program);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string LastName = Lname.Text;
            string FirstName = Fname.Text;
            string MiddleName = Mname.Text;
            string day = Day.SelectedItem?.ToString() ?? string.Empty;
            string month = Month.SelectedItem?.ToString() ?? string.Empty;
            string year = Year.SelectedItem?.ToString() ?? string.Empty;
            string program = Program.SelectedItem?.ToString() ?? string.Empty;
            string gender;
            if (Male.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            if (string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(FirstName) ||
                string.IsNullOrEmpty(day) || string.IsNullOrEmpty(month) || string.IsNullOrEmpty(year))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string message = "Student name: " + FirstName + " " + MiddleName + " " + LastName +
       "\nGender: " + gender + "\nDate of birth: " + day + "/" + month + "/" + year + "\nProgram: " + program;
            MessageBox.Show(message);
        }
    }
}
