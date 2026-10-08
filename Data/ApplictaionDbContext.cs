namespace HospitalSystem.Data
{
    public class ApplictaionDbContext : DbContext
    {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.; initial catalog = HospitalDB; Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");


        }
     
    }
}
