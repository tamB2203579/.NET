using System;
namespace bai4;

public class Program {
    static int SumOddNumbers(List<int> L) {
        int sum = 0;
        foreach (int number in L) {
            if (number % 2 != 0) {
                sum += number;
            }
        }
        return sum;
    }

    static void PrintWordsOfLengthOf4(List<string> words) {
        foreach (string word in words) {
            if (word.Length == 4) {
                Console.WriteLine(word);
            }
        }
    }

    static void PrintWordsOfLength(List<string> words, int length) {
        foreach (string word in words) {
            if (word.Length == length) {
                Console.WriteLine(word);
            }
        }
    }

    static void Main(string[] args) {
        List<int> numbers = new List<int> { 1, 1, 2, 3, 5, 8, 13, 21 };
        int oddSum = SumOddNumbers(numbers);
        Console.WriteLine("Sum of odd numbers: " + oddSum);
        List<string> words = new List<string> { "apple", "banana", "pear", "grape", "kiwi", "plum" };
        Console.WriteLine("Words with 4 letters:");
        PrintWordsOfLengthOf4(words);
        Console.Write("Enter the word length to search for: ");
        if (int.TryParse(Console.ReadLine(), out int length)) {
            Console.WriteLine("Words with {0} letters:", length);
            PrintWordsOfLength(words, length);
        }
        else {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}