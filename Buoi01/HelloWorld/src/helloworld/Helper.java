package helloworld;

import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import java.util.Scanner;

public class Helper {

    private Scanner sc = new Scanner(System.in);

    public void printTriangleEmpty(int h) {
        for (int i = 0; i < h; i++) {
            for (int j = 0; j < h - i; j++) {
                System.out.print(" ");
            }
            for (int j = 0; j < (2 * i + 1); j++) {
                if (j == 0 || j == (2 * i) || i == h - 1) {
                    System.out.print("*");
                } else {
                    System.out.print(" ");
                }
            }
            System.out.println();
        }
    }
    public void printTriangle(int h) {
        for (int i = 0; i < h; i++) {

            for (int j = 0; j < h - i; j++)
                System.out.print(" ");

            for (int j = 0; j <= 2 * i; j++)
                System.out.print("*");

            System.out.println();
        }
    }

    public void printRectangleEmpty(int row, int col) {
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                if(i == 0 || i == row - 1 || j == 0 || j == col - 1)
                    System.out.print("*");
                else
                    System.out.print(" ");
            }
            System.out.println();
        }
    }

    public void printRectangle(int row, int col) {
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                System.out.print("*" + " ");
            }
            System.out.println();
        }
    }

    public int getSumOfEvenDigits(int n) {
        int sum = 0;
        n = Math.abs(n);
        while(n != 0) {
            int remainder = n % 10;
            if((remainder & 1) == 0) {
                sum += remainder;
            }
            n /= 10;
        }
        return sum;
    }

    public int countOddDigits(int n) {
        n = Math.abs(n);
        int count = 0;
        while(n != 0) {
            int remainder = n % 10;
            if ((remainder & 1) != 0)
                count++;
            n /= 10;
        }
        return count;
    }

    public double getSumDouble() {
        boolean flag = false;
        double sum = 0;

        do {
            double temp;
            System.out.print("Input a number not equal to zero: ");
            temp = Double.parseDouble(sc.nextLine());
            if(isZero(temp))
                flag = true;
            else
                sum += temp;
        }while(!flag);

        return sum;
    }

    public boolean isZero(double n) {
        return n == 0;
    }

    public boolean isPrime(double n) {
        for(int i = 2; i <= Math.sqrt(n); i++)
            if(n % i == 0)
                return false;
        return true;
    }

    public int countUocSoLe(int n) {
        int count = 0;
        for(int i = 1; i <= n; i++)
            if(n % i == 0 && (i % 2) != 0)
                count++;
        return count;
    }

    public int countUocSo(int n) {
        int count = 0;
        for(int i = 1; i <= n; i++)
            if(n % i == 0)
                count++;
        return count;
    }


    public String dateNextFormat(String dateString) throws ParseException {
        DateFormat dateFormat = new SimpleDateFormat("yyyyMMdd");
        Date myDate = dateFormat.parse(dateString);

        Calendar calender = Calendar.getInstance();
        calender.setTime(myDate);
        calender.add(Calendar.DAY_OF_YEAR, +1);

        Date nextDate = calender.getTime();
        String result = dateFormat.format(nextDate);
        return result;
    }

    public String datePrevioutFormat(String dateString) throws ParseException {
        DateFormat dateFormat = new SimpleDateFormat("yyyyMMdd");
        Date myDate = dateFormat.parse(dateString);

        Calendar calender = Calendar.getInstance();
        calender.setTime(myDate);
        calender.add(Calendar.DAY_OF_YEAR, -1);

        Date previousDate = calender.getTime();
        String result = dateFormat.format(previousDate);
        return result;
    }

    public boolean kiemTraNgayHopLe(int day, int month, int year) {
        switch (month) {
            case 1, 3, 5, 7, 9, 11:
                if (day > 31 || day < 0) {
                    return false;
                }
                return true;
            case 4, 6, 8, 10, 12:
                if (day > 30 || day < 0) {
                    return false;
                }
                return true;
            case 2:
                boolean checkYear = kiemTraNamNhuan(year);
                if (checkYear == true && day <= 29) {
                    return true;
                } else if (!checkYear && day <= 28) {
                    return true;
                }
                return false;
            default:
                throw new AssertionError("That is bug!");
        }
    }

    public int khoiTaoNgay(int month, int year) {
        int day;
        do {
            System.out.print("input a day: ");
            day = sc.nextInt();

            if (!kiemTraNgayHopLe(day, month, year)) {
                System.out.println("Invalid");
            }
        } while (!kiemTraNgayHopLe(day, month, year));
        return day;
    }

    public int khoiTaoThang() {
        int month;
        do {
            System.out.print("input a moth: ");
            month = sc.nextInt();
            if (month < 1 || month > 12) {
                System.out.println("Month must between 1..12");
            }
        } while (month < 1 || month > 12);
        return month;
    }

    public int khoiTaoNam() {
        int year;
        do {
            System.out.print("Input a year: ");
            year = sc.nextInt();
            if (year < 0) {
                System.out.println("Year must be greater than 0");
            }
        } while (year < 0);
        return year;
    }

    public double tinhTienDien(double dienCu, double dienMoi) {
        double soDien = dienMoi - dienCu;
        if (soDien <= 50) {
            return soDien * 1480;
        } else if (soDien <= 100) {
            return 50 * 1480 + (soDien - 50) * 1533;
        } else if (soDien <= 200) {
            return 50 * 1480 + 50 * 1533 + (soDien - 100) * 1786;
        } else if (soDien <= 300) {
            return 50 * 1480 + 50 * 1533 + 100 * 2242 + (soDien - 200) * 2242;
        } else {
            return 50 * 1480 + 50 * 1533 + 100 * 2242 + (soDien - 300) * 2593;
        }
    }

    public int getDateOfMonth(int month) {
        switch (month) {
            case 1, 3, 5, 7, 9, 11:
                return 31;
            case 4, 6, 8, 10, 12:
                return 30;
            case 2:
                int year;
                System.out.print("Input a year you want: ");
                year = sc.nextInt();
                boolean checkYear = kiemTraNamNhuan(year);
                if (checkYear == true) {
                    return 29;
                }
                return 28;
            default:
                throw new AssertionError("Dinh dang khong hop le");
        }
    }

    public boolean kiemTraNamNhuan(int year) {
        if (year * 400 == 0 || year % 4 == 0) {
            return true;
        }
        return false;
    }
}
