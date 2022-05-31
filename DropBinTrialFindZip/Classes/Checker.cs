namespace DropBinTrialFindZip.Classes
{
    public class Checker
    {
        public static bool CheckingFolder(string path)
        {
            if (Directory.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


/*                  
 *                  ZipClass objectToZip = new ZipClass();
 *                  var ZippedFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
 *                  objectToZip.ZipFileOperation(path, ZippedFolderPath);
*/
