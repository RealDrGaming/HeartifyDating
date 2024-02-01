﻿// <auto-generated />
using HeartifyDating.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HeartifyDating.Infrastructure.Migrations
{
    [DbContext(typeof(HeartifyDatingDbContext))]
    partial class HeartifyDatingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HeartifyDating.Infrastructure.Data.Models.PersonProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Person Unique Identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int")
                        .HasComment("Person Age");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasComment("Person Description");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Person First Name");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasComment("Person Sexual Orientation");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Person Last Name");

                    b.Property<string>("ProfileImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Person Profile Picture");

                    b.Property<string>("RandomPicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Person Random Picture");

                    b.Property<string>("RelationshipType")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("Wanted Relationship Type");

                    b.Property<string>("UsernamePicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Person Username Picture");

                    b.Property<string>("WantedGender")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasComment("Seuxal Orientation of Wanted Person");

                    b.HasKey("Id");

                    b.ToTable("PersonProfiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 22,
                            Description = "Fit, strong, tall, rich, looking for ma queen.",
                            FirstName = "Alejandro",
                            Gender = "Male",
                            LastName = "Himenez",
                            ProfileImage = "",
                            RandomPicture = "",
                            RelationshipType = "Love",
                            UsernamePicture = "",
                            WantedGender = "Female"
                        },
                        new
                        {
                            Id = 2,
                            Age = 18,
                            Description = "Biggest ass in town, looking for multiple partners that don't have a problem to be in open relationships.",
                            FirstName = "Hristina",
                            Gender = "Female",
                            LastName = "Petkova",
                            ProfileImage = "",
                            RandomPicture = "",
                            RelationshipType = "Open",
                            UsernamePicture = "",
                            WantedGender = "Male"
                        },
                        new
                        {
                            Id = 3,
                            Age = 27,
                            Description = "Im just a gay dude looking for hook-ups and sex.",
                            FirstName = "Alek",
                            Gender = "Male",
                            LastName = "Ritaro",
                            ProfileImage = "",
                            RandomPicture = "",
                            RelationshipType = "Aromantical",
                            UsernamePicture = "",
                            WantedGender = "Male"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
