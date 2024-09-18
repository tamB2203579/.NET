namespace bai2;

public class Program {
    static void Main(string[] args) {
        int[] myNum = {1, 1, 2, 3, 5, 8, 13, 21};
        foreach (int i in myNum){
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();
        foreach (int i in myNum){
            if (i % 2 != 0) System.Console.Write(i + " ");
        }
    }
}