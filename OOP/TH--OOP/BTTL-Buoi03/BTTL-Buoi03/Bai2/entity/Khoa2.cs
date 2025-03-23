using System.Xml;

namespace BTTLBuoi03.Bai2.entity;

public class Khoa2
{
    private string _tenKhoa;
    private string _viTri;
    private string _soDienThoai;
    private string _soNganh;
    private List<GiangVien> _listGiangVien;

    public List<GiangVien> ListGiangVien
    {
        get => _listGiangVien;
        set => _listGiangVien = value;
    }

    public Khoa2()
    {
        _listGiangVien = new List<GiangVien>();
    }

    public void DocDSGiangVien(string fileName)
    {
        XmlDocument read = new XmlDocument();
        read.Load(fileName);
        this._tenKhoa = read.SelectSingleNode("/Khoa/TenKhoa").InnerText;
        this._viTri = read.SelectSingleNode("/Khoa/ViTri").InnerText;
        this._soDienThoai = read.SelectSingleNode("/Khoa/SDT").InnerText;
        this._soNganh = read.SelectSingleNode("/Khoa/SoNganh").InnerText;
        
        XmlNodeList nodeList = read.SelectNodes("/Khoa/DSGV/GiangVien");
        foreach (XmlNode node in nodeList)
        {
            GiangVien gv = new GiangVien();
            gv.HoTen = node["HoTen"].InnerText;
            gv.SoNhomHD = int.Parse(node["SoNhom"].InnerText);
            _listGiangVien.Add(gv);
        }
    }

    public void Xuat() {
        Console.WriteLine("Thong tin Khoa:");
        Console.WriteLine("Ten Khoa: {0}", _tenKhoa);
        Console.WriteLine("Vi tri: {0}", _viTri);
        Console.WriteLine("So dien thoai: {0}", _soDienThoai);
        Console.WriteLine("So nganh Khoa quan ly: {0}", _soNganh);
        Console.WriteLine("-----Danh sach tat ca giang vien-----");
        Console.WriteLine("Ho Ten \t\t So nhom huong dan");

        foreach (GiangVien gvhd in _listGiangVien)
            gvhd.Xuat();
    }

       
    public int TinhTongSoNHomHD() => _listGiangVien.Sum(_ => _.SoNhomHD);

    public void SXTangDanHoTen() => _listGiangVien.OrderBy(_ => _.HoTen).ToList();
    
    public void SXGiamDanSoNhom() => _listGiangVien.OrderByDescending(_ => _.SoNhomHD).ToList();
        
    public List<GiangVien> LocSoNHomLonHon1() => _listGiangVien.Where(_ => _.SoNhomHD > 1).ToList();
    
}