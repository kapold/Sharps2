using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LW2;

public partial class SearchForm : Form
{
    public SearchForm()
    {
        InitializeComponent();
    }
    
    string searchResultsPath = 
        Path.GetFullPath(@"D:\Универ 2 курс\Университет 4 семестр\ООП\Лабораторные работы\LW3\LW2\searchResult.xml");

    public string path =
        Path.GetFullPath(@"D:\Универ 2 курс\Университет 4 семестр\ООП\Лабораторные работы\LW2\LW2\students.xml");

    private List<Student> RegexS(string regBox)
    {
        Student[] studentArray =
            XmlSerialize.Deserialize(@"D:\Универ 2 курс\Университет 4 семестр\ООП\Лабораторные работы\LW2\LW2\students.xml");
        int minValue = 0, maxValue = 11;
        string match;
        Regex numberReg = new Regex(@"^[0-9]+-[0-9]+$");
        Regex minNumber = new Regex(@"^[0-9]+-");
        Regex maxNumber = new Regex(@"[0-9]+$");
        Regex Numbers = new Regex(@"[0-9]+");

        Regex regMore = new Regex(@"^>[0-9]+$");
        Regex regLess = new Regex(@"^<[0-9]+$");
        List<Student> regResult = new List<Student>();
        // [0-10]
        if (numberReg.IsMatch(regBox))
        {
            if (minNumber.IsMatch(regBox))
            {
                match = minNumber.Match(regBox).Value;
                minValue = Convert.ToInt32(Numbers.Match(match).Value);
            }
            if (maxNumber.IsMatch(regBox))
            {
                match = maxNumber.Match(regBox).Value;
                maxValue = Convert.ToInt32(Numbers.Match(match).Value);
            }
            foreach (var student in studentArray)
            {
                if (student.averageMark >= minValue && student.averageMark <= maxValue)
                {
                    regResult.Add(student);
                }
            }
        }
        
        // >
        if (regMore.IsMatch(regBox))
        {
            if (Numbers.IsMatch(regBox))
            {
                match = Numbers.Match(regBox).Value;
                minValue = Convert.ToInt32(Numbers.Match(match).Value);
            }
            foreach (var student in studentArray)
            {
                if (student.averageMark > minValue)
                {
                    regResult.Add(student);
                }
            }
        }
        
        // <
        if (regLess.IsMatch(regBox))
        {
            if (Numbers.IsMatch(regBox))
            {
                match = Numbers.Match(regBox).Value;
                maxValue = Convert.ToInt32(Numbers.Match(match).Value);
            }
            foreach (var student in studentArray)
            {
                if (student.averageMark < maxValue)
                {
                    regResult.Add(student);
                }
            }
        }

        return regResult;
    }
    
    private IEnumerable<Student> CheckStatus(Student obj)
        {
            Student[] searchingInfo = XmlSerialize.Deserialize(path);
            IEnumerable<Student> searchedItems = null;
            
            if (!String.IsNullOrEmpty(searchFIO.Text)) // FIO
            {
                searchedItems = searchingInfo.Where(s => s.name == obj.name)
                    .Where(s => s.surname == obj.surname)
                    .Where(s => s.secondName == obj.secondName);
            }
            if (!String.IsNullOrEmpty(searchSpec.Text)) // speciality
            {
                searchedItems = searchingInfo.Where(s => s.speciality == obj.speciality);
            }
            if (!String.IsNullOrEmpty(searchCourse.Text)) // course
            {
                searchedItems = searchingInfo.Where(s => s.course == obj.course);
            }
            if (searchMark.Value != 0) // mark
            {
                searchedItems = searchingInfo.Where(s => s.averageMark == obj.averageMark);
            }
            if (!String.IsNullOrEmpty(searchFIO.Text) && !String.IsNullOrEmpty(searchSpec.Text)) // FIO + spec
            {
                searchedItems = searchingInfo.Where(s => s.name == obj.name)
                    .Where(s => s.surname == obj.surname)
                    .Where(s => s.secondName == obj.secondName)
                    .Where(s => s.speciality == obj.speciality);
            }
            if (!String.IsNullOrEmpty(searchFIO.Text) && !String.IsNullOrEmpty(searchCourse.Text)) // FIO + course
            {
                searchedItems = searchingInfo.Where(s => s.name == obj.name)
                    .Where(s => s.surname == obj.surname)
                    .Where(s => s.secondName == obj.secondName)
                    .Where(s => s.course == obj.course);
            }
            if (!String.IsNullOrEmpty(searchFIO.Text) && searchMark.Value != 0) // FIO + mark
            {
                searchedItems = searchingInfo.Where(s => s.name == obj.name)
                    .Where(s => s.surname == obj.surname)
                    .Where(s => s.secondName == obj.secondName)
                    .Where(s => s.averageMark == obj.averageMark);
            }
            if (!String.IsNullOrEmpty(searchSpec.Text) && !String.IsNullOrEmpty(searchCourse.Text)) // spec + course
            {
                searchedItems = searchingInfo.Where(s => s.speciality == obj.speciality)
                    .Where(s => s.course == obj.course);
            }
            if (!String.IsNullOrEmpty(searchSpec.Text) && searchMark.Value != 0) // spec + mark
            {
                searchedItems = searchingInfo.Where(s => s.speciality == obj.speciality)
                    .Where(s => s.averageMark == obj.averageMark);
            }
            if (!String.IsNullOrEmpty(searchCourse.Text) && searchMark.Value != 0) // course + mark
            {
                searchedItems = searchingInfo.Where(s => s.course == obj.course)
                    .Where(s => s.averageMark == obj.averageMark);
            }
            
            if (!String.IsNullOrEmpty(searchSpec.Text) && !String.IsNullOrEmpty(searchCourse.Text) &&
                       searchMark.Value != 0) // spec + course + mark
            {
                searchedItems = searchingInfo.Where(s => s.speciality == obj.speciality)
                    .Where(s => s.course == obj.course)
                    .Where(s => s.averageMark == obj.averageMark);
            }
            if (!String.IsNullOrEmpty(searchFIO.Text) && !String.IsNullOrEmpty(searchCourse.Text) &&
                       searchMark.Value != 0) // FIO + course + mark
            {
                searchedItems = searchingInfo.Where(s => s.name == obj.name)
                    .Where(s => s.surname == obj.surname)
                    .Where(s => s.secondName == obj.secondName)
                    .Where(s => s.course == obj.course)
                    .Where(s => s.averageMark == obj.averageMark);
            }
            if (!String.IsNullOrEmpty(searchFIO.Text) && !String.IsNullOrEmpty(searchSpec.Text) &&
                       searchMark.Value != 0) // FIO + spec + mark
            {
                searchedItems = searchingInfo.Where(s => s.name == obj.name)
                    .Where(s => s.surname == obj.surname)
                    .Where(s => s.secondName == obj.secondName)
                    .Where(s => s.speciality == obj.speciality)
                    .Where(s => s.averageMark == obj.averageMark);
            }
            if (!String.IsNullOrEmpty(searchFIO.Text) && !String.IsNullOrEmpty(searchSpec.Text) &&
                       !String.IsNullOrEmpty(searchCourse.Text)) // FIO + spec + course
            {
                searchedItems = searchingInfo.Where(s => s.name == obj.name)
                    .Where(s => s.surname == obj.surname)
                    .Where(s => s.secondName == obj.secondName)
                    .Where(s => s.speciality == obj.speciality)
                    .Where(s => s.course == obj.course);
            }
            
            if (!String.IsNullOrEmpty(searchFIO.Text) && !String.IsNullOrEmpty(searchSpec.Text) 
                       && !String.IsNullOrEmpty(searchCourse.Text) && searchMark.Value != 0) // all
            {
                searchedItems = searchingInfo.Where(s => s.name == obj.name)
                    .Where(s => s.surname == obj.surname)
                    .Where(s => s.secondName == obj.secondName)
                    .Where(s => s.speciality == obj.speciality)
                    .Where(s => s.course == obj.course)
                    .Where(s => s.averageMark == obj.averageMark);
            }

            return searchedItems;
        }
    
    private void SearchStudent()
    {
        Address address = new Address();
        address.city = String.Empty;
        address.home = 0;
        address.index = 0;
        address.street = String.Empty;
        Student SearchObj = new Student(address);

        try
        {
            if (!String.IsNullOrEmpty(searchFIO.Text))
            {
                string[] splitedFIO = searchFIO.Text.Split(' ');
                SearchObj.surname = splitedFIO[0];
                SearchObj.name = splitedFIO[1];
                SearchObj.secondName = splitedFIO[2];
            }
            else 
            { 
                SearchObj.surname = String.Empty; 
                SearchObj.name = String.Empty; 
                SearchObj.secondName = String.Empty;
            }
        }
        catch (Exception e)
        {
            MessageBox.Show("Введите ФИО полностью!");
        }

        if (!String.IsNullOrEmpty(searchCourse.Text))
        {
            SearchObj.course = Convert.ToInt32(searchCourse.Text);
        }
            
        if (!String.IsNullOrEmpty(searchSpec.Text))
        {
            SearchObj.speciality = searchSpec.Text;
        }
        else
        {
            SearchObj.speciality = null;
        }
            
        if (searchMark.Value != 0)
        {
            SearchObj.averageMark = searchMark.Value;
        }

        List<Student> studentResult = new List<Student>();
        try
        {
            IEnumerable<Student> result = CheckStatus(SearchObj);
            studentResult = result.ToList();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Заполните хотя бы 1 поле!");
        }

        
        PrintTable(studentResult);
            
        XmlSerialize.Serialize(studentResult, searchResultsPath, true);
    }
    
    private void PrintTable(IEnumerable<Student> arr)
    {
        if (searchTable.Rows.Count > 1)
        {
            searchTable.Rows.Clear();
        }
            
        foreach(var student in arr)
        {
            string fullStudentName = $"{student.name} {student.secondName} {student.surname}";
            string fullStudentAddress = $"{student.address.city} {student.address.home} {student.address.street} {student.address.index}";
            searchTable.Rows.Add(fullStudentName, student.speciality, student.birthday, student.course, student.group, student.averageMark, student.male, fullStudentAddress);
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

    private void SearchButton(object sender, EventArgs e)
    {
        SearchStudent();
    }

    private void RegexButton(object sender, EventArgs e)
    {
        PrintTable(RegexS(regexBox.Text));
    }
}