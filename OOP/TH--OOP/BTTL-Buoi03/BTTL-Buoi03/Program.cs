using BTTLBuoi03.Bai1.entity;
using BTTLBuoi03.Bai2.entity;

namespace BTTLBuoi03
{
    class Program
    {
        static void Bai2()
        {
            Khoa2 khoa = new Khoa2();
            string filePath = "/home/dontwait/Documents/SEMESTER04/lecturer-homework-u/OOP/TH--OOP/BTTL-Buoi03/BTTL-Buoi03/Bai2/Khoa.xml";
            khoa.DocDSGiangVien(filePath);
            khoa.Xuat();
        }

       
        static void Main(string[] args)
        {
            Bai2();
        }
    }
}

