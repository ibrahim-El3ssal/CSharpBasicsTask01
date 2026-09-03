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

            #region Question02

            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());
            #endregion

            #region Question03
            //  Compile-time Error ------- you can't put text (string) into an int variable.  

            int pages = 464;

            #endregion
        }
    }
}
