using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using LW2.Abstract_Factory;
using LW2.Proxy;

namespace LW2
{
    public partial class University : Form
    {
        public University()
        {
            InitializeComponent();
            
            studentBirthday.MaxDate = DateTime.Today;
        }

        List<Student> students = new List<Student>();
        
        private void PrintTable(IEnumerable<Student> arr)
        {
            if (infoTableAboutStudents.Rows.Count > 1)
            {
                infoTableAboutStudents.Rows.Clear();
            }
            
            foreach(var student in arr)
            {
                string fullStudentName = $"{student.name} {student.secondName} {student.surname}";
                string fullStudentAddress = $"{student.address.city} {student.address.home} {student.address.street} {student.address.index}";
                infoTableAboutStudents.Rows.Add(fullStudentName, student.speciality, student.birthday, student.course, student.group, student.averageMark, student.male, fullStudentAddress);
            }
        }

        private void AddStudentButton(object sender, EventArgs e) // Add
        {
            try
            {
                Address addr = new Address();
                addr.city = addressCity.Text;
                addr.street = addressStreet.Text;
                addr.home = Convert.ToInt32(addressHome.Text);
                addr.index = Convert.ToInt32(addressIndex.Text);
                Student student = new Student(addr);
                student.name = studentName.Text;
                student.secondName = studentSecondName.Text;
                student.surname = studentSurname.Text;
                student.birthday = studentBirthday.Value;
                student.speciality = studentSpeciality.Text;
                student.course = Convert.ToInt32(studentCourse.Text);
                student.group = Convert.ToInt32(studentGroup.Text);
                student.averageMark = Convert.ToInt32(studentAverageMark.Value);

                if (maleRadioButton.Checked)
                {
                    student.male = "Male";
                }
                else if (femaleRadioButton.Checked)
                {
                    student.male = "Female";
                }
                else
                {
                    throw new Exception("Выберите пол!");
                }
                
                students.Add(student);
                MessageBox.Show("Студент добавлен!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        
        private void ClearFormButton(object sender, EventArgs e) // Clear
        {
            studentName.Text = "";
            studentSecondName.Text = "";
            studentSurname.Text = "";
            addressCity.Text = "";
            addressStreet.Text = "";
            addressHome.Text = "";
            addressIndex.Text = "";
            studentSpeciality.Text = "";
            studentCourse.Text = "";
            studentGroup.Text = "";
            studentAverageMark.Value = 0;
            maleRadioButton.Checked = false; 
            femaleRadioButton.Checked = false;
            studentBirthday.Value = DateTime.Today;

            if (infoTableAboutStudents.Rows.Count > 1)
            {
                infoTableAboutStudents.Rows.Clear();
            }
        }

        string path =
            Path.GetFullPath(@"D:\Универ 2 курс\Университет 4 семестр\ООП\Лабораторные работы\LW5\LW2\students.xml");
        private void ConvertToXml(object sender, EventArgs e) // objects to xml
        {
            XmlSerialize.Serialize(students, path);
            MessageBox.Show("Сериализовано!");
        }
        
        private void ShowFromXml(object sender, EventArgs e) // displays objects from xml
        {
            Student[] studentInfo = XmlSerialize.Deserialize(path);
            
            PrintTable(studentInfo);
        }

        private void University_Load(object sender, EventArgs e)
        {
            Size = new Size(1230, 630);
        }

        public Student getRanStudent()
        {
            Director director = new Director();
            StudentBuilder studentBuilder = new StudentBuilder();

            director.Builder = studentBuilder;
            director.BuildRandomStudent();

            return studentBuilder.GetStudent();
        }
        string randomStudentsPath =
            Path.GetFullPath(@"D:\Универ 2 курс\Университет 4 семестр\ООП\Лабораторные работы\LW4\LW2\randomStudents.xml");
        
        //                                        PATTERNS

        private List<Student> randomStudents = new List<Student>();
        private void BuilderBtn_Click(object sender, EventArgs e)
        {
            randomStudents.Add(getRanStudent());
            
            XmlSerialize.Serialize(randomStudents, randomStudentsPath);
            PrintTable(randomStudents);
        }

        private void SingletonBtn_Click(object sender, EventArgs e)
        {
            SingletonForm singletonForm = SingletonForm.getSingle(BackColor, Font, Size);
            MessageBox.Show(singletonForm.ToString());
        }

        private void AbsFactBtn_Click(object sender, EventArgs e)
        {
            if (factoryBox.Text == "School")
            {
                Factory factory = new Factory(new SchoolFactory());
                factory.InfoAboutFactory();
            }
            else if (factoryBox.Text == "Univer")
            {
                Factory factory = new Factory(new UniverFactory());
                factory.InfoAboutFactory();
            }
            else
            {
                MessageBox.Show("Выберите фабрику!");
            }
        }

        private void PrototypeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int ind = infoTableAboutStudents.CurrentRow.Index;
                string fio = (string) infoTableAboutStudents.Rows[ind].Cells[0].Value;
                string[] splFIO = fio.Split(' ');
                string name = splFIO[1];
                string surname = splFIO[0];
                string secondName = splFIO[2];
                string speciality = (string) infoTableAboutStudents.Rows[ind].Cells[1].Value;
                DateTime birthday = (DateTime) infoTableAboutStudents.Rows[ind].Cells[2].Value;
                int course = (int) infoTableAboutStudents.Rows[ind].Cells[3].Value;
                int group = (int) infoTableAboutStudents.Rows[ind].Cells[4].Value;
                float averMark = (float) infoTableAboutStudents.Rows[ind].Cells[5].Value;
                string male = (string) infoTableAboutStudents.Rows[ind].Cells[6].Value;
                Address address = new Address();
                string selectedAddress = (string) infoTableAboutStudents.Rows[ind].Cells[7].Value;
                string[] splitedAddress = selectedAddress.Split(' ');
                address.city = splitedAddress[0];
                address.home = Convert.ToInt32(splitedAddress[1]);
                address.index = Convert.ToInt32(splitedAddress[2]);
                address.street = splitedAddress[3];
            
                Student stud = new Student(address);
                stud.name = name;
                stud.surname = surname;
                stud.secondName = secondName;
                stud.speciality = speciality;
                stud.birthday = birthday;
                stud.course = course;
                stud.group = group;
                stud.averageMark = averMark;
                stud.male = male;

                IPrototype student = new Student(stud);
                IPrototype copiedStudent = student.Clone();
                copiedStudent.GetInfo();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Выберите студента!");
            }
        }

        private static Address _address = new Address();
        private static Student studentObj = new Student(_address);
        private void outObj_Click(object sender, EventArgs e)
        {
            try
            {
                int ind = infoTableAboutStudents.CurrentRow.Index;
                string fio = (string) infoTableAboutStudents.Rows[ind].Cells[0].Value;
                string[] splFIO = fio.Split(' ');
                string name = splFIO[1];
                string surname = splFIO[0];
                string secondName = splFIO[2];
                string speciality = (string) infoTableAboutStudents.Rows[ind].Cells[1].Value;
                DateTime birthday = (DateTime) infoTableAboutStudents.Rows[ind].Cells[2].Value;
                int course = (int) infoTableAboutStudents.Rows[ind].Cells[3].Value;
                int group = (int) infoTableAboutStudents.Rows[ind].Cells[4].Value;
                float averMark = (float) infoTableAboutStudents.Rows[ind].Cells[5].Value;
                string male = (string) infoTableAboutStudents.Rows[ind].Cells[6].Value;
                string selectedAddress = (string) infoTableAboutStudents.Rows[ind].Cells[7].Value;
                string[] splitedAddress = selectedAddress.Split(' ');
                _address.city = splitedAddress[0];
                _address.home = Convert.ToInt32(splitedAddress[1]);
                _address.index = Convert.ToInt32(splitedAddress[2]);
                _address.street = splitedAddress[3];
            
                studentObj.name = name;
                studentObj.surname = surname;
                studentObj.secondName = secondName;
                studentObj.speciality = speciality;
                studentObj.birthday = birthday;
                studentObj.course = course;
                studentObj.group = group;
                studentObj.averageMark = averMark;
                studentObj.male = male;
                MessageBox.Show(studentObj.ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка выбора студента!");
                // MessageBox.Show(exception.Message); // Debug window
            }
        }

        private void decrStateBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(studentObj.name))
            {
                studentObj.DeacreaseMark();
            }
            else
            {
                MessageBox.Show("Выберите студента!");
            }
        }

        History history = new History(); // Стек состояний
        private void saveStateBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(studentObj.name))
            {
                history.history.Push(studentObj.SaveState());
            }
            else
            {
                MessageBox.Show("Выберите студента!");
            }
        }

        private void returnStateBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(studentObj.name))
            {
                studentObj.RestoreState(history.history.Pop());
            }
            else
            {
                MessageBox.Show("Выберите студента!");
            }
        }
        
        private ISubject proxy = new Proxy.Proxy(studentObj); // Proxy для работы с объектом

        private void poxyBtnState_Click(object sender, EventArgs e)
        {
            proxy.GetInfo();
        }

        private void lowPrxyBtn_Click(object sender, EventArgs e)
        {
            proxy.DeacreaseMark();
        }
    }
}
