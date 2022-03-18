using System;
using System.Windows.Forms;

namespace LW2
{
    [Serializable]
    public class Student : IPrototype
    {
        public string name;
        public string secondName;
        public string surname;
        public string speciality;
        public DateTime birthday;
        public int course;
        public int group;
        public float averageMark;
        public string male;
        public Address address;

        public Student() {}
        public Student(Address ad)
        {
            address = ad;
        }

        public Student(Student student)
        {
            name = student.name;
            secondName = student.secondName;
            surname = student.surname;
            speciality = student.speciality;
            birthday = student.birthday;
            course = student.course;
            group = student.group;
            averageMark = student.averageMark;
            male = student.male;
            address = student.address;
        }
        
        public IPrototype Clone()
        {
            return new Student(this);
        }
        
        public override string ToString()
        {
            string studInfo = $"Student: {name} {secondName} {surname}\n" +
                              $"Male: {male}\n" +
                              $"Birthday: {birthday}\n" +
                              $"Speciality: {speciality}\n" +
                              $"Course: {course}\n" +
                              $"Group: {group}\n" +
                              $"Average Mark: {averageMark}\n" +
                              $"Address: {address.city} {address.home} {address.street}, index {address.index}";
            return studInfo;
        }

        public void GetInfo()
        {
            MessageBox.Show($"Скопированный студент\n\n" +
                            $"Студент: {name} {secondName} {surname}\n" +
                            $"Пол: {male}\n" +
                            $"Дата рождения: {birthday}\n" +
                            $"Специальность: {speciality}\n" +
                            $"Курс: {course}\n" +
                            $"Группа: {group}\n" +
                            $"Средняя Оценка: {averageMark}\n" +
                            $"Адрес: {address.city} {address.home} {address.street}, index {address.index}");
        }
    }
}
