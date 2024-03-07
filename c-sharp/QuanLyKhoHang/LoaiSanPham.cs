namespace QuanLyKhoHang
{
    public class LoaiSanPham
    {
        public int maLoaiSanPham { get; set; }
        public string tenLoaiSanPham { get; set; }

        public LoaiSanPham(int maLoaiSanPham, string tenLoaiSanPham)
        {
            this.maLoaiSanPham = maLoaiSanPham;
            this.tenLoaiSanPham = tenLoaiSanPham;
        }
        public LoaiSanPham(LoaiSanPham LOAI)
        {
            this.maLoaiSanPham = LOAI.maLoaiSanPham;
            this.tenLoaiSanPham = LOAI.tenLoaiSanPham;
        }
    }
}
