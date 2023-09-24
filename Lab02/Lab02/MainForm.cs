using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lab02
{
    public partial class MainForm : Form
    {
        private List<Student> _list; //список студентів
        private List<Teacher> _list2; //список вчителів

        public MainForm()
        {
            InitializeComponent();
            _list = new List<Student>(); //список студентів
            _list2 = new List<Teacher>(); //список вчителів
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stopwatch clock = new Stopwatch(); //таймер
            clock.Start(); //початок відліку часу
            try
            {
                string[] linesStudents = File.ReadAllLines("E:\\repos\\DataBase-Projects\\Lab02\\Lab02\\list.txt");
                // StLastName, StFirstName, Grade, Classroom, Bus
                // COOKUS, XUAN, 3, 107, 52

                foreach (string line in linesStudents)
                {
                    string[] data = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
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
                // TLastName, TFirstName, Classroom
                // FAFARD, ROCIO, 107

                foreach (string line in linesTeachers)
                {
                    string[] data = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    Teacher teacher = new Teacher()
                    {
                        TLastName = data[0],
                        TFirstName = data[1],
                        Classroom = int.Parse(data[2]),
                    };
                    _list2.Add(teacher);
                }
                clock.Stop(); //зупинка відліку
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            statusStrip1.Items[1].Text = Convert.ToString(clock.Elapsed);
        }

        private void button1_Click(object sender, EventArgs e) //пошук вчителів за учнем
        {
            result.Text = "";
            string? StudentSurname = StSurname.Text.Trim();
            Stopwatch clock = new Stopwatch(); //таймер
            clock.Start(); //початок відліку часу

            foreach (var item in _list)
            {
                if (item.StLastName == StudentSurname)
                {
                    result.Text += item.ToStringStudent(); //записуємо учня

                    foreach (var item2 in _list2)
                    {
                        if (item2.Classroom == item.Classroom) //порівнюємо класні кімнати
                        {
                            result.Text += "  " + item2.ToStringTeacher(); //записуємо його викладачів
                        }
                    }
                    result.Text += "************************************" + Environment.NewLine;
                }
            }
            clock.Stop(); //зупинка відліку
            statusStrip1.Items[1].Text = Convert.ToString(clock.Elapsed);
        }

        private void button2_Click(object sender, EventArgs e) //пошук автобусу учня
        {
            result.Text = "";
            string? StudentSurname = StSurname2.Text.Trim();
            Stopwatch clock = new Stopwatch(); //таймер
            clock.Start(); //початок відліку часу

            foreach (var item in _list)
            {
                if (item.StLastName == StudentSurname)
                {
                    result.Text += item.ToStringStudentBus();
                }
            }
            clock.Stop(); //зупинка відліку
            statusStrip1.Items[1].Text = Convert.ToString(clock.Elapsed);
        }

        private void button3_Click(object sender, EventArgs e) //пошук списку учнів за вчителем
        {
            result.Text = "";
            string? TeacherSurname = TSurname.Text.Trim();
            Stopwatch clock = new Stopwatch(); //таймер
            clock.Start(); //початок відліку часу

            foreach (var item in _list2)
            {
                if (item.TLastName == TeacherSurname)
                {
                    result.Text += item.ToStringTeacher(); //записуємо викладача

                    foreach (var item2 in _list)
                    {
                        if (item.Classroom == item2.Classroom) //порівнюємо класні кімнати
                        {
                            result.Text += "  " + item2.ToStringStudent(); //записуємо його учня
                        }
                    }
                    result.Text += "************************************" + Environment.NewLine;
                }
            }
            clock.Stop(); //зупинка відліку
            statusStrip1.Items[1].Text = Convert.ToString(clock.Elapsed);
        }

        private void button4_Click(object sender, EventArgs e) //пошук учнів за автобусом
        {
            result.Text = "";
            int BusNum = Convert.ToInt32(BusNumber.Text.Trim());
            Stopwatch clock = new Stopwatch(); //таймер
            clock.Start(); //початок відліку часу

            foreach (var item in _list)
            {
                if (item.Bus == BusNum)
                {
                    result.Text += item.ToStringStudentsByBus();
                }
            }
            clock.Stop(); //зупинка відліку
            statusStrip1.Items[1].Text = Convert.ToString(clock.Elapsed);
        }

        private void button5_Click(object sender, EventArgs e) //пошук учнів за ступенню їхнього класу
        {
            result.Text = "";
            int Grade = Convert.ToInt32(GradeTB.Text.Trim());
            Stopwatch clock = new Stopwatch(); //таймер
            clock.Start(); //початок відліку часу

            foreach (var item in _list)
            {
                if (item.Grade == Grade)
                {
                    result.Text += item.ToStringStudent();
                }
            }
            clock.Stop(); //зупинка відліку
            statusStrip1.Items[1].Text = Convert.ToString(clock.Elapsed);
        }

        private void button6_Click(object sender, EventArgs e) //пошук вчителів за класною кімнатою
        {
            result.Text = "";
            int Classroom = Convert.ToInt32(classroomTBTeach.Text.Trim());
            Stopwatch clock = new Stopwatch(); //таймер
            clock.Start(); //початок відліку часу

            foreach (var item in _list2)
            {
                if (item.Classroom == Classroom)
                {
                    result.Text += item.ToStringTeacher();
                }
            }
            clock.Stop(); //зупинка відліку
            statusStrip1.Items[1].Text = Convert.ToString(clock.Elapsed);
        }

        private void button7_Click(object sender, EventArgs e) //пошук вчителів за ступенню класу
        {
            result.Text = "";
            int Grade = Convert.ToInt32(gradeTBTeach.Text.Trim());
            Stopwatch clock = new Stopwatch(); //таймер
            clock.Start(); //початок відліку часу

            foreach (var item in _list)
            {
                if (item.Grade == Grade)
                {
                    //result.Text += item.ToStringTeacher(); //записуємо викладача

                    foreach (var item2 in _list2)
                    {
                        if (item.Classroom == item2.Classroom) //порівнюємо класні кімнати
                        {
                            result.Text += "  " + item2.ToStringTeacher(); //записуємо його учня
                        }
                    }
                    result.Text += "************************************" + Environment.NewLine;
                }
            }
            clock.Stop(); //зупинка відліку
            statusStrip1.Items[1].Text = Convert.ToString(clock.Elapsed);
        }
    }
}