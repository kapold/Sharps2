using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SampleMVVM.Models
{
    public partial class MedicineModel : DbContext
    {
        public MedicineModel() : base("name=MedicineContext")
        { }

        public virtual DbSet<Doctor> Doctors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        { }
    }
}
