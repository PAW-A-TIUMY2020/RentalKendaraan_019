using RentalKendaraan_019.Models.Upload;
using System.Collections.Generic;

namespace RentalKendaraan_019.Controllers
{

    public class FileDetails
    {
        public string Name { get; set; }
        public string Path { get; set; }
    }

    public class FilesViewModel
    {
        public List<FileDetails> Files { get; set; }
        = new List<FileDetails>();
    }
}
