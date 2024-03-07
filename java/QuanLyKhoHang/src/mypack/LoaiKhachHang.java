package mypack;

public class LoaiKhachHang {
	public int maLoaiKhachHang;
    public String tenLoaiKhachHang;
    
    public int getMaLoaiKhachHang()
    {
    	return maLoaiKhachHang;
    }
    public void setMaLoaiKhachHang(int MaLoaiKhachHang)
    {
    	maLoaiKhachHang = MaLoaiKhachHang;
    }
    //
    public String getTenLoaiKhachHang()
    {
    	return tenLoaiKhachHang;
    }
    public void setTenLoaiKhachHang(String TenLoaiKhachHang)
    {
    	tenLoaiKhachHang = TenLoaiKhachHang;
    }
    

    public LoaiKhachHang(int maLoaiKhachHang, String tenLoaiKhachHang) 
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
