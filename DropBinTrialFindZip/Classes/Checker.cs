namespace DropBinTrialFindZip.Classes
{
    public class Checker
    {
        ZipClass objectToZip = new ZipClass();
        string ZippedFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public string CheckingFolder(string path)
        {
            if (Directory.Exists(path))
            {
                var removal = new Deleter().DeletingOperation(path);

                if (removal is true)
                {
                    objectToZip.ZipFileOperation(path, ZippedFolderPath);
                    return "Project has been Dropbined";
                }
                else
                {
                    Console.WriteLine("No Bin or Obj or Both found"); 
                    objectToZip.ZipFileOperation(path, ZippedFolderPath);
                    return "Project has been Dropbined";
                }
            }
            else
            {
                return "Not found";
            }
        }
    }
}

/*                    ZipClass objectToZip = new ZipClass();
                    var ZippedFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    objectToZip.ZipFileOperation(path, ZippedFolderPath);
*/
