using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTask.Classes
{
    public class Books
    {
        public class Author
        {
            public int AuthorId { get; set; }
            public string Name { get; set; }
            public string Nationality { get; set; }
        }

        // Book Class
        public class Book
        {
            public int BookId { get; set; }
            public string Title { get; set; }
            public int PublicationYear { get; set; }
            public int AuthorId { get; set; } 
        }
    }
}
