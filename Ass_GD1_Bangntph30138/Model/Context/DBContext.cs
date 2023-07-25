using System;
using System.Collections.Generic;
using Ass_GD1_Bangntph30138.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace Ass_GD1_Bangntph30138.Model.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Grade> Grades { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=BANGCHIU105\\SQLEXPRESS01;Initial Catalog=FPL_DaoTao;Integrated Security=True ;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Grade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Grade__3214EC27F9ACB525");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.MaSvNavigation).WithMany(p => p.Grades).HasConstraintName("FK__Grade__maSV__286302EC");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.MaSv).HasName("PK__Students__7A227A64DAEA549F");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserName).HasName("PK__Users__66DCF95D58F5E645");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
