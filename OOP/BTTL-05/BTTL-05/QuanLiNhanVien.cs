namespace BTTL_05;

public class QuanLiNhanVien
{
    private List<NhanVien> danhSachNhanvien;

    public QuanLiNhanVien()
    {
        danhSachNhanvien = new List<NhanVien>();
        
    }
    
    public void InputListNhanVien()
    {
        Console.Write("Input size of list: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Choose type of employee:");
            Console.WriteLine("1. NhanVien");
            Console.WriteLine("2. Canbo");
            Console.Write("Enter your choice (1 or 2): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Input NhanVien#" + (i + 1));
                    NhanVien nhanVien = new NhanVien();
                    nhanVien.InputInfo();
                    danhSachNhanvien.Add(nhanVien);
                    break;

                case 2:
                    Console.WriteLine("Input Canbo#" + (i + 1));
                    CanBo canbo = new CanBo();
                    canbo.InputInfo();
                    danhSachNhanvien.Add(canbo);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                    i--; // Decrement i to repeat this iteration
                    break;
            }
        }
    }
    
    public void ShowListInfo()
    {
        Console.WriteLine("Danh sach nhan vien:");
        danhSachNhanvien.ForEach(x => x.ShowInfo());
    }

    public double CalculateIncome() => danhSachNhanvien.Sum(x => x.TinhLuongNhanVien());

    public void PrintAEmployee()
    {
        Console.WriteLine("Danh sach nhan vien xep loai A:");
        foreach (var nhanVien in danhSachNhanvien)
        {
            if (IsXepLoaiA(nhanVien.XepLoai())) 
                nhanVien.ShowInfo();
        }
        danhSachNhanvien.Where(x => IsXepLoaiA(x.XepLoai()));
    }

    public void SortEmployees() => danhSachNhanvien.OrderBy(x => x.XepLoai());
    private Boolean IsXepLoaiA(String xepLoai) => String.Equals(xepLoai, "A");
}