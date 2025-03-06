namespace BTTL_05;

public class Menu
{
    private void PrintMenu()
    {
        Console.WriteLine("Welcome to the BTTL-05 menu!");
        Console.WriteLine("1. Add an employee");
        Console.WriteLine("2. Show all employees");
        Console.WriteLine("3. Show all employee have level A");
        Console.WriteLine("4. Calculate Sum of Income employee");
        Console.WriteLine("5. Sort employees by Level");
        Console.WriteLine("0. Exit");
    }

    private void SubMenu()
    {
        Console.WriteLine("a. Add Nhan vien");
        Console.WriteLine("b. Add Can bo");
    }

    
    public void PlayWithMenu()
    {
        QuanLiNhanVien quanLiNhanVien = new QuanLiNhanVien();   
        int choice;
        do
        {
            PrintMenu();
            Console.Write("Choose an option: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    quanLiNhanVien.InputListNhanVien();
                    break;
                case 2:
                    quanLiNhanVien.ShowListInfo();
                    break;
                case 3:
                    quanLiNhanVien.PrintAEmployee();
                    
                    break;
                case 4:
                    Console.WriteLine($"Total Income: {quanLiNhanVien.CalculateIncome()} $");
                    break;
                case 5:
                    quanLiNhanVien.SortEmployees();
                    Console.WriteLine("Danh sach nhan vien sau khi sap xep tang dan theo xep loai");
                    quanLiNhanVien.ShowListInfo();
                    break;
                case 0:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Not a valid option");
                    break;
            }
        } while (choice != 0);
    }
}