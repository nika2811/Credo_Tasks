using Assignments.BookLibraryApi.Models;

namespace BookLibraryApi.Requests.ShelfRequests
{
    public class DeleteShelfRequest
    {
        public int ShelfId { get; set; }
        public Shelf? Shelf { get; set; }
    }
}
