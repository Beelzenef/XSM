using System.Collections.ObjectModel;
using XSM.Data;
using XSM.Models;
using System.Linq;
using XSM.ViewModels.Base;

namespace XSM.ViewModels.Projects
{
    class ProjectsViewModel : BaseViewModel
    {
        private ObservableCollection<Book> _books;
        public ObservableCollection<Book> Books
        {
            get { return _books; }
            set { SetProperty(ref _books, value); }
        }

        public ProjectsViewModel()
        {
            Books = new ObservableCollection<Book>();

            BookData _context = new BookData();
            _context.Books.ToList().ForEach(Books.Add);
        }

    }
}
