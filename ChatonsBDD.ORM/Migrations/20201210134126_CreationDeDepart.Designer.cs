﻿// <auto-generated />
using System;
using ChatonsBDD.ORM;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChatonsBDD.ORM.Migrations
{
    [DbContext(typeof(Contexte))]
    [Migration("20201210134126_CreationDeDepart")]
    partial class CreationDeDepart
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("ChatonsBDD.ORM.Chaton", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DateDeNaissance")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("EstUneFemelle")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nom")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<bool?>("Sterilise")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Chatons");
                });
#pragma warning restore 612, 618
        }
    }
}
