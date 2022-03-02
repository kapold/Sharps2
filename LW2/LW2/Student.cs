using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LW2
{
    [Serializable]
    public class Student
    {
        public string name;
        public string secondName;
        public string surname;
        public string speciality;
        public DateTime birthday;
        public int course;
        public int group;
        public int averageMark;
        public string male;
        public Address address;

        public Student() {}
        public Student(Address ad)
        {
            address = ad;
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
    }
}
