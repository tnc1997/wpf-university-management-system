namespace UniversityManagementSystem.Data.Entities
{
    public class LibraryBook
    {
        public int LibraryId { get; set; }
        public Library Library { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}