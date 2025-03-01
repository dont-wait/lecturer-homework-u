namespace BTVN_04;

public class HoGiaDinh
{
    private string maHo;
    private string tenChuHo;
    private long soDienDauKi;
    private long soDienCuoiKi;
    private LoaiHoGiaDinhEnum loaiHoGiaDinh;
    public static long giaDienQuyDinh = 3000;

    public HoGiaDinh()
    {
        maHo = "";
        tenChuHo = "";
        soDienDauKi = 0;
        soDienCuoiKi = 0;
        loaiHoGiaDinh = LoaiHoGiaDinhEnum.C;
    }

    public HoGiaDinh(string maHo, string tenChuHo, long soDienDauKi, long soDienCuoiKi, LoaiHoGiaDinhEnum loaiHoGiaDinh)
    {
        MaHo = maHo;
        TenChuHo = tenChuHo;
        SoDienDauKi = soDienDauKi;
        SoDienCuoiKi = soDienCuoiKi;
        LoaiHoGiaDinhEnum = loaiHoGiaDinh;
    }

    public LoaiHoGiaDinhEnum LoaiHoGiaDinhEnum
    {
        get { return loaiHoGiaDinh; }
        set
        {
            if(value.ToString() != "A" || value.ToString() != "B")
                throw new Exception("LoaiHoGiaDinh enum is not valid");
        }
    }

    public HoGiaDinh(HoGiaDinh hoGiaDinh)
    {
        maHo = hoGiaDinh.maHo;
        tenChuHo = hoGiaDinh.tenChuHo;
        soDienDauKi = hoGiaDinh.soDienDauKi;
        soDienCuoiKi = hoGiaDinh.soDienCuoiKi;
        loaiHoGiaDinh = hoGiaDinh.loaiHoGiaDinh;
    }

    public string MaHo
    {
        get => maHo;
        set
        {
            if(String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                throw new Exception("MaHo cant be empty!");
            maHo = value;
        }
    }

    public string TenChuHo
    {
        get => tenChuHo;
        set
        {
            if(String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                throw new Exception("TenChuHo cant be empty!");
            TenChuHo = value;
        }
    }

    public long SoDienDauKi
    {
        get => soDienDauKi;
        set 
        {
            if(value < 0)
                throw new Exception("SoDienDauKi cant be negative!");       
        }
    }

    public long SoDienCuoiKi
    {
        get => soDienCuoiKi;
        set
        {
            if (value < 0 || value >= soDienDauKi)
                throw new Exception("SoDienCuoiKi is invalid!");
        }
    }

    public long TinhTienDienThucTe() => soDienCuoiKi - soDienDauKi;

    public int TinhTienDienUuTien()
    {
        if (loaiHoGiaDinh.ToString() == "A")
            return 10;
        else if (loaiHoGiaDinh.ToString() == "B")
            return 5;
        return 0;
    }

    public long TinhTienDien() => (TinhTienDienThucTe() - TinhTienDienUuTien()) * giaDienQuyDinh;

    public void NhapThongTinHoGiaDinh()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        
        Console.Write("Input ma ho: ");
        maHo = Console.ReadLine();
        
        Console.Write("Input ten chu ho: ");
        tenChuHo = Console.ReadLine();
        
        Console.Write("Input a so dien dau ki: ");
        soDienDauKi = long.Parse(Console.ReadLine());
        
        
        Console.Write("Input a so dien cuoi ki: ");
        soDienDauKi = long.Parse(Console.ReadLine());
        
        Console.Write("Input a loai ho: ");
        string input = Console.ReadLine();
        LoaiHoGiaDinhEnum loaiHoGiaDinhEnum = (LoaiHoGiaDinhEnum)Enum.Parse(typeof(LoaiHoGiaDinhEnum), input);
    }

    public void XuatThongTinHoGiaDinh()
    {
        Console.WriteLine($"{maHo} | {tenChuHo} | {soDienDauKi} | {soDienCuoiKi} | {loaiHoGiaDinh}");
    }
}