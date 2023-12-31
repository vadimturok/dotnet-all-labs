﻿// <auto-generated />
using DotnetProject.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Program.Migrations
{
    [DbContext(typeof(DotnetProjectDbContext))]
    [Migration("20231126134151_AddMessageText")]
    partial class AddMessageText
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DotnetProject.DAL.FriendshipRequest", b =>
                {
                    b.Property<int>("friendshipRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("fromUserId")
                        .HasColumnType("int");

                    b.Property<bool>("isAccepted")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("toUserId")
                        .HasColumnType("int");

                    b.HasKey("friendshipRequestId");

                    b.ToTable("FriendshipRequests");
                });

            modelBuilder.Entity("DotnetProject.DAL.Message", b =>
                {
                    b.Property<int>("messageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("fromUserId")
                        .HasColumnType("int");

                    b.Property<string>("message")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("toUserId")
                        .HasColumnType("int");

                    b.HasKey("messageId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("DotnetProject.DAL.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("userId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
