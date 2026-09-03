namespace C_BasicsTask01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01

            Book book = new Book();
            book.Title = "C# Basics ";
            book.Pages = 150;

            object obj = book;
            Console.WriteLine(obj);

            #endregion
        }
    }
}
