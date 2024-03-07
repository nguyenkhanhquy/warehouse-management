namespace QuanLyKhoHang
{
    public class CongViec
    {
        public int maCongViec { get; set; }
        public string tenCongViec { get; set; }
        public int tienThuong { get; set; }

        public CongViec(int maCongViec, string tenCongViec, int tienThuong)
        {
            this.maCongViec = maCongViec;
            this.tenCongViec = tenCongViec;
            this.tienThuong = tienThuong;
        }
        public CongViec(CongViec CONGVIEC)
        {
            this.maCongViec = CONGVIEC.maCongViec;
            this.tenCongViec = CONGVIEC.tenCongViec;
            this.tienThuong = CONGVIEC.tienThuong;
        }
    }
}
