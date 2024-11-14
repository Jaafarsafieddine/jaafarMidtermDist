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
    [Migration("20240425214136_Init21333344")]
    partial class Init21333344
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
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Owner")
                        .HasColumnType("int");

                    b.Property<DateTime>("modelYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("person_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("person_id");

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
                    b.HasOne("TrainingForQuiz.Models.Person", "owner")
                        .WithMany("myCars")
                        .HasForeignKey("person_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("owner");
                });

            modelBuilder.Entity("TrainingForQuiz.Models.Person", b =>
                {
                    b.Navigation("myCars");
                });
#pragma warning restore 612, 618
        }
    }
}
