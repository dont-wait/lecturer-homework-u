using BTVN_NguyenTanSang_B2.entity;

namespace BTVN_NguyenTanSang_B2.dao;

public class ListNhanVien
{
    private List<NhanVien> listNhanVien;

    public ListNhanVien()
    {
        listNhanVien = new List<NhanVien>();

        listNhanVien.Add(new NhanVien("NV001", "Nguyen Van A", "IT", "Lanh Dao", 4.5, 10, 25));
        listNhanVien.Add(new NhanVien("NV002", "Tran Thi B", "Ke toan", "Nhan Vien", 3.2, 5, 20));
        listNhanVien.Add(new NhanVien("NV003", "Le Van C", "Tai Vu", "Lanh Dao", 4.34, 7, 23));
        listNhanVien.Add(new NhanVien("NV004", "Pham Hong D", "IT", "Nhan Vien", 3.6, 8, 8));
        listNhanVien.Add(new NhanVien("NV005", "Vo Thi E", "Nhan su", "Lanh Dao", 4.2, 12, 22));
        listNhanVien.Add(new NhanVien("NV006", "Bui Minh F", "Marketing", "Nhan Vien", 3.8, 9, 24));
        listNhanVien.Add(new NhanVien("NV007", "Ly Van G", "Ke toan", "Nhan Vien", 3.0, 6, 21));
        listNhanVien.Add(new NhanVien("NV008", "Ngo Thi H", "Nhan su", "Nhan Vien", 2.9, 4, 19));

    }

    public ListNhanVien(List<NhanVien> listNhanVien)
    {
        this.listNhanVien = listNhanVien;
    }

    public void InputListNhanVien()
    {
        Console.Write("Input size of list: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Input info #{i + 1}");
            listNhanVien.Add(new NhanVien().InputInfo());
        }

        Console.WriteLine("Successfull");
    }

    public void xuatTT()
    {
        Console.WriteLine("-------------------Danh sach nhan vien---------------");
        if(!listNhanVien.Any())
            Console.WriteLine("Rong");
        else
            foreach (var _ in listNhanVien)
            {
                _.xuatTT();
            }
    }
    private List<NhanVien> FilterNhanVienTheoHeSoThiDua(double heSoThiDua) =>
        listNhanVien.Where(nv => nv.TinhHeSoThiDua() == heSoThiDua).ToList();
    
    private List<NhanVien> FilterNhanVienTheoPhongBan(String phongBan) =>
    listNhanVien.Where(nv => nv.PhongBan == phongBan).ToList();

    public void XuatDanhSachNhanVienTheoPhongBan(String phongBan)
    {
        Console.WriteLine($"Danh sach nhan vien thuoc phong ban: {phongBan}");
        var listNhanVienPhongBan = FilterNhanVienTheoPhongBan(phongBan);
        foreach (var nvPB in listNhanVienPhongBan)
        {
            nvPB.xuatTT();
        }
    }
    public void xuatDanhSachCoChucVuLanhDao()
    {
        Console.WriteLine("--------Danh Sach Nhan vien chuc vu lanh dao--------------------");
        var lanhDaoList = listNhanVien.Where(t => t.ChucVu == "Lanh Dao").ToList();
        foreach(var nv in lanhDaoList)
        {
            nv.xuatTT();
        }
        if(!lanhDaoList.Any())
        {
            Console.WriteLine("Nhan Vien khong co chuc vu lanh dao.");
        }
    }

    private void XuatDanhSachTheoHeSoThiDua(double heSoThiDua)
    {
        var danhSachCoHeSo = FilterNhanVienTheoHeSoThiDua(heSoThiDua);
        Console.WriteLine($"----------------------------Danh Sach Thi Dua {heSoThiDua}----------------------------");
        foreach (var nv in listNhanVien)
        {
            nv.xuatTT();
        }
    }

    public void XuatDanhSachHeSoThiDua()
    {
        double[] _arr = { 1.0, 0.8, 0.6 };

        foreach (var heSo in _arr)
        {
            XuatDanhSachTheoHeSoThiDua(heSo);
        }
    }

    public double TinhTongLuong() => listNhanVien.Sum(nv => nv.TinhLuong());

    public void XoaNhanVienLamViecDuoi10Ngay() => listNhanVien.RemoveAll(nv => nv.SoNgayLamViecTrongThang < 10);

    public void XuatDanhSachNhanVienKhongPhaiLanhDaoNhungLamTren22Ngay()
    {
        List<NhanVien> listNVGuongMau = listNhanVien
        .Where(nv => !nv.ChucVu.Equals("Lanh dao") && nv.SoNgayLamViecTrongThang >= 22).ToList();

        if (!listNVGuongMau.Any())
            Console.WriteLine("Ko co ai guong mau het");
        else
        {
            Console.WriteLine("Danh sach nhan vien guong mau");
            foreach (var _ in listNVGuongMau)
            {
                _.xuatTT();
            }
        }
    }

    public void XuatDanhSachNhanVienCoHSLonHon4_34VaOPhongTaiVu()
    {
        List<NhanVien> listNVTVChamChi = listNhanVien
            .Where(nv => nv.ChucVu.Equals("Tai vu") && nv.HeSoLuong.Equals(4.34)).ToList();

        if (!listNVTVChamChi.Any())
            Console.WriteLine("Ko co ai cham chi het");
        else
        {
            Console.WriteLine("Danh sach nhan vien cham chi");
            foreach (var _ in listNVTVChamChi)
            {
                _.xuatTT();
            }
        }
    }
    
}