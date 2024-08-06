﻿// <auto-generated />
using System;
using Horizon_HR.AppDataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Horizon_HR.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Horizon_HR.Models.BankAccount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("account_number");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("bank_name");

                    b.Property<string>("HolderName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("holder_name");

                    b.Property<string>("Iban")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("iban");

                    b.HasKey("Id");

                    b.ToTable("bank_accounts", (string)null);
                });

            modelBuilder.Entity("Horizon_HR.Models.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("departments", (string)null);
                });

            modelBuilder.Entity("Horizon_HR.Models.EmploymentDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("ContractType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("contract_type");

                    b.Property<string>("EmployeeType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("employee_type");

                    b.Property<string>("EmploymentStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("employment_status");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("end_date");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("joining_date");

                    b.Property<Guid>("PositionId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("position_id");

                    b.Property<string>("ProbationPeriod")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("probation_period");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("salary");

                    b.Property<Guid>("TeamId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("team_id");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.HasIndex("TeamId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("employment_details", (string)null);
                });

            modelBuilder.Entity("Horizon_HR.Models.Position", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("description");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("positions", (string)null);
                });

            modelBuilder.Entity("Horizon_HR.Models.Team", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("department_id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("teams", (string)null);
                });

            modelBuilder.Entity("Horizon_HR.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("address");

                    b.Property<Guid>("BankAccountId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("bank_account_id");

                    b.Property<string>("Cin")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("cin");

                    b.Property<string>("CnssRegistrationNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("cnss_registration_number");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Cv")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("cv");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("MaritalStatus")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("marital_status");

                    b.Property<string>("PersonalEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("personal_email");

                    b.Property<string>("PersonalPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("personal_phone");

                    b.Property<string>("ProfessionalEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("professional_email");

                    b.Property<string>("ProfileImage")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("profile_image");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.HasIndex("BankAccountId")
                        .IsUnique();

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("Horizon_HR.Models.EmploymentDetails", b =>
                {
                    b.HasOne("Horizon_HR.Models.Position", "Position")
                        .WithMany("EmploymentsDetails")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Horizon_HR.Models.Team", "Team")
                        .WithMany("EmploymentsDetails")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Horizon_HR.Models.User", "User")
                        .WithOne("EmploymentDetails")
                        .HasForeignKey("Horizon_HR.Models.EmploymentDetails", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Position");

                    b.Navigation("Team");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Horizon_HR.Models.Team", b =>
                {
                    b.HasOne("Horizon_HR.Models.Department", "Department")
                        .WithMany("Teams")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Horizon_HR.Models.User", b =>
                {
                    b.HasOne("Horizon_HR.Models.BankAccount", "BankAccount")
                        .WithOne("User")
                        .HasForeignKey("Horizon_HR.Models.User", "BankAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BankAccount");
                });

            modelBuilder.Entity("Horizon_HR.Models.BankAccount", b =>
                {
                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("Horizon_HR.Models.Department", b =>
                {
                    b.Navigation("Teams");
                });

            modelBuilder.Entity("Horizon_HR.Models.Position", b =>
                {
                    b.Navigation("EmploymentsDetails");
                });

            modelBuilder.Entity("Horizon_HR.Models.Team", b =>
                {
                    b.Navigation("EmploymentsDetails");
                });

            modelBuilder.Entity("Horizon_HR.Models.User", b =>
                {
                    b.Navigation("EmploymentDetails")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
