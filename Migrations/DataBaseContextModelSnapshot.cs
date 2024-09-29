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

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("HolderName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("holder_name");

                    b.Property<string>("Rib")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("rib");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

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

                    b.Property<string>("EmploymentType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("employment_type");

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

            modelBuilder.Entity("Horizon_HR.Models.LeaveBalance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Annual")
                        .HasColumnType("float")
                        .HasColumnName("annual");

                    b.Property<double>("Sick")
                        .HasColumnType("float")
                        .HasColumnName("sick");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("leave_balances", (string)null);
                });

            modelBuilder.Entity("Horizon_HR.Models.LeaveRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("end_date");

                    b.Property<bool>("IsHalfDay")
                        .HasColumnType("bit")
                        .HasColumnName("is_half_day");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("reason");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("start_date");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("status");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("type");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("leave_requests", (string)null);
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

            modelBuilder.Entity("Horizon_HR.Models.PublicHoliday", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PublicHolidays");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9644258c-4136-4099-a54d-f12ec3bf2558"),
                            Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "New year's Day"
                        },
                        new
                        {
                            Id = new Guid("3dd0c6d6-d12b-406d-be6e-de34a30738cf"),
                            Date = new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Independence Day"
                        },
                        new
                        {
                            Id = new Guid("5607434f-613a-410e-ad57-f10a3b2a2663"),
                            Date = new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Martyrs' Day"
                        },
                        new
                        {
                            Id = new Guid("2a1bd0e0-77e1-4d76-9f59-c1e3a1bc6d3e"),
                            Date = new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Labour Day"
                        },
                        new
                        {
                            Id = new Guid("90b0a845-8c18-486e-93c9-79d0136e3ca9"),
                            Date = new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Republic Day"
                        },
                        new
                        {
                            Id = new Guid("1691eba7-9a9f-4219-b8c8-7160ddf5450a"),
                            Date = new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Women's Day"
                        },
                        new
                        {
                            Id = new Guid("0b360352-77bd-4a7f-89d8-13aa63e60cb5"),
                            Date = new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Evacuation Day"
                        },
                        new
                        {
                            Id = new Guid("c3567d7d-c627-4044-bea6-18552f2c9078"),
                            Date = new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Revolution Day"
                        });
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

                    b.Property<Guid?>("BankAccountId")
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

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("first_name");

                    b.Property<int>("Gender")
                        .HasMaxLength(10)
                        .HasColumnType("int")
                        .HasColumnName("gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("last_name");

                    b.Property<int>("MaritalStatus")
                        .HasMaxLength(20)
                        .HasColumnType("int")
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

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("status");

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
                        .IsUnique()
                        .HasFilter("[bank_account_id] IS NOT NULL");

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

            modelBuilder.Entity("Horizon_HR.Models.LeaveBalance", b =>
                {
                    b.HasOne("Horizon_HR.Models.User", "User")
                        .WithOne("LeaveBalance")
                        .HasForeignKey("Horizon_HR.Models.LeaveBalance", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Horizon_HR.Models.LeaveRequest", b =>
                {
                    b.HasOne("Horizon_HR.Models.User", "User")
                        .WithMany("LeaveRequests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
                        .HasForeignKey("Horizon_HR.Models.User", "BankAccountId");

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

                    b.Navigation("LeaveBalance")
                        .IsRequired();

                    b.Navigation("LeaveRequests");
                });
#pragma warning restore 612, 618
        }
    }
}
