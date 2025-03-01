using BTVN_04;
class Program
{
    public static void Main(String[] args)
    {
        QuanLiHoGiaDinh quanLiHoGiaDinh = new QuanLiHoGiaDinh();
        Helper helper = new Helper();
        helper.HandleMenu(quanLiHoGiaDinh);
    }
}
