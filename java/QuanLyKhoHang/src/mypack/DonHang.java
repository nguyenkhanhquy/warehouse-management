package mypack;

public class DonHang {
	public int maDonHang;
	public String ngayMua;
    public SanPham sanPham;
    public int soLuongMua;
    public NhanVien nhanVienXuLy;
    public KhachHang khachHang;
    
    public int getMaDonHang()
    {
    	return maDonHang;
    }
    public void setMaDonHang(int MaDonHang)
    {
    	maDonHang = MaDonHang;
    }
    //
    public String getNgayMua()
    {
    	return ngayMua;
    }
    public void setNgayMua(String NgayMua)
    {
    	ngayMua = NgayMua;
    }
    //
    public SanPham getSanPham()
    {
    	return sanPham;
    }
    public void setSanPham(SanPham SanPham)
    {
    	sanPham = SanPham;
    }
    //
    public int getSoLuongMua()
    {
    	return soLuongMua;
    }
    public void setSoLuongMua(int SoLuongMua)
    {
    	soLuongMua = SoLuongMua;
    }
    //
    public NhanVien getNhanVienXuLy()
    {
    	return nhanVienXuLy;
    }
    public void setNhanVienXuLy(NhanVien NhanVienXuLy)
    {
    	nhanVienXuLy = NhanVienXuLy;
    }
    //
    public KhachHang getKhachHang()
    {
    	return khachHang;
    }
    public void setKhachHang(KhachHang KhachHang)
    {
    	khachHang = KhachHang;
    }
    

    public DonHang(int maDonHang, String ngayMua, SanPham sanPham, 
        int soLuongMua, NhanVien nhanVienXuLy, KhachHang khachHang)
    {
        this.maDonHang = maDonHang;
        this.ngayMua = ngayMua;
        this.sanPham = sanPham;
        this.soLuongMua = soLuongMua;
        this.nhanVienXuLy = nhanVienXuLy;
        this.khachHang = khachHang;
    }
    public DonHang(DonHang DONHANG)
    {
        this.maDonHang = DONHANG.maDonHang;
        this.ngayMua = DONHANG.ngayMua;
        this.sanPham = DONHANG.sanPham;
        this.soLuongMua = DONHANG.soLuongMua;
        this.nhanVienXuLy = DONHANG.nhanVienXuLy;
        this.khachHang = DONHANG.khachHang;
    }
}
