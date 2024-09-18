using System;
namespace bai5;

public class Program {
    static void Modify(Dictionary<string, string> D, string modID, string newName){
        if (D.ContainsKey(modID)) {
            D[modID] = newName;
            System.Console.WriteLine("Student ID {0} updated to {1}.", modID, newName);
        } else {
            System.Console.WriteLine("Student ID {0} does not exist.", modID);
        }
    }
    static void Main(string[] args) {
        Dictionary<string, string> students = new Dictionary<string, string>{
            {"001", "Peter"},
            {"002", "Nicolas"},
            {"003", "Josh"}
        };
        Console.Write("Enter Student ID to modify: ");
        string userID = Console.ReadLine();

        Console.Write("Enter new name for the student: ");
        string newName = Console.ReadLine();

        Modify(students, userID, newName);
    }
}