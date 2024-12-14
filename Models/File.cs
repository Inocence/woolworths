using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace woolworths.Models
{
    public class File
    {
        public int Id { get; set; } // Unique identifier for the image
        public string FileName { get; set; } // URL or path to the image file (could be a local path or cloud storage URL)
        public string FileType { get; set; } // File type, e.g., "jpg", "png", "webp"
        public long FileSize { get; set; } // Size of the file in bytes
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Date when the image was uploaded
    }

}