using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalKendaraan_019.Models.Upload
{
    public class FilesViewModel
    {
        public string Name { get; set; }
        public string Path { get; set; }
    }

    public class FilesViewModel
    {
        public List<FilesDetails> Files { get; set; }
            = new List<FilesDetails>();
    }
}
