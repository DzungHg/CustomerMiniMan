using System;

namespace CustomerAccountsUsingRaptorDb.Entities
{
    public class HoatDong
    {
        public HoatDong()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public Guid IdChinhPhuc { get; set; }
        public string TieuDe { get; set; }
        public string DienGiai { get; set; }
        public DateTime HetHan { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayHieuDinh { get; set; }
        public string LoaiHoatDong { get; set; }
       
    }
}
