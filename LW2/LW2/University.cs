using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;

namespace LW2
{
    public partial class University : Form
    {
        public University()
        {
            InitializeComponent();
        }

        List<Student> students = new List<Student>();

        private void addStudentButton(object sender, EventArgs e) // Add
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
        
        private void clearFormButton(object sender, EventArgs e) // Clear
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

        public string path =
            Path.GetFullPath(@"D:\Универ 2 курс\Университет 4 семестр\ООП\Лабораторные работы\LW2\LW2\students.xml");
        private void convertToXml(object sender, EventArgs e) // objects to xml
        {
            XmlSerialize.Serialize(students, path);
            MessageBox.Show("Сериализовано!");
        }
        
        private void showFromXml(object sender, EventArgs e) // displays objects from xml
        {
            Student[] studentInfo = XmlSerialize.Deserialize(path);
            
            if (infoTableAboutStudents.Rows.Count > 1)
            {
                infoTableAboutStudents.Rows.Clear();
            }
            
            foreach(var student in studentInfo)
            {
                string fullStudentName = $"{student.name} {student.secondName} {student.surname}";
                string fullStudentAddress = $"{student.address.city} {student.address.home} {student.address.street} {student.address.index}";
                infoTableAboutStudents.Rows.Add(fullStudentName, student.speciality, student.birthday, student.course, student.group, student.averageMark, student.male, fullStudentAddress);
            }
        }

        private void University_Load(object sender, EventArgs e)
        {
            Size = new Size(1230, 630);
        }
    }

    public static class XmlSerialize
    {
        public static void Serialize(List<Student> obj, string fileName)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Student>));

            using (StreamWriter sw = new StreamWriter(fileName, false))
            {
                formatter.Serialize(sw, obj);
            }
        }
        
        public static Student[] Deserialize(string fileName)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Student[]));
            Student[] students;
            
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                students = (Student[]) formatter.Deserialize(fs);
            }

            return students;
        }
    }
}
