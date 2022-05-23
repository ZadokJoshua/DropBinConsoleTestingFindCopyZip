using System.IO.Compression;

namespace DropBinTrialFindZip.Classes
{
    public class ZipClass
    {
        public static string ZippedFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public void ZipFileOperation(string confirmedPath, string zipFilePath)
        {
            var startPath = confirmedPath;          
            var zipPath = zipFilePath;
            ZipFile.CreateFromDirectory(startPath, Path.Combine(zipPath, @"Zadok.zip"));
        }
    }
}
