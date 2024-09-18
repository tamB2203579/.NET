using System;

namespace bai7;

public class Sphere : Circle {
    public Sphere() : base() {}
    public Sphere(double radius) : base(radius) {}

    public override double DienTich() {
        return 4 * Math.PI * Math.Pow(getR(), 2);
    }

    public double TheTich() {
        return (4.0 / 3.0) * Math.PI * Math.Pow(getR(), 3);
    }

    public void print() {
        Console.WriteLine("Surface area = " + DienTich());
        Console.WriteLine("Volume =  " + TheTich()); 
    }
}