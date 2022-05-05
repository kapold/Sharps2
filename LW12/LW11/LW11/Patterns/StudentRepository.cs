using LW11.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW11.Patterns
{
    public class StudentRepository : IRepository<Student>
    {
        private UniversityModel db;
        
        public StudentRepository(UniversityModel um)
        {
            this.db = um;
        }
        public void Create(Student student)
        {
            db.Students.Add(student);
        }

        public void Delete(int id)
        {
            Student student = db.Students.Find(id);
            if (student != null)
                db.Students.Remove(student);
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Student GetSingle(int id)
        {
            return db.Students.Find(id);
        }

        public IEnumerable<Student> GetList()
        {
            return db.Students;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Student student)
        {
            db.Entry(student).State = EntityState.Modified;
        }
    }
}
