using static TaskSession5.Book;
namespace TaskSession5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task5 Q1

            ////Compile error , password is accessible only inside its class
            //Book hmada = new Book();
            //Console.WriteLine(hmada.password);

            #endregion

            #region Task5 Q2


            ////it will compile ,bc internal means the field is accessible from anywhere in the same project
            //Book hmada = new Book();
            //Console.WriteLine(hmada.copiesInStock);

            #endregion

            #region Task5 Q3


            //Book hmada = new Book();
            //hmada.Title = "Basics C#";
            //Console.WriteLine(hmada.Title);

            #endregion

            #region Task5 Q4

            //Book book = new Book();
            //book.BookGenre = Genre.Science;
            // Console.WriteLine(book.BookGenre);


            #endregion

            #region Task5 Q5


            //Console.WriteLine((int)Genre.Fiction);
            //Console.WriteLine((int)Genre.NonFiction);
            //Console.WriteLine((int)Genre.Science);

            #endregion

            #region Task5 Q6
            //int genreNumber = 1;
            //Genre result = (Genre)genreNumber;
            //Console.WriteLine(result);


            #endregion

            #region Task5 Q7

            //Genre genre = Genre.Fiction;
            //string result=genre.ToString();
            //Console.WriteLine(result);

            #endregion

            #region Task5 Q8

            //string genreText = "Science";
            //Genre result =(Genre)Enum.Parse(typeof(Genre), genreText);

            #endregion

            #region Task5 Q9
            //string genreText = "Mystery";

            //if (Enum.TryParse<Genre>(genreText, out Genre result))
            //{
            //    Console.WriteLine($"{genreText} : is valid genre");
            //}
            //else { Console.WriteLine("Unknown genre"); }


            #endregion


        }
    }
}
