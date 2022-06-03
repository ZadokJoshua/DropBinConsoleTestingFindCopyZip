using DropBinTrialFindZip.Classes;
using Microsoft.VisualBasic.FileIO;

Console.WriteLine("Welcome To DropBin", Console.ForegroundColor = ConsoleColor.DarkGreen);

Loader.Loading();

Console.WriteLine("What project folder do you want to DropBin? (Please provide a path)");
Console.Write("Path: ");

// Folder info
string MainProjectPath = Console.ReadLine();
string ProjectName = new DirectoryInfo(MainProjectPath).Name;
Console.WriteLine("Your project name: " + ProjectName);

Loader.Loading();

Console.WriteLine("Select an option");
Console.WriteLine("\n\t1- DropBin only           2- Copy and DropBin");
Console.WriteLine("\t3- Rename before DropBin  4- Do 2, 3 and DropBin\n");
Console.Write("Option: ");

int option = Convert.ToInt32(Console.ReadLine());

Loader.Loading();

switch (option)
{
    case 1:
        try
        {
            Operator.SwitchOperator(MainProjectPath, ProjectName);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        break;

    case 2:
        try
        {
            Console.Write("Copy folder to: ");
            string CopiedFolderPath = Console.ReadLine();
            Copier.CopyDirectory(MainProjectPath, CopiedFolderPath);
            string newFilePath = Path.Combine(CopiedFolderPath, ProjectName);
            Operator.SwitchOperator(newFilePath, CopiedFolderPath, ProjectName);
            Directory.Delete(newFilePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        break;

    case 3:
        Console.Write("Change zipped folder name to: ");
        string NewProjectName = Console.ReadLine();
        try
        {
            Operator.SwitchOperator(MainProjectPath, NewProjectName);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        break;

    case 4:
        // Do case 2, 3 and DropBin
        break;

    default:
        break;
}
