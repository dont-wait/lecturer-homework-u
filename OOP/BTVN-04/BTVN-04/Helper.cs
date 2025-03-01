using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_04
{
    class Helper
    {
        public void PrintMenu()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("1. Nhập danh sách hộ gia đình");
            Console.WriteLine("2. Tính tiền điện");
            Console.WriteLine("3. Tìm hộ gia đình có tiêu thụ điện cao nhất");
            Console.WriteLine("4. Sắp xếp danh sách giảm dần theo số điện tiêu thụ");
            Console.WriteLine("0. Exit");
        }
        public void HandleMenu(QuanLiHoGiaDinh quanLiHoGiaDinh)
        {
            bool exit = false;
            while (!exit)
            {
                PrintMenu();
                Console.Write("Chọn một tùy chọn: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        quanLiHoGiaDinh.NhapDanhSachSoHoGiaDinh();
                        break;
                    case 2:
                        long totalElectricityBill = quanLiHoGiaDinh.TinhTongTienDienCuaCacHoGiaDinh();
                        Console.WriteLine($"Tổng tiền điện của các hộ gia đình: {totalElectricityBill} đồng");
                        break;
                    case 3:
                        HoGiaDinh hoGiaDinhMax = quanLiHoGiaDinh.TimHoGiaDinhCoTieuThuDienCaoNhat();
                        Console.WriteLine("Hộ gia đình có tiêu thụ điện cao nhất:");
                        hoGiaDinhMax.XuatThongTinHoGiaDinh();
                        break;
                    case 4:
                        quanLiHoGiaDinh.SapXepDanhSachHoGiaDinhGiamDanTheoSoDienTieuThu();
                            
                        Console.WriteLine("Danh sách hộ gia đình sắp xếp giảm dần theo số điện tiêu thụ:");
                        quanLiHoGiaDinh.XuatDanhSachHoGiaDinh();
                        break;
                    case 0:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            }
        }
    }
}
