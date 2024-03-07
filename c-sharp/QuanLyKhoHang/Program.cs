using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyKhoHang
{
    public class Program
    {
        static List<PhongBan> dsPhongBan = new List<PhongBan>();
        static List<KinhNghiem> dsKinhNghiem = new List<KinhNghiem>();
        static List<CongViec> dsCongViec = new List<CongViec>();
        static List<NhanVien> dsNhanVien = new List<NhanVien>();
        static List<LoaiKhachHang> dsLoaiKhachHang = new List<LoaiKhachHang>();
        static List<KhachHang> dsKhachHang = new List<KhachHang>();
        static List<LoaiSanPham> dsLoaiSanPham = new List<LoaiSanPham>();
        static List<SanPham> dsSanPham = new List<SanPham>();
        static List<DonHang> dsDonHang = new List<DonHang>();

        public static void TaoDanhSachPhongBan()
        {
            dsPhongBan.Add(new PhongBan(0, "Phong Ban A"));
            dsPhongBan.Add(new PhongBan(1, "Phong Ban B"));
            dsPhongBan.Add(new PhongBan(2, "Phong Ban C"));
        }
        public static void TaoDanhSachKinhNghiem()
        {
            dsKinhNghiem.Add(new KinhNghiem(0, 0));
            dsKinhNghiem.Add(new KinhNghiem(1, 1));
            dsKinhNghiem.Add(new KinhNghiem(2, 2));
            dsKinhNghiem.Add(new KinhNghiem(3, 3));
            dsKinhNghiem.Add(new KinhNghiem(4, 4));
        }
        public static void TaoDanhSachCongViec()
        {
            dsCongViec.Add(new CongViec(0, "Nhan Vien Kho", 500000));
            dsCongViec.Add(new CongViec(1, "Ke Toan Kho", 1500000));
            dsCongViec.Add(new CongViec(2, "Thu Kho", 2000000));
            dsCongViec.Add(new CongViec(3, "Giam Sat Kho", 2500000));
            dsCongViec.Add(new CongViec(4, "Quan Ly Kho", 3500000));
        }
        public static void TaoDanhSachNhanVien()
        {
            dsNhanVien.Add(new NhanVien(0, "Nguyen Thanh A", "Nam", dsKinhNghiem[1], dsCongViec[3], dsPhongBan[0], 10000000));
            dsNhanVien.Add(new NhanVien(1, "Nguyen Thi B", "Nu", dsKinhNghiem[3], dsCongViec[1], dsPhongBan[0], 20000000));
            dsNhanVien.Add(new NhanVien(2, "Tran Van C", "Nam", dsKinhNghiem[0], dsCongViec[0], dsPhongBan[0], 5000000));
            dsNhanVien.Add(new NhanVien(3, "Nguyen Quoc D", "Nam", dsKinhNghiem[2], dsCongViec[2], dsPhongBan[1], 15000000));
            dsNhanVien.Add(new NhanVien(4, "Pham Thuy E", "Nu", dsKinhNghiem[3], dsCongViec[1], dsPhongBan[1], 20000000));
            dsNhanVien.Add(new NhanVien(5, "Doan Van P", "Nam", dsKinhNghiem[4], dsCongViec[4], dsPhongBan[1], 30000000));
            dsNhanVien.Add(new NhanVien(6, "Trinh Van G", "Nam", dsKinhNghiem[2], dsCongViec[2], dsPhongBan[2], 15000000));
            dsNhanVien.Add(new NhanVien(7, "Vu Thi H", "Nu", dsKinhNghiem[0], dsCongViec[0], dsPhongBan[2], 5000000));
            dsNhanVien.Add(new NhanVien(8, "Nguyen Thi T", "Nu", dsKinhNghiem[1], dsCongViec[2], dsPhongBan[2], 10000000));

            dsPhongBan[0].lapTruongPhongBan(dsNhanVien[0]);
            dsPhongBan[1].lapTruongPhongBan(dsNhanVien[5]);
            dsPhongBan[2].lapTruongPhongBan(dsNhanVien[6]);
        }
        public static void TaoDanhSachLoaiKhachHang()
        {
            dsLoaiKhachHang.Add(new LoaiKhachHang(0, "Thuong"));
            dsLoaiKhachHang.Add(new LoaiKhachHang(1, "Than Thiet"));
        }
        public static void TaoDanhSachKhachHangTheoLoaiKhachHang()
        {
            dsKhachHang.Add(new KhachHang(0, dsLoaiKhachHang[0], "Nguyen Van A", "Nam", "Thu Duc"));
            dsKhachHang.Add(new KhachHang(1, dsLoaiKhachHang[1], "Nguyen Van B", "Nam", "Quan 1"));
            dsKhachHang.Add(new KhachHang(2, dsLoaiKhachHang[0], "Nguyen Thi C", "Nu", "Quan 2"));
            dsKhachHang.Add(new KhachHang(3, dsLoaiKhachHang[0], "Nguyen Van D", "Nam", "Quan 1"));
            dsKhachHang.Add(new KhachHang(4, dsLoaiKhachHang[1], "Nguyen Thi E", "Nu", "Quan 4"));
            dsKhachHang.Add(new KhachHang(5, dsLoaiKhachHang[0], "Tran Van A", "Nam", "Thu Duc"));
            dsKhachHang.Add(new KhachHang(6, dsLoaiKhachHang[1], "Pham Thi B", "Nu", "Quan 2"));
            dsKhachHang.Add(new KhachHang(7, dsLoaiKhachHang[0], "Nguyen Thi K", "Nu", "Quan 7"));
            dsKhachHang.Add(new KhachHang(8, dsLoaiKhachHang[0], "Nguyen Van N", "Nam", "Quan 2"));
            dsKhachHang.Add(new KhachHang(9, dsLoaiKhachHang[1], "Tran Thi M", "Nu", "Quan 1"));
            dsKhachHang.Add(new KhachHang(10, dsLoaiKhachHang[0], "Tran Van C", "Nam", "Thu Duc"));
        }
        public static void TaoDanhSachLoaiSanPham()
        {
            dsLoaiSanPham.Add(new LoaiSanPham(0, "Nuoc Giai Khat"));
            dsLoaiSanPham.Add(new LoaiSanPham(1, "Gia Vi"));
            dsLoaiSanPham.Add(new LoaiSanPham(2, "Thit"));
            dsLoaiSanPham.Add(new LoaiSanPham(3, "Hai San"));
            dsLoaiSanPham.Add(new LoaiSanPham(4, "Banh Keo"));
            dsLoaiSanPham.Add(new LoaiSanPham(5, "Ngu Coc"));
            dsLoaiSanPham.Add(new LoaiSanPham(6, "Sua"));
            dsLoaiSanPham.Add(new LoaiSanPham(7, "Dung Cu"));
            dsLoaiSanPham.Add(new LoaiSanPham(8, "Cong Nghe"));
        }
        public static void TaoDanhSachSanPhamTheoLoaiSanPham()
        {
            dsSanPham.Add(new SanPham(0, "Coca", dsLoaiSanPham[0], 10000, 150));
            dsSanPham.Add(new SanPham(1, "Sua Bo", dsLoaiSanPham[6], 8000, 2));
            dsSanPham.Add(new SanPham(2, "Keo Vien", dsLoaiSanPham[4], 3000, 109));
            dsSanPham.Add(new SanPham(3, "Sting", dsLoaiSanPham[0], 9000, 30));
            dsSanPham.Add(new SanPham(4, "Ngu Coc Yen Mach", dsLoaiSanPham[5], 80000, 0));
            dsSanPham.Add(new SanPham(5, "Ca Ngu", dsLoaiSanPham[3], 130000, 90));
            dsSanPham.Add(new SanPham(6, "Thit Bo", dsLoaiSanPham[2], 150000, 202));
            dsSanPham.Add(new SanPham(7, "Muoi", dsLoaiSanPham[1], 5000, 147));
            dsSanPham.Add(new SanPham(8, "Laptop Asus", dsLoaiSanPham[8], 20000000, 15));
            dsSanPham.Add(new SanPham(9, "Xeng", dsLoaiSanPham[7], 63000, 80));
            dsSanPham.Add(new SanPham(10, "Number1", dsLoaiSanPham[0], 8500, 360));
            dsSanPham.Add(new SanPham(11, "Sua Ong Tho", dsLoaiSanPham[6], 24000, 150));
            dsSanPham.Add(new SanPham(12, "Laptop Dell", dsLoaiSanPham[8], 25000000, 13));
            dsSanPham.Add(new SanPham(13, "Ngu coc Muesli", dsLoaiSanPham[5], 80000, 85));
            dsSanPham.Add(new SanPham(14, "Choi", dsLoaiSanPham[7], 5000000, 0));
            dsSanPham.Add(new SanPham(15, "Bot Ca Ri", dsLoaiSanPham[1], 6000, 187));
            dsSanPham.Add(new SanPham(16, "Snack Oishi", dsLoaiSanPham[4], 10000, 312));
            dsSanPham.Add(new SanPham(17, "Do Hot Rac", dsLoaiSanPham[7], 15000, 241));
            dsSanPham.Add(new SanPham(18, "IPhone", dsLoaiSanPham[8], 18000000, 26));
            dsSanPham.Add(new SanPham(19, "Tom Hum", dsLoaiSanPham[3], 3500000, 91));
            dsSanPham.Add(new SanPham(20, "Tom Cang Xanh", dsLoaiSanPham[3], 150000, 0));
            dsSanPham.Add(new SanPham(21, "Ngu Coc Granola", dsLoaiSanPham[5], 185000, 35));
            dsSanPham.Add(new SanPham(22, "C2", dsLoaiSanPham[0], 10000, 97));
            dsSanPham.Add(new SanPham(23, "Laptop Lenovo", dsLoaiSanPham[8], 30000000, 11));
            dsSanPham.Add(new SanPham(24, "MacBook", dsLoaiSanPham[8], 40000000, 0));
            dsSanPham.Add(new SanPham(25, "Thit Heo", dsLoaiSanPham[2], 65000, 78));
            dsSanPham.Add(new SanPham(26, "Muc", dsLoaiSanPham[3], 85000, 0));
            dsSanPham.Add(new SanPham(27, "Hat Tieu", dsLoaiSanPham[1], 100000, 147));
            dsSanPham.Add(new SanPham(28, "Compact", dsLoaiSanPham[0], 12000, 64));
            dsSanPham.Add(new SanPham(29, "Sua Vinamilk", dsLoaiSanPham[6], 8000, 96));
            dsSanPham.Add(new SanPham(30, "Laptop LG", dsLoaiSanPham[8], 15000000, 0));
        }
        public static void TaoDanhSachDonHang()
        {
            dsDonHang.Add(new DonHang(0, new DateTime(2022, 12, 15), dsSanPham[0], 27, dsNhanVien[0], dsKhachHang[0]));
            dsDonHang.Add(new DonHang(1, new DateTime(2021, 9, 4), dsSanPham[1], 10, dsNhanVien[0], dsKhachHang[1]));
            dsDonHang.Add(new DonHang(2, new DateTime(2021, 10, 1), dsSanPham[14], 7, dsNhanVien[8], dsKhachHang[3]));
            dsDonHang.Add(new DonHang(3, new DateTime(2020, 6, 7), dsSanPham[18], 4, dsNhanVien[0], dsKhachHang[5]));
            dsDonHang.Add(new DonHang(4, new DateTime(2022, 7, 16), dsSanPham[2], 42, dsNhanVien[8], dsKhachHang[2]));
            dsDonHang.Add(new DonHang(5, new DateTime(2020, 6, 2), dsSanPham[16], 12, dsNhanVien[8], dsKhachHang[6]));
            dsDonHang.Add(new DonHang(6, new DateTime(2010, 4, 9), dsSanPham[9], 20, dsNhanVien[0], dsKhachHang[7]));
            dsDonHang.Add(new DonHang(7, new DateTime(2012, 8, 15), dsSanPham[24], 1, dsNhanVien[8], dsKhachHang[10]));
            dsDonHang.Add(new DonHang(8, new DateTime(2018, 8, 6), dsSanPham[10], 32, dsNhanVien[0], dsKhachHang[9]));
            dsDonHang.Add(new DonHang(9, new DateTime(2020, 9, 27), dsSanPham[5], 10, dsNhanVien[0], dsKhachHang[8]));
            dsDonHang.Add(new DonHang(10, new DateTime(2015, 10, 8), dsSanPham[0], 7, dsNhanVien[8], dsKhachHang[1]));
            dsDonHang.Add(new DonHang(11, new DateTime(2018, 12, 5), dsSanPham[8], 4, dsNhanVien[0], dsKhachHang[8]));
            dsDonHang.Add(new DonHang(12, new DateTime(2019, 4, 7), dsSanPham[1], 24, dsNhanVien[8], dsKhachHang[3]));
            dsDonHang.Add(new DonHang(13, new DateTime(2022, 7, 2), dsSanPham[12], 21, dsNhanVien[0], dsKhachHang[3]));
            dsDonHang.Add(new DonHang(14, new DateTime(2022, 11, 4), dsSanPham[5], 3, dsNhanVien[8], dsKhachHang[0]));
            dsDonHang.Add(new DonHang(15, new DateTime(2022, 11, 5), dsSanPham[7], 7, dsNhanVien[8], dsKhachHang[0]));

        }

        //Họ và tên - MSSV : Nguyễn Khánh Quy - 21110282

        //Câu 1: In ra tên và công việc của các nhân viên thực tập
        public static void Cau1()
        {
            var dsnv = dsNhanVien
                .Where(nv => nv.kinhNghiem.soNamKinhNghiem == 0)
                .Select(nv => (TenNV: nv.tenNhanVien, TenCV: nv.congViec.tenCongViec));

            Console.WriteLine("Cau 1: In ra ten va cong viec cua cac nhan vien thuc tap");
            foreach (var x in dsnv)
            {
                Console.WriteLine($" - Ten: {x.TenNV} - Cong Viec: {x.TenCV}");
            }
            Console.WriteLine();
        }

        //Câu 2: In ra số lượng nhân viên từ 1 năm kinh nghiệm trở lên
        //của từng phòng ban
        public static void Cau2()
        {
            var dsnv = dsNhanVien
                .Where(nv => nv.kinhNghiem.soNamKinhNghiem > 0)
                .GroupBy(nv => nv.phongBan.tenPhongBan)
                .Select(g => (TenPB: g.Key, SoNV: g.Count()));

            Console.WriteLine("Cau 2: In ra so luong nhan vien tu 1 nam kinh nghiem tro len cua tung phong ban");
            foreach (var x in dsnv)
            {
                Console.WriteLine($" - {x.TenPB}:");
                Console.WriteLine($"   + Co {x.SoNV} nhan vien tu 1 nam kinh nghiem tro len");
            }
            Console.WriteLine();
        }

        //Câu 3: In ra danh sách tên, công việc và tổng lương của từng nhân viên
        //theo thứ tự giảm dần của tổng lương.
        public static void Cau3()
        {
            var dsnv = dsNhanVien
                .Select(nv => (TenNV: nv.tenNhanVien,
                               TenCV: nv.congViec.tenCongViec,
                               TongLuong: nv.tienLuong + nv.congViec.tienThuong));
            
            var dsnv_sx = dsnv.OrderByDescending(o => o.TongLuong);

            Console.WriteLine("Cau 3: In ra danh sach ten, cong viec va tong luong cua tung nhan vien theo thu tu giam dan cua tong luong");
            foreach (var x in dsnv_sx)
            {
                Console.WriteLine($" - Ten: {x.TenNV}");
                Console.WriteLine($"   + Cong Viec: {x.TenCV}");
                Console.WriteLine($"   + Luong: {x.TongLuong}");
            }
            Console.WriteLine();
        }

        //Câu 4: In ra lương trung bình của tất cả nhân viên cùng với tên
        //và lương tổng của các nhân viên có lương tổng lớn hơn lương trung bình
        //theo thứ tự tăng dần của lương tổng
        public static void Cau4()
        {
            double luongTB = dsNhanVien
                .Select(nv => nv.tienLuong + nv.congViec.tienThuong)
                .Average();

            var dsnv = dsNhanVien
                .Where(nv => nv.tienLuong + nv.congViec.tienThuong > luongTB)
                .Select(nv => (TenNV: nv.tenNhanVien, 
                               LuongTong: nv.tienLuong + nv.congViec.tienThuong));

            var dsnv_sx = dsnv.OrderBy(o => o.LuongTong);

            Console.WriteLine("Cau 4: In ra luong trung binh cua tat ca nhan vien cung voi ten va luong tong cua cac nhan vien\nco luong tong lon hon luong trung binh theo thu tu tang dan cua luong tong");
            Console.WriteLine(" * Luong trung binh tat ca nhan vien = " + luongTB);
            foreach (var x in dsnv_sx)
            {
                Console.WriteLine($" - Ten: {x.TenNV} - Luong Tong: {x.LuongTong}");
            }
            Console.WriteLine();
        }

        //Câu 5: In ra số lượng hàng tồn kho của từng loại sản phẩm
        public static void Cau5()
        {
            var dssp = dsSanPham
                .GroupBy(sp => sp.loaiSanPham)
                .Select(g => (LoaiSP: g.Key, 
                              SoHangTonKho: g.Sum(s => s.soLuongSanPham)));
            Console.WriteLine("Cau 5: In ra so luong hang ton kho cua tung loai san pham");
            foreach (var x in dssp)
            {
                Console.WriteLine($" - Loai san pham: {x.LoaiSP.tenLoaiSanPham}" +
                    $" - So luong hang ton kho la: {x.SoHangTonKho}");
            }
            Console.WriteLine();
        }

        //Câu 6: Phân vùng tên khách hàng theo loại khách hàng sau đó đến địa chỉ
        public static void Cau6()
        {
            var dskh = dsKhachHang
                .GroupBy(lkh => lkh.loaiKhachHang.tenLoaiKhachHang)
                .Select(glkh => (LoaiKH: glkh.Key,
                                 ThongTin: glkh.GroupBy(dc => dc.diaChi)
                                  .Select(gdc => (DiaChi: gdc.Key, ThongTin: gdc))));

            Console.WriteLine("Cau 6: Phan vung ten khach hang theo loai khach hang sau do den dia chi");
            foreach (var x in dskh)
            {
                Console.WriteLine($" - Khach Hang {x.LoaiKH}:");
                foreach (var w in x.ThongTin)
                {
                    Console.WriteLine($"   + {w.DiaChi}:");
                    foreach (var z in w.ThongTin)
                    {
                        Console.WriteLine($"       {z.tenKhachHang}");
                    }
                }
            }
            Console.WriteLine();
        }

        //Câu 7: In ra những sản phẩm có giá trên 5000000 và còn hàng
        //theo thứ tự tăng dần của số lượng sản phẩm
        public static void Cau7()
        {
            var dssp = dsSanPham
                .Where(sp => sp.giaSanPham > 5000000 && sp.soLuongSanPham > 0)
                .OrderBy(o => o.soLuongSanPham);

            Console.WriteLine("Cau 7: In ra nhung san pham co gia tren 5000000 va con hang theo thu tu tang dan cua so luong san pham");
            foreach (var x in dssp)
            {
                Console.WriteLine($" - Ma SP: {x.maSanPham} - Ten SP: {x.tenSanPham} " +
                    $"- Loai SP: {x.loaiSanPham.tenLoaiSanPham} " +
                    $"- Gia SP: {x.giaSanPham} - So Luong SP: {x.soLuongSanPham}");
            }
            Console.WriteLine();
        }

        //Câu 8: In ra mã, tên khách hàng và số đơn hàng mà họ đã đặt, xếp theo thứ tự
        //tăng dần của số đơn hàng
        public static void Cau8()
        {
            var dsdh = dsDonHang
                .GroupBy(o => o.khachHang)
                .Select(g => (KH: g.Key, SoDonHang: g.Count()))
                .OrderBy(h => h.SoDonHang);

            Console.WriteLine("Cau 8: In ra ma, ten khach hang va so don hang ma ho da dat, xep theo thu tu tang dan cua so don hang");
            foreach (var x in dsdh)
            {
                Console.WriteLine($" - Ma KH: {x.KH.maKhachHang} " +
                    $"- Ten KH: {x.KH.tenKhachHang} - So Don Hang: {x.SoDonHang}");
            }
            Console.WriteLine();
        }

        //Câu 9: In ra danh sách mã và tổng tiền của từng đơn hàng,
        //in ra danh sách thông tin những đơn hàng có tổng tiền cao nhất và thấp nhất
        public static void Cau9()
        {
            var dsdh = dsDonHang
                .Select(dh => (MaDH: dh.maDonHang,
                               tienDH: dh.sanPham.giaSanPham * dh.soLuongMua));

            int tienDH_MAX = dsdh.Max(p => p.tienDH);
            var dsdh_max = dsDonHang
                .Where(dh => dh.sanPham.giaSanPham * dh.soLuongMua == tienDH_MAX);

            int tienDH_MIN = dsdh.Min(p => p.tienDH);
            var dsdh_min = dsDonHang
                .Where(dh => dh.sanPham.giaSanPham * dh.soLuongMua == tienDH_MIN);

            Console.WriteLine("Cau 9: In ra danh sach ma va tong tien cua tung don hang, in ra danh sach thong tin nhung don hang\nco tong tien cao nhat va thap nhat");
            Console.WriteLine(" * Danh sach ma don hang va tong tien cua tung don hang:");
            foreach (var x in dsdh)
            {
                Console.WriteLine($"   - Ma DH: {x.MaDH} - Tien DH: {x.tienDH}");
            }
            foreach (var w in dsdh_max)
            {
                Console.WriteLine($" * Danh sach don hang co so tien cao nhat: ");
                Console.WriteLine($"   - Ma DH: {w.maDonHang} - Ngay Mua: {w.ngayMua.ToShortDateString()} " +
                    $"- SP: {w.sanPham.tenSanPham} - SL: {w.soLuongMua} " +
                    $"- NV Xu Ly: {w.nhanVienXuLy.tenNhanVien} - KH: {w.khachHang.tenKhachHang}");
            }
            foreach (var z in dsdh_min)
            {
                Console.WriteLine($" * Danh sach don hang co so tien thap nhat: ");
                Console.WriteLine($"   - Ma DH: {z.maDonHang} - Ngay Mua: {z.ngayMua.ToShortDateString()} " +
                    $"- SP: {z.sanPham.tenSanPham} - SL: {z.soLuongMua} " +
                    $"- NV Xu Ly: {z.nhanVienXuLy.tenNhanVien} - KH: {z.khachHang.tenKhachHang}");
            }
            Console.WriteLine();
        }

        //Câu 10: Phân vùng thông tin đơn hàng của từng khách hàng theo năm,
        //sau đó là theo tháng
        public static void Cau10()
        {
            var dsdh = dsDonHang
                .GroupBy(dh => dh.khachHang.tenKhachHang)
                .Select(gkh => (TenKH: gkh.Key,
                                YearGroup: gkh.GroupBy(o => o.ngayMua.Year)
                                              .Select(gy => (Year: gy.Key,
                                                             MonthGroup: gy.GroupBy(o => o.ngayMua.Month)
                                                                           .Select(gm => (Month: gm.Key, ThongTin: gm))
                                                                           .OrderBy(gm => gm.Month)
                                                            )
                                                      ).OrderBy(gy => gy.Year)
                                 )
                         );

            Console.WriteLine("Cau 10: Phan vung thong tin don hang cua tung khach hang theo nam, sau do la theo thang");
            foreach (var x in dsdh)
            {
                Console.WriteLine($" - Ten KH: {x.TenKH}");
                foreach (var w in x.YearGroup)
                {
                    Console.WriteLine($"\tNam: {w.Year}");
                    foreach (var y in w.MonthGroup)
                    {
                        Console.WriteLine($"\t\tThang: {y.Month}");
                        foreach (var z in y.ThongTin)
                        {
                            Console.WriteLine($"\t\t\tMa DH: {z.maDonHang}");
                            Console.WriteLine($"\t\t\tSP: {z.sanPham.tenSanPham}");
                            Console.WriteLine($"\t\t\tSL: {z.soLuongMua}");
                            Console.WriteLine($"\t\t\tGia DH: {z.sanPham.giaSanPham * z.soLuongMua}");
                            Console.WriteLine($"\t\t\tNgay mua hang: {z.ngayMua.Day}/{z.ngayMua.Month}/{z.ngayMua.Year}\n");
                        }
                    }
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //Tạo các danh sách
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
            Cau6();
            Cau7();
            Cau8();
            Cau9();
            Cau10();

            Console.ReadKey();
        }
    }
}
