// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcProyekt_.Net_5.DAL.DatabaseContext;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MvcProyekt_.Net_5.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220908081904_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("MvcProyekt_.Net_5.Entities.Chart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("count")
                        .HasColumnType("integer");

                    b.Property<string>("proname")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Charts");
                });

            modelBuilder.Entity("MvcProyekt_.Net_5.Entities.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DepartmentName")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("MvcProyekt_.Net_5.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateofBirth")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("integer");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("text");

                    b.Property<string>("EmployeeSurname")
                        .HasColumnType("text");

                    b.Property<string>("ImagePath")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("PositionId")
                        .HasColumnType("integer");

                    b.Property<double>("Salary")
                        .HasColumnType("double precision");

                    b.Property<int>("SectorId")
                        .HasColumnType("integer");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("PositionId");

                    b.HasIndex("SectorId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("MvcProyekt_.Net_5.Entities.Month", b =>
                {
                    b.Property<int>("MonthId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("MonthName")
                        .HasColumnType("text");

                    b.HasKey("MonthId");

                    b.ToTable("Months");
                });

            modelBuilder.Entity("MvcProyekt_.Net_5.Entities.Position", b =>
                {
                    b.Property<int>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("PositionName")
                        .HasColumnType("text");

                    b.HasKey("PositionId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("MvcProyekt_.Net_5.Entities.Salarys", b =>
                {
                    b.Property<int>("SalaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("MonthId")
                        .HasColumnType("integer");

                    b.Property<double>("Salary")
                        .HasColumnType("double precision");

                    b.Property<int>("YearId")
                        .HasColumnType("integer");

                    b.HasKey("SalaryId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("MonthId");

                    b.HasIndex("YearId");

                    b.ToTable("Salariys");
                });

            modelBuilder.Entity("MvcProyekt_.Net_5.Entities.Sector", b =>
                {
                    b.Property<int>("SectorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("SectorName")
                        .HasColumnType("text");

                    b.HasKey("SectorId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Sectors");
                });

            modelBuilder.Entity("MvcProyekt_.Net_5.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MvcProyekt_.Net_5.Entities.Years", b =>
                {
                    b.Property<int>("YearId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("YearId");

                    b.ToTable("Years");
                });

            modelBuilder.Entity("MvcProyekt_.Net_5.Entities.Employee", b =>
                {
                    b.HasOne("MvcProyekt_.Net_5.Entities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MvcProyekt_.Net_5.Entities.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MvcProyekt_.Net_5.Entities.Sector", "Sector")
                        .WithMany()
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Position");

                    b.Navigation("Sector");
                });

            modelBuilder.Entity("MvcProyekt_.Net_5.Entities.Salarys", b =>
                {
                    b.HasOne("MvcProyekt_.Net_5.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MvcProyekt_.Net_5.Entities.Month", "Month")
                        .WithMany()
                        .HasForeignKey("MonthId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MvcProyekt_.Net_5.Entities.Years", "Year")
                        .WithMany()
                        .HasForeignKey("YearId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Month");

                    b.Navigation("Year");
                });

            modelBuilder.Entity("MvcProyekt_.Net_5.Entities.Sector", b =>
                {
                    b.HasOne("MvcProyekt_.Net_5.Entities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}
