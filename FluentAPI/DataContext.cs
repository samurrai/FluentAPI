namespace FluentAPI
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("_users");

            modelBuilder.Entity<User>().Property(user => user.Id).HasColumnName("ID");

            modelBuilder.Entity<User>().HasKey(user => user.Id);

            modelBuilder.Entity<User>().Property(user => user.Login).HasColumnName("login").IsRequired();

            modelBuilder.Entity<User>().Property(user => user.Password).HasColumnName("passw").IsRequired();

            //modelBuilder.Entity<User>().HasMany(user => user.Orders).WithRequired(order => order.User);

            base.OnModelCreating(modelBuilder);

        }
    }
}
