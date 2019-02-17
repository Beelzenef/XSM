using System.Collections.ObjectModel;
using XSM.Data;
using XSM.Models;
using System.Linq;

namespace XSM.ViewModels
{
    class BookViewModel
    {
        private ObservableCollection<Book> _books;

        public ObservableCollection<Book> Books
        {
            get { return _books; }
            set
            {
                if (value != _books)
                {
                    _books = value;
                }
            }
        }

        public BookViewModel()
        {
            Books = new ObservableCollection<Book>();

            BookData _context = new BookData();
            _context.Books.ToList().ForEach(Books.Add);
        }

    }
}
