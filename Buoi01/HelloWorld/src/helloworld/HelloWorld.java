/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package helloworld;

import java.text.ParseException;
import java.util.Scanner;

/**
 *
 * @author Administrator
 */
public class HelloWorld {

    static Scanner sc = new Scanner(System.in);
    static Helper helper = new Helper();
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws ParseException {
        //baiMotChamBa();
        //baiMotChamBon();
        //baiMOtChamNam();
        //baiMotChamSau();
        //baiMotChamBay();
        //baiMotChamTam();
        //baiMotChamChin();
        //baiMotChamMuoi();
        //baiMotChamMuoiMot();
        //baiMotChamMuoiHai();
        //baiMotChamMuoiBa();
        //baiMoiChamMuoiBon();
        //baiMotChamMuoiNam();
        //baiMotChamMuoiSau();
        //baiMotChamMuoiBay();
        // baiMotChamMuoiTam();
        // baiMotChamMuoiChin();
        //baiMotChamHaiMuoi();
        baiMotChamHaiMuoiMot();
    }

    public static void baiMotChamHaiMuoiMot() {
        System.out.print("Input a integer number: ");
        int h = sc.nextInt();
        helper.printTriangleEmpty(h);
    }

    public static void baiMotChamHaiMuoi() {
        System.out.print("Input a integer number: ");
        int h = sc.nextInt();
        helper.printTriangle(h);
    }

    public static void baiMotChamMuoiChin() {
        int m, n;
        System.out.print("Input m, n: ");
        m = sc.nextInt();
        n = sc.nextInt();

        helper.printRectangleEmpty(m, n);
    }

    public static void baiMotChamMuoiTam() {
        int m, n;
        System.out.print("Input m, n: ");
        m = sc.nextInt();
        n = sc.nextInt();

        helper.printRectangle(m, n);
    }

    public static void baiMotChamMuoiBay() {
        System.out.print("Input a integer number: ");
        int n = sc.nextInt();

        System.out.println("Sum of even digit: " + helper.getSumOfEvenDigits(n));
    }

    public static void baiMotChamMuoiSau() {
        System.out.print("Input a integer number: ");
        int n = sc.nextInt();

        System.out.println("A number has: " + helper.countOddDigits(n) + " odd digits");
    }

    public static void baiMotChamMuoiNam() {
        double sum = helper.getSumDouble();
        System.out.println(sum);
    }

    public static void baiMoiChamMuoiBon() {
        System.out.print("Input n: ");
        //int n = Integer.parseInt(sc.nextLine());
        double n = sc.nextDouble();
        boolean check = helper.isPrime(n);

        if(check)
            System.out.println("Prime Number");
        else
            System.out.println("Not Prime Number");

    }

    public static void baiMotChamMuoiBa() {
        int n;
        Helper helper = new Helper();
        System.out.print("Input n: ");
        n = Integer.parseInt(sc.nextLine());
        System.out.println(helper.countUocSoLe(n));

    }

    
    public static void baiMotChamMuoiHai() {
        int n;
        System.out.print("Input n: ");

        n = Integer.parseInt(sc.nextLine());
        System.out.println(helper.countUocSo(n));
    }
    

    
    public static void baiMotChamMuoiMot() throws ParseException {
        String dateString = "20201201";
        try {
            System.out.println(helper.datePrevioutFormat(dateString));
            System.out.println(helper.dateNextFormat(dateString));
        }catch(ParseException e) {
            System.out.println("Invalid date string");
            e.printStackTrace();
        }
    }

    public static void baiMotChamMuoi() {
        int year = helper.khoiTaoNam();
        int month = helper.khoiTaoThang();
        int day = helper.khoiTaoNgay(month, year);

        System.out.println(day + "/" + month + "/" + year);
    }




    public static void baiMotChamChin() {
        double dienCu, dienMoi;

        do {
            System.out.print("Nhap dien cu: ");
            dienCu = Double.parseDouble(sc.nextLine());

            System.out.print("Nhap dien moi: ");
            dienMoi = Double.parseDouble(sc.nextLine());

            if (dienCu > dienMoi) {
                System.out.println("dien cu phai < dien moi");
            }
        } while (dienCu > dienMoi);

        System.out.println("So tien dien phai tra cho " + (dienMoi - dienCu) + " kwh " + "la: " + helper.tinhTienDien(dienCu, dienMoi));
    }



    public static void baiMotChamTam() {
        double score;
        System.out.print("Input a score: ");
        score = Double.parseDouble(sc.nextLine());
        System.out.println(getCharacterScore(score));
    }

    static char getCharacterScore(double score) {
        if (score >= 8.5 && score <= 10) {
            return 'A';
        } else if (score >= 7 && score <= 8.4) {
            return 'B';
        } else if (score >= 5.5 && score <= 6.9) {
            return 'C';
        } else if (score >= 4.0 && score < -5.4) {
            return 'D';
        }
        return 'F';
    }

    public static void baiMotChamBay() {
        int month;
        System.out.print("Input a month you want: ");
        month = sc.nextInt();
        System.out.println(helper.getDateOfMonth(month));

    }

    public static void baiMotChamSau() {
        int year;
        System.out.print("Input a year you want: ");
        year = sc.nextInt();
        boolean check = helper.kiemTraNamNhuan(year);
        if (check == true) {
            System.out.println(year + " la nam nhuan");
        } else {
            System.out.println(year + " la nam khong nhuan");
        }
    }



    public static void baiMOtChamNam() {
        PTBac2 ptBac2 = new PTBac2();
        System.out.print("a = ");
        ptBac2.setA(sc.nextDouble());
        System.out.print("b = ");
        ptBac2.setC(sc.nextDouble());
        System.out.print("c = ");
        ptBac2.setC(sc.nextDouble());

        System.out.println(ptBac2.getA());
        System.out.println(ptBac2.getSoNghiemPT());
        ptBac2.getNghiemPT();
    }

    public static void baiMotChamBon() {

        int a, b, c;
        System.out.print("a = ");
        a = sc.nextInt();
        System.out.print("b = ");
        b = sc.nextInt();
        System.out.print("c = ");
        c = sc.nextInt();

        if (a > b && a > c) {
            System.out.println(a);
        } else if (b > a && b > c) {
            System.out.println(b);
        } else {
            System.out.println(c);
        }
    }

    public static void baiMotChamBa() {
        int a, b;
        System.out.print("a = ");
        a = sc.nextInt();

        System.out.print("b = ");
        b = sc.nextInt();

        if (a > b) {
            System.out.println(a);
        } else {
            System.out.println(b);
        }
    }

}
