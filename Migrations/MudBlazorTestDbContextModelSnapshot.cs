﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MudBlazorTest.Data;

#nullable disable

namespace MudBlazorTest.Migrations
{
    [DbContext(typeof(MudBlazorTestDbContext))]
    partial class MudBlazorTestDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("IngredientRecipe", b =>
                {
                    b.Property<int>("IngredientsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RecipesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("IngredientsId", "RecipesId");

                    b.HasIndex("RecipesId");

                    b.ToTable("IngredientRecipe");
                });

            modelBuilder.Entity("MudBlazorTest.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MudBlazorTest.Model.Dish", b =>
                {
                    b.Property<int>("MealId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RecipeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MealId", "RecipeId");

                    b.HasIndex("RecipeId");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("MudBlazorTest.Model.Friend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Friends");
                });

            modelBuilder.Entity("MudBlazorTest.Model.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("MudBlazorTest.Model.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("MudBlazorTest.Model.Presence", b =>
                {
                    b.Property<int>("MealId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FriendId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MealId", "FriendId");

                    b.HasIndex("FriendId");

                    b.ToTable("Presences");
                });

            modelBuilder.Entity("MudBlazorTest.Model.Recipe", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("IngredientRecipe", b =>
                {
                    b.HasOne("MudBlazorTest.Model.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MudBlazorTest.Model.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MudBlazorTest.Model.Dish", b =>
                {
                    b.HasOne("MudBlazorTest.Model.Meal", "Meal")
                        .WithMany("Dishes")
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MudBlazorTest.Model.Recipe", "Recipe")
                        .WithMany("Dishes")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meal");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("MudBlazorTest.Model.Presence", b =>
                {
                    b.HasOne("MudBlazorTest.Model.Friend", "Friend")
                        .WithMany("Presences")
                        .HasForeignKey("FriendId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MudBlazorTest.Model.Meal", "Meal")
                        .WithMany("Presences")
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Friend");

                    b.Navigation("Meal");
                });

            modelBuilder.Entity("MudBlazorTest.Model.Recipe", b =>
                {
                    b.HasOne("MudBlazorTest.Model.Category", "Category")
                        .WithMany("Recipes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MudBlazorTest.Model.Category", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("MudBlazorTest.Model.Friend", b =>
                {
                    b.Navigation("Presences");
                });

            modelBuilder.Entity("MudBlazorTest.Model.Meal", b =>
                {
                    b.Navigation("Dishes");

                    b.Navigation("Presences");
                });

            modelBuilder.Entity("MudBlazorTest.Model.Recipe", b =>
                {
                    b.Navigation("Dishes");
                });
#pragma warning restore 612, 618
        }
    }
}
