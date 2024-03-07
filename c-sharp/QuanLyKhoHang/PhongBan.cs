namespace QuanLyKhoHang
{
    public class PhongBan
    {
        public int maPhongBan { get; set; }
        public string tenPhongBan { get; set; }
        public NhanVien truongPhongBan { get; set; }

        public PhongBan(int maPhongBan, string tenPhongBan)
        {
            this.maPhongBan = maPhongBan;
            this.tenPhongBan = tenPhongBan;
        }
        public PhongBan(PhongBan PHONGBAN)
        {
            this.maPhongBan = PHONGBAN.maPhongBan;
            this.tenPhongBan = PHONGBAN.tenPhongBan;
        }
        public void lapTruongPhongBan(NhanVien truongphong)
        {
            this.truongPhongBan = truongphong;
        }
    }
}
