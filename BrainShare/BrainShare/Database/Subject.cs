using SQLite.Net.Attributes;

namespace BrainShare.Database
{
    [Table("Subject")]
    public class Subject
    {
        [PrimaryKey]
        public int SubjectId { get; set; }
        public string name { get; set; }
        public string thumb { get; set; }
        public Subject() { }
    }
}
