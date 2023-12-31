﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TextSmiles.API.Data;

#nullable disable

namespace TextSmiles.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("TextSmiles.API.Data.Entities.Emotion", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Emotions");
                });

            modelBuilder.Entity("TextSmiles.API.Data.Entities.Smile", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("EmotionID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserID")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("EmotionID");

                    b.HasIndex("UserID");

                    b.ToTable("Smiles");
                });

            modelBuilder.Entity("TextSmiles.API.Data.Entities.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TextSmiles.API.Data.Entities.Smile", b =>
                {
                    b.HasOne("TextSmiles.API.Data.Entities.Emotion", "Emotion")
                        .WithMany("Smiles")
                        .HasForeignKey("EmotionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TextSmiles.API.Data.Entities.User", "User")
                        .WithMany("Smiles")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Emotion");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TextSmiles.API.Data.Entities.Emotion", b =>
                {
                    b.Navigation("Smiles");
                });

            modelBuilder.Entity("TextSmiles.API.Data.Entities.User", b =>
                {
                    b.Navigation("Smiles");
                });
#pragma warning restore 612, 618
        }
    }
}
