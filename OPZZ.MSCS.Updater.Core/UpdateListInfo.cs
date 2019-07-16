using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPZZ.MSCS.Updater.Core
{
    public class UpdateListInfo
    {
        public string Description { get; set; }

        public UpdaterInfo Updater { get; set; }

        public ApplicationInfo Application { get; set; }

        public List<FileInfo> Files { get; set; }

        public class UpdaterInfo
        {
            public string Url { get; set; }
            public string LastUpdateTime { get; set; }
        }

        public class ApplicationInfo
        {
            public string applicationId { get; set; }
            public string EntryPoint { get; set; }
            public string Location { get; set; }
            public MSCSVersion Version { get; set; }
        }

        public class FileInfo
        {
            public string Name { get; set; }
            public MSCSVersion Ver { get; set; }
        }

        public void MergeUpdateFiles(IEnumerable<UpdateFileInfo> updateFiles)
        {
            foreach (var file in updateFiles)
            {
                var found = this.Files.Find(x => x.Name == file.RelativePath);
                if (found != null)
                {
                    found.Ver = found.Ver.Increase();
                }
                else
                {
                    var newFile = new UpdateListInfo.FileInfo();
                    newFile.Name = file.RelativePath;
                    newFile.Ver = MSCSVersion.First();
                    this.Files.Add(newFile);
                }
            }

            this.Application.Version = this.Application.Version.Increase();
        }
    }
}
