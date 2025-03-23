namespace BTTLBuoi03.Bai2.entity;

public class GiangVien
{
    private string _hoTen;
    private int _soNhomHD;

    public string HoTen
    {
        get => _hoTen;
        set
        {
            if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                throw new Exception("Invalid format");
            _hoTen = value;
        }
    }

    public int SoNhomHD
    {
        get => _soNhomHD;
        set
        {
            if(value <= 0)
                throw new Exception("Invalid format");
            _soNhomHD = value;
        }
    }
    public GiangVien() {}

    public GiangVien(string hoTen, int soNhomHD)
    {
        HoTen = hoTen;
        SoNhomHD = soNhomHD;
    }

    public void Xuat()
    {
        Console.WriteLine($"{_hoTen} \t\t {_soNhomHD}");
    }
}