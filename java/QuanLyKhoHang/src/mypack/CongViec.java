package mypack;

public class CongViec {
	public int maCongViec;
    public String tenCongViec;
    public int tienThuong;
    
    public int getMaCongViec()
    {
    	return maCongViec;
    }
    public void setMaCongViec(int MaCongViec)
    {
    	maCongViec = MaCongViec;
    }
    //
    public String getTenCongViec()
    {
    	return tenCongViec;
    }
    public void setTenCongViec(String TenCongViec)
    {
    	tenCongViec = TenCongViec;
    }
    //
    public int getTienThuong()
    {
    	return tienThuong;
    }
    public void setTienThuong(int TienThuong)
    {
    	tienThuong = TienThuong;
    }

    public CongViec(int maCongViec, String tenCongViec, int tienThuong)
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
