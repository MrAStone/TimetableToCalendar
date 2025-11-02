namespace TimetableToCalender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void setupWeek(string fileLoc)
        {
            string output = "";
            string[] lessons = { "Reg", "P1", "P2", "P3", "P4", "P5" };
            DateTime[] lessonTimes = { Convert.ToDateTime("08:40"), Convert.ToDateTime("09:00"), Convert.ToDateTime("10:20"), Convert.ToDateTime("11:20"), Convert.ToDateTime("13:15"), Convert.ToDateTime("14:15") };
            //timetable file needs to start with week B
            //timetable file needs to have one subject per line in order of lessons
            //timetable file needs to have no blank lines
            //timetable file needs 6 subjects per day for 5 days for 2 weeks = 60 lines
            // replace blanks with Free
            StreamWriter streamWriter = new StreamWriter("timetableOutput.txt");
            // this will output into the bin/debug folder of the project
            StreamReader tt = new StreamReader(fileLoc);
            List<string> subject = new List<string>();
            while (!tt.EndOfStream)
            {
                subject.Add(tt.ReadLine());
            }
            DateTime day = dateTimePicker7.Value;
            string[] week = { "B", "A" };
            while (day < dateTimePicker6.Value)
            {
                int lessonCount = 0;

                for (int w = 0; w < 2; w++)

                    for (int d = 0; d < 5; d++)
                    {
                        string dayPart = day.ToString("ddd");
                        for (int l = 0; l < lessons.Length; l++)
                        {
                            int lessonLength = 0;
                            if (lessons[l] == "Reg")
                            {
                                lessonLength = 20;

                            }
                            else
                            {
                                lessonLength = 60;
                            }
                            streamWriter.WriteLine(week[w] + dayPart + lessons[l] + " " + subject[lessonCount] + " " + day.ToString("d") + " " + lessonTimes[l].ToString("t") + " " + lessonTimes[l].AddMinutes(lessonLength).ToString("t") + " " + getCategory(subject[lessonCount]));
                            lessonCount++;

                        }

                        day = day.AddDays(1);
                        if (day.DayOfWeek == DayOfWeek.Saturday)
                        {
                            day = day.AddDays(2);
                        }
                        if (day.ToString("d") == dateTimePicker1.Value.ToString("d") || day.ToString("d") == dateTimePicker3.Value.ToString("d") || day.ToString("d") == dateTimePicker5.Value.ToString("d"))
                        {

                            day = day.AddDays(7);

                        }
                        if (day.ToString("d") == dateTimePicker2.Value.ToString("d") || day.ToString("d") == dateTimePicker4.Value.ToString("d"))
                        {

                            day = day.AddDays(14);


                        }

                    }

            }
            streamWriter.Close();
        }





        private void btnSetDates_Click(object sender, EventArgs e)
        {
            // you can set the term dates here and they will be saved to a text file

            StreamWriter sw = new StreamWriter("termDates.txt");
            for (int i = 1; i < 8; i++)
            {
                DateTimePicker dateTimePicker = (DateTimePicker)Controls["dateTimePicker" + i];
                DateTime date = dateTimePicker.Value;
                sw.WriteLine(date);
            }
            sw.Close();
            for (int i = 1; i <= 7; i++)
            {
                Controls["dateTimePicker" + i].Enabled = !Controls["dateTimePicker" + i].Enabled;
            }
            if (Controls["dateTimePicker1"].Enabled)
            {
                btnSetDates.Text = "Set Term Dates";

            }
            else
            {
                btnSetDates.Text = "Change Term Dates";
            }

        }
        private string getCategory(string input)
        {
            if (input == "Enrichment")
            {
                return input;
            }
            if (input == "SLT Link Meeting") // change this for special cases on your timetable
            {
                return "Link Meetings";
            }
            string cat = "Y";
            int index = 0;
            while (char.IsNumber(input[index]))
            {
                cat += input[index];
                index++;
            }
            return cat;


        }


        private void button2_Click(object sender, EventArgs e)
        {
            //load file open dialog and select csv file
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                setupWeek(ofd.FileName);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(7);

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3.Value = dateTimePicker2.Value.AddDays(14);
        }


        private void dateTimePicker3_ValueChanged_1(object sender, EventArgs e)
        {
            dateTimePicker4.Value = dateTimePicker3.Value.AddDays(7);
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker5.Value = dateTimePicker4.Value.AddDays(14);
        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker6.Value = dateTimePicker5.Value.AddDays(7);
        }

        private void timetableSetter_Load(object sender, EventArgs e)
        {
            if (File.Exists("termDates.txt"))
            {
                StreamReader sr = new StreamReader("termDates.txt");
                for (int i = 1; i < 8; i++)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)Controls["dateTimePicker" + i];
                    dateTimePicker.Value = Convert.ToDateTime(sr.ReadLine());

                }
                sr.Close();
                btnSetDates.Text = "Change Term Dates";
            }
            else
            {
                btnSetDates.Text = "Set Term Dates";
            }
            label8.Text = "Timetable should start week B in CSV file";
        }

       
    }
}
