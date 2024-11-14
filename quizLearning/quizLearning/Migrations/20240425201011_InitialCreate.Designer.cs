﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using quizLearning;

#nullable disable

namespace quizLearning.Migrations
{
    [DbContext(typeof(DbContext))]
    [Migration("20240425201011_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("quizLearning.Models.Car", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("Personid")
                        .HasColumnType("int");

                    b.Property<string>("modelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("modelYear")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Personid");

                    b.ToTable("car");
                });

            modelBuilder.Entity("quizLearning.Models.Person", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("quizLearning.Models.Car", b =>
                {
                    b.HasOne("quizLearning.Models.Person", null)
                        .WithMany("myCars")
                        .HasForeignKey("Personid");
                });

            modelBuilder.Entity("quizLearning.Models.Person", b =>
                {
                    b.Navigation("myCars");
                });
#pragma warning restore 612, 618
        }
    }
}