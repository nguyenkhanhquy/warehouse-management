namespace QuanLyKhoHang
{
    public class NhanVien
    {
        public int maNhanVien { get; set; }
        public string tenNhanVien { set; get; }
        public string gioiTinh { set; get; }
        public KinhNghiem kinhNghiem { get; set; }
        public CongViec congViec { get; set; }
        public PhongBan phongBan { get; set; }
        public int tienLuong { get; set; }

        public NhanVien(int maNhanVien, string tenNhanVien, string gioiTinh, 
            KinhNghiem kinhNghiem, CongViec congViec, PhongBan phongBan, int tienLuong)
        {
            this.maNhanVien = maNhanVien;
            this.tenNhanVien = tenNhanVien;
            this.gioiTinh = gioiTinh;
            this.kinhNghiem = kinhNghiem;
            this.congViec = congViec;
            this.phongBan = phongBan;
            this.tienLuong = tienLuong;
        }
        public NhanVien(NhanVien NHANVIEN) 
        {
            this.maNhanVien = NHANVIEN.maNhanVien;
            this.tenNhanVien = NHANVIEN.tenNhanVien;
            this.gioiTinh = NHANVIEN.gioiTinh;
            this.kinhNghiem = NHANVIEN.kinhNghiem;
            this.congViec = NHANVIEN.congViec;
            this.phongBan = NHANVIEN.phongBan;
            this.tienLuong = NHANVIEN.tienLuong;
        }
    }
}
