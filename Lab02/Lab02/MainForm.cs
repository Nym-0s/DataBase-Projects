using System.Windows.Forms;

namespace Lab02
{
    public partial class MainForm : Form
    {
        private List<Student> _list; 
        private List<Teacher> _list2;

        public MainForm()
        {
            InitializeComponent();
            _list = new List<Student>(); //список студентів
            _list2 = new List<Teacher>(); //список вчителів
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] linesStudents = File.ReadAllLines("E:\\repos\\DataBase-Projects\\Lab02\\Lab02\\list.txt");
                // StLastName, StFirstName, Grade, Classroom, Bus
                // COOKUS, XUAN, 3, 107, 52

                foreach (string line in linesStudents)
                {
                    string[] data = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    //result.Text += line + Environment.NewLine;
                    Student student = new Student()
                    {
                        StLastName = data[0],
                        StFirstName = data[1],
                        Grade = int.Parse(data[2]),
                        Classroom = int.Parse(data[3]),
                        Bus = int.Parse(data[4])
                    };
                    _list.Add(student);
                }

                string[] linesTeachers = File.ReadAllLines("E:\\repos\\DataBase-Projects\\Lab02\\Lab02\\teachers.txt");
                // TLastName,TFirstName, Classroom
                // FAFARD, ROCIO, 107

                foreach (string line in linesTeachers)
                {
                    string[] data = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    //result.Text += line + Environment.NewLine;
                    Teacher teacher = new Teacher()
                    {
                        TLastName = data[0],
                        TFirstName = data[1],
                        Classroom = int.Parse(data[2]),
                    };
                    _list2.Add(teacher);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            statusStrip1.Items[1].Text = _list.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = "";
            int counter = 0;
            string? StudentSurname = StSurname.Text.Trim();
            foreach (var item in _list)
            {
                if (item.StLastName == StudentSurname)
                {
                    result.Text += item.ToStringStudentClassTeacher(); //записуємо учня

                    foreach (var item2 in _list2)
                    {
                        if (item2.Classroom == item.Classroom) //порівнюємо класні кімнати
                        {
                            result.Text += item.ToStringStudentClassTeacher(); //записуємо його викладачів
                        }
                    }
                    counter++;
                }
                if (counter >= 500)
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result.Text = "";
            int counter = 0;
            string? StudentSurname = StSurname2.Text.Trim();
            foreach (var item in _list)
            {
                if (item.StLastName == StudentSurname)
                {
                    result.Text += item.ToStringStudentBus();
                    counter++;
                }
                if (counter >= 500)
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result.Text = "";
            int counter = 0;
            string? TeacherSurname = TSurname.Text.Trim();
            foreach (var item in _list)
            {
                if (item.TLastName == TeacherSurname)
                {
                    result.Text += item.ToStringTeachersStudentsList();
                    counter++;
                }
                if (counter >= 500)
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result.Text = "";
            int counter = 0;
            int BusNum = Convert.ToInt32(BusNumber.Text.Trim());
            foreach (var item in _list)
            {
                if (item.Bus == BusNum)
                {
                    result.Text += item.ToStringStudentsByBus();
                    counter++;
                }
                if (counter >= 500)
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result.Text = "";
            int counter = 0;
            int Grade = Convert.ToInt32(GradeTB.Text.Trim());
            foreach (var item in _list)
            {
                if (item.Grade == Grade)
                {
                    result.Text += item.ToStrinStudentsGrade();
                    counter++;
                }
                if (counter >= 500)
                    break;
            }
        }

    }
}