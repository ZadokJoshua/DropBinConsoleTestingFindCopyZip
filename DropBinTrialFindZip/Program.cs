using DropBinTrialFindZip.Classes;

Console.WriteLine("Welcome To DropBin");

Loader.Loading();

Console.WriteLine("What project folder do you want to DropBin? (Please provide a path)");
Console.Write("Path: ");

// Folder info
string MainProjectPath = Console.ReadLine();
string ProjectName = new DirectoryInfo(MainProjectPath).Name;
Console.WriteLine("Your project name: " + ProjectName);

Loader.Loading2();

Console.WriteLine("Select an option");
Console.WriteLine("\n\t1- DropBin only           2- Create Copy and DropBin");
Console.WriteLine("\t3- Rename before DropBin  4- Do 2, 3 and DropBin\n");
Console.Write("Option: ");

int option = Convert.ToInt32(Console.ReadLine());

Loader.Loading2();

switch (option)
{
    case 1:
        Operator.SwitchOperator(MainProjectPath, ProjectName);
        break;

    case 2:
        Console.Write("Copy folder to: ");
        string CopiedFolderPath = Console.ReadLine();
        Copier.CopyDirectory(MainProjectPath, CopiedFolderPath, true);
        //string newFilePath = Path.Combine(testingPath2, $"{ProjectName}");
        //Operator.SwitchOperator(newFilePath, testingPath2, ProjectName);
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
