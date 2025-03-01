namespace BTVN_04;

public class HoGiaDinh
{
    private string maHo;
    private string tenChuHo;
    private long soDienDauKi;
    private long soDienCuoiKi;
    private string loaiHoGiaDinh;
    public static long giaDienQuyDinh = 3000;

    public HoGiaDinh()
    {

    }

    public HoGiaDinh(string maHo, string tenChuHo, long soDienDauKi, long soDienCuoiKi, string loaiHoGiaDinh)
    {
        MaHo = maHo;
        TenChuHo = tenChuHo;
        SoDienDauKi = soDienDauKi;
        SoDienCuoiKi = soDienCuoiKi;
        LoaiHoGiaDinh = loaiHoGiaDinh;
    }

    

    public HoGiaDinh(HoGiaDinh hoGiaDinh)
    {
        MaHo = hoGiaDinh.maHo;
        TenChuHo = hoGiaDinh.tenChuHo;
        SoDienDauKi = hoGiaDinh.soDienDauKi;
        SoDienCuoiKi = hoGiaDinh.soDienCuoiKi;
        LoaiHoGiaDinh = hoGiaDinh.loaiHoGiaDinh;
    }

    public string LoaiHoGiaDinh
    {
        get { return loaiHoGiaDinh; }
        set
        {
            if (value != "A" && value != "B" && value != "C")
                throw new Exception("Invalid LoaiHoGiaDinh");
            loaiHoGiaDinh = value;
        }
    }

    public string MaHo
    {
        get => maHo;
        set
        {
            if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                throw new Exception("MaHo cant be empty!");
            maHo = value;
        }
    }

    public string TenChuHo
    {
        get => tenChuHo;
        set
        {
            if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                throw new Exception("TenChuHo cant be empty!");
            tenChuHo = value;
        }
    }

    public long SoDienDauKi
    {
        get => soDienDauKi;
        set 
        {
            if(value < 0)
                throw new Exception("SoDienDauKi cant be negative!");       
            soDienDauKi = value;
        }
    }

    public long SoDienCuoiKi
    {
        get => soDienCuoiKi;
        set
        {
            if (value < 0 || value <= soDienDauKi)
                throw new Exception("SoDienCuoiKi is invalid!");
            soDienCuoiKi = value;
        }
    }

    public long TinhSoDienTieuThuThucTe() => soDienCuoiKi - soDienDauKi;

    public int TinhTienDienUuTien()
    {
        if (loaiHoGiaDinh.ToString() == "A")
            return 10;
        else if (loaiHoGiaDinh.ToString() == "B")
            return 5;
        return 0;
    }

    public long TinhTienDien() => (TinhSoDienTieuThuThucTe() - TinhTienDienUuTien()) * giaDienQuyDinh;

    public void NhapThongTinHoGiaDinh()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        do
        {
            try
            {
                Console.Write("Nhập Mã hộ: ");
                MaHo = Console.ReadLine();
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } while (true);

        do
        {
            try
            {
                Console.Write("Nhập tên chủ hộ: ");
                TenChuHo = Console.ReadLine();
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } while (true);

        do
        {
            try
            {
                Console.Write("Nhập số điện đầu kì: ");
                SoDienDauKi = long.Parse(Console.ReadLine());
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } while (true);

        do
        {
            try
            {
                Console.Write("Nhập số điện cuối kì: ");
                SoDienCuoiKi = long.Parse(Console.ReadLine());
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } while (true);

        do
        {
            try
            {
                Console.Write("Nhập loại hộ gia đình: ");
                LoaiHoGiaDinh = Console.ReadLine();
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } while (true);
    }




    public void XuatThongTinHoGiaDinh()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine($"{maHo, -10}| {tenChuHo, 20}| {soDienDauKi, 10}| {soDienCuoiKi, 10} | {loaiHoGiaDinh, 5}");
    }
}