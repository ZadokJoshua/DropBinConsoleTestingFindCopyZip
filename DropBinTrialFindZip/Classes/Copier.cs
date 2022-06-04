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
            //FileSystem.CopyDirectory(sourceDirectoryPath, targetDirectoryPath);
            Directory.CreateDirectory(targetDirectoryPath);

            foreach (var file in Directory.GetFiles(sourceDirectoryPath))
            {
                File.Copy(file, Path.Combine(targetDirectoryPath, Path.GetFileName(file)));
            }
                

            foreach (var directory in Directory.GetDirectories(sourceDirectoryPath))
            {
                CopyDirectory(directory, Path.Combine(targetDirectoryPath, Path.GetFileName(directory)));
            }
        }
    }
}
