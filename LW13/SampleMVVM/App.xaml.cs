using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using SampleMVVM.Models;
using SampleMVVM.ViewModels;
using SampleMVVM.Views;

namespace SampleMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {
            List<Doctor> doctors = new List<Doctor>();
            using (MedicineModel db = new MedicineModel())
            {
                doctors =  db.Doctors.ToList();
            }

            MainView view = new MainView(); // создали View
            MainViewModel viewModel = new ViewModels.MainViewModel(doctors); // Создали ViewModel
            view.DataContext = viewModel; // положили ViewModel во View в качестве DataContext
            view.Show();
        }
    }
}
