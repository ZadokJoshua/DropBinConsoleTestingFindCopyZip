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

