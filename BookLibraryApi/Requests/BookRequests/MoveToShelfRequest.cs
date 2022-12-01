namespace BookLibraryApi.Requests.BookRequests
{
    public class MoveToShelfRequest
    {
        public int BookId { get; set; }
        public int NewShelfid { get; set; }
    }
}
