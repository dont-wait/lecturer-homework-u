using System;
using System.Text;

namespace BaiTapSanPham.entity
{
  
    public class SanPham
    {
        private string tenSanPham;
        private double giaSanPham;
        private double giamGia;
        private double phanTramThueNhapKhau;

        public SanPham() { }

        public SanPham(string tenSanPham, double giaSanPham, double giamGia)
        {
            TenSanPham = tenSanPham;
            GiaSanPham = giaSanPham;
            GiamGia = giamGia;
        }

        public SanPham(SanPham sanPham)
        {
            TenSanPham = sanPham.TenSanPham;
            GiaSanPham = sanPham.GiaSanPham;
            GiamGia = sanPham.GiamGia;
        }

        public string TenSanPham
        {

            get => tenSanPham;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Tên sản phẩm không được để trống.");
                tenSanPham = value;
            }
        }

        public double GiaSanPham
        {
            get => giaSanPham;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Giá sản phẩm phải lớn hơn 0.");
                giaSanPham = value;
            }
        }

        public double GiamGia
        {
            get => giamGia;
            set
            {
                if (value < 0 || value > 1)
                    throw new ArgumentException("Giảm giá phải nằm trong khoảng 0 - 1.");
                giamGia = value;
            }
        }

        public double PhanTramThueNhapKhau
        {
            get => phanTramThueNhapKhau;
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("Thuế nhập khẩu phải nằm trong khoảng 0 - 1.");
                phanTramThueNhapKhau = value;
            }
        }

        public void NhapThongTinSanPham()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập tên sản phẩm: ");
            TenSanPham = Console.ReadLine();
            Console.Write("Nhập giá sản phẩm: ");
            GiaSanPham = double.Parse(Console.ReadLine());
            Console.Write("Nhập giảm giá: ");
            GiamGia = double.Parse(Console.ReadLine());
            Console.Write("Nhập thuế nhập khẩu: ");
            PhanTramThueNhapKhau = double.Parse(Console.ReadLine());
        }

        public double TinhphanTramThueNhapKhau() => GiaSanPham * phanTramThueNhapKhau;

        public void XuatThongTinSanPham()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Tên Sản Phẩm: {TenSanPham} | Giá Sản Phẩm: {GiaSanPham} | Giảm giá: {GiamGia} | Thuế nhập khẩu: {TinhphanTramThueNhapKhau()}");
        }
    }
}