/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package helloworld;

/**
 *
 * @author Administrator
 */
/*final*/ 
public class PTBac2 {
    private double a;
    private double b;
    private double c;

    
    public PTBac2() {}
    
    public PTBac2(double a, double b, double c) {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double getA() {
        return a;
    }

    public void setA(double a) {
        this.a = a;
    }

    public double getB() {
        return b;
    }

    public void setB(double b) {
        this.b = b;
    }

    public double getC() {
        return c;
    }

    public void setC(double c) {
        this.c = c;
    }
    
    public double getSoNghiemPT() {
        double delta;
        delta = b*b - 4*a*c;
        if(delta < 0)
            return 0;
        if(delta > 0)
            return 2;
        return 1;
    }
    
    public void getNghiemPT() {
        double delta;
        delta = b*b - 4*a*c;
        
        if(delta == 0)
            System.out.println("PT Co nghiem kep: " + -b / (2*a));
        else if(delta > 0)
            System.out.println("PT co 2 nghiem phan biet x1: " + ((-b + Math.sqrt(delta)) / (2 * a)) + 
                                                        "x2: " + ((-b - Math.sqrt(delta)) / (2 * a)));
        else
            System.out.println("PT vo nghiem");
        
    }
    
}
