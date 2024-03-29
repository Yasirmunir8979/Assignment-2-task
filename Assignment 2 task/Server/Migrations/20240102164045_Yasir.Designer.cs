﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment2task.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240102164045_Yasir")]
    partial class Yasir
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Assignment_2_task.Shared.Shared.DiabetesInput", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<double>("BMI")
                        .HasColumnType("float");

                    b.Property<double>("BloodGlucose")
                        .HasColumnType("float");

                    b.Property<double>("HbA1cLevel")
                        .HasColumnType("float");

                    b.Property<bool>("HeartDisease")
                        .HasColumnType("bit");

                    b.Property<bool>("Hypertension")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("DiabetesInputs");
                });
#pragma warning restore 612, 618
        }
    }
}
