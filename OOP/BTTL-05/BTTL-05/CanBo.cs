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
}