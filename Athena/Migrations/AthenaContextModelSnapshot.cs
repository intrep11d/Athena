﻿// <auto-generated />
using System;
using Athena.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Athena.Migrations
{
    [DbContext(typeof(AthenaContext))]
    partial class AthenaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("Athena.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<int>("Duration")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("CourseId");

                    b.ToTable("Course");
                });
#pragma warning restore 612, 618
        }
    }
}
