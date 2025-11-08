using Library;

class Program
{
    public static void Main(string[] args)
    {
        // Create a new instance (object) of the book class
        // Note how the object name differs from the class name
        Book book = new Book("C# for Beginners", "BillGates", "1234567");
        book.DisplayInfo();

        // This is another new book in our library
        Book book1 = new Book("C# Methods and Classes", "Microsoft", "2233445");
        book1.DisplayInfo();
    }
}