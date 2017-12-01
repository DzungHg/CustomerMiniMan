using System;
using RaptorDB;

namespace CustomerAccountsUsingRaptorDb.Views.Schemas
{
    public class CongTyViewRowSchema : RDBSchema
    {
        public Guid Id { get; set; }
        public string TenCongTy { get; set; }
        public string MaCongTy { get; set; }
        public string TenLogo { get; set; }
        public string DiaChi1 { get; set; }
        public string DiaChi2 { get; set; }
        public string QuanHuyen { get; set; }
        public string TinhThanh { get; set; }
        public string MaBuuChinh { get; set; }
        public string HangKhachHang { get; set; }
        public string PhanDiaBan { get; set; }
    }
}
