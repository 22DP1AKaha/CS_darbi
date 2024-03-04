// sealed class BookGenrePubl : BookGenre{
//     String Publisher;
//     public BookGenrePubl(String BookName, String Genre, String AuthorName, String Publisher, double BookPrice) 
//     : base(BookName, Genre, AuthorName, BookPrice)
//     {
//         this.Publisher = Publisher;
//     }
    
//     public String getPublisher{
//         get{ return Publisher; }
//         set{ Publisher = value; }
//     }

//     public static void ShowInfo(BookGenrePubl book){
//         BookGenre.ShowInfo(book);
//         System.Console.WriteLine($"Book publisher: {book.Publisher}");
//     }
// }