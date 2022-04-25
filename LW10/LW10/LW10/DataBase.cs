using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LW10
{
    public class DataBase
    {
        string connectionString;
        private SqlConnection connection;

        public DataBase()
        {
            connectionString = "Server=.;Database=universityDB;Encrypt=False;Trusted_Connection=True";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public void Dispose()
        {
            if (connection != null)
                connection.Close();
        }

        public void AddStudent(Student s)
        {
            string sqlStudent = $"INSERT INTO Students(AddressID, Name, Surname, Patronymic, Speciality, Birthday, Course, GroupNumber, Gender, PhoneNumber, ImageSrc) " +
                $"VALUES({s.ID}, '{s.Name}', '{s.Surname}', '{s.Patronymic}', '{s.Speciality}', '{s.Birthday}', {s.Course}, {s.Group}, '{s.Gender}', '{s.PhoneNumber}', '{s.ImageSrc}');";
            string sqlAddress = $"INSERT INTO Addresses(ID, City, C_Index, Street, Home) " +
                $"VALUES({s.ID}, '{s.City}', {s.Index}, '{s.Street}', '{s.Home}');";

            SqlTransaction transaction = connection.BeginTransaction();
            SqlCommand commandTrans = connection.CreateCommand();
            commandTrans.Transaction = transaction;

            try
            {
                SqlCommand command2 = new SqlCommand(sqlAddress, connection);
                command2.ExecuteNonQuery();
                SqlCommand command = new SqlCommand(sqlStudent, connection);
                command.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                transaction.Rollback();
            }
        }

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            Student student = new Student();
            string sql = $"SELECT * FROM Students as st INNER JOIN Addresses as adr ON st.AddressID = adr.ID;";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    student = new Student();

                    student.Name = reader["Name"].ToString();
                    student.Surname = reader["Surname"].ToString();
                    student.Patronymic = reader["Patronymic"].ToString();
                    student.Speciality = reader["Speciality"].ToString();
                    student.Birthday = Convert.ToDateTime(reader["Birthday"]);
                    student.Course = Convert.ToInt32(reader["Course"]);
                    student.Group = Convert.ToInt32(reader["GroupNumber"]);
                    student.Gender = reader["Gender"].ToString();
                    student.PhoneNumber = reader["PhoneNumber"].ToString();
                    student.ImageSrc = reader["ImageSrc"].ToString();
                    student.ID = Convert.ToInt32(reader["ID"]);
                    student.Street = reader["Street"].ToString();
                    student.Home = Convert.ToInt32(reader["Home"]);
                    student.City = reader["City"].ToString();
                    student.Index = Convert.ToInt32(reader["C_Index"]);

                    students.Add(student);
                }
            }

            return students;
        }

        public void Update(int id, Student s)
        {
            string sqlStudent = $"UPDATE Students SET Name = '{s.Name}', Surname = '{s.Surname}', Patronymic = '{s.Patronymic}', Speciality = '{s.Speciality}', Birthday = '{s.Birthday}', Course = {s.Course}, GroupNumber = {s.Group}, Gender = '{s.Gender}', PhoneNumber = '{s.PhoneNumber}' WHERE AddressID = {id}";
            string sqlAddress = $"UPDATE Addresses SET City = '{s.City}', C_Index = '{s.Index}', Street = '{s.Street}', Home = '{s.Home}' WHERE ID = {id}";

            //SqlTransaction transaction = connection.BeginTransaction();
            //SqlCommand commandTrans = connection.CreateCommand();
            //commandTrans.Transaction = transaction;

            try
            {
                SqlCommand commandStudent = new SqlCommand(sqlStudent, connection);
                commandStudent.ExecuteNonQuery();

                SqlCommand commandAddrerss = new SqlCommand(sqlAddress, connection);
                commandAddrerss.ExecuteNonQuery();

                //transaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //transaction.Rollback();
            }
        }

        public void Delete(int id)
        {
            string sqlStudent = $"DELETE FROM Students WHERE AddressID = {id}";
            string sqlAddress = $"DELETE FROM Addresses WHERE ID = {id}";

            //SqlTransaction transaction = connection.BeginTransaction();
            //SqlCommand commandTrans = connection.CreateCommand();
            //commandTrans.Transaction = transaction;

            try
            {
                SqlCommand commandStudent = new SqlCommand(sqlStudent, connection);
                commandStudent.ExecuteNonQuery();
                SqlCommand commandAddress = new SqlCommand(sqlAddress, connection);
                commandAddress.ExecuteNonQuery();

                //transaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //transaction.Rollback();
            }
        }

        public List<Student> ExecuteQuery(string query)
        {
            List<Student> list = new List<Student>();
            Student student = new Student();
            string sql = $"{query}";

            try
            {
                SqlCommand commandQuery = new SqlCommand(sql, connection);
                commandQuery.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (query.Split(' ')[0].ToUpper() == "SELECT")
            {
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        student = new Student();

                        student.Name = reader["Name"].ToString();
                        student.Surname = reader["Surname"].ToString();
                        student.Patronymic = reader["Patronymic"].ToString();
                        student.Speciality = reader["Speciality"].ToString();
                        student.Birthday = Convert.ToDateTime(reader["Birthday"]);
                        student.Course = Convert.ToInt32(reader["Course"]);
                        student.Group = Convert.ToInt32(reader["GroupNumber"]);
                        student.Gender = reader["Gender"].ToString();
                        student.PhoneNumber = reader["PhoneNumber"].ToString();
                        student.ImageSrc = reader["ImageSrc"].ToString();
                        student.ID = Convert.ToInt32(reader["ID"]);
                        student.Street = reader["Street"].ToString();
                        student.Home = Convert.ToInt32(reader["Home"]);
                        student.City = reader["City"].ToString();
                        student.Index = Convert.ToInt32(reader["C_Index"]);

                        list.Add(student);
                    }
                }
            }

            return list;
        }
    }
}
