using SampleMVVM.Commands;
using SampleMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace SampleMVVM.ViewModels
{
    class DoctorViewModel : ViewModelBase
    {
        public Doctor Doctor;

        public DoctorViewModel(Doctor doctor)
        {
            this.Doctor = doctor;
        }

        public string ID
        {
            get { return Convert.ToString(Doctor.ID); }
            set
            {
                Doctor.ID = Convert.ToInt32(value);
                OnPropertyChanged("ID");
            }
        }

        public string Name
        {
            get { return Doctor.Name; }
            set
            {
                Doctor.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Surname
        {
            get { return Doctor.Surname; }
            set
            {
                Doctor.Surname = value;
                OnPropertyChanged("Surname");
            }
        }

        public string Patronymic
        {
            get { return Doctor.Patronymic; }
            set
            {
                Doctor.Patronymic = value;
                OnPropertyChanged("Patronymic");
            }
        }

        public string Speciality
        {
            get { return Doctor.Speciality; }
            set
            {
                Doctor.Speciality = value;
                OnPropertyChanged("Speciality");
            }
        }

        public string ImageSrc
        {
            get { return Doctor.ImageSrc; }
            set
            {
                Doctor.ImageSrc = value;
                OnPropertyChanged("ImageSrc");
            }
        }

        public string Category
        {
            get { return Doctor.Category; }
            set
            {
                Doctor.Category = value;
                OnPropertyChanged("Category");
            }
        }

        public int? TicketsCount
        {
            get { return Doctor.TicketsCount; }
            set
            {
                Doctor.TicketsCount = Convert.ToInt32(value);
                OnPropertyChanged("TicketsCount");
            }
        }

        // Забрать талон
        private DelegateCommand getItemCommand;

        public ICommand GetItemCommand
        {
            get
            {
                if (getItemCommand == null)
                {
                    getItemCommand = new DelegateCommand(GetItem);
                }
                return getItemCommand;
            }
        }

        private void GetItem()
        {
            TicketsCount++;
        }

        // Выдать талон
        private DelegateCommand giveItemCommand;

        public ICommand GiveItemCommand
        {
            get
            {
                if (giveItemCommand == null)
                {
                    giveItemCommand = new DelegateCommand(GiveItem, CanGiveItem);
                }
                return giveItemCommand;
            }
        }

        private void GiveItem()
        {
            TicketsCount--;
        }

        private bool CanGiveItem()
        {
            return TicketsCount > 0;
        }
    }
}
