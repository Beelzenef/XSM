using System.Collections.Generic;
using XSM.Models;

namespace XSM.Data
{
    class BookData
    {
        public List<Book> Books = new List<Book>
        {
            new Book { Title = "Eragon", Author = "C. Paolini" },
            new Book { Title = "La sombra del viento", Author = "C. Ruiz Zafón" },
            new Book { Title = "Sesión nocturna", Author = "M. Connelly" },
            new Book { Title = "Ciudad de huesos", Author = "M. Connelly" }
        };
    }
}
