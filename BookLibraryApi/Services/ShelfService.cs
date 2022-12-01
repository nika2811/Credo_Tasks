using Assignments.BookLibraryApi.Models;
using Assignments.BookLibraryApi.Requests.ShelfRequests;
using BookLibraryApi.Requests.BookRequests;
using BookLibraryApi.Requests.ShelfRequests;

namespace BookLibraryApi.Services;

public class ShelfService
{
    private static int _id = 1;
    private static int _bookid = 1;

    static ShelfService()
    {
        Shelves = new List<Shelf>();
    }

    public static List<Shelf> Shelves { get; set; }

    public Shelf Create(CreateShelfRequest request)
    {
        var shelf = new Shelf
        {
            Id = _id++,
            Name = request.Name
        };
        Shelves.Add(shelf);

        return shelf;
    }

    public Shelf? Rename(RenameShelfRequest request)
    {
        var shelf = Shelves.Find(s => s.Id == request.ShelfId);
        if (shelf == null) return null;
        shelf.Name = request.NewName;
        return shelf;
    }

    public Shelf? Get(int shelfId)
    {
        var shelf = Shelves.Find(s => s.Id == shelfId);
        return shelf;
    }

    public List<Shelf> GetAll()
    {
        return Shelves;
    }

    public List<Shelf>? Delete(DeleteShelfRequest request)
    {
        var shelf = Shelves.Find(s => s.Id == request.ShelfId);
        if (shelf == null) return null;

        if (request.Shelf.ValidateIfEmpty(shelf.Books)) Shelves.Remove(shelf);
        return Shelves;
    }

    public Book AddToShelf(AddToShelfRequest request)
    {
        var book = new Book
        {
            Id = _bookid++,
            Title = request.Title,
            ISBN = request.ISBN,
            Description = request.Description,
            ShelfId = request.ShelfId
        };
        var shelf = Shelves.Find(s => s.Id == book.ShelfId);
        shelf?.Books.Add(book);
        return book;
    }


    public void Remove(RemoveBookRequest request)
    {
        foreach (var shelf in Shelves.ToList())
        foreach (var book in shelf.Books.ToList())
            if (book.Id == request.BookId)
                shelf.Books.Remove(book);
    }

    public void MoveToShelf(MoveToShelfRequest request)
    {
        var newShelf = Shelves.Find(s => s.Id == request.NewShelfid);
        foreach (var shelf in Shelves.ToList())
        foreach (var book in shelf.Books.ToList())
            if (book.Id == request.BookId)
            {
                book.ShelfId = request.NewShelfid;
                shelf.Books.Remove(book);
                newShelf?.Books.Add(book);
            }
    }
}