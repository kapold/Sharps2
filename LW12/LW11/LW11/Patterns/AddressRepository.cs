using LW11.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW11.Patterns
{
    public class AddressRepository : IRepository<Address>
    {
        private UniversityModel db;
        public AddressRepository(UniversityModel um)
        {
            this.db = um;
        }
        public void Create(Address address)
        {
            db.Addresses.Add(address);
        }

        public void Delete(int id)
        {
            Address address = db.Addresses.Find(id);
            if (address != null)
                db.Addresses.Remove(address);
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

        public Address GetSingle(int id)
        {
            return db.Addresses.Find(id);
        }

        public IEnumerable<Address> GetList()
        {
            return db.Addresses;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Address address)
        {
            db.Entry(address).State = EntityState.Modified;
        }
    }
}
