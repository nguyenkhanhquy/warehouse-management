namespace QuanLyKhoHang
{
    public class SanPham
    {
        public int maSanPham { get; set; }
        public string tenSanPham { get; set; }
        public LoaiSanPham loaiSanPham { get; set; }
        public int giaSanPham { get; set; }
        public int soLuongSanPham { get; set; }
        
        public SanPham(int maSanPham, string tenSanPham, LoaiSanPham loaiSanPham, 
            int giaSanPham, int soLuongSanPham)
        {
            this.maSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.loaiSanPham = loaiSanPham;
            this.giaSanPham = giaSanPham;
            this.soLuongSanPham = soLuongSanPham;
        }
        public SanPham(SanPham SANPHAM)
        {
            this.maSanPham = SANPHAM.maSanPham;
            this.tenSanPham = SANPHAM.tenSanPham;
            this.loaiSanPham = SANPHAM.loaiSanPham;
            this.giaSanPham = SANPHAM.giaSanPham;
            this.soLuongSanPham = SANPHAM.soLuongSanPham;
        }
    }
}
