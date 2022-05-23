namespace DropBinTrialFindZip.Classes
{
    public class Checker
    {
        public string CheckingFolder(string path)
        {
            var binDirectory = Path.Combine(path, "bin");
            var objDirectory = Path.Combine(path, "obj");

            if (Directory.Exists(path))
            {
                //if (Directory.Exists(binDirectory) && Directory.Exists(objDirectory))
                //{
                    // CopyAll()
                    Directory.Delete(binDirectory);
                    Directory.Delete(objDirectory);
                    
                    ZipClass objectToZip = new ZipClass();
                    var ZippedFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    objectToZip.ZipFileOperation(path, ZippedFolderPath);
                    return "Project has been Dropbined";

                //}
                //else
                //{
                //    return "Invalid Bin and Obj folders";
                //}
            }
            else
            {
                return "No found";
            }
        }
    }
}
