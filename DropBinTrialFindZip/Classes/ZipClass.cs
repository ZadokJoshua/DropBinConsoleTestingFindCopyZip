using System.IO.Compression;

namespace DropBinTrialFindZip.Classes
{
    public class ZipClass
    {
        public static string ZippedFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public void ZipFileOperation(string confirmedPath)
        {
            var startPath = confirmedPath;
            ZipFile.CreateFromDirectory(confirmedPath, Path.Combine(ZippedFolderPath, @"Zadok.zip"));
        }
    }
}
