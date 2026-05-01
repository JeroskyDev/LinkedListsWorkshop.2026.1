using Core;
using System.ComponentModel.Design;

var textFile = new SimpleTextFile("animals.txt");
var lines = textFile.ReadLines();
var list = lines.ToList();
var option = string.Empty;

do
{
    option = Menu();
    switch (option)
    {
        case "1":
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            break;
        case "2":
            Console.Write("Enter a new line: ");
            var newLine = Console.ReadLine();
            list.Add(newLine!);
            break;
        case "3":
            Console.Write("Which line do you want to remove?: ");
            var lineToRemove = Console.ReadLine();
            list.Remove(lineToRemove!);
            break;
        case "6":
            textFile.WriteLines(list.ToArray());
            Console.WriteLine("Changes saved.");
            break;
        default:
            break;
    }
} while (option != "0");
textFile.WriteLines(list.ToArray());
Console.WriteLine("Changes saved.");

string Menu()
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Show lines");
    Console.WriteLine("2. Add line");
    Console.WriteLine("3. Remove one ocurrence");
    Console.WriteLine("4. Remove all ocurrences"); //homework
    Console.WriteLine("5. Sort lines"); //homework
    Console.WriteLine("6. Save changes");
    Console.WriteLine("0. exit");
    Console.Write("Choose an option: ");
    return Console.ReadLine() ?? string.Empty;
}

//print the lines inside of the text
foreach (var line in lines)
{
    Console.WriteLine(line);
}