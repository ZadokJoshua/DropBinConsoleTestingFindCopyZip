using Microsoft.VisualBasic.FileIO;

namespace DropBinTrialFindZip.Classes
{
    public class Copier
    {
        /* 
         * Code: CopyDirectory() 
         * Adapted from: https://stackoverflow.com/questions/7146021/copy-all-files-in-directory
         * Title: Copy all files in directory
         * Author: https://stackoverflow.com/users/572644/daniel-hilgarth
         * Date:  Aug 22, 2011 
         */

        public static void CopyDirectory(string sourceDirectoryPath, string targetDirectoryPath)
        {
            Loader.Loading();
            Console.WriteLine(@"Copying... {0} ... Please stand by ", sourceDirectoryPath);
            FileSystem.CopyDirectory(sourceDirectoryPath, targetDirectoryPath);
        }
        

        //public static void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
        //{
        //    // Get information about the source directory
        //    var dir = new DirectoryInfo(sourceDir);

        //    // Check if the source directory exists
        //    if (!dir.Exists)
        //        throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

        //    // Cache directories before we start copying
        //    DirectoryInfo[] dirs = dir.GetDirectories();

        //    // Create the destination directory
        //    Directory.CreateDirectory(destinationDir);

        //    // Get the files in the source directory and copy to the destination directory
        //    foreach (FileInfo file in dir.GetFiles())
        //    {
        //        string targetFilePath = Path.Combine(destinationDir, file.Name);
        //        file.CopyTo(targetFilePath);
        //    }

        //    // If recursive and copying subdirectories, recursively call this method
        //    if (recursive)
        //    {
        //        foreach (DirectoryInfo subDir in dirs)
        //        {
        //            string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
        //            CopyDirectory(subDir.FullName, newDestinationDir, true);
        //        }
        //    }
        //}
        //public static void CopyDirectoryMethod(string sourceDirectoryPath, string targetDirectoryPath)
        //{
        //    DirectoryInfo sourceDirectoryInfo = new DirectoryInfo(sourceDirectoryPath);
        //    DirectoryInfo targetDirectoryInfo = new DirectoryInfo(targetDirectoryPath);

        //    CopyDirectory(sourceDirectoryInfo, targetDirectoryInfo);
        //}

        //public static void CopyDirectory(DirectoryInfo source, DirectoryInfo target)
        //{
        //    Directory.CreateDirectory(target.FullName);

        //    foreach (var file in source.GetFiles())
        //    {
        //        Thread.Sleep(50);
        //        file.CopyTo(Path.Combine(target.FullName, file.Name), true);
        //    }

        //    foreach (var sourceSubDirectory in source.GetDirectories())
        //    {
        //        Thread.Sleep(50);
        //        var targetSubDirectory = target.CreateSubdirectory(source.Name);
        //        CopyDirectory(sourceSubDirectory, targetSubDirectory);
        //    }
        //}
    }
}
