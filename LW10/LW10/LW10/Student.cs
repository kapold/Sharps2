using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW10
{
    public class Student
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Patronymic { get; set; }
        public string? Speciality { get; set; }
        public DateTime? Birthday { get; set; }
        public int? Course { get; set; }
        public int? Group { get; set; }
        public string? Gender { get; set; }
        public string? PhoneNumber { get; set; }
        public string? ImageSrc { get; set; }
        // Address
        public int? ID { get; set; }
        public string? City { get; set; }
        public int? Index { get; set; }
        public string? Street { get; set; }
        public int? Home { get; set; }

        public Student() { }

        public override string ToString()
        {
            return $"\tStudent\n\n" +
                $"Name: {Name}\n" +
                $"Surname: {Surname}\n" +
                $"Patronymic: {Patronymic}\n" +
                $"Speciality: {Speciality}\n" +
                $"Birthday: {Birthday}\n" +
                $"Course: {Course}\n\n" +
                $"Index: {Index}";
        }
    }
}
