using DropBinTrialFindZip.Classes;
//var checkingPath = new Checker();

//Console.WriteLine(checkingPath.CheckingFolder(testingPath));

public class Operator
{
    public static void SwitchOperator(string path, string FileName)
    {
        if (Checker.CheckingFolder(path) is true)
        {
            if (Deleter.DeletingOperation(path) is true)
            {
                ZipClass.ZipFileOperation(path, FileName);
                Console.WriteLine("Project has been Dropbined");
            }
            else
            {
                Console.WriteLine("No Bin or Obj or Both found");
                ZipClass.ZipFileOperation(path, FileName);
                Console.WriteLine("Project has been Dropbined");
            }
        }
        else
        {
            Console.WriteLine("NotFoundException: Project not Found");
        }
    }

    public static void SwitchOperator(string path, string newPath, string FileName)
    {
        if (Checker.CheckingFolder(path) is true)
        {
            if (Deleter.DeletingOperation(path) is true)
            {
                ZipClass.ZipFileOperation(path, newPath, FileName);
                Console.WriteLine("Project has been Dropbined");
            }
            else
            {
                Console.WriteLine("No Bin or Obj or Both found");
                ZipClass.ZipFileOperation(path, newPath, FileName);
                Console.WriteLine("Project has been Dropbined");
            }
        }
        else
        {
            Console.WriteLine("NotFoundException: Project not Found");
        }
    }
}