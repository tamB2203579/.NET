public class Square : IShape {
	private double side;

	public Square(double side) {
		this.side = side;
	}

	public double area() {
		return side * side;
	}
}
