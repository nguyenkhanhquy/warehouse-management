namespace QuanLyKhoHang
{
    public class LoaiKhachHang
    {
        public int maLoaiKhachHang { get; set; }
        public string tenLoaiKhachHang { get; set; }

        public LoaiKhachHang(int maLoaiKhachHang, string tenLoaiKhachHang) 
        {
            this.maLoaiKhachHang = maLoaiKhachHang;
            this.tenLoaiKhachHang= tenLoaiKhachHang;
        }
        public LoaiKhachHang(LoaiKhachHang LOAI)
        {
            this.maLoaiKhachHang = LOAI.maLoaiKhachHang;
            this.tenLoaiKhachHang = LOAI.tenLoaiKhachHang;
        }
    }
}
