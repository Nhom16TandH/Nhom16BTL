﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nhom16.Data;

#nullable disable

namespace Nhom16.Migrations
{
    [DbContext(typeof(MvcBigContext))]
    [Migration("20221206054219_QuanLyNguonHang")]
    partial class QuanLyNguonHang
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Nhom16.Models.QuanLyDonHang", b =>
                {
                    b.Property<string>("Madonhang")
                        .HasColumnType("TEXT");

                    b.Property<string>("Makhachhang")
                        .HasColumnType("TEXT");

                    b.Property<string>("Masanpham")
                        .HasColumnType("TEXT");

                    b.Property<string>("ThongTinSanPham")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ngaydatdon")
                        .HasColumnType("TEXT");

                    b.HasKey("Madonhang");

                    b.HasIndex("Makhachhang");

                    b.ToTable("QuanLyDonHang");
                });

            modelBuilder.Entity("Nhom16.Models.QuanLyNguonHang", b =>
                {
                    b.Property<string>("MaSanPham")
                        .HasColumnType("TEXT");

                    b.Property<int>("SoLuong")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenSanPham")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("XuatXu")
                        .HasColumnType("TEXT");

                    b.HasKey("MaSanPham");

                    b.ToTable("QuanLyNguonHang");
                });

            modelBuilder.Entity("Nhom16.Models.ThongTinKhachHang", b =>
                {
                    b.Property<string>("Makhachhang")
                        .HasColumnType("TEXT");

                    b.Property<string>("Diachi")
                        .HasColumnType("TEXT");

                    b.Property<int>("Sodienthoai")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tenkhachhang")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Makhachhang");

                    b.ToTable("ThongTinKhachHang");
                });

            modelBuilder.Entity("Nhom16.Models.ThongTinSanPham", b =>
                {
                    b.Property<string>("MaSanPham")
                        .HasColumnType("TEXT");

                    b.Property<string>("Color")
                        .HasColumnType("TEXT");

                    b.Property<int>("GiaTien")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenSanPham")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaSanPham");

                    b.ToTable("ThongTinSanPham");
                });

            modelBuilder.Entity("Nhom16.Models.QuanLyDonHang", b =>
                {
                    b.HasOne("Nhom16.Models.ThongTinKhachHang", "ThongTinKhachHang")
                        .WithMany()
                        .HasForeignKey("Makhachhang");

                    b.Navigation("ThongTinKhachHang");
                });
#pragma warning restore 612, 618
        }
    }
}
