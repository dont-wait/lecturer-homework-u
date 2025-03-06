namespace BTTL_05;

public class NhanVien
{
    protected String maNhanVien;
    protected String tenNhanVien;
    protected Double heSoLuong;
    protected String phongBan;
    protected int soNgayLamViec;

    public NhanVien(string maNhanVien, string tenNhanVien, double heSoLuong, string phongBan, int soNgayLamViec)
    {
        this.maNhanVien = maNhanVien;
        this.tenNhanVien = tenNhanVien;
        this.heSoLuong = heSoLuong;
        this.phongBan = phongBan;
        this.soNgayLamViec = soNgayLamViec;
    }
    
    public NhanVien() {}

    public String XepLoai()
    {
        if (soNgayLamViec > 25) 
            return "A";
        else if (soNgayLamViec > 22) 
            return "B";
        return "C";
    }

    public double TinhHeSoThiDua()
    {
        if (XepLoai() == "A")
            return 1.00;
        else if(XepLoai() == "B")
            return 0.75;
        return 0.5;
    }

    public virtual double TinhLuongNhanVien()
    {
        return 1200 * heSoLuong + TinhHeSoThiDua();
    }

    public virtual void InputInfo()
    {
        Console.Write("Input MaNhanVien: ");
        maNhanVien = Console.ReadLine();
        Console.Write("Input TenNhanVien: ");
        tenNhanVien = Console.ReadLine();
        Console.Write("Input HeSoLuong: ");
        heSoLuong = Double.Parse(Console.ReadLine());
        Console.Write("Input PhongBan: ");
        phongBan = Console.ReadLine();
        Console.Write("Input SoNgayLamViec: ");
        soNgayLamViec = int.Parse(Console.ReadLine());
    }
    
    public virtual void ShowInfo()
    {
        Console.WriteLine($"|{maNhanVien, -5}| {tenNhanVien, 30}| {heSoLuong, 5}| {phongBan, 10}| {soNgayLamViec, 5}|");
    }
}