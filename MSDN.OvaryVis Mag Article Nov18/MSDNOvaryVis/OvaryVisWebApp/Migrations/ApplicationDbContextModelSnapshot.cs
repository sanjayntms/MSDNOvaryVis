﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OvaryVisWebApp.Data;

namespace OvaryVisWebApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OvaryVisWebApp.Models.OvaryVis", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("D1mm");

                    b.Property<int>("D2mm");

                    b.Property<int>("D3mm");

                    b.Property<DateTime>("JobSubmitted");

                    b.Property<int>("ResultVis");

                    b.Property<string>("StatusMsg");

                    b.HasKey("Id");

                    b.ToTable("OvaryVis");
                });
#pragma warning restore 612, 618
        }
    }
}
