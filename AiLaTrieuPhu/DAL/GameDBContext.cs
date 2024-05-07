using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiLaTrieuPhu.DAL
{
    internal class GameDBContext : DbContext // Tạo ra để thực hiện kết nối và thao các trên DB thông qua EFCore
    {
        public GameDBContext() { }
        public GameDBContext(DbContextOptions options) : base(options) { }
        public DbSet<Question> Questions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-I6GJF6D7;Initial Catalog=ALTP_data;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
