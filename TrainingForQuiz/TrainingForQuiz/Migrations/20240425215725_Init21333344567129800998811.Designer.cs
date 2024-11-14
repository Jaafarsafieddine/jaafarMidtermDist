﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrainingForQuiz;

#nullable disable

namespace TrainingForQuiz.Migrations
{
    [DbContext(typeof(AppDBcontext))]
    [Migration("20240425215725_Init21333344567129800998811")]
    partial class Init21333344567129800998811
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TrainingForQuiz.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ModelYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("person_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("person_Id");

                    b.ToTable("car");
                });

            modelBuilder.Entity("TrainingForQuiz.Models.Person", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("TrainingForQuiz.Models.Car", b =>
                {
                    b.HasOne("TrainingForQuiz.Models.Person", "person")
                        .WithMany("myCars")
                        .HasForeignKey("person_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("person");
                });

            modelBuilder.Entity("TrainingForQuiz.Models.Person", b =>
                {
                    b.Navigation("myCars");
                });
#pragma warning restore 612, 618
        }
    }
}
