//console app for our double linked list.
using DLL.Backend;

var list = new DoubleLinkedList<string>();
var option = string.Empty;
var value = string.Empty;

do
{
    option = Menu();
    switch(option)
    {
        case "1":
            Console.Write("Enter a value: ");
            value = Console.ReadLine() ?? string.Empty;
            list.Add(value);
            break;
        case "2":
            Console.WriteLine(list);
            break;
        case "3":
            break;
        case "4":
            break;
        case "5":
            break;
        case "6":
            break;
        case "7":
            break;
        case "8":
            break;
        case "9":
            break;
        case "0":
            Console.WriteLine("Exiting...");
            break;
        default:
            Console.WriteLine("Invalid option! Please try again...");
            break;
    }
} while (option != "0");

string Menu()
{
    Console.WriteLine("*************************");
    Console.WriteLine("***DOUBLE LINKED LISTS***");
    Console.WriteLine("*************************");
    Console.WriteLine();
    Console.WriteLine("1. Add an element");
    Console.WriteLine("2. Show the list in forward");
    Console.WriteLine("3. Show the list in backwards");
    Console.WriteLine("4. Sort in descending order");
    Console.WriteLine("5. Show mode between values");
    Console.WriteLine("6. Show graph");
    Console.WriteLine("7. Search for a value (exists)");
    Console.WriteLine("8. Delete an ocurrence");
    Console.WriteLine("9. Delete all ocurrences");
    Console.WriteLine("+++++++++++++++++++++++++");
    Console.WriteLine("0. Exit the program");
    return Console.ReadLine() ?? string.Empty;
}