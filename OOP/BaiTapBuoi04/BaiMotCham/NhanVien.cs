namespace BaiMotCham;

public class NhanVien
{
    private String maNhanVien;
    private String hoTen;
    private int NVL;
    private int hsl;
    static long MLTT = 1800;

    
    static void CapNhatMTT(long mltt)
    {
        MLTT = mltt;
    }

    public NhanVien()
    {
        maNhanVien = "hello01";
        hoTen = "Bui Quoc Tri";
        NVL = 2020;
        hsl = 1800000;
    }

    public NhanVien(String maNhanVien, String hoTen, int NVL, int hsl)
    {
        this.maNhanVien = maNhanVien;
        this.hoTen = hoTen;
        this.NVL = NVL;
        this.hsl = hsl;
    }

    public NhanVien(NhanVien obj)
    {
        maNhanVien = obj.maNhanVien;
        hoTen = obj.hoTen;
        NVL = obj.NVL;
        hsl = obj.hsl;
    }

    public double TinhHSPCTN() => (DateTime.Now.Year - NVL) / 100.0;

    public double TinhLuongCoBan() => hsl * MLTT;

    public double TinhLuongNhanVien() => TinhLuongCoBan() * (1 + TinhHSPCTN());

    public void showInfoNV()
    {
        Console.WriteLine($"{maNhanVien} - {hoTen} - {NVL} - {hsl} - {TinhLuongNhanVien()}");
    }
}