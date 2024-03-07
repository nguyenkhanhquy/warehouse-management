package mypack;

public class LoaiSanPham {
	public int maLoaiSanPham;
    public String tenLoaiSanPham;
    
    public int getMaLoaiSanPham()
    {
    	return maLoaiSanPham;
    }
    public void setMaLoaiSanPham(int MaLoaiSanPham)
    {
    	maLoaiSanPham = MaLoaiSanPham;
    }
    public String getTenLoaiSanPham()
    {
    	return tenLoaiSanPham;
    }
    public void setTenLoaiSanPham(String TenLoaiSanPham)
    {
    	tenLoaiSanPham = TenLoaiSanPham;
    }

	public LoaiSanPham() {}
	public LoaiSanPham(int maLoaiSanPham, String tenLoaiSanPham)
	{
		this.maLoaiSanPham = maLoaiSanPham;
		this.tenLoaiSanPham = tenLoaiSanPham;
	}
	public LoaiSanPham(LoaiSanPham LOAI)
	{
		this.maLoaiSanPham = LOAI.maLoaiSanPham;
		this.tenLoaiSanPham = LOAI.tenLoaiSanPham;
	}
}
