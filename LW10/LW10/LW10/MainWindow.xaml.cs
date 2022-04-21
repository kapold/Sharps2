using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
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

namespace LW10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow mainForm;
        public static List<Student> students = new List<Student>();
        public string connectionString = "Server=.;Database=universityDB;Encrypt=False;Trusted_Connection=True";
        public int currentTableID;
        public MainWindow()
        {
            InitializeComponent();
            mainForm = this;

            DbConnection db = new SqlConnection(connectionString);
            try
            {
                db.Open();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);

                //string createSql = "CREATE DATABASE universityDB;";
                //SqlConnection connection = new SqlConnection(connectionString);
                //SqlCommand createDBCommand = new SqlCommand(createSql, connection);
                //createDBCommand.ExecuteNonQuery();
            }

            DataBase dataBase = new DataBase();
            students = dataBase.GetStudents();
            dataBase.Dispose();

            this.DataContext = this;
            OutputStudents(students);
        }

        public void OutputStudents(List<Student> l)
        {
            dataTable.ItemsSource = null;
            dataTable.ItemsSource = l;
        }

        private void AddStudent(object sender, RoutedEventArgs e)
        {
            AddStudentWnd addStudentWnd = new AddStudentWnd();
            addStudentWnd.Show();
        }

        private void DeleteStudent(object sender, RoutedEventArgs e)
        {
            DataBase dataBase = new DataBase();
            dataBase.Delete(currentTableID);
            dataBase.Dispose();

            //MessageBox.Show(currentTableID.ToString());
            ShowStudents(sender, e);
        }

        private void ChangeStudent(object sender, RoutedEventArgs e)
        {
            Student student = (Student) dataTable.SelectedItem;
            int AddressID = Convert.ToInt32(student.ID);
            MessageBox.Show(student.ToString());
            MessageBox.Show(AddressID.ToString());

            DataBase dataBase = new DataBase();
            dataBase.Update(AddressID, student);
            dataBase.Dispose();
            ShowStudents(sender, e);
        }

        private void ShowStudents(object sender, RoutedEventArgs e)
        {
            DataBase dataBase = new DataBase();
            students = dataBase.GetStudents();
            dataBase.Dispose();

            //foreach (Student s in students)
            //{
            //    MessageBox.Show(s.ToString());
            //}
            OutputStudents(students);
        }

        private void dataTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataTable.SelectedItem != null)
            {
                var a = dataTable.SelectedItem as Student;
                currentTableID = Convert.ToInt32(a.ID);
            }
        }

        private void MoveRight_Table(object sender, RoutedEventArgs e)
        {
            if(dataTable.SelectedIndex != dataTable.Items.Count - 1)
            {
                dataTable.SelectedIndex++;
            }
        }

        private void MoveLeft_Table(object sender, RoutedEventArgs e)
        {
            if (dataTable.SelectedIndex != 0)
            {
                dataTable.SelectedIndex--;
            }
        }

        private void OkQuery_Click(object sender, RoutedEventArgs e)
        {
            string query = QTB.Text;
            DataBase dataBase = new DataBase();
            dataBase.ExecuteQuery(query);
            dataBase.Dispose();
        }

        private void Query_Click(object sender, RoutedEventArgs e)
        {
            QueryPopUp.IsOpen = true;
        }

        private void CloseQuery_Click(object sender, RoutedEventArgs e)
        {
            QueryPopUp.IsOpen = false;
        }
    }
}
