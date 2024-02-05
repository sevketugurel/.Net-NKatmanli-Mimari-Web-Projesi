    using EntityLayer.Concrete;
    using Microsoft.EntityFrameworkCore;

    namespace DataAccessLayer.Concrete
    {
        public class Context:DbContext
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
               
                optionsBuilder.UseSqlServer(@"Server=127.0.0.1,1433; Database=DBNewOOP; User Id=SA; Password=reallyStrongPwd123;TrustServerCertificate=true");

            }
            public DbSet<Product> Products { get; set; }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Category> Categories { get; set; }
        }
    }