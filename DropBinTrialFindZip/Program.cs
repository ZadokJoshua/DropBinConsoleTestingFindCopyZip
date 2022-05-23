using DropBinTrialFindZip.Classes;

Console.WriteLine("What project folder to you want to DropBin? (Please give us a path)");
string testingPath1 = Console.ReadLine();

var testingPath = @testingPath1;

var checkingPath = new Checker();

Console.WriteLine(checkingPath.CheckingFolder(testingPath));