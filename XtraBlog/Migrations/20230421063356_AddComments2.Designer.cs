﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XtraBlog.DAL;

#nullable disable

namespace XtraBlog.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230421063356_AddComments2")]
    partial class AddComments2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("XtraBlog.Model.Comments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Craeateat")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostID");

                    b.ToTable("Comment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "Heri seni",
                            Craeateat = new DateTime(2023, 4, 21, 10, 33, 55, 726, DateTimeKind.Local).AddTicks(9147),
                            Name = "Nahid",
                            PostID = 1
                        },
                        new
                        {
                            Id = 2,
                            Comment = "reyiz",
                            Craeateat = new DateTime(2023, 4, 21, 10, 33, 55, 726, DateTimeKind.Local).AddTicks(9152),
                            Name = "Revan",
                            PostID = 1
                        },
                        new
                        {
                            Id = 3,
                            Comment = "Pak",
                            Craeateat = new DateTime(2023, 4, 21, 10, 33, 55, 726, DateTimeKind.Local).AddTicks(9153),
                            Name = "Revan",
                            PostID = 2
                        });
                });

            modelBuilder.Entity("XtraBlog.Model.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Created_By")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created_By = "Nahid Shirinov",
                            Date = new DateTime(2023, 4, 21, 10, 33, 55, 726, DateTimeKind.Local).AddTicks(8512),
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ",
                            Image = "img-01.jpg",
                            Slug = "7f06c5db-fc2b-438a-a515-25073f7285cc",
                            Title = "You can also have an image"
                        },
                        new
                        {
                            Id = 2,
                            Created_By = "Nahid Sirinov",
                            Date = new DateTime(2023, 5, 1, 10, 33, 55, 726, DateTimeKind.Local).AddTicks(8524),
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ",
                            Image = "img-02.jpg",
                            Slug = "4b8b75b3-08c8-41c8-aece-a057964359f8",
                            Title = "He qaqa, ele mi olufff"
                        });
                });

            modelBuilder.Entity("XtraBlog.Model.TagPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("PostID")
                        .HasColumnType("int");

                    b.Property<int>("TagsID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostID");

                    b.HasIndex("TagsID");

                    b.ToTable("TagPosts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PostID = 1,
                            TagsID = 1
                        },
                        new
                        {
                            Id = 2,
                            PostID = 2,
                            TagsID = 2
                        },
                        new
                        {
                            Id = 3,
                            PostID = 2,
                            TagsID = 4
                        },
                        new
                        {
                            Id = 4,
                            PostID = 2,
                            TagsID = 3
                        });
                });

            modelBuilder.Entity("XtraBlog.Model.Tags", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tag");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Siyaset"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Idman"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Blog"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Hava"
                        });
                });

            modelBuilder.Entity("XtraBlog.Model.Comments", b =>
                {
                    b.HasOne("XtraBlog.Model.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("XtraBlog.Model.TagPost", b =>
                {
                    b.HasOne("XtraBlog.Model.Post", "Post")
                        .WithMany("TagPost")
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XtraBlog.Model.Tags", "Tags")
                        .WithMany("TagPost")
                        .HasForeignKey("TagsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Tags");
                });

            modelBuilder.Entity("XtraBlog.Model.Post", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("TagPost");
                });

            modelBuilder.Entity("XtraBlog.Model.Tags", b =>
                {
                    b.Navigation("TagPost");
                });
#pragma warning restore 612, 618
        }
    }
}
