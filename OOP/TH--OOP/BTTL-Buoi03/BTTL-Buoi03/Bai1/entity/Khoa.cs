using System.Xml;

namespace BTTLBuoi03.Bai1.entity;

public class Khoa
{
    private List<GiangVien> _listGiangVien;

    public List<GiangVien> ListGiangVien
    {
        get => _listGiangVien;
        set => _listGiangVien = value;
    }

    public Khoa()
    {
        _listGiangVien = new List<GiangVien>();
    }

    public void DocDSGiangVien(string fileName)
    {
        XmlDocument read = new XmlDocument();
        read.Load(fileName);
        XmlNodeList nodeList = read.SelectNodes("/Khoa/GiangVien");
        foreach (XmlNode node in nodeList)
        {
            GiangVien gv = new GiangVien();
            gv.HoTen = node["HoTen"].InnerText;
            gv.SoNhomHD = int.Parse(node["SoNhom"].InnerText);
            _listGiangVien.Add(gv);
        }
    }

    public void XuatDSGiangVien()
    {
        Console.WriteLine("\nHo Ten \t\t So nhom huong dan");
        foreach (var gvhd in _listGiangVien)
        {
            gvhd.Xuat();
        }
    }
       
    public int TinhTongSoNHomHD() => _listGiangVien.Sum(_ => _.SoNhomHD);

    public void SXTangDanHoTen() => _listGiangVien.OrderBy(_ => _.HoTen).ToList();
    
    public void SXGiamDanSoNhom() => _listGiangVien.OrderByDescending(_ => _.SoNhomHD).ToList();
        
    public List<GiangVien> LocSoNHomLonHon1() => _listGiangVien.Where(_ => _.SoNhomHD > 1).ToList();
    
}