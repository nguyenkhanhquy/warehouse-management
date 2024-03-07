package mypack;

public class KhachHang {
	public int maKhachHang;
    public LoaiKhachHang loaiKhachHang;
    public String tenKhachHang;
    public String gioiTinh;
    public String diaChi;
    
    public int getMaKhachHang()
    {
    	return maKhachHang;
    }
    public void setMaKhachHang(int MaKhachHang)
    {
    	maKhachHang = MaKhachHang;
    }
    //
    public LoaiKhachHang getLoaiKhachHang()
    {
    	return loaiKhachHang;
    }
    public void setLoaiKhachHang(LoaiKhachHang LoaiKhachHang)
    {
    	loaiKhachHang = LoaiKhachHang;
    }
    //
    public String getTenKhachHang()
    {
    	return tenKhachHang;
    }
    public void setTenKhachHang(String TenKhachHang)
    {
    	tenKhachHang = TenKhachHang;
    }
    //
    public String getGioiTinh()
    {
    	return gioiTinh;
    }
    public void setGioiTinh(String GioiTinh)
    {
    	gioiTinh = GioiTinh;
    }
    //
    public String getDiaChi()
    {
    	return diaChi;
    }
    public void setDiaChi(String DiaChi)
    {
    	diaChi = DiaChi;
    }

    public KhachHang(int maKhachHang, LoaiKhachHang loaiKhachHang,
        String tenKhachHang, String gioiTinh, String diaChi)
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
