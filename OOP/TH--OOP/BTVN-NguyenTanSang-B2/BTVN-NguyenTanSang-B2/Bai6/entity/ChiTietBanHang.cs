namespace BTVN_NguyenTanSang_B2.Bai6.dao;

public class ChiTietBanHang
{
    private string _maSanPham;
    private string _tenSanPham;
    private double _giaBan;
    private int _soLuong;
    public static double VAT = 0.10;

    public ChiTietBanHang()
    {
        MaSanPham = "SP0010";
        TenSanPham = "May Tinh Dell";
        GiaBan = 15000;
        SoLuong = 2;
    }

    public ChiTietBanHang(string maSanPham, string tenSanPham, double giaBan, int soLuong)
    {
        MaSanPham = maSanPham;
        TenSanPham = tenSanPham;
        GiaBan = giaBan;
        SoLuong = soLuong;
    }

    public ChiTietBanHang(ChiTietBanHang ctbh)
    {
        MaSanPham = ctbh._maSanPham;
        TenSanPham = ctbh._tenSanPham;
        GiaBan = ctbh._giaBan;
        SoLuong = ctbh._soLuong;
    }

    public string MaSanPham
    {
        get => _maSanPham;
        set => _maSanPham = (value.Length == 6 && value.StartsWith("SP")) ? value : "SP0000";
    }

    public string TenSanPham
    {
        get => _tenSanPham;
        set
        {
            if (string.IsNullOrEmpty(value)) throw new Exception("Invalid format");
            _tenSanPham = value;
        }
    }

    public double GiaBan
    {
        get => _giaBan;
        set
        {
            if (value < 0) throw new Exception("Invalid format");
            _giaBan = value;
        }
    }

    public int SoLuong
    {
        get => _soLuong;
        set
        {
            if (value < 0) throw new Exception("Invalid format");
            _soLuong = value;
        }
    }

    public double TinhTien() => _soLuong * _giaBan * (1 + VAT);

    public ChiTietBanHang NhapTT()
    {
        Console.Write("Nhap Ma San Pham: ");
        MaSanPham = Console.ReadLine();
        Console.Write("Nhap Ten San Pham: ");
        TenSanPham = Console.ReadLine();
        Console.Write("Nhap So Luong: ");
        SoLuong = int.Parse(Console.ReadLine());
        Console.Write("Nhap Gia Ban: ");
        GiaBan = double.Parse(Console.ReadLine());
        return new ChiTietBanHang(MaSanPham, TenSanPham, GiaBan, SoLuong);
    }
    public void XuatTT()
    {
        Console.WriteLine("Ma San Pham: {0,10} | Ten San Pham: {1,15} | So Luong: {2,7} | Gia Ban: {3,10} | Thanh Tien: {4,20}", 
            MaSanPham, TenSanPham, SoLuong, GiaBan, TinhTien());
    }
}
