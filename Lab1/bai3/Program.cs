namespace bai3;

public class Program {
    static void Main(string[] args) {
        string myString = @"Worm snakes are usually reptiles with a body length of up to 23 cm. The snout is relatively narrow, accounting for about 20 - 33% of the width of the head. The eyes of this widely distributed snake are visible. The snake's color is almost uniform, the upper body is dark brown to black but the lower body is lighter. The snout, anal area, and tip of the tail are pale.";
        string[] myCollect = myString.Split(" ");
        foreach (string word in myCollect){
            System.Console.Write(word + ", ");
        }
    }
}