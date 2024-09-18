using System;
namespace bai6;

public class Program {
    static void Main(string[] args) {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        foreach (char c in input) {
            if (charCount.ContainsKey(c)) {
                charCount[c]++;
            }
            else {
                charCount[c] = 1;
            }
        }
        Console.WriteLine("\nCharacter counts:");
        foreach (var kvp in charCount) {
            Console.WriteLine($"Character '{kvp.Key}': {kvp.Value} times");
        }
    }
}