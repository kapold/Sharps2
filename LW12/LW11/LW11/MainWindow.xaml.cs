using LW11.Classes;
using LW11.Patterns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LW11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow mainWnd;
        public string lastChoosen = "";
        public bool addingNew = false;
        UniversityModel db;
        public MainWindow()
        {
            InitializeComponent();
            mainWnd = this;
            db = new UniversityModel();
            this.Closing += Window_Closing;
        }

        public void UpdateDB()
        {
            try
            {
                ComboBoxItem typeItem = (ComboBoxItem) CBTable.SelectedItem;
                lastChoosen = typeItem.Content.ToString();
                switch (lastChoosen)
                {
                    case "Students":
                    {
                        using (UniversityModel db = new UniversityModel())
                        {
                            studentIDColumn.Visibility = Visibility.Visible;
                            NameColumn.Visibility = Visibility.Visible;
                            SurnameColumn.Visibility = Visibility.Visible;
                            PatronymicColumn.Visibility = Visibility.Visible;
                            SpecialityColumn.Visibility = Visibility.Visible;
                            BirthdayColumn.Visibility = Visibility.Visible;
                            CourseColumn.Visibility = Visibility.Visible;
                            GroupColumn.Visibility = Visibility.Visible;
                            GenderColumn.Visibility = Visibility.Visible;
                            PhoneColumn.Visibility = Visibility.Visible;

                            IDColumn.Visibility = Visibility.Hidden;
                            CityColumn.Visibility = Visibility.Hidden;
                            IndexColumn.Visibility = Visibility.Hidden;
                            StreetColumn.Visibility = Visibility.Hidden;
                            HomeColumn.Visibility = Visibility.Hidden;

                            dataTable.ItemsSource = db.Students.ToList();
                            Add.IsEnabled = true;
                            Change.IsEnabled = true;
                        }
                        break;
                    }
                    case "Addresses":
                    {
                        using (UniversityModel db = new UniversityModel())
                        {
                                studentIDColumn.Visibility = Visibility.Hidden;
                                NameColumn.Visibility = Visibility.Hidden;
                                SurnameColumn.Visibility = Visibility.Hidden;
                                PatronymicColumn.Visibility = Visibility.Hidden;
                                SpecialityColumn.Visibility = Visibility.Hidden;
                                BirthdayColumn.Visibility = Visibility.Hidden;
                                CourseColumn.Visibility = Visibility.Hidden;
                                GroupColumn.Visibility = Visibility.Hidden;
                                GenderColumn.Visibility = Visibility.Hidden;
                                PhoneColumn.Visibility = Visibility.Hidden;

                                IDColumn.Visibility = Visibility.Visible;
                                CityColumn.Visibility = Visibility.Visible;
                                IndexColumn.Visibility = Visibility.Visible;
                                StreetColumn.Visibility = Visibility.Visible;
                                HomeColumn.Visibility = Visibility.Visible;

                                dataTable.ItemsSource = db.Addresses.ToList(); 
                            Add.IsEnabled = true;
                            Change.IsEnabled = true;
                        }
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source);
            }
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            db.Dispose();
        }

        private void AddDB(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (lastChoosen)
                {
                    case "Students":
                    {
                        AddStudentWnd addStudentWnd = new AddStudentWnd();
                        addStudentWnd.Show();
                        break;
                    }
                    case "Addresses":
                    {
                        AddAddressWnd addAddressWnd = new AddAddressWnd();
                        addAddressWnd.Show();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteDB(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (lastChoosen)
                {
                    case "Students":
                        {
                            Student st = (Student)dataTable.SelectedItem;
                            UnitOfWork context = new UnitOfWork();
                            context.StudentRepository.Delete(st.StudentID);
                            context.Save();
                            //Student student = new Student();
                            //student = (Student)dataTable.SelectedItem;

                            //using (UniversityModel db = new UniversityModel())
                            //{
                            //    List<Student> deleteStudent = db.Students.Where(s => s.StudentID == student.StudentID).ToList();
                            //    db.Students.Remove(deleteStudent[0]);
                            //    db.SaveChanges();
                            //}
                            MessageBox.Show("Студент удален!");
                            break;
                        }
                    case "Addresses":
                        {
                            Address ad = (Address)dataTable.SelectedItem;
                            UnitOfWork context = new UnitOfWork();
                            context.AddressRepository.Delete(ad.ID);
                            context.Save();
                            //Address address = new Address();
                            //address = (Address)dataTable.SelectedItem;

                            //using (UniversityModel db = new UniversityModel())
                            //{
                            //    List<Address> deleteAddress = db.Addresses.Where(a => a.ID == address.ID).ToList();
                            //    db.Addresses.Remove(deleteAddress[0]);
                            //    db.SaveChanges();
                            //}
                            MessageBox.Show("Адрес удален!");
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            UpdateDB();
        }

        private void UpdateInfo(object sender, RoutedEventArgs e)
        {
            UpdateDB();
        }

        private void ChangeDB(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (lastChoosen)
                {
                    case "Students":
                        {
                            Student student = new Student();
                            student = (Student)dataTable.SelectedItem;
                            UnitOfWork context = new UnitOfWork();

                            using (UniversityModel db = new UniversityModel())
                            {
                                Student st = db.Students.Where(s => s.StudentID == student.StudentID).First();
                                st.Name = student.Name;
                                st.Surname = student.Surname;
                                st.Patronymic = student.Patronymic;
                                st.Speciality = student.Speciality;
                                st.Birthday = student.Birthday;
                                st.Course = student.Course;
                                st.GroupNumber = student.GroupNumber;
                                st.Gender = student.Gender;
                                st.PhoneNumber = student.PhoneNumber;
                                st.ImageSrc = student.ImageSrc;
                                // db.SaveChanges();

                                context.StudentRepository.Update(st);
                                context.Save();

                                MessageBox.Show("Студент изменен!");
                            }
                            break;
                        }
                    case "Addresses":
                        {
                            Address address = new Address();
                            address = (Address)dataTable.SelectedItem;
                            UnitOfWork context = new UnitOfWork();

                            using (UniversityModel db = new UniversityModel())
                            {
                                Address ad = db.Addresses.Where(a => a.ID == a.ID).First();
                                ad.ID = address.ID;
                                ad.Street = address.Street;
                                ad.City = address.City;
                                ad.C_Index = address.C_Index;
                                ad.Home = address.Home;
                                // db.SaveChanges();
                                
                                context.AddressRepository.Update(ad);
                                context.Save();

                                MessageBox.Show("Адрес изменен!");
                            }
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            UpdateDB();
        }

        private void CBTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateDB();
        }
    }
}
