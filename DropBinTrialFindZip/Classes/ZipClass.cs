using System.IO.Compression;

namespace DropBinTrialFindZip.Classes
{
    public class ZipClass
    {
        public static string ZippedFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public static void ZipFileOperation(string confirmedPath)
        {
            ZipFile.CreateFromDirectory(confirmedPath, Path.Combine(ZippedFolderPath, @"Zadok.zip"));
        }

        public static void ZipFileOperation(string confirmedPath, string newPath)
        {
            ZipFile.CreateFromDirectory(confirmedPath, Path.Combine(newPath, @"Zadok.zip"));
        }
    }
}
