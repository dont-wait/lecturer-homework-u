using System.Collections.Generic;

namespace BTVN_04;

public class QuanLiHoGiaDinh
{
    private List<HoGiaDinh> listHoGiaDinh = new List<HoGiaDinh>();
    public void NhapDanhSachSoHoGiaDinh()
    {
        Console.Write("Nhập số hộ gia đình: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Thông tin người thứ {i + 1}");
            HoGiaDinh hoGiaDinh = new HoGiaDinh();
            hoGiaDinh.NhapThongTinHoGiaDinh();
            listHoGiaDinh.Add(hoGiaDinh);
        }
    }

    public long TinhTongTienDienCuaCacHoGiaDinh()
    {
        long sum = 0;
        foreach (var hoGiaDinh in listHoGiaDinh)
        {
            sum += hoGiaDinh.TinhTienDien();
        }
        return sum;
    }

    public HoGiaDinh TimHoGiaDinhCoTieuThuDienCaoNhat()
    {
        //max nằm ở trên nên ta sắp xếp giảm dần -> max nằm ở đỉnh-phần tử đầu
        return listHoGiaDinh.OrderByDescending(HoGiaDinh => HoGiaDinh.TinhSoDienTieuThuThucTe()).First();
    }

    public void SapXepDanhSachHoGiaDinhGiamDanTheoSoDienTieuThu()
    {
        listHoGiaDinh = listHoGiaDinh.OrderByDescending(HoGiaDinh => HoGiaDinh.TinhSoDienTieuThuThucTe()).ToList();
    }

    public void XuatDanhSachHoGiaDinh()
    {
        foreach (var hoGiaDinh in listHoGiaDinh)
        {
            hoGiaDinh.XuatThongTinHoGiaDinh();
        }
    }
}