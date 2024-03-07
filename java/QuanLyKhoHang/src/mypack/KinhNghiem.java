package mypack;

public class KinhNghiem {
	public int maKinhNghiem;
    public int soNamKinhNghiem;
    
    public int getMaKinhNghiem()
    {
    	return maKinhNghiem;
    }
    public void setMaKinhNghiem(int MaKinhNghiem)
    {
    	maKinhNghiem = MaKinhNghiem;
    }
    //
    public int getSoNamKinhNghiem()
    {
    	return soNamKinhNghiem;
    }
    public void setSoNamKinhNghiem(int SoNamKinhNghiem)
    {
    	soNamKinhNghiem = SoNamKinhNghiem;
    }
    
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
