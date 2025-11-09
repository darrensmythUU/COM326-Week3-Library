using Library;

class Program
{
    public static void Main(string[] args)
    {
        // Create new lists that will be used to store Books and Members
        List<Book> books = new List<Book>();
        List<Member> members = new List<Member>();

        // Create and add new Book objects to the list
        books.Add(new Book("C# for Beginners", "BillGates", "1234567"));
        books.Add(new Book("C# Methods and Classes", "Microsoft", "2233445"));

        members.Add(new Member(1, "John Smith", "1 High Street", 0790090090));
        members.Add(new Member(2, "Mary Jones", "102 Garden Road", 0790345666));

        // Display all items within the Book List
        foreach (Book book in books)
        {

        }
    }
}