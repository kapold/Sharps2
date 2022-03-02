using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using Timer = System.Windows.Forms.Timer;

namespace LW2
{
    public partial class UniversityForm : Form
    {
        public UniversityForm()
        {
            InitializeComponent();
            
            studentBirthday.MaxDate = DateTime.Today;
            timer = new Timer() { Interval = 1000 };
            timer.Tick += TimeLabel;
            timer.Tick += ObjectsCountLabel;
            timer.Tick += LastEventLabel;
            timer.Start();
        }
        
        Timer timer;
        List<Student> students = new List<Student>();

        private Student[] studentArray =
            XmlSerialize.Deserialize(@"D:\Универ 2 курс\Университет 4 семестр\ООП\Лабораторные работы\LW2\LW2\students.xml");

        private void University_Load(object sender, EventArgs e)
        {
            Size = new Size(1250, 680);
        }
        
        private static bool Validate(Student user)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(user);
            if (!Validator.TryValidateObject(user, context, results, true))
            {
                foreach (var error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                }

                return false;
            }
            else
            {
                MessageBox.Show("Пользователь прошел валидацию!");
                return true;
            }
        }

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
                Address address = new Address();
                address.city = addressCity.Text;
                address.street = addressStreet.Text;
                address.home = Convert.ToInt32(addressHome.Text);
                address.index = Convert.ToInt32(addressIndex.Text);
                Student student = new Student(address);
                student.name = studentName.Text;
                student.secondName = studentSurname.Text; // перепутаны фамилия-отчество
                student.surname = studentSecondName.Text;
                student.birthday = studentBirthday.Value.ToShortDateString();
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

                if (!Validate(student))
                {
                    throw new Exception("Проверьте вводимую информацию!");
                }

                students.Add(student);
                MessageBox.Show("Студент добавлен!");
                lastEventInfo = "Добавление";
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
            studentSpeciality.Text = null;
            studentCourse.Text = null;
            studentGroup.Text = null;
            studentAverageMark.Value = 0;
            maleRadioButton.Checked = false; 
            femaleRadioButton.Checked = false;
            lastEventInfo = "Очистка";

            if (infoTableAboutStudents.Rows.Count > 1)
            {
                infoTableAboutStudents.Rows.Clear();
            }
        }
        
        public string path =
            Path.GetFullPath(@"D:\Универ 2 курс\Университет 4 семестр\ООП\Лабораторные работы\LW2\LW2\students.xml");

        public string lastEventInfo = "";
        string stateOfTools = "Visible";
        private void ConvertToXml(object sender, EventArgs e) // objects to xml
        {
            XmlSerialize.Serialize(students, path, false);
            MessageBox.Show("Сериализовано!");
            lastEventInfo = "Сериализация";
        }
        
        private void ShowFromXml(object sender, EventArgs e) // displays objects from xml
        {
            Student[] studentInfo = XmlSerialize.Deserialize(path);
            lastEventInfo = "Десериализация";
            
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

        private void SearchButton(object sender, EventArgs e)
        {
            lastEventInfo = "Поиск";
            // SearchStudent();

            SearchForm sForm = new SearchForm();
            sForm.Show();
            // if (FormStatus.isOpened == false)
            // {
            //     sForm.Show();
            //     FormStatus.isOpened = true;
            // }
        }

        private void SortByCourseButton(object sender, EventArgs e) // sort by course
        {
            Student[] searchingInfo = XmlSerialize.Deserialize(path);

            var sortedResult = searchingInfo.OrderBy(s => s.course);

            List<Student> sortedList = sortedResult.ToList();
            string sortPath =
                Path.GetFullPath(@"D:\Универ 2 курс\Университет 4 семестр\ООП\Лабораторные работы\LW3\LW2\commonSort.xml");
            XmlSerialize.Serialize(sortedList, sortPath, false);
            lastEventInfo = "Сортировка по курсу";
            // output
            PrintTable(sortedResult);
        }
        
        private void SortByGroupButton(object sender, EventArgs e) // sort by group
        {
            Student[] searchingInfo = XmlSerialize.Deserialize(path);

            var sortedResult = searchingInfo.OrderBy(s => s.group);

            List<Student> sortedList = sortedResult.ToList();
            string sortPath =
                Path.GetFullPath(@"D:\Универ 2 курс\Университет 4 семестр\ООП\Лабораторные работы\LW3\LW2\commonSort.xml");
            XmlSerialize.Serialize(sortedList, sortPath ,false);
            lastEventInfo = "Сортировка по группе";
            // output
            PrintTable(sortedResult);
        }

        private void AboutButton(object sender, EventArgs e)
        {
            string about = "Version: v.1.0.2\n" +
                           "Developer: Adamovich A.M.";
            MessageBox.Show(about);
            lastEventInfo = "О Программе";
        }
        
        private void ClearToolStrip(object sender, EventArgs e)
        {
            ClearFormButton(sender, e);
        }

        private void ObjectsCountLabel(object sender, EventArgs e) // count of objects
        {
            toolStripStatusLabel2.Text = Convert.ToString(studentArray.Length);
        }

        private void LastEventLabel(object sender, EventArgs e) // last event
        {
            toolStripStatusLabel4.Text = lastEventInfo;
        }
        
        private void TimeLabel(object sender, EventArgs e) // datetime
        {
            toolStripStatusLabel6.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel7.Text = DateTime.Now.ToLongTimeString();
        }
        
        private void HideArrowButton(object sender, EventArgs e)
        {
            if (stateOfTools == "Visible")
            {
                toolStripButton1.Visible = false;
                toolStripSeparator1.Visible = false;
                toolStripSeparator2.Visible = false;
                toolStripSeparator3.Visible = false;
                toolStripButton4.Visible = false;
                toolStripSeparator5.Visible = false;
                toolStripButton6.Visible = false;
                toolStripButton7.Visible = false;
                toolStripSeparator6.Visible = false;
                toolStripDropDownButton1.Visible = false;
                
                stateOfTools = "Hiden";
            }
            else if (stateOfTools == "Hiden")
            {
                toolStripButton1.Visible = true;
                toolStripSeparator1.Visible = true;
                toolStripSeparator2.Visible = true;
                toolStripSeparator3.Visible = true;
                toolStripButton4.Visible = true;
                toolStripSeparator5.Visible = true;
                toolStripButton6.Visible = true;
                toolStripButton7.Visible = true;
                toolStripSeparator6.Visible = true;
                toolStripDropDownButton1.Visible = true;
                
                stateOfTools = "Visible";
            }
        }
        
        /*                      UNDO/REDO       TABLE                              */
        private Stack<tempObj> states = new Stack<tempObj>();
        private uint count = 0;
        private void PrevButton(object sender, EventArgs e) // previous tool btn
        {
            Student[] arr = studentArray;
            if (arr.Length - count == 0)
            {
                MessageBox.Show("Объектов нет!");
                return;
            }
            count++;
            lastEventInfo = "Назад";
            int currentState = arr.Length;
            List<Student> listS = new List<Student>();
            for (int i = 0; i < currentState - count; i++)
            {
                listS.Add(arr[i]);
            }
            PrintTable(listS);
            // tempObj temp = states.Pop();
            // if (temp.place == "studentName")
            // {
            //     tempObj temp2 = states.Peek();
            //     if (temp2.place == "studentName")
            //     {
            //         studentName.Text = temp2.value;
            //     }
            //     
            // }

        }

        private void NextButton(object sender, EventArgs e) // next tool btn
        {
            if (count == 0)
            {
                MessageBox.Show("Все объекты восстановлены!");
                return;
            }
            count--;
            lastEventInfo = "Вперед";
            Student[] arr = studentArray; 
            int currentState = arr.Length;
            List<Student> listS = new List<Student>();
            for (int i = 0; i < currentState - count; i++)
            {
                listS.Add(arr[i]);
            }
            PrintTable(listS);
        }

        private void StripSortCourse(object sender, EventArgs e)
        {
            SortByCourseButton(sender, e);
        }

        private void StripSortGroup(object sender, EventArgs e)
        {
            SortByGroupButton(sender, e);
        }
        
        private void SearchTool(object sender, EventArgs e)
        {
            SearchButton(sender, e);
        }

        private void studentName_TextChanged(object sender, EventArgs e)
        {
            // tempObj temp = new tempObj();
            // temp.place = "studentName";
            // temp.value = studentName.Text;
            // states.Push(temp);
        }
    }

    public static class XmlSerialize
    {
        public static void Serialize(List<Student> obj, string fileName, bool isAppend)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Student>));

            using (StreamWriter sw = new StreamWriter(fileName, isAppend))
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
        
        public static List<List<Student>> DeserializeList(string fileName)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Student>));
            List<List<Student>> students;
            
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                students = (List<List<Student>>) formatter.Deserialize(fs);
            }

            return students;
        }
    }
}
