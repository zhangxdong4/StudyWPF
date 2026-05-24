using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Entities
{
    public class SchoolTimeDbContext : DbContext
    {/* optionsBuilder.UseSqlite("Data Source=schooltime.db");*/
        /// <summary>
        /// 数据库文件路径
        /// </summary>
        string _DatabasePath;
        public SchoolTimeDbContext()
        {
            // 获取当前应用程序的基目录，并将数据库文件名附加到该路径上
            _DatabasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "schooltime.db");
           
        }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Curricula> Curriculas { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={_DatabasePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.ToTable("Schedules");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Session).IsRequired().HasMaxLength(50);
                entity.Property(e => e.TimeSegment).IsRequired().HasMaxLength(50);
            });
            modelBuilder.Entity<Curricula>(entity =>
            {
                entity.ToTable("Curriculas");
                entity.HasKey(e => e.Id);
                entity.HasOne(e => e.Scheduley)
                      .WithMany()
                      .HasForeignKey(e => e.ScheduleId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
