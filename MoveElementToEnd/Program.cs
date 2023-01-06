namespace MoveElementToEnd;

internal class Program
{
    private static void Main()
    {
        var numArray = new List<int> { 2, 1, 2, 2, 2, 3, 4, 2 };
        var move = 2;

        void MoveToBottom(List<int> array, int toMove)
        {
            var result = array.Where(x => x != toMove).ToList();

            result.AddRange(array.Where(x => x == toMove));

            array.Clear();
            array.AddRange(result);
        }

        MoveToBottom(numArray, move);
        Console.WriteLine(string.Join(",", numArray));
    }
}