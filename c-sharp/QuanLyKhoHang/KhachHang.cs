namespace QuanLyKhoHang
{
    public class KhachHang
    {
        public int maKhachHang { get; set; }
        public LoaiKhachHang loaiKhachHang { get; set; }
        public string tenKhachHang { get; set; }
        public string gioiTinh { get; set; }
        public string diaChi { get; set; }

        public KhachHang(int maKhachHang, LoaiKhachHang loaiKhachHang,
            string tenKhachHang, string gioiTinh, string diaChi)
        {
            this.maKhachHang = maKhachHang;
            this.loaiKhachHang = loaiKhachHang;
            this.tenKhachHang = tenKhachHang;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
        }
        public KhachHang(KhachHang KHACHHANG)
        {
            this.maKhachHang = KHACHHANG.maKhachHang;
            this.loaiKhachHang = KHACHHANG.loaiKhachHang;
            this.tenKhachHang = KHACHHANG.tenKhachHang;
            this.gioiTinh = KHACHHANG.gioiTinh;
            this.diaChi = KHACHHANG.diaChi;
        }
    }
}