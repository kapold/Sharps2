using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

using SampleMVVM.Commands;
using System.Collections.ObjectModel;
using SampleMVVM.Models;

namespace SampleMVVM.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        public ObservableCollection<DoctorViewModel> DoctorsList { get; set; }

        public MainViewModel(List<Doctor> doctors)
        {
            DoctorsList = new ObservableCollection<DoctorViewModel>(doctors.Select(b => new DoctorViewModel(b)));
        }
    }
}
