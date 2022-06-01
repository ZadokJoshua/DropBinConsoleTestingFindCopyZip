﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropBinTrialFindZip.Classes
{
    public class Copier
    {
        /* 
         * Code: GetDirectoryInfo() and CopyDirectory() methods
         * Adapted from: https://docs.microsoft.com/en-us/dotnet/standard/io/how-to-copy-directories
         * Title: How to: Copy directories
         * Author: 15 contibutors
         * Date:  01/14/2022
         * Cited: Jun 1, 2022
         */
        public static void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
        {
            // Get information about the source directory
            var dir = new DirectoryInfo(sourceDir);

            // Check if the source directory exists
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Create the destination directory
            Directory.CreateDirectory(destinationDir);

            // Get the files in the source directory and copy to the destination directory
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(targetFilePath);
            }

            // If recursive and copying subdirectories, recursively call this method
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true);
                }
            }
        }
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
