using BaiTapSanPham.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapSanPham
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TestCase();
        }
        static void TestCase()
        {
            Console.OutputEncoding = Encoding.UTF8;

            SanPham sp1 = new SanPham();
            SanPham sp2 = new SanPham();

            sp1.NhapThongTinSanPham();
            sp1.XuatThongTinSanPham();

            sp2.NhapThongTinSanPham();
            sp2.XuatThongTinSanPham();
        }
    }
}
