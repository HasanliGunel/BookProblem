using System;
using System.Collections.Generic;
using System.Text;

namespace Tapshiriq_7
{
    public class Method 
    {
       public static List<Book> booklist= new List<Book>();
            
        public static void Append()
        {
       
            Book book = new Book();
            Console.WriteLine("ID-ni daxil edin:");
            book.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adini daxil edin:");
            book.Name = Console.ReadLine();
            Console.WriteLine("Muellifi daxil edin:");
            book.Author = Console.ReadLine();
            Console.WriteLine("Janrini daxil edin");
            book.Genre = Console.ReadLine();
            Console.WriteLine("Dilini daxil edin:");
            book.Language = Console.ReadLine();
           /* {
                ID = bookID,
                Name = bookName,
                Author = bookAutor,
                Genre = bookGenre,
                Language = bookLanguage
            };*/
            booklist.Add(book);
        }
        public static void Show()
        {
            foreach(var book in booklist)
            {
                Console.WriteLine($"ID:{book.ID}\t Ad:{book.Name}\t\t Muellif:{book.Author}\t Janr:{book.Genre}\t Dil:{book.Language}\n ");
            }
        }
        public static void Remove()
        {
            Console.WriteLine("Silinecek ID-ni daxil edin:");
            Book book = new Book();
            book.ID = Convert.ToInt32(Console.ReadLine());
            booklist.RemoveAll(x => x.ID == book.ID);
        }
        public static void Update()
        {
            Book book = new Book();

            Console.WriteLine("Yenilenecek edilecek ID-ni daxil edin");
            book.ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yenilenecek bolmeni daxil edin:");
            Console.WriteLine("Eger\n ad bomesini yenilemek isteyirsinizse'Name'\n muellif bolmesini yenilemek isteyirsinizse 'Author'\n Janr bolmesini yenilemek isteyirsinizse 'Genre'\n Dil bolmesini yenilemek isteyirsinizse'Language'\ndaxil edin");
            string section = Console.ReadLine();
            
            var obj = booklist.FindIndex(x => x.ID == book.ID);
            if (section == "Name")
            {
                Console.WriteLine("Adini daxil edin:");
                booklist[obj].Name = Console.ReadLine();
                //booklist.Add(book);
            }
            if (section == "Author")
            {
                Console.WriteLine("Muellifi daxil edin:");
                booklist[obj].Author = Console.ReadLine();
            }
            if (section == "Genre")
            {
                Console.WriteLine("Janrini daxil edin");
                booklist[obj].Genre = Console.ReadLine();
            }
            if (section == "Language")
            {
                Console.WriteLine("Dilini daxil edin:");
                booklist[obj].Language = Console.ReadLine();
            }
        }
    }
}
