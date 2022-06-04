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

int option = 0;

while (option!=4)
{
    Console.WriteLine("Select an option");
    Console.WriteLine("\n\t1- DropBin only                2- Rename and DropBin");
    Console.WriteLine("\t3- To Unzip DropBinned folder  4- To end program\n");
    Console.Write("Option: ");

    option = Convert.ToInt32(Console.ReadLine());

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

        case 3:
            // To unzip folder
            break;

        default:
            break;
    } 
}

Console.WriteLine("Program has Ended");
