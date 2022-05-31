using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropBinTrialFindZip.Classes
{
    public class CopyClass
    {
        public void CopyDirectory(string path, string newPath)
        {
            File.Copy(path, newPath, true);
        }
    }
}
