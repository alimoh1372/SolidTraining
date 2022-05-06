using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples
{
  public  class Project
    {
        public List<ProjectFile> AllFiles { get; set; } = new List<ProjectFile>();
        public List<ReadOnlyFile> readOnlyFiles { get; set; } = new List<ReadOnlyFile>();

        public void LoadFiles()
        {
            foreach (ProjectFile file in AllFiles)
            {
                file.LoadData();
            }
            foreach (ReadOnlyFile file in readOnlyFiles)
            {
                file.LoadData();
            }
        }

        public void SaveFiels()
        {
            foreach (ProjectFile file in AllFiles)
            {
                    file.SaveData();
            }
        }
    }
}
