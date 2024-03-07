package mypack;

public class NhanVien {
	public int maNhanVien;
    public String tenNhanVien;
    public String gioiTinh;
    public KinhNghiem kinhNghiem;
    public CongViec congViec;
    public PhongBan phongBan;
    public int tienLuong;
    
    public int getMaNhanVien()
    {
    	return maNhanVien;
    }
    public void setMaNhanVien(int MaNhanVien)
    {
    	maNhanVien = MaNhanVien;
    }
    //
    public String getTenNhanVien()
    {
    	return tenNhanVien;
    }
    public void setTenNhanVien(String TenNhanVien)
    {
    	tenNhanVien = TenNhanVien;
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
    public KinhNghiem getKinhNghiem()
    {
    	return kinhNghiem;
    }
    public void setKinhNghiem(KinhNghiem KinhNghiem)
    {
    	kinhNghiem = KinhNghiem;
    }
    //
    public CongViec getCongViec()
    {
    	return congViec;
    }
    public void setCongViec(CongViec CongViec)
    {
    	congViec = CongViec;
    }
    //
    public PhongBan getPhongBan()
    {
    	return phongBan;
    }
    public void setPhongBan(PhongBan PhongBan)
    {
    	phongBan = PhongBan;
    }
    //
    public int getTienLuong()
    {
    	return tienLuong;
    }
    public void setTienLuong(int TienLuong)
    {
    	tienLuong = TienLuong;
    }
    

    public NhanVien(int maNhanVien, String tenNhanVien, String gioiTinh, 
        KinhNghiem kinhNghiem, CongViec congViec, PhongBan phongBan, int tienLuong)
    {
        this.maNhanVien = maNhanVien;
        this.tenNhanVien = tenNhanVien;
        this.gioiTinh = gioiTinh;
        this.kinhNghiem = kinhNghiem;
        this.congViec = congViec;
        this.phongBan = phongBan;
        this.tienLuong = tienLuong;
    }
    public NhanVien(NhanVien NHANVIEN) 
    {
        this.maNhanVien = NHANVIEN.maNhanVien;
        this.tenNhanVien = NHANVIEN.tenNhanVien;
        this.gioiTinh = NHANVIEN.gioiTinh;
        this.kinhNghiem = NHANVIEN.kinhNghiem;
        this.congViec = NHANVIEN.congViec;
        this.phongBan = NHANVIEN.phongBan;
        this.tienLuong = NHANVIEN.tienLuong;
    }
}
