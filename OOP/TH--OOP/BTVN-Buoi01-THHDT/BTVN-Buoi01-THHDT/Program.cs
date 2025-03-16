internal class BTVN_Buoi01_THHDT
{
    static void Main(String[] args)
    {
        //PlayWithBai6();        
        PlayWithBai7();
    }

    static void PlayWithBai6()
    {
        NuocGiaiKhat cocas = new NuocGiaiKhat();
        cocas.InputInfo();
        NuocGiaiKhat pepsi = new NuocGiaiKhat("Pepsi vi chanh khong calo", "Ket", 100, 100);
        
        cocas.ShowInfo();
        pepsi.ShowInfo();
    }

    static void PlayWithBai7()
    {
        
        HinhChuNhat hcn = new HinhChuNhat();
        hcn.InputInfo();
        hcn.ShowInfo();
        HinhChuNhat hcn2 = new HinhChuNhat(5, 10);
        hcn2.ShowInfo();

        HinhChuNhat hcn3 = new HinhChuNhat(hcn2);
        hcn3.ShowInfo();
        
        hcn2.ChangeSize(6, 11, 0);
        hcn2.ShowInfo();
        
        hcn2.ChangeSize(hcn2, 1);
        hcn2.ShowInfo();

    }
    
}
