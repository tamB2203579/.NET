using System;

namespace bai7;

public class Circle {
    private double radius;

    public Circle() {
        radius = 0;
    }

    public Circle(double radius) {
        this.radius = radius;
    }
        
    public double ChuVi() {
        return 2 * Math.PI * radius;
    }

    public virtual double DienTich() {
        return Math.PI * radius * radius;
    }

    public void input() {
        Console.Write("Enter the radius of the circle: ");
        radius = Convert.ToDouble(Console.ReadLine());
    }

    public void print() {
        Console.WriteLine($"Circumference = " + ChuVi());
        Console.WriteLine($"Area = " + DienTich());
    }

    public double getR() {
        return radius;
    }
}