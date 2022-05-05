using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SampleMVVM.Models
{
    public class Doctor
    {
        public int ID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Surname { get; set; }
        [StringLength(50)]
        public string Patronymic { get; set; }
        [StringLength(50)]
        public string Speciality { get; set; }
        public string ImageSrc { get; set; }
        [StringLength(50)]
        public string Category { get; set; }
        public int? TicketsCount { get; set; }

        public Doctor() { }

        public Doctor(string name, string surname, string patronymic, string speciality, string imageSrc, string category, int ticketsCount)
        {
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            this.Speciality = speciality;
            this.ImageSrc = imageSrc;
            this.Category = category;
            this.TicketsCount = ticketsCount;
        }
    }
}
