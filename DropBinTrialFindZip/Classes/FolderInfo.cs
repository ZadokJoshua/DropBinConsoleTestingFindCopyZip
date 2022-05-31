using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropBinTrialFindZip.Classes
{
    public class FolderInfo
    {
        public virtual string FolderNewName { get; set; }
        public virtual string FolderPath { get; set; }
        public virtual DateTime TimeOfCreation { get ; set; } 
    }
}
