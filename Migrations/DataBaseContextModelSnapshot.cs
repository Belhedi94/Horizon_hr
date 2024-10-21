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

            modelBuilder.Entity("Horizon_HR.Models.DocumentRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<DateTime>("ProcessedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("processed_at");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("status");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("type");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("document_requests", (string)null);
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

            modelBuilder.Entity("Horizon_HR.Models.JobOffer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("EmploymentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("employment_type");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("location");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("title");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("job_offers", (string)null);
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

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PublicHolidays");

                    b.HasData(
                        new
                        {
                            Id = new Guid("04dd48cf-179c-4ef1-8488-6d3918c8f8e1"),
                            CreatedAt = new DateTime(2024, 10, 20, 12, 48, 26, 941, DateTimeKind.Local).AddTicks(6006),
                            Description = "New year's Day",
                            StartDate = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Paid leave",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("e47152b2-5398-4a86-a751-e482bebce54e"),
                            CreatedAt = new DateTime(2024, 10, 20, 12, 48, 26, 941, DateTimeKind.Local).AddTicks(6081),
                            Description = "Independence Day",
                            StartDate = new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Paid leave",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("e1319b75-85de-4d8c-a57c-c0f4daec2aa3"),
                            CreatedAt = new DateTime(2024, 10, 20, 12, 48, 26, 941, DateTimeKind.Local).AddTicks(6083),
                            Description = "Martyrs' Day",
                            StartDate = new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Paid leave",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("29766219-6811-4cb6-8d72-353155f17f8a"),
                            CreatedAt = new DateTime(2024, 10, 20, 12, 48, 26, 941, DateTimeKind.Local).AddTicks(6085),
                            Description = "Labour Day",
                            StartDate = new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Paid leave",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("174b6938-e6f5-44d7-8fac-d56fc3bc0cc4"),
                            CreatedAt = new DateTime(2024, 10, 20, 12, 48, 26, 941, DateTimeKind.Local).AddTicks(6086),
                            Description = "Republic Day",
                            StartDate = new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Paid leave",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("ba0caff9-aff0-4d34-89a3-305fdbb5e102"),
                            CreatedAt = new DateTime(2024, 10, 20, 12, 48, 26, 941, DateTimeKind.Local).AddTicks(6088),
                            Description = "Women's Day",
                            StartDate = new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Unpaid leave",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("a7b7e333-d525-469c-b015-44ab28e5a752"),
                            CreatedAt = new DateTime(2024, 10, 20, 12, 48, 26, 941, DateTimeKind.Local).AddTicks(6090),
                            Description = "Evacuation Day",
                            StartDate = new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Paid leave",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("ebbe14a7-cc67-4595-99b7-d8a8a451513b"),
                            CreatedAt = new DateTime(2024, 10, 20, 12, 48, 26, 941, DateTimeKind.Local).AddTicks(6091),
                            Description = "Revolution Day",
                            StartDate = new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Paid leave",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("44418b80-0165-4c3b-8ca2-49750e083c3e"),
                            CreatedAt = new DateTime(2024, 10, 20, 12, 48, 26, 941, DateTimeKind.Local).AddTicks(6093),
                            Description = "Eid al-Adha",
                            StartDate = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Paid leave",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("324ca6b0-a1ba-4cfb-b4c0-c8c63f4d6d98"),
                            CreatedAt = new DateTime(2024, 10, 20, 12, 48, 26, 941, DateTimeKind.Local).AddTicks(6097),
                            Description = "Eid al-Fitr",
                            StartDate = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Paid leave",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("ed779d24-3bb0-47d6-b3ab-db04a521c91b"),
                            CreatedAt = new DateTime(2024, 10, 20, 12, 48, 26, 941, DateTimeKind.Local).AddTicks(6099),
                            Description = "Islamic New Year",
                            StartDate = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Unpaid leave",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("08ff24d2-1212-4e7c-85e9-446f0eae4d89"),
                            CreatedAt = new DateTime(2024, 10, 20, 12, 48, 26, 941, DateTimeKind.Local).AddTicks(6101),
                            Description = "Mawlid al-Nabi",
                            StartDate = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Paid leave",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
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

            modelBuilder.Entity("Horizon_HR.Models.DocumentRequest", b =>
                {
                    b.HasOne("Horizon_HR.Models.User", "User")
                        .WithMany("DocumentRequests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
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
                    b.Navigation("DocumentRequests");

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
