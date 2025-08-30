using Library_Management.Models;

public interface IBookService
{
    void AddBook(AddBookViewModel book);
    void AddBookCopy(CopyBookViewModel model);
    void DeleteBook(Guid id);
    EditBookViewModel GetBookById(Guid id);
    IEnumerable<BookListViewModel> GetBooks();
    void UpdateBook(EditBookViewModel vm);
}