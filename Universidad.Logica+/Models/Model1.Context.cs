//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Universidad.Logica_.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UniversityEntities : DbContext
    {
        public UniversityEntities()
            : base("name=UniversityEntities")
        {
        }
        private static UniversityEntities universityEntities = null;
        //si ya tiene un valor ya intanciada , ya no crea una 
        public static UniversityEntities create()
        {
            if (universityEntities == null)
                universityEntities = new UniversityEntities();

            return universityEntities;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<OfficeAssignment> OfficeAssignment { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Enrollment> Enrollment { get; set; }
    }
}
