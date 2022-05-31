using DropBinTrialFindZip.Classes;

Console.WriteLine("WELCOME TO DROPBIN");
Console.WriteLine("What project folder to you want to DropBin? (Please give us a path)");
Console.Write("Path:");
string testingPath1 = Console.ReadLine();
var testingPath = @testingPath1;

Console.WriteLine("\t1- DropBin only             2- Copy file and DropBin");
Console.WriteLine("\t3- Rename file and DropBin  4- Do 2, 3 and DropBin");
int option = Convert.ToInt32(Console.ReadLine());

switch (option)
{
    case 1:
        if (Checker.CheckingFolder(testingPath) is true)
        {
            if(Deleter.DeletingOperation(testingPath) is true)
            {
                ZipClass.ZipFileOperation(testingPath);
                Console.WriteLine("Project has been Dropbined");
            }
            else
            {
                Console.WriteLine("No Bin or Obj or Both found"); 
                ZipClass.ZipFileOperation(testingPath);
                Console.WriteLine("Project has been Dropbined");
            }
        }
        else
        {
            Console.WriteLine("NotFoundException: Project not Found");
        }
        break;

    case 2:
        Console.WriteLine("Copy folder to:");
        string testingPath2 = Console.ReadLine();
        var testingPathCopy = @testingPath2;
        Console.WriteLine();
        break;
    case 3:
        break;
    case 4:
        break;
    default:
        break;
}

var checkingPath = new Checker();

Console.WriteLine(checkingPath.CheckingFolder(testingPath));