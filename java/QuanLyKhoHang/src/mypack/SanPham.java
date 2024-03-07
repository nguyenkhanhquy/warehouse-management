package mypack;

public class SanPham {
	public int maSanPham;
    public String tenSanPham;
    public LoaiSanPham loaiSanPham;
    public int giaSanPham;
    public int soLuongSanPham;
    
    public int getMaSanPham()
    {
    	return maSanPham;
    }
    public void setMaSanPham(int MaSanPham)
    {
    	maSanPham = MaSanPham;
    }
    //
    public String getTenSanPham()
    {
    	return tenSanPham;
    }
    public void setTenSanPham(String TenSanPham)
    {
    	tenSanPham = TenSanPham;
    }
    //
    public LoaiSanPham getLoaiSanPham()
    {
    	return loaiSanPham;
    }
    public void setLoaiSanPham(LoaiSanPham LoaiSanPham)
    {
    	loaiSanPham = LoaiSanPham;
    }
    //
    public int getGiaSanPham()
    {
    	return giaSanPham;
    }
    public void setGiaSanPham(int GiaSanPham)
    {
    	giaSanPham = GiaSanPham;
    }
    //
    public int getSoLuongSanPham()
    {
    	return soLuongSanPham;
    }
    public void setSoLuongSanPham(int SoLuongSanPham)
    {
    	soLuongSanPham = SoLuongSanPham;
    }
    
    public SanPham(int maSanPham, String tenSanPham, LoaiSanPham loaiSanPham, 
            int giaSanPham, int soLuongSanPham)
        {
            this.maSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.loaiSanPham = loaiSanPham;
            this.giaSanPham = giaSanPham;
            this.soLuongSanPham = soLuongSanPham;
        }
        public SanPham(SanPham SANPHAM)
        {
            this.maSanPham = SANPHAM.maSanPham;
            this.tenSanPham = SANPHAM.tenSanPham;
            this.loaiSanPham = SANPHAM.loaiSanPham;
            this.giaSanPham = SANPHAM.giaSanPham;
            this.soLuongSanPham = SANPHAM.soLuongSanPham;
        }
}
