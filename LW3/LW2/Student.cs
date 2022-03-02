using System;
using System.ComponentModel.DataAnnotations;

namespace LW2
{
    [Serializable]
    [StudentValidation]
    public class Student
    {
        [Required(ErrorMessage = "Укажите имя!")]
        [StringLength(50)]
        public string name;
        [Required(ErrorMessage = "Укажите отчество!")]
        [StringLength(50)]
        public string secondName;
        [Required(ErrorMessage = "Укажите фамилию!")]
        [StringLength(50)]
        public string surname;
        [Required(ErrorMessage = "Укажите специальность!")]
        public string speciality;
        [Required(ErrorMessage = "Укажите дату рождения!")]
        public string birthday;
        [Required(ErrorMessage = "Укажите курс!")]
        public int course;
        [Required(ErrorMessage = "Укажите группу!")]
        public int group;
        [Required(ErrorMessage = "Укажите оценку!")]
        public int averageMark;
        [Required(ErrorMessage = "Укажите род!")]
        public string male;
        [Required(ErrorMessage = "Укажите адрес!")]
        public Address address;

        public Student() {}
        public Student(Address ad)
        {
            address = ad;
        }
        
        public override string ToString()
        {
            string studInfo = $"Student: {surname} {name} {secondName}\n" +
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
