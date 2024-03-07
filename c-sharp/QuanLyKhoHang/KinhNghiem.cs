namespace QuanLyKhoHang
{
    public class KinhNghiem
    {
        public int maKinhNghiem { get; set; }
        public int soNamKinhNghiem { get; set; }

        public KinhNghiem(int maKinhNghiem, int soNamKinhNghiem)
        { 
            this.maKinhNghiem = maKinhNghiem;
            this.soNamKinhNghiem = soNamKinhNghiem;
        }
        public KinhNghiem(KinhNghiem KINHNGHIEM)
        {
            this.maKinhNghiem = KINHNGHIEM.maKinhNghiem;
            this.soNamKinhNghiem = KINHNGHIEM.soNamKinhNghiem;
        }
    }
}
