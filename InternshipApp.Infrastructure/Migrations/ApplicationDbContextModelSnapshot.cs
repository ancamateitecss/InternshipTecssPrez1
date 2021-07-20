﻿// <auto-generated />
using System;
using InternshipApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InternshipApp.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InternshipApp.Domain.Entities.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("InternshipApp.Domain.Entities.MusicType", b =>
                {
                    b.Property<int>("MusicTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("MusicTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MusicTypeID");

                    b.HasIndex("EventId");

                    b.ToTable("MusicTypes");
                });

            modelBuilder.Entity("InternshipApp.Domain.Entities.MusicType", b =>
                {
                    b.HasOne("InternshipApp.Domain.Entities.Event", null)
                        .WithMany("MusicTypes")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InternshipApp.Domain.Entities.Event", b =>
                {
                    b.Navigation("MusicTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
