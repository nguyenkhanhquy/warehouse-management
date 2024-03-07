package mypack;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

public class Program 
{
	static List<PhongBan> dsPhongBan = new ArrayList<PhongBan>();
	static List<KinhNghiem> dsKinhNghiem = new ArrayList<KinhNghiem>();
    static List<CongViec> dsCongViec = new ArrayList<CongViec>();
    static List<NhanVien> dsNhanVien = new ArrayList<NhanVien>();
	static List<LoaiKhachHang> dsLoaiKhachHang = new ArrayList<LoaiKhachHang>();
    static List<KhachHang> dsKhachHang = new ArrayList<KhachHang>();
	static List<LoaiSanPham> dsLoaiSanPham = new ArrayList<LoaiSanPham>();
	static List<SanPham> dsSanPham = new ArrayList<SanPham>();
	static List<DonHang> dsDonHang = new ArrayList<DonHang>();
	
	public static void TaoDanhSachPhongBan()
    {
        dsPhongBan.add(new PhongBan(0, "Phong Ban A"));
        dsPhongBan.add(new PhongBan(1, "Phong Ban B"));
        dsPhongBan.add(new PhongBan(2, "Phong Ban C"));
    }
	public static void TaoDanhSachKinhNghiem()
    {
        dsKinhNghiem.add(new KinhNghiem(0, 0));
        dsKinhNghiem.add(new KinhNghiem(1, 1));
        dsKinhNghiem.add(new KinhNghiem(2, 2));
        dsKinhNghiem.add(new KinhNghiem(3, 3));
        dsKinhNghiem.add(new KinhNghiem(4, 4));
    }
    public static void TaoDanhSachCongViec()
    {
        dsCongViec.add(new CongViec(0, "Nhan Vien Kho", 500000));
        dsCongViec.add(new CongViec(1, "Ke Toan Kho", 1500000));
        dsCongViec.add(new CongViec(2, "Thu Kho", 2000000));
        dsCongViec.add(new CongViec(3, "Giam Sat Kho", 2500000));
        dsCongViec.add(new CongViec(4, "Quan Ly Kho", 3500000));
    }   
    public static void TaoDanhSachNhanVien()
    {
        dsNhanVien.add(new NhanVien(0, "Nguyen Thanh A", "Nam", dsKinhNghiem.get(1), dsCongViec.get(3), dsPhongBan.get(0), 10000000));
        dsNhanVien.add(new NhanVien(1, "Nguyen Thi B", "Nu", dsKinhNghiem.get(3), dsCongViec.get(1), dsPhongBan.get(0), 20000000));
        dsNhanVien.add(new NhanVien(2, "Tran Van C", "Nam", dsKinhNghiem.get(0), dsCongViec.get(0), dsPhongBan.get(0), 5000000));
        dsNhanVien.add(new NhanVien(3, "Nguyen Quoc D", "Nam", dsKinhNghiem.get(2), dsCongViec.get(2), dsPhongBan.get(1), 15000000));
        dsNhanVien.add(new NhanVien(4, "Pham Thuy E", "Nu", dsKinhNghiem.get(3), dsCongViec.get(1), dsPhongBan.get(1), 20000000));
        dsNhanVien.add(new NhanVien(5, "Doan Van P", "Nam", dsKinhNghiem.get(4), dsCongViec.get(4), dsPhongBan.get(1), 30000000));
        dsNhanVien.add(new NhanVien(6, "Trinh Van G", "Nam", dsKinhNghiem.get(2), dsCongViec.get(2), dsPhongBan.get(2), 15000000));
        dsNhanVien.add(new NhanVien(7, "Vu Thi H", "Nu", dsKinhNghiem.get(0), dsCongViec.get(0), dsPhongBan.get(2), 5000000));
        dsNhanVien.add(new NhanVien(8, "Nguyen Thi T", "Nu", dsKinhNghiem.get(1), dsCongViec.get(2), dsPhongBan.get(2), 10000000));

        dsPhongBan.get(0).lapTruongPhongBan(dsNhanVien.get(0));
        dsPhongBan.get(1).lapTruongPhongBan(dsNhanVien.get(5));
        dsPhongBan.get(2).lapTruongPhongBan(dsNhanVien.get(6));
    }
	public static void TaoDanhSachLoaiKhachHang()
    {
        dsLoaiKhachHang.add(new LoaiKhachHang(0, "Thuong"));
        dsLoaiKhachHang.add(new LoaiKhachHang(1, "Than Thiet"));
    }	
    public static void TaoDanhSachKhachHangTheoLoaiKhachHang()
    {
        dsKhachHang.add(new KhachHang(0, dsLoaiKhachHang.get(0), "Nguyen Van A", "Nam", "Thu Duc"));
        dsKhachHang.add(new KhachHang(1, dsLoaiKhachHang.get(1), "Nguyen Van B", "Nam", "Quan 1"));
        dsKhachHang.add(new KhachHang(2, dsLoaiKhachHang.get(0), "Nguyen Thi C", "Nu", "Quan 2"));
        dsKhachHang.add(new KhachHang(3, dsLoaiKhachHang.get(0), "Nguyen Van D", "Nam", "Quan 1"));
        dsKhachHang.add(new KhachHang(4, dsLoaiKhachHang.get(1), "Nguyen Thi E", "Nu", "Quan 4"));
        dsKhachHang.add(new KhachHang(5, dsLoaiKhachHang.get(0), "Tran Van A", "Nam", "Thu Duc"));
        dsKhachHang.add(new KhachHang(6, dsLoaiKhachHang.get(1), "Pham Thi B", "Nu", "Quan 2"));
        dsKhachHang.add(new KhachHang(7, dsLoaiKhachHang.get(0), "Nguyen Thi K", "Nu", "Quan 7"));
        dsKhachHang.add(new KhachHang(8, dsLoaiKhachHang.get(0), "Nguyen Van N", "Nam", "Quan 2"));
        dsKhachHang.add(new KhachHang(9, dsLoaiKhachHang.get(1), "Tran Thi M", "Nu", "Quan 1"));
        dsKhachHang.add(new KhachHang(10, dsLoaiKhachHang.get(0), "Tran Van C", "Nam", "Thu Duc"));
    }
	public static void TaoDanhSachLoaiSanPham()
    {
        dsLoaiSanPham.add(new LoaiSanPham(0, "Nuoc Giai Khat"));
        dsLoaiSanPham.add(new LoaiSanPham(1, "Gia Vi"));
        dsLoaiSanPham.add(new LoaiSanPham(2, "Thit"));
        dsLoaiSanPham.add(new LoaiSanPham(3, "Hai San"));
        dsLoaiSanPham.add(new LoaiSanPham(4, "Banh Keo"));
        dsLoaiSanPham.add(new LoaiSanPham(5, "Ngu Coc"));
        dsLoaiSanPham.add(new LoaiSanPham(6, "Sua"));
        dsLoaiSanPham.add(new LoaiSanPham(7, "Dung Cu"));
        dsLoaiSanPham.add(new LoaiSanPham(8, "Cong Nghe"));
    }
	public static void TaoDanhSachSanPhamTheoLoaiSanPham()
    {
        dsSanPham.add(new SanPham(0, "Coca", dsLoaiSanPham.get(0), 10000, 150));
        dsSanPham.add(new SanPham(1, "Sua Bo", dsLoaiSanPham.get(6), 8000, 2));
        dsSanPham.add(new SanPham(2, "Keo Vien", dsLoaiSanPham.get(4), 3000, 109));
        dsSanPham.add(new SanPham(3, "Sting", dsLoaiSanPham.get(0), 9000, 30));
        dsSanPham.add(new SanPham(4, "Ngu Coc Yen Mach", dsLoaiSanPham.get(5), 80000, 0));
        dsSanPham.add(new SanPham(5, "Ca Ngu", dsLoaiSanPham.get(3), 130000, 90));
        dsSanPham.add(new SanPham(6, "Thit Bo", dsLoaiSanPham.get(2), 150000, 202));
        dsSanPham.add(new SanPham(7, "Muoi", dsLoaiSanPham.get(1), 5000, 147));
        dsSanPham.add(new SanPham(8, "Laptop Asus", dsLoaiSanPham.get(8), 20000000, 15));
        dsSanPham.add(new SanPham(9, "Xeng", dsLoaiSanPham.get(7), 63000, 80));
        dsSanPham.add(new SanPham(10, "Number1", dsLoaiSanPham.get(0), 8500, 360));
        dsSanPham.add(new SanPham(11, "Sua Ong Tho", dsLoaiSanPham.get(6), 24000, 150));
        dsSanPham.add(new SanPham(12, "Laptop Dell", dsLoaiSanPham.get(8), 25000000, 13));
        dsSanPham.add(new SanPham(13, "Ngu coc Muesli", dsLoaiSanPham.get(5), 80000, 85));
        dsSanPham.add(new SanPham(14, "Choi", dsLoaiSanPham.get(7), 5000000, 0));
        dsSanPham.add(new SanPham(15, "Bot Ca Ri", dsLoaiSanPham.get(1), 6000, 187));
        dsSanPham.add(new SanPham(16, "Snack Oishi", dsLoaiSanPham.get(4), 10000, 312));
        dsSanPham.add(new SanPham(17, "Do Hot Rac", dsLoaiSanPham.get(7), 15000, 241));
        dsSanPham.add(new SanPham(18, "IPhone", dsLoaiSanPham.get(8), 18000000, 26));
        dsSanPham.add(new SanPham(19, "Tom Hum", dsLoaiSanPham.get(3), 3500000, 91));
        dsSanPham.add(new SanPham(20, "Tom Cang Xanh", dsLoaiSanPham.get(3), 150000, 0));
        dsSanPham.add(new SanPham(21, "Ngu Coc Granola", dsLoaiSanPham.get(5), 185000, 35));
        dsSanPham.add(new SanPham(22, "C2", dsLoaiSanPham.get(0), 10000, 97));
        dsSanPham.add(new SanPham(23, "Laptop Lenovo", dsLoaiSanPham.get(8), 30000000, 11));
        dsSanPham.add(new SanPham(24, "MacBook", dsLoaiSanPham.get(8), 40000000, 0));
        dsSanPham.add(new SanPham(25, "Thit Heo", dsLoaiSanPham.get(2), 65000, 78));
        dsSanPham.add(new SanPham(26, "Muc", dsLoaiSanPham.get(3), 85000, 0));
        dsSanPham.add(new SanPham(27, "Hat Tieu", dsLoaiSanPham.get(1), 100000, 147));
        dsSanPham.add(new SanPham(28, "Compact", dsLoaiSanPham.get(0), 12000, 64));
        dsSanPham.add(new SanPham(29, "Sua Vinamilk", dsLoaiSanPham.get(6), 8000, 96));
        dsSanPham.add(new SanPham(30, "Laptop LG", dsLoaiSanPham.get(8), 15000000, 0));
    }
	public static void TaoDanhSachDonHang()
    {
        dsDonHang.add(new DonHang(0, "15/12/2022", dsSanPham.get(0), 27, dsNhanVien.get(0), dsKhachHang.get(0)));
        dsDonHang.add(new DonHang(1, "4/9/2021", dsSanPham.get(1), 10, dsNhanVien.get(0), dsKhachHang.get(1)));
        dsDonHang.add(new DonHang(2, "1/10/2021", dsSanPham.get(14), 7, dsNhanVien.get(8), dsKhachHang.get(3)));
        dsDonHang.add(new DonHang(3, "6/7/2020", dsSanPham.get(18), 4, dsNhanVien.get(0), dsKhachHang.get(5)));
        dsDonHang.add(new DonHang(4, "16/7/2022", dsSanPham.get(2), 42, dsNhanVien.get(8), dsKhachHang.get(2)));
        dsDonHang.add(new DonHang(5, "2/6/2020", dsSanPham.get(16), 12, dsNhanVien.get(8), dsKhachHang.get(6)));
        dsDonHang.add(new DonHang(6, "9/4/2010", dsSanPham.get(9), 20, dsNhanVien.get(0), dsKhachHang.get(7)));
        dsDonHang.add(new DonHang(7, "15/8/2012", dsSanPham.get(24), 1, dsNhanVien.get(8), dsKhachHang.get(10)));
        dsDonHang.add(new DonHang(8, "6/8/2018", dsSanPham.get(10), 32, dsNhanVien.get(0), dsKhachHang.get(9)));
        dsDonHang.add(new DonHang(9, "27/9/2020", dsSanPham.get(5), 10, dsNhanVien.get(0), dsKhachHang.get(8)));
        dsDonHang.add(new DonHang(10, "8/10/2015", dsSanPham.get(0), 7, dsNhanVien.get(8), dsKhachHang.get(1)));
        dsDonHang.add(new DonHang(11, "5/12/2018", dsSanPham.get(8), 4, dsNhanVien.get(0), dsKhachHang.get(8)));
        dsDonHang.add(new DonHang(12, "7/4/2019", dsSanPham.get(1), 24, dsNhanVien.get(8), dsKhachHang.get(3)));
        dsDonHang.add(new DonHang(13, "2/7/2022", dsSanPham.get(12), 21, dsNhanVien.get(0), dsKhachHang.get(3)));
        dsDonHang.add(new DonHang(14, "4/11/2022", dsSanPham.get(5), 3, dsNhanVien.get(8), dsKhachHang.get(0)));
        dsDonHang.add(new DonHang(15, "5/11/2022", dsSanPham.get(7), 7, dsNhanVien.get(8), dsKhachHang.get(0)));
    }
	
	//Họ và tên - MSSV : Nguyễn Khánh Quy - 21110282
	
	//Câu 1: In ra thông tin của các nhân viên thực tập
	public static void Cau1()
	{
		List <NhanVien> dsnv = dsNhanVien
				.stream()
				.filter(x -> x.getKinhNghiem().getSoNamKinhNghiem() == 0)
				.collect(Collectors.toList());
		
		System.out.println("Cau 1: In ra thong tin cua cac nhan vien thuc tap");
		for (NhanVien nv : dsnv)
		{
			System.out.println(" - Ma Nhan Vien: " + nv.getMaNhanVien()
			+ " - Ten Nhan Vien: " + nv.getTenNhanVien()
			+ " - Gioi Tinh: " + nv.getGioiTinh()
			+ " - Cong Viec: " + nv.getCongViec().getTenCongViec()
			+ " - Phong Ban: " + nv.getPhongBan().getTenPhongBan()
			+ " - Tong Luong: " + (nv.getTienLuong() + nv.getCongViec().getTienThuong()));
		}
		System.out.println();
	}
	
	//Câu 2: In ra thông tin của những sản phẩm hết hàng
	public static void Cau2()
	{
		List <SanPham> dssp = dsSanPham
				.stream()
				.filter(x -> x.getSoLuongSanPham() == 0)
				.collect(Collectors.toList());
		
		System.out.println("Cau 2: In ra thong tin cua nhung san pham het hang");
		for (SanPham sp : dssp)
		{
			System.out.println(" - Ma San Pham: " + sp.getMaSanPham()
			+ " - Ten San Pham: " + sp.getTenSanPham()
			+ " - Loai San Pham: " + sp.getLoaiSanPham().getTenLoaiSanPham()
			+ " - Gia San Pham: " + sp.getGiaSanPham());
		}
		System.out.println();
	}
	
	//Câu 3: In ra số lượng khách hàng có địa chỉ ở Thủ Đức
	public static void Cau3()
	{
		List <KhachHang> dskh = dsKhachHang
				.stream()
				.filter(x -> x.getDiaChi() == "Thu Duc")
				.collect(Collectors.toList());
		
		Long n = dskh.stream().collect(Collectors.counting());
		
		System.out.println("Cau 3: In ra so luong khach hang co dia chi o Thu Duc");
		System.out.println(" - So luong khach hang o Thu Duc: " + n);	
		System.out.println();	
	}
	
	//Câu 4: In ra thông tin và tổng tiền của 5 đơn hàng đầu tiên
	public static void Cau4()
	{
		List <DonHang> dsdh = dsDonHang
				.stream()
				.limit(5)
				.collect(Collectors.toList());
		
		System.out.println("Cau 4: In ra thong tin va tong tien cua 5 don hang dau tien");
		for (DonHang dh : dsdh)
		{
			System.out.println(" - Ma Don Hang: " + dh.getMaDonHang() 
			+ " - Ngay Mua: " + dh.getNgayMua()
			+ " - San Pham: " + dh.getSanPham().getTenSanPham() 
			+ " - So Luong: " + dh.getSoLuongMua() 
			+ " - Nhan Vien Xu Ly: " + dh.getNhanVienXuLy().getTenNhanVien()
			+ " - Khach Hang: " + dh.getKhachHang().getTenKhachHang()
			+ " - Tong Tien: " + dh.getSanPham().getGiaSanPham() * dh.getSoLuongMua());
		}
		System.out.println();
	}
	
	//Câu 5: In ra thông tin và tổng tiền của những đơn hàng có tổng tiền < 200000
		public static void Cau5()
		{
			List <DonHang> dsdh = dsDonHang
					.stream()
					.filter(x -> x.getSanPham().getGiaSanPham() * x.getSoLuongMua() < 200000)
					.collect(Collectors.toList());
			
			System.out.println("Cau 5: In ra thong tin va tong tien cua nhung don hang co tong tien < 200000");
			for (DonHang dh : dsdh)
			{
				System.out.println(" - Ma Don Hang: " + dh.getMaDonHang() 
				+ " - Ngay Mua: " + dh.getNgayMua()
				+ " - San Pham: " + dh.getSanPham().getTenSanPham() 
				+ " - So Luong: " + dh.getSoLuongMua() 
				+ " - Nhan Vien Xu Ly: " + dh.getNhanVienXuLy().getTenNhanVien()
				+ " - Khach Hang: " + dh.getKhachHang().getTenKhachHang()
				+ " - Tong Tien: " + dh.getSanPham().getGiaSanPham() * dh.getSoLuongMua());
			}
			System.out.println();
		}
	
	public static void main(String[] args) {
		TaoDanhSachPhongBan();
		TaoDanhSachKinhNghiem();
		TaoDanhSachCongViec();
		TaoDanhSachNhanVien();
		TaoDanhSachLoaiKhachHang();
		TaoDanhSachKhachHangTheoLoaiKhachHang();
		TaoDanhSachLoaiSanPham();
		TaoDanhSachSanPhamTheoLoaiSanPham();
		TaoDanhSachDonHang();
		
		Cau1();
		Cau2();
		Cau3();
		Cau4();
		Cau5();
	}

}
