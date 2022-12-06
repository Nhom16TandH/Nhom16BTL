using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nhom16.Migrations
{
    /// <inheritdoc />
    public partial class QuanLyDonHang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuanLyNguonHang",
                columns: table => new
                {
                    MaSanPham = table.Column<string>(type: "TEXT", nullable: false),
                    TenSanPham = table.Column<string>(type: "TEXT", nullable: false),
                    XuatXu = table.Column<string>(type: "TEXT", nullable: true),
                    SoLuong = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuanLyNguonHang", x => x.MaSanPham);
                });

            migrationBuilder.CreateTable(
                name: "ThongTinKhachHang",
                columns: table => new
                {
                    Makhachhang = table.Column<string>(type: "TEXT", nullable: false),
                    Tenkhachhang = table.Column<string>(type: "TEXT", nullable: false),
                    Diachi = table.Column<string>(type: "TEXT", nullable: true),
                    Sodienthoai = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinKhachHang", x => x.Makhachhang);
                });

            migrationBuilder.CreateTable(
                name: "ThongTinSanPham",
                columns: table => new
                {
                    MaSanPham = table.Column<string>(type: "TEXT", nullable: false),
                    TenSanPham = table.Column<string>(type: "TEXT", nullable: false),
                    Color = table.Column<string>(type: "TEXT", nullable: true),
                    GiaTien = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinSanPham", x => x.MaSanPham);
                });

            migrationBuilder.CreateTable(
                name: "QuanLyDonHang",
                columns: table => new
                {
                    Madonhang = table.Column<string>(type: "TEXT", nullable: false),
                    ngaydatdon = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Masanpham = table.Column<string>(type: "TEXT", nullable: true),
                    ThongTinSanPham = table.Column<string>(type: "TEXT", nullable: true),
                    Makhachhang = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuanLyDonHang", x => x.Madonhang);
                    table.ForeignKey(
                        name: "FK_QuanLyDonHang_ThongTinKhachHang_Makhachhang",
                        column: x => x.Makhachhang,
                        principalTable: "ThongTinKhachHang",
                        principalColumn: "Makhachhang");
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuanLyDonHang_Makhachhang",
                table: "QuanLyDonHang",
                column: "Makhachhang");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuanLyDonHang");

            migrationBuilder.DropTable(
                name: "QuanLyNguonHang");

            migrationBuilder.DropTable(
                name: "ThongTinSanPham");

            migrationBuilder.DropTable(
                name: "ThongTinKhachHang");
        }
    }
}
