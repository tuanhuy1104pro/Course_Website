﻿// <auto-generated />
using Infrastrucure.Dbcontext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastrucure.Migrations
{
    [DbContext(typeof(CourseDbcontext))]
    partial class CourseDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CourseEdu_Core.Domain.Model.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "CA834AA4-7F87-4DF5-A29E-A856071BE701",
                            CategoryName = "History"
                        },
                        new
                        {
                            CategoryId = "AE4B2F2E-2C3C-44C6-AB6F-4618254EEF91",
                            CategoryName = "IT"
                        });
                });

            modelBuilder.Entity("CourseEdu_Core.Domain.Model.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CourseDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CoursePrice")
                        .HasColumnType("float");

                    b.HasKey("CourseId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            CategoryId = "CA834AA4-7F87-4DF5-A29E-A856071BE701",
                            CourseDescription = "escriven0",
                            CourseName = "ecollingridge0",
                            CoursePrice = 74.0
                        },
                        new
                        {
                            CourseId = 2,
                            CategoryId = "CA834AA4-7F87-4DF5-A29E-A856071BE701",
                            CourseDescription = "ejeavon1",
                            CourseName = "wgreenstreet1",
                            CoursePrice = 90.0
                        },
                        new
                        {
                            CourseId = 3,
                            CategoryId = "CA834AA4-7F87-4DF5-A29E-A856071BE701",
                            CourseDescription = "cprendergast2",
                            CourseName = "hhockey2",
                            CoursePrice = 76.0
                        },
                        new
                        {
                            CourseId = 4,
                            CategoryId = "AE4B2F2E-2C3C-44C6-AB6F-4618254EEF91",
                            CourseDescription = "mbuckleigh3",
                            CourseName = "kfaichnie3",
                            CoursePrice = 24.0
                        },
                        new
                        {
                            CourseId = 5,
                            CategoryId = "AE4B2F2E-2C3C-44C6-AB6F-4618254EEF91",
                            CourseDescription = "nwholesworth4",
                            CourseName = "pchristofle4",
                            CoursePrice = 64.0
                        },
                        new
                        {
                            CourseId = 6,
                            CategoryId = "AE4B2F2E-2C3C-44C6-AB6F-4618254EEF91",
                            CourseDescription = "emilier5",
                            CourseName = "lcovelle5",
                            CoursePrice = 95.0
                        },
                        new
                        {
                            CourseId = 7,
                            CategoryId = "CA834AA4-7F87-4DF5-A29E-A856071BE701",
                            CourseDescription = "rheino6",
                            CourseName = "dfranzel6",
                            CoursePrice = 86.0
                        });
                });

            modelBuilder.Entity("CourseEdu_Core.Domain.Model.Course", b =>
                {
                    b.HasOne("CourseEdu_Core.Domain.Model.Category", "Category")
                        .WithMany("Courses")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CourseEdu_Core.Domain.Model.Category", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}