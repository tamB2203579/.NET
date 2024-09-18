using System.Drawing;

public class Program {
    static void Main(string[] args) {
        List<IShape> shapes = new List<IShape>();

        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 6);
        Square square = new Square(5);

        shapes.Add(circle);
        shapes.Add(rectangle);
        shapes.Add(square);

        foreach (var shape in shapes) {
            Console.WriteLine($"Area of shape: {shape.area()}");
        }
    }
}