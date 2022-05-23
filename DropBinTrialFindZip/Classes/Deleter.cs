namespace DropBinTrialFindZip.Classes
{
    public class Deleter
    {
        bool originalBoolean = false;

        public bool DeletingOperation(string path)
        {
            
            var binDirectory = Path.Combine(path, "bin");
            var objDirectory = Path.Combine(path, "obj");

            if (Directory.Exists(binDirectory) && Directory.Exists(objDirectory))
            {
                Directory.Delete(binDirectory);
                Directory.Delete(objDirectory);
                return originalBoolean = true;
            }
            else if(Directory.Exists(binDirectory) && !Directory.Exists(objDirectory))
            {
                Directory.Delete(binDirectory);
                return originalBoolean = true;
            }
            else if (!Directory.Exists(binDirectory) && Directory.Exists(objDirectory))
            {
                Directory.Delete(objDirectory);
                return originalBoolean = true;
            }
            else { return originalBoolean = false; }
        }
    }
}
