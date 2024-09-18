using System;

namespace bai7;

public class Program {
    static void Main(string[] args) {
        Circle myCircle = new Circle();
        myCircle.input();
        myCircle.print();

        Sphere mySphere = new Sphere(myCircle.getR());
        mySphere.print();
    }
}