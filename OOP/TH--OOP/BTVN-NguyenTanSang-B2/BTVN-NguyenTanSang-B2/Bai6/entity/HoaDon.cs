using BTVN_NguyenTanSang_B2.Bai6.dao;

namespace BTVN_NguyenTanSang_B2.Bai6.entity;

public class HoaDon
{
    private string _maHoaDon;
    private string _tenKhachHang;
    private List<ChiTietBanHang> _chiTietHoaDon = new List<ChiTietBanHang>();

    public HoaDon(string maHoaDon, string tenKhachHang, List<ChiTietBanHang>? danhSachChiTiet = null)
    {
        _maHoaDon = maHoaDon;
        _tenKhachHang = tenKhachHang;
        _chiTietHoaDon = danhSachChiTiet ?? new List<ChiTietBanHang>();
    }
    
    public void nhapHoaDon()
    {
        Console.WriteLine("Nhap Ma Hoa Don: ");
        _maHoaDon = Console.ReadLine();
        Console.WriteLine("Ten Khach Hang: ");
        _tenKhachHang = Console.ReadLine();
        Console.WriteLine("Nhap so luong chi tiet ban hang: ");
        int soLuongChiTiet = int.Parse(Console.ReadLine());
        for (int i = 0; i < soLuongChiTiet; i++)
        {
            Console.WriteLine($"nhap thong ban hang chi tiet thu nhat {i + 1}:");
            ChiTietBanHang chiTiet = new ChiTietBanHang();
            _chiTietHoaDon.Add(chiTiet.NhapTT());
        }
    }

    public double TinhTongTien()
    {
        double tongTien = 0;
        foreach (var chiTiet in _chiTietHoaDon)
        {
            tongTien += chiTiet.TinhTien(); 
        }
        return tongTien;
    }

    public void xuatHoaDon()
    {
        Console.WriteLine("--------------------Thong tin Hoa Don--------------------------");
        Console.WriteLine($"Ma Hoa Don: {_maHoaDon}");
        Console.WriteLine($"Ten Khach Hang: {_tenKhachHang}");
        Console.WriteLine("Chi Tiet Ban Hang:");
        foreach (var chiTiet in _chiTietHoaDon)
        {
            chiTiet.XuatTT();
        }
        Console.WriteLine($"Tong Tien Hoa Don: {TinhTongTien()}");
    }

    public void SapXepChiTietBanHang() => _chiTietHoaDon = _chiTietHoaDon.OrderByDescending(t => t.TinhTien())
                                            .ThenBy(t => t.GiaBan).ToList();

    public double tienLonNhat() => _chiTietHoaDon.Max(t => t.TinhTien());

    public void ThemChiTiet(ChiTietBanHang chiTiet) => _chiTietHoaDon.Add(chiTiet);
}