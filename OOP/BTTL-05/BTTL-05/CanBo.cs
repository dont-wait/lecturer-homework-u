namespace BTTL_05;

public class CanBo : NhanVien
{
    private String chucVu;
    private Double heSoChucVu;

    public CanBo(string maNhanVien, string tenNhanVien, double heSoLuong, string phongBan, int soNgayLamViec, string chucVu, double heSoChucVu) : base(maNhanVien, tenNhanVien, heSoLuong, phongBan, soNgayLamViec)
    {
        this.chucVu = chucVu;
        this.heSoChucVu = heSoChucVu;
    }
    
    public CanBo() {}
    
    public override double TinhLuongNhanVien()
    {
        return 1210 * heSoLuong * TinhHeSoThiDua() + heSoChucVu * 1100;
    }

    public override void InputInfo()
    {
        base.InputInfo();
        Console.Write("Input chuc vu: ");
        chucVu = Console.ReadLine();
        Console.WriteLine("Input he so chuc vu");
        heSoChucVu = double.Parse(Console.ReadLine());
    }
    
    public override void ShowInfo()
    {
        Console.WriteLine($"|{maNhanVien, -5}| {tenNhanVien, 30}| {heSoLuong, 5}| {phongBan, 10}| {soNgayLamViec, 5}| {chucVu, 5}| {heSoChucVu, 3}|");
    }
}