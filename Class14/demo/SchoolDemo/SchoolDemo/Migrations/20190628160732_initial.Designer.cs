﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolDemo.Data;

namespace SchoolDemo.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    [Migration("20190628160732_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SchoolDemo.Models.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseCode");

                    b.Property<decimal>("Price");

                    b.Property<int>("Technology");

                    b.HasKey("ID");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("SchoolDemo.Models.Enrollments", b =>
                {
                    b.Property<int>("CourseID");

                    b.Property<int>("StudentID");

                    b.HasKey("CourseID", "StudentID");

                    b.HasIndex("StudentID");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("SchoolDemo.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Birthdate = new DateTime(1988, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jack",
                            LastName = "Shepard"
                        },
                        new
                        {
                            ID = 2,
                            Birthdate = new DateTime(1975, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Kate",
                            LastName = "Austin"
                        },
                        new
                        {
                            ID = 3,
                            Birthdate = new DateTime(1990, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Hugo",
                            LastName = "Reyes"
                        },
                        new
                        {
                            ID = 4,
                            Birthdate = new DateTime(1996, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "James",
                            LastName = "Ford"
                        });
                });

            modelBuilder.Entity("SchoolDemo.Models.Transcripts", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseID");

                    b.Property<int>("Grade");

                    b.Property<bool>("Passed");

                    b.Property<int>("StudentID");

                    b.HasKey("ID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("Transcripts_1");
                });

            modelBuilder.Entity("SchoolDemo.Models.Enrollments", b =>
                {
                    b.HasOne("SchoolDemo.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SchoolDemo.Models.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SchoolDemo.Models.Transcripts", b =>
                {
                    b.HasOne("SchoolDemo.Models.Course", "Course")
                        .WithMany("Transcripts")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SchoolDemo.Models.Student", "Student")
                        .WithMany("Transcripts")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
