using System;
using BTVN_NguyenTanSang_B2.dao;

class Program
{
    static void Main(string[] args)
    {
        ListNhanVien listNhanVien = new ListNhanVien();

        Console.WriteLine("\nTEST 1: Xuat danh sach nhan vien");
        listNhanVien.xuatTT();

        Console.WriteLine("\nTEST 2: Xuat danh sach nhan vien phong ban IT");
        listNhanVien.XuatDanhSachNhanVienTheoPhongBan("IT");

        Console.WriteLine("\nTEST 3: Xuat danh sach nhan vien lanh dao");
        listNhanVien.xuatDanhSachCoChucVuLanhDao();

        Console.WriteLine("\nTEST 4: Xuat danh sach nhan vien theo he so thi dua");
        listNhanVien.XuatDanhSachHeSoThiDua();

        Console.WriteLine("\nTEST 5: Tinh tong luong nhan vien");
        double totalSalary = listNhanVien.TinhTongLuong();
        Console.WriteLine($"Tong luong: {totalSalary}");

        Console.WriteLine("\nTEST 6: Xoa nhan vien lam viec duoi 10 ngay");
        listNhanVien.XoaNhanVienLamViecDuoi10Ngay();
        listNhanVien.xuatTT();

        Console.WriteLine("\nTEST 7: Xuat danh sach nhan vien khong lanh dao nhung lam tren 22 ngay");
        listNhanVien.XuatDanhSachNhanVienKhongPhaiLanhDaoNhungLamTren22Ngay();

        Console.WriteLine("\nTEST 8: Xuat danh sach nhan vien co he so luong > 4.34 va thuoc phong Tai Vu");
        listNhanVien.XuatDanhSachNhanVienCoHSLonHon4_34VaOPhongTaiVu();
    }
}