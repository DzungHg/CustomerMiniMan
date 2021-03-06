﻿using System;

namespace CustomerAccountsUsingRaptorDb.Entities
{
    public class CongTy
    {
        public CongTy()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string TenCongTy { get; set; }
        public string MaCongTy { get; set; }
        public string TenLogo { get; set; }
        public string DiaChi1 { get; set; }
        public string DiaChi2 { get; set; }
        public string QuanHuyen { get; set; }
        public string TinhThanh { get; set; }
        public string MaBuuChinh { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string DienGiaiDauMoi { get; set; }
        public string HangKhachHang { get; set; }
        public string PhanDiaBan { get; set; }
        public string LoaiCongTy { get; set; }
        public string DienGiai { get; set; }
    }
}
