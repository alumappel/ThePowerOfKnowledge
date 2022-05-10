﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThePowerOfKnowledge.Server.Data;

namespace ThePowerOfKnowledge.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("ThePowerOfKnowledge.Shared.Entities.Answer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<bool>("CorrectAnswer")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GameID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HaveImge")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("GameID");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("ThePowerOfKnowledge.Shared.Entities.Game", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GamePin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("GameQuestionImge")
                        .HasColumnType("TEXT");

                    b.Property<string>("GameQuestionText")
                        .HasColumnType("TEXT");

                    b.Property<string>("GameTopic")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsPublish")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("ThePowerOfKnowledge.Shared.Entities.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ThePowerOfKnowledge.Shared.Entities.Answer", b =>
                {
                    b.HasOne("ThePowerOfKnowledge.Shared.Entities.Game", null)
                        .WithMany("GameAnswers")
                        .HasForeignKey("GameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ThePowerOfKnowledge.Shared.Entities.Game", b =>
                {
                    b.HasOne("ThePowerOfKnowledge.Shared.Entities.User", null)
                        .WithMany("UserGames")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ThePowerOfKnowledge.Shared.Entities.Game", b =>
                {
                    b.Navigation("GameAnswers");
                });

            modelBuilder.Entity("ThePowerOfKnowledge.Shared.Entities.User", b =>
                {
                    b.Navigation("UserGames");
                });
#pragma warning restore 612, 618
        }
    }
}
