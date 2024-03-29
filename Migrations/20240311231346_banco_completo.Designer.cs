﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using infraAlerta.Data;

#nullable disable

namespace infraAlerta.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20240311231346_banco_completo")]
    partial class banco_completo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("infraAlerta.Models.Problem", b =>
                {
                    b.Property<int>("pro_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("pro_id"));

                    b.Property<string>("pro_classification")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("pro_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("pro_photo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("pro_id");

                    b.ToTable("Problem");
                });

            modelBuilder.Entity("infraAlerta.Models.Problem_address", b =>
                {
                    b.Property<int>("pa_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("pa_id"));

                    b.Property<string>("pa_address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("pa_city")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("pa_neighborhood")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("pa_number")
                        .HasColumnType("int");

                    b.Property<int>("pa_problem_id")
                        .HasColumnType("int");

                    b.Property<int>("pa_problempro_id")
                        .HasColumnType("int");

                    b.Property<string>("pa_state")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("pa_id");

                    b.HasIndex("pa_problempro_id");

                    b.ToTable("Problem_Address");
                });

            modelBuilder.Entity("infraAlerta.Models.User", b =>
                {
                    b.Property<int>("user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("user_id"));

                    b.Property<bool>("admin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("user_id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("infraAlerta.Models.User_address", b =>
                {
                    b.Property<int>("ua_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ua_id"));

                    b.Property<string>("ua_address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ua_city")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ua_neighborhood")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ua_number")
                        .HasColumnType("int");

                    b.Property<int>("ua_problem_id")
                        .HasColumnType("int");

                    b.Property<string>("ua_state")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("ua_id");

                    b.HasIndex("user_id");

                    b.ToTable("User_Address");
                });

            modelBuilder.Entity("infraAlerta.Models.Problem_address", b =>
                {
                    b.HasOne("infraAlerta.Models.Problem", "pa_problem")
                        .WithMany()
                        .HasForeignKey("pa_problempro_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pa_problem");
                });

            modelBuilder.Entity("infraAlerta.Models.User_address", b =>
                {
                    b.HasOne("infraAlerta.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });
#pragma warning restore 612, 618
        }
    }
}
