package mypack;

public class PhongBan {
	public int maPhongBan;
    public String tenPhongBan;
    public NhanVien truongPhongBan;
    
    public int getMaPhongBan()
    {
    	return maPhongBan;
    }
    public void setMaPhongBan(int MaPhongBan)
    {
    	maPhongBan = MaPhongBan;
    }
    //
    public String getTenPhongBan()
    {
    	return tenPhongBan;
    }
    public void setTenPhongBan(String TenPhongBan)
    {
    	tenPhongBan = TenPhongBan;
    }
    //
    public NhanVien getTruongPhongBan()
    {
    	return truongPhongBan;
    }
    public void setTruongPhongBan(NhanVien TruongPhongBan)
    {
    	truongPhongBan = TruongPhongBan;
    }

    public PhongBan(int maPhongBan, String tenPhongBan)
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
