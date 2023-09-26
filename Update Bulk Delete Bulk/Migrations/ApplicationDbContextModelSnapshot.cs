﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Update_Bulk_Delete_Bulk.Data;

#nullable disable

namespace Update_Bulk_Delete_Bulk.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PostTag", b =>
                {
                    b.Property<int>("PostsPostId")
                        .HasColumnType("int");

                    b.Property<int>("TagsTagId")
                        .HasColumnType("int");

                    b.HasKey("PostsPostId", "TagsTagId");

                    b.HasIndex("TagsTagId");

                    b.ToTable("PostTagsTest", (string)null);
                });

            modelBuilder.Entity("Update_Bulk_Delete_Bulk.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Update_Bulk_Delete_Bulk.Models.BlogImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BolgForeignKey")
                        .HasColumnType("int");

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BolgForeignKey")
                        .IsUnique();

                    b.ToTable("BlogImage");
                });

            modelBuilder.Entity("Update_Bulk_Delete_Bulk.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            Email = "Ahmad3223@gmail.com",
                            IsActive = false,
                            Name = "Ahmad"
                        },
                        new
                        {
                            EmployeeId = 2,
                            Email = "Ali3323@gmail.com",
                            IsActive = false,
                            Name = "Ali"
                        },
                        new
                        {
                            EmployeeId = 3,
                            Email = "Yaser4323@gmail.com",
                            IsActive = false,
                            Name = "Yaser"
                        },
                        new
                        {
                            EmployeeId = 4,
                            Email = "khaled4323@gmail.com",
                            IsActive = false,
                            Name = "khaled"
                        },
                        new
                        {
                            EmployeeId = 5,
                            Email = "mhmod4323@gmail.com",
                            IsActive = false,
                            Name = "mhmod"
                        },
                        new
                        {
                            EmployeeId = 6,
                            Email = "mustafa4323@gmail.com",
                            IsActive = false,
                            Name = "mustafa"
                        });
                });

            modelBuilder.Entity("Update_Bulk_Delete_Bulk.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Update_Bulk_Delete_Bulk.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagId"));

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("PostTag", b =>
                {
                    b.HasOne("Update_Bulk_Delete_Bulk.Models.Post", null)
                        .WithMany()
                        .HasForeignKey("PostsPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Update_Bulk_Delete_Bulk.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Update_Bulk_Delete_Bulk.Models.BlogImage", b =>
                {
                    b.HasOne("Update_Bulk_Delete_Bulk.Models.Blog", "Blog")
                        .WithOne("blogImage")
                        .HasForeignKey("Update_Bulk_Delete_Bulk.Models.BlogImage", "BolgForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("Update_Bulk_Delete_Bulk.Models.Blog", b =>
                {
                    b.Navigation("blogImage")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
