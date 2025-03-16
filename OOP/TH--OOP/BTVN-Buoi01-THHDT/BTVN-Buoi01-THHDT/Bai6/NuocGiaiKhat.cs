
public class NuocGiaiKhat
{
    private String _tenHang;
    private String _donViTinh;
    private int _soLuong;
    private Double _donGia;
    public static Double VAT = 0.1;

    public NuocGiaiKhat(string tenHang, string donViTinh, int soLuong, double donGia)
    {
        TenHang = tenHang;
        DonViTinh = donViTinh;
        SoLuong = soLuong;
        DonGia = donGia;
    }

    public NuocGiaiKhat()
    {
        _tenHang = "";
        _donViTinh = "";
        _soLuong = 0;
        _donGia = 0;
    }

    public void CapNhatVAT(Double _vat) => VAT = _vat;
    
    public string TenHang
    {
        get => _tenHang;
        set  
        {
            if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                throw new Exception("Ten hang can't be empty");
            _tenHang = value;
        }
    }

    public string DonViTinh
    {
        get => _donViTinh;
        set
        {
            if (value.Equals("Ket") || value.Equals("Thung") || value.Equals("Chai") || value.Equals("Lon"))
                _donViTinh = value;
            else
                _donViTinh = "Ket";
        }
    }

    public int SoLuong
    {
        get => _soLuong;
        set
        {
            if(value <= 0)
                throw new Exception("SoLuong can't be less than or equal to 0");
            _soLuong = value;
        }
    }

    public double DonGia
    {
        get => _donGia;
        set
        {
            if (value <= 0)
                throw new Exception("DonGia can't be less than or equal to 0");
            _donGia = value;
        }
    }

    public void InputInfo()
    {
        Console.Write("Ten hang: ");
        TenHang = Console.ReadLine();
        Console.Write("Don vi tinh(Ket - Thung - Chai - Lon): ");
        DonViTinh = Console.ReadLine();
        bool check;
        do
        {
            check = true;
            try
            {
                Console.Write("So Luong: ");
                SoLuong = int.Parse(Console.ReadLine());
                Console.Write("Don Gia: ");
                DonGia = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                check = false;
            }
        } while (!check);

    }
    
    public Double CalculateTotalCost()
    {
        if(_donViTinh.Equals("Ket") || _donViTinh.Equals("Thung"))
            return _soLuong * _donGia * (1 + VAT);
        if(_donViTinh.Equals("Chai"))
            return _soLuong * (_donGia / 20) * (1 + VAT);
        return _soLuong * (_donGia / 24) * (1 + VAT);
    }

    public void ShowInfo() => Console.WriteLine($"| {_tenHang,-30}| {_donGia,10}| {_donViTinh,-10}| {_soLuong,5}| {CalculateTotalCost()}");
    public override string ToString() => $"| {_tenHang, -30}| {_donGia, 10}| {_donViTinh, -10}| {_soLuong, 5}";
}