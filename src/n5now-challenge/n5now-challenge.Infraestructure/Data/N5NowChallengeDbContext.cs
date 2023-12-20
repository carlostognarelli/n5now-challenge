using Microsoft.EntityFrameworkCore;
using n5now_challenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n5now_challenge.Infraestructure.Data
{
    public partial class N5NowChallengeDbContext : DbContext
    {
        public N5NowChallengeDbContext(DbContextOptions<N5NowChallengeDbContext> options)
            : base(options)
        {

        }

        public DbSet<Permission> Permission { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<PermissionType> PermissionType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Permissi__3214EC07DF392002");

                entity.ToTable("Permission");

                entity.Property(e => e.EndDate).HasColumnType("datetime");
                entity.Property(e => e.RequestedDate).HasColumnType("datetime");
                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Employee).WithMany(p => p.Permissions)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Permissio__Emplo__1AD3FDA4");

                entity.HasOne(d => d.PermissionType).WithMany(p => p.Permissions)
                    .HasForeignKey(d => d.PermissionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Permissio__Permi__19DFD96B");
            });

            modelBuilder.Entity<PermissionType>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Permissi__3214EC0737481691");

                entity.ToTable("PermissionType");

                entity.Property(e => e.Name).HasMaxLength(255);
            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);


    }
}
