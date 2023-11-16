using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace connectwithentity.Models;

public partial class BookdbContext : DbContext
{
    public BookdbContext()
    {
    }

    public BookdbContext(DbContextOptions<BookdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<GetDatum> GetData { get; set; }

    public virtual DbSet<Salesperson> Salespersons { get; set; }

    public virtual DbSet<TblAudit> TblAudits { get; set; }

    public virtual DbSet<TblBook> TblBooks { get; set; }

    public virtual DbSet<TblCourse> TblCourses { get; set; }

    public virtual DbSet<TblCustomer> TblCustomers { get; set; }

    public virtual DbSet<TblOrder> TblOrders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-PP0TB7N;Initial Catalog=BOOKDB;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("address");

            entity.Property(e => e.AddressId).HasColumnName("address_id");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.SalespersonId).HasColumnName("salesperson_id");
            entity.Property(e => e.State)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("state");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("department");

            entity.Property(e => e.DepartmentName).HasMaxLength(200);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__employee__3213E83F75824193");

            entity.ToTable("employee");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EmpID");
            entity.Property(e => e.Employeename)
                .HasMaxLength(200)
                .HasColumnName("employeename");
            entity.Property(e => e.Salary).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<GetDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GetData");

            entity.Property(e => e.City)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.State)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("state");
        });

        modelBuilder.Entity<Salesperson>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("salespersons", tb => tb.HasTrigger("trg_sales"));

            entity.HasIndex(e => e.SalespersonId, "ind_sales");

            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.SalespersonId).HasColumnName("salesperson_id");
        });

        modelBuilder.Entity<TblAudit>(entity =>
        {
            entity.ToTable("tblAudit");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(50);
        });

        modelBuilder.Entity<TblBook>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblBook");

            entity.Property(e => e.BookName).HasMaxLength(200);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<TblCourse>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblCourse");

            entity.Property(e => e.CourseName).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblCustomer");

            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.ContactName).HasMaxLength(50);
            entity.Property(e => e.CustomerName).HasMaxLength(50);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<TblOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblOrders");

            entity.Property(e => e.EmlopyeeId).HasColumnName("EmlopyeeID");
            entity.Property(e => e.OrderDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OrderId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("OrderID");
            entity.Property(e => e.ShipperId).HasColumnName("ShipperID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
