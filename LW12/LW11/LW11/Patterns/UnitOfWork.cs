using LW11.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW11.Patterns
{
    public class UnitOfWork : IDisposable
    {
        private UniversityModel context = new UniversityModel();
        private StudentRepository studentRepository;
        private AddressRepository addressRepository;

        public StudentRepository StudentRepository
        {
            get
            {

                if (this.studentRepository == null)
                {
                    this.studentRepository = new StudentRepository(context);
                }
                return studentRepository;
            }
        }

        public AddressRepository AddressRepository
        {
            get
            {

                if (this.addressRepository == null)
                {
                    this.addressRepository = new AddressRepository(context);
                }
                return addressRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
