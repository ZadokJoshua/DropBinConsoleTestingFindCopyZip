Console.WriteLine("Welcome TO DropBin");
Console.WriteLine("What project folder to you want to DropBin? (Please give us a path)");
Console.Write("Path: ");
string testingPath1 = Console.ReadLine();
var testingPath = @testingPath1;

Console.WriteLine("\n\t1- DropBin only             2- Copy file and DropBin");
Console.WriteLine("\t3- Rename file and DropBin  4- Do 2, 3 and DropBin\n");
Console.Write("Option: ");
int option = Convert.ToInt32(Console.ReadLine());

switch (option)
{
    case 1:
        Operator.SwitchOperator(testingPath);
        break;

    case 2:
        Console.WriteLine("Copy folder to: ");
        string testingPath2 = Console.ReadLine();
        Operator.SwitchOperator(testingPath, testingPath2);
        break;
    case 3:
        break;
    case 4:
        break;
    default:
        break;
}
