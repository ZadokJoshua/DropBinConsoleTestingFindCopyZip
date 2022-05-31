namespace DropBinTrialFindZip.Classes
{
    public class Deleter
    {
        public static bool DeletingOperation(string path)
        {
            var binDirectory = Path.Combine(path, "bin");
            var objDirectory = Path.Combine(path, "obj");

            if (Directory.Exists(binDirectory) && Directory.Exists(objDirectory))
            {
                Directory.Delete(binDirectory);
                Directory.Delete(objDirectory);
                return true;
            }
            else if(Directory.Exists(binDirectory) && !Directory.Exists(objDirectory))
            {
                Directory.Delete(binDirectory);
                return true;
            }
            else if (!Directory.Exists(binDirectory) && Directory.Exists(objDirectory))
            {
                Directory.Delete(objDirectory);
                return true;
            }
            else 
            { 
                return false; 
            }
        }
    }
}
