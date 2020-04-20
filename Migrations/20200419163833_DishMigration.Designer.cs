﻿// <auto-generated />
using System;
using ChefsAndDishes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChefsAndDishes.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20200419163833_DishMigration")]
    partial class DishMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ChefsAndDishes.Models.Chef", b =>
                {
                    b.Property<int>("ChefID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("ChefID");

                    b.ToTable("Chefs");
                });

            modelBuilder.Entity("ChefsAndDishes.Models.Dish", b =>
                {
                    b.Property<int>("DishID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Calories");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int?>("CreatorChefID");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("DishName")
                        .IsRequired();

                    b.Property<int>("Tastiness");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("DishID");

                    b.HasIndex("CreatorChefID");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("ChefsAndDishes.Models.Dish", b =>
                {
                    b.HasOne("ChefsAndDishes.Models.Chef", "Creator")
                        .WithMany("CreatedDishes")
                        .HasForeignKey("CreatorChefID");
                });
#pragma warning restore 612, 618
        }
    }
}
