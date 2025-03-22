namespace BTVN_NguyenTanSang_B2.entity;

public class NhanVien
{
    private String _maNhanVien;
    private String _tenNhanVien;
    private String _phongBan;
    private String _chucVu;
    private double _heSoLuong;
    private int _thamNienCongTac;
    private int _soNgayLamViecTrongThang;
    public static double luongCoBan = 2340000;
    public static double phuCapLanhDao = 1350000;

    public NhanVien()
    {

    }
    public NhanVien(String maNhanVien, String tenNhanVien, String phongBan, String chucVu, double heSoLuong, int thamNienCongTac, int soNgayLamViecTrongThang)
    {
        MaNhanVien = maNhanVien;
        TenNhanVien = tenNhanVien;
        PhongBan = phongBan;
        ChucVu = chucVu;
        HeSoLuong = heSoLuong;
        ThamNienCongTac = thamNienCongTac;
        SoNgayLamViecTrongThang = soNgayLamViecTrongThang;
    }
    public string MaNhanVien
        {
            get { return _maNhanVien; }
            set
            {
                if(String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                    throw new Exception("Invalid format");
                _maNhanVien = value;
            }
        }

    public string TenNhanVien
    {
        get
        {
            return _tenNhanVien;
        }
        set
        {
            if(string.IsNullOrEmpty(value))
                throw new Exception("Invalid format");
            _tenNhanVien = value;
        }
    }

    public string PhongBan
    {
        get
        {
            return _phongBan;
        }
        set
        {
            if(string.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
            {
                throw new Exception("Invalid format");
            }
            else
            {
                _phongBan = value;
            }
        }
    }

    public string ChucVu
    {
        get
        {
            return _chucVu;
        }
        set
        {
            if(value.Equals("Nhan Vien") || value.Equals("Lanh Dao"))
            {
                _chucVu = value;
            }
            else
            {
                throw new Exception("Invalid format");
            }
        }
    }

    public double HeSoLuong
    {
        get
        {
            return _heSoLuong;
        }
        set
        {
            if (value < 0)
            {
                throw new Exception("Erol");
            }
            else
            {
                _heSoLuong = value;
            }
        }
    }

    public int ThamNienCongTac
    {
        get
        {
            return _thamNienCongTac;
        }
        set
        {
            if (value < 0)
            {
                throw new Exception("Erol");
            }
            else
            {
                _thamNienCongTac = value;
            }
        }
    }

    public int SoNgayLamViecTrongThang
    {
        get
        {
            return _soNgayLamViecTrongThang;
        }
        set
        {
            if (value < 0)
                throw new Exception("Invalid format");
            _soNgayLamViecTrongThang = value;
        }
    }

    public double TinhHeSoThiDua()
    {
        if(_chucVu == "Lanh Dao") 
            return 1.0;
        else {
            if(_soNgayLamViecTrongThang > 22) {
                return 1.0;
            }
            else if(_soNgayLamViecTrongThang > 20) {
                return 0.8;
            }
            return 0.6;
        }
    }

    public double TinhPhuCap() => _chucVu == "Lanh Dao" ? phuCapLanhDao : 0; 
    public double TinhLuong() => HeSoLuong * luongCoBan * TinhHeSoThiDua() + 1100000 + TinhPhuCap();
    public NhanVien InputInfo()
    {
        Console.WriteLine("Nhap Ma So Nhan Vien: ");
        MaNhanVien = Console.ReadLine();
        
        Console.WriteLine("Nhap Ten Nhan Vien: ");
        TenNhanVien = Console.ReadLine();
        
        Console.WriteLine("Nhap Phong Ban: ");
        PhongBan = Console.ReadLine();
        
        Console.WriteLine("Nhap Chuc vu: ");
        ChucVu = Console.ReadLine();
        
        Console.WriteLine("Nhap He So Luong: ");
        HeSoLuong = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Nhap Nam Tham Nien Cong Tac: ");
        ThamNienCongTac = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Nhap So NGay Lam Viec Trong 1 Thang: ");
        SoNgayLamViecTrongThang = int.Parse(Console.ReadLine());
        
        return new NhanVien(MaNhanVien, TenNhanVien, PhongBan, ChucVu, HeSoLuong, ThamNienCongTac, SoNgayLamViecTrongThang);
    }

    public void xuatTT()
    {
        Console.WriteLine("Ma Nhan Vien: {0,10} | Ten Nhan Vien: {1,15} | Phong Ban: {2, 10} | Chuc Vu: {3,15} | He So Luong: {4,10} | Tham Nien Cong Tac: {5,10} | So Ngay Lam: {6, 10} | Luong: {7,20} ", MaNhanVien, TenNhanVien, PhongBan, ChucVu, HeSoLuong, ThamNienCongTac,SoNgayLamViecTrongThang, TinhLuong());
    }
}