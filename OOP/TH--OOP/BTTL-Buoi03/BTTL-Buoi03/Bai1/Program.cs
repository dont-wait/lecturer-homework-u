using BTTLBuoi03.Bai1.entity;

namespace BTTLBuoi03.Bai1;

public class Program
{
    static void Bai1()
    {
        // Tạo đối tượng Khoa
        Khoa khoa = new Khoa();
            
        // Đọc danh sách giảng viên từ file XML
        string filePath = "/home/dontwait/Documents/SEMESTER04/lecturer-homework-u/OOP/TH--OOP/BTTL-Buoi03/BTTL-Buoi03/Bai1/Khoa.xml";
        khoa.DocDSGiangVien(filePath);
                
        // Xuất danh sách giảng viên
        Console.WriteLine("Danh sách giảng viên:");
        khoa.XuatDSGiangVien();
            
        // Tính tổng số nhóm hướng dẫn
        int tongSoNhom = khoa.TinhTongSoNHomHD();
        Console.WriteLine($"\nTổng số nhóm hướng dẫn: {tongSoNhom}");
                
        // Sắp xếp danh sách giảng viên tăng dần theo họ tên
        khoa.SXTangDanHoTen();
        Console.WriteLine("\nDanh sách giảng viên sau khi sắp xếp tăng dần theo họ tên:");
        khoa.XuatDSGiangVien();
                
        // Sắp xếp danh sách giảng viên giảm dần theo số nhóm hướng dẫn
        khoa.SXGiamDanSoNhom();
        Console.WriteLine("\nDanh sách giảng viên sau khi sắp xếp giảm dần theo số nhóm hướng dẫn:");
        khoa.XuatDSGiangVien();
                
        // Lọc giảng viên có số nhóm hướng dẫn lớn hơn 1
        List<GiangVien> dsLoc = khoa.LocSoNHomLonHon1();
        Console.WriteLine("\nDanh sách giảng viên có số nhóm hướng dẫn lớn hơn 1:");
        foreach (var gv in dsLoc)
        {
            gv.Xuat();
        }

    }
}