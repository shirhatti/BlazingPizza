﻿// <auto-generated />
using System;
using BlazingPizza.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazingPizza.Migrations
{
    [DbContext(typeof(PizzaStoreContext))]
    [Migration("20190501211429_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview5.19227.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlazingPizza.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("UserId");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BlazingPizza.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId");

                    b.Property<int>("Size");

                    b.Property<int>("SpecialId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("SpecialId");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("BlazingPizza.PizzaSpecial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BasePrice");

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Specials");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BasePrice = 9.99m,
                            Description = "It's cheesy and delicious. Why wouldn't you want one?",
                            ImageUrl = "img/pizzas/cheese.jpg",
                            Name = "Basic Cheese Pizza"
                        },
                        new
                        {
                            Id = 2,
                            BasePrice = 11.99m,
                            Description = "It has EVERY kind of bacon",
                            ImageUrl = "img/pizzas/bacon.jpg",
                            Name = "The Baconatorizor"
                        },
                        new
                        {
                            Id = 3,
                            BasePrice = 10.50m,
                            Description = "It's the pizza you grew up with, but Blazing hot!",
                            ImageUrl = "img/pizzas/pepperoni.jpg",
                            Name = "Classic pepperoni"
                        },
                        new
                        {
                            Id = 4,
                            BasePrice = 12.75m,
                            Description = "Spicy chicken, hot sauce and bleu cheese, guaranteed to warm you up",
                            ImageUrl = "img/pizzas/meaty.jpg",
                            Name = "Buffalo chicken"
                        },
                        new
                        {
                            Id = 5,
                            BasePrice = 11.00m,
                            Description = "It has mushrooms. Isn't that obvious?",
                            ImageUrl = "img/pizzas/mushroom.jpg",
                            Name = "Mushroom Lovers"
                        },
                        new
                        {
                            Id = 6,
                            BasePrice = 10.25m,
                            Description = "When in London...",
                            ImageUrl = "img/pizzas/brit.jpg",
                            Name = "The Brit"
                        },
                        new
                        {
                            Id = 7,
                            BasePrice = 11.50m,
                            Description = "It's like salad, but on a pizza",
                            ImageUrl = "img/pizzas/salad.jpg",
                            Name = "Veggie Delight"
                        },
                        new
                        {
                            Id = 8,
                            BasePrice = 9.99m,
                            Description = "Traditional Italian pizza with tomatoes and basil",
                            ImageUrl = "img/pizzas/margherita.jpg",
                            Name = "Margherita"
                        });
                });

            modelBuilder.Entity("BlazingPizza.PizzaTopping", b =>
                {
                    b.Property<int>("PizzaId");

                    b.Property<int>("ToppingId");

                    b.HasKey("PizzaId", "ToppingId");

                    b.HasIndex("ToppingId");

                    b.ToTable("PizzaTopping");
                });

            modelBuilder.Entity("BlazingPizza.Topping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("Toppings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Extra cheese",
                            Price = 2.50m
                        },
                        new
                        {
                            Id = 2,
                            Name = "American bacon",
                            Price = 2.99m
                        },
                        new
                        {
                            Id = 3,
                            Name = "British bacon",
                            Price = 2.99m
                        },
                        new
                        {
                            Id = 4,
                            Name = "Canadian bacon",
                            Price = 2.99m
                        },
                        new
                        {
                            Id = 5,
                            Name = "Tea and crumpets",
                            Price = 5.00m
                        },
                        new
                        {
                            Id = 6,
                            Name = "Fresh-baked scones",
                            Price = 4.50m
                        },
                        new
                        {
                            Id = 7,
                            Name = "Bell peppers",
                            Price = 1.00m
                        },
                        new
                        {
                            Id = 8,
                            Name = "Onions",
                            Price = 1.00m
                        },
                        new
                        {
                            Id = 9,
                            Name = "Mushrooms",
                            Price = 1.00m
                        },
                        new
                        {
                            Id = 10,
                            Name = "Pepperoni",
                            Price = 1.00m
                        },
                        new
                        {
                            Id = 11,
                            Name = "Duck sausage",
                            Price = 3.20m
                        },
                        new
                        {
                            Id = 12,
                            Name = "Venison meatballs",
                            Price = 2.50m
                        },
                        new
                        {
                            Id = 13,
                            Name = "Served on a silver platter",
                            Price = 250.99m
                        },
                        new
                        {
                            Id = 14,
                            Name = "Lobster on top",
                            Price = 64.50m
                        },
                        new
                        {
                            Id = 15,
                            Name = "Sturgeon caviar",
                            Price = 101.75m
                        },
                        new
                        {
                            Id = 16,
                            Name = "Artichoke hearts",
                            Price = 3.40m
                        },
                        new
                        {
                            Id = 17,
                            Name = "Fresh tomatos",
                            Price = 1.50m
                        },
                        new
                        {
                            Id = 18,
                            Name = "Basil",
                            Price = 1.50m
                        },
                        new
                        {
                            Id = 19,
                            Name = "Steak (medium-rare)",
                            Price = 8.50m
                        },
                        new
                        {
                            Id = 20,
                            Name = "Blazing hot peppers",
                            Price = 4.20m
                        },
                        new
                        {
                            Id = 21,
                            Name = "Buffalo chicken",
                            Price = 5.00m
                        },
                        new
                        {
                            Id = 22,
                            Name = "Blue cheese",
                            Price = 2.50m
                        });
                });

            modelBuilder.Entity("BlazingPizza.Order", b =>
                {
                    b.OwnsOne("BlazingPizza.LatLong", "DeliveryLocation", b1 =>
                        {
                            b1.Property<int>("OrderId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<double>("Latitude");

                            b1.Property<double>("Longitude");

                            b1.HasKey("OrderId");

                            b1.ToTable("Orders");

                            b1.WithOwner()
                                .HasForeignKey("OrderId");
                        });
                });

            modelBuilder.Entity("BlazingPizza.Pizza", b =>
                {
                    b.HasOne("BlazingPizza.Order", null)
                        .WithMany("Pizzas")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazingPizza.PizzaSpecial", "Special")
                        .WithMany()
                        .HasForeignKey("SpecialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlazingPizza.PizzaTopping", b =>
                {
                    b.HasOne("BlazingPizza.Pizza", null)
                        .WithMany("Toppings")
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazingPizza.Topping", "Topping")
                        .WithMany()
                        .HasForeignKey("ToppingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
