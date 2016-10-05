using System.Collections.Generic;

namespace BrainShare.Models
{
    public class LibraryModel
    {
        public int library_id { get; set; }
        public List<LibCategoryModel> categories { get; set; }
        public LibraryModel()
        {
        }
    }
}
