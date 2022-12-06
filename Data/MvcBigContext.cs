using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nhom16.Models;

namespace Nhom16.Data 
{
#pragma warning restore format
    public class MvcBigContext : DbContext
    {
        public MvcBigContext (DbContextOptions<MvcBigContext> options)
            : base(options)
        {
        }

        public DbSet<Nhom16.Models.ThongTinKhachHang> ThongTinKhachHang { get; set; }

        public DbSet<Nhom16.Models.ThongTinSanPham> ThongTinSanPham { get; set; }

        public DbSet<Nhom16.Models.QuanLyNguonHang> QuanLyNguonHang { get; set; }

        public DbSet<Nhom16.Models.QuanLyDonHang> QuanLyDonHang { get; set; }
        public DbSet<Nhom16.Models.QuanLyNV>QuanLyNV{get; set;}

    }
}