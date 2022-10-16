﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Monolithic.Models.Context;

#nullable disable

namespace monolithic.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221016024219_RemoveUserColumnInPostTable")]
    partial class RemoveUserColumnInPostTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Monolithic.Models.Entities.AddressDistrictEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("AddressProvinceId")
                        .HasColumnType("int")
                        .HasColumnName("province_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("AddressProvinceId");

                    b.ToTable("address_district");
                });

            modelBuilder.Entity("Monolithic.Models.Entities.AddressProvinceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("address_province");
                });

            modelBuilder.Entity("Monolithic.Models.Entities.AddressWardEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("AddressDistrictId")
                        .HasColumnType("int")
                        .HasColumnName("district_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("AddressDistrictId");

                    b.ToTable("address_ward");
                });

            modelBuilder.Entity("Monolithic.Models.Entities.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("display_name");

                    b.Property<string>("Slug")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("slug");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.ToTable("category");
                });

            modelBuilder.Entity("Monolithic.Models.Entities.PermissionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<string>("Key")
                        .HasColumnType("longtext")
                        .HasColumnName("key");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("permission");
                });

            modelBuilder.Entity("Monolithic.Models.Entities.PostEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .HasColumnType("longtext")
                        .HasColumnName("address");

                    b.Property<int>("AddressWardId")
                        .HasColumnType("int");

                    b.Property<float>("Area")
                        .HasColumnType("float")
                        .HasColumnName("area");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<int>("LimitTenant")
                        .HasColumnType("int")
                        .HasColumnName("limit_tenant");

                    b.Property<int>("NumView")
                        .HasColumnType("int")
                        .HasColumnName("num_view");

                    b.Property<float>("PrePaidPrice")
                        .HasColumnType("float")
                        .HasColumnName("pre_paid_price");

                    b.Property<float>("Price")
                        .HasColumnType("float")
                        .HasColumnName("price");

                    b.Property<string>("Slug")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("slug");

                    b.Property<string>("Title")
                        .HasColumnType("longtext")
                        .HasColumnName("title");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("AddressWardId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.ToTable("post");
                });

            modelBuilder.Entity("Monolithic.Models.Entities.PostPropertyEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<int>("PostId")
                        .HasColumnType("int")
                        .HasColumnName("post_id");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int")
                        .HasColumnName("property_id");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.HasIndex("PostId", "PropertyId")
                        .IsUnique();

                    b.ToTable("post_property");
                });

            modelBuilder.Entity("Monolithic.Models.Entities.PropertyEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("DisplayName")
                        .HasColumnType("longtext")
                        .HasColumnName("display_name");

                    b.Property<int>("PropertyGroupId")
                        .HasColumnType("int")
                        .HasColumnName("property_group_id");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("PropertyGroupId");

                    b.ToTable("property");
                });

            modelBuilder.Entity("Monolithic.Models.Entities.PropertyGroupEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("DisplayName")
                        .HasColumnType("longtext")
                        .HasColumnName("display_name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("property_group");
                });

            modelBuilder.Entity("Monolithic.Models.Entities.RoleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("role");
                });

            modelBuilder.Entity("Monolithic.Models.Entities.UserAccountEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_verified");

                    b.Property<byte[]>("PasswordHashed")
                        .HasColumnType("longblob")
                        .HasColumnName("password_hashed");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("longblob")
                        .HasColumnName("password_salt");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("user_account");
                });

            modelBuilder.Entity("Monolithic.Models.Entities.AddressDistrictEntity", b =>
                {
                    b.HasOne("Monolithic.Models.Entities.AddressProvinceEntity", "AddressProvince")
                        .WithMany("AddressDistricts")
                        .HasForeignKey("AddressProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddressProvince");
                });

            modelBuilder.Entity("Monolithic.Models.Entities.AddressWardEntity", b =>
                {
                    b.HasOne("Monolithic.Models.Entities.AddressDistrictEntity", "AddressDistrict")
                        .WithMany("AddressWards")
                        .HasForeignKey("AddressDistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddressDistrict");
                });

            modelBuilder.Entity("Monolithic.Models.Entities.PermissionEntity", b =>
                {
                    b.HasOne("Monolithic.Models.Entities.RoleEntity", "Role")
                        .WithMany("Permissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Monolithic.Models.Entities.PostEntity", b =>
                {
                    b.HasOne("Monolithic.Models.Entities.AddressWardEntity", "AddressWard")
                        .WithMany()
                        .HasForeignKey("AddressWardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Monolithic.Models.Entities.CategoryEntity", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddressWard");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Monolithic.Models.Entities.PostPropertyEntity", b =>
                {
                    b.HasOne("Monolithic.Models.Entities.PostEntity", "Post")
                        .WithMany("PostProperties")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Monolithic.Models.Entities.PropertyEntity", "Property")
                        .WithMany()
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("Monolithic.Models.Entities.PropertyEntity", b =>
                {
                    b.HasOne("Monolithic.Models.Entities.PropertyGroupEntity", "PropertyGroup")
                        .WithMany("Properties")
                        .HasForeignKey("PropertyGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PropertyGroup");
                });

            modelBuilder.Entity("Monolithic.Models.Entities.UserAccountEntity", b =>
                {
                    b.HasOne("Monolithic.Models.Entities.RoleEntity", "Role")
                        .WithMany("UserAccounts")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Monolithic.Models.Entities.AddressDistrictEntity", b =>
                {
                    b.Navigation("AddressWards");
                });

            modelBuilder.Entity("Monolithic.Models.Entities.AddressProvinceEntity", b =>
                {
                    b.Navigation("AddressDistricts");
                });

            modelBuilder.Entity("Monolithic.Models.Entities.PostEntity", b =>
                {
                    b.Navigation("PostProperties");
                });

            modelBuilder.Entity("Monolithic.Models.Entities.PropertyGroupEntity", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("Monolithic.Models.Entities.RoleEntity", b =>
                {
                    b.Navigation("Permissions");

                    b.Navigation("UserAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}
