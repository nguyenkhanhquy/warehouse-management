using System;

namespace QuanLyKhoHang
{
    public class DonHang
    {
        public int maDonHang { get; set; }
        public DateTime ngayMua { get; set; }
        public SanPham sanPham { get; set; }
        public int soLuongMua { get; set; }
        public NhanVien nhanVienXuLy { get; set; }
        public KhachHang khachHang { get; set; }

        public DonHang(int maDonHang, DateTime ngayMua, SanPham sanPham, 
            int soLuongMua, NhanVien nhanVienXuLy, KhachHang khachHang)
        {
            this.maDonHang = maDonHang;
            this.ngayMua = ngayMua;
            this.sanPham = sanPham;
            this.soLuongMua = soLuongMua;
            this.nhanVienXuLy = nhanVienXuLy;
            this.khachHang = khachHang;
        }
        public DonHang(DonHang DONHANG)
        {
            this.maDonHang = DONHANG.maDonHang;
            this.ngayMua = DONHANG.ngayMua;
            this.sanPham = DONHANG.sanPham;
            this.soLuongMua = DONHANG.soLuongMua;
            this.nhanVienXuLy = DONHANG.nhanVienXuLy;
            this.khachHang = DONHANG.khachHang;
        }
    }
}
