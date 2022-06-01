using DropBinTrialFindZip.Classes;

Console.WriteLine("Welcome To DropBin");

Loader.Loading();

Console.WriteLine("What project folder to you want to DropBin? (Please give us a path)");
Console.Write("Path: ");

// Folder info
string ProjectPath = Console.ReadLine();
string MainProjectPath = @ProjectPath;
string ProjectName = new DirectoryInfo(MainProjectPath).Name;

Console.WriteLine("\n\t1- DropBin only             2- Copy file and DropBin");
Console.WriteLine("\t3- Rename file and DropBin  4- Do 2, 3 and DropBin\n");
Console.Write("Option: ");

int option = Convert.ToInt32(Console.ReadLine());

Loader.Loading2();

switch (option)
{
    case 1:
        Operator.SwitchOperator(MainProjectPath, ProjectName);
        break;

    case 2:
        Console.Write("Copy and Move folder to: ");
        string testingPath2 = Console.ReadLine();
        Copier.CopyDirectory(MainProjectPath, @testingPath2);
        string newFilePath = Path.Combine(testingPath2, $"{ProjectName}");
        Operator.SwitchOperator(newFilePath, testingPath2, ProjectName);
        break;

    case 3:
        Console.WriteLine("New folder to: ");
        //string testingPath2 = Console.ReadLine();
        //Operator.SwitchOperator(testingPath, testingPath2);
        break;
    case 4:
        break;
    default:
        break;
}
