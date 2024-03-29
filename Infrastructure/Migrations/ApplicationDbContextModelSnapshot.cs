﻿// <auto-generated />
using System;
using Infrastructure.AppDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domian.Entities.Form", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Language")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Forms");
                });

            modelBuilder.Entity("Domian.Entities.FormElement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ElementLabel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ElementType")
                        .HasColumnType("int");

                    b.Property<string>("ElementValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("FormId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FormId");

                    b.ToTable("FormElements");
                });

            modelBuilder.Entity("Domian.Entities.FormStyle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AlignItems")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BackgroundColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Direction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlexWrap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("FormId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Justify")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MarginBottom")
                        .HasColumnType("int");

                    b.Property<int?>("MarginLeft")
                        .HasColumnType("int");

                    b.Property<int?>("MarginRight")
                        .HasColumnType("int");

                    b.Property<int?>("MarginTop")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FormId")
                        .IsUnique();

                    b.ToTable("FormStyles");
                });

            modelBuilder.Entity("Domian.Entities.FormElement", b =>
                {
                    b.HasOne("Domian.Entities.Form", "FormData")
                        .WithMany("FormElements")
                        .HasForeignKey("FormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FormData");
                });

            modelBuilder.Entity("Domian.Entities.FormStyle", b =>
                {
                    b.HasOne("Domian.Entities.Form", "Form")
                        .WithOne("Style")
                        .HasForeignKey("Domian.Entities.FormStyle", "FormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Form");
                });

            modelBuilder.Entity("Domian.Entities.Form", b =>
                {
                    b.Navigation("FormElements");

                    b.Navigation("Style")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
