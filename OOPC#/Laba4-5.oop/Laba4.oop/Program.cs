using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Laba4.oop {



    public abstract class Publication : IComparable<Publication> //дозволяє порівнювати об'єкти за допомогою методу CompareTo
    {
        public string Title { get; set; }
        public DateTime PublicationDate { get; set; }

        protected Publication(string title, DateTime publicationday)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Заголовок не може бути пустим або порожнiм.");
            }
            Title = title;
            PublicationDate = publicationday;
        }

        public int CompareTo(Publication other)//порівнювати екземпляри узагальненого типу
        {
            return PublicationDate.CompareTo(other.PublicationDate.Year);
        }
        public abstract void DisplayInfo();
    }

    public class Book : Publication
    {
        public string Author { get; set; }
        public Book(string title, DateTime publicationdate, string author) : base(title, publicationdate)
        {
            if (string.IsNullOrEmpty(author))
            {
                throw new ArgumentException("Автор не може бути пустим.");
            }
            Author = author;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Книга:{Title},Автор:{Author},Дата видання:{PublicationDate.Year}");
        }

    }

    public class Magazine : Publication
    { public int IssueNumber { get; set; }
        public Magazine(string title, DateTime publicationdate, int issuenumber) : base(title, publicationdate)
        {
            IssueNumber = issuenumber;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Журнал:{Title},Номер:{IssueNumber},Дата видання:{PublicationDate.Year}");
        }
    }

    public class Newpaper : Publication
    {
        public string Publisher { get; set; }
        public Newpaper(string title, DateTime publicationdate, string publisher) : base(title, publicationdate)
        {
            if (string.IsNullOrEmpty(publisher))
            {
                throw new ArgumentException("Редагтор не може бути пустим.");
            }
            Publisher = publisher;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Газета:{Title},Видавець:{Publisher}, Дата видання:{PublicationDate.Year}");
        }
    }

//4 laba 
    //public class Library : IEnumerable<Publication>//реалізує інтерфейс , щоб можна було використовувати ітератор.
    //{
    //    private List<Publication> publications;
    //    public Library()
    //    {
    //        publications = new List<Publication>();
    //    }
        
    //    public void AddPublication(Publication publication)
    //    {
    //        if (publication == null)
    //        {
    //            throw new ArgumentNullException("Публікація не може бути нульовою.");
    //        }
    //        publications.Add(publication);
    //    }
        
    //    public IEnumerator<Publication> GetEnumerator()
    //    {
    //        return publications.GetEnumerator();
    //    }
    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        return GetEnumerator();
    //    }

    //}
    public class LibraryCatalog<T> where T : Publication 
    {
        private List<T> publications = new List<T>();
        public  void AddPublication(T publication) 
        {
            publications.Add(publication);
        }
        public bool RemovePulication(T publication)
        {
            return publications.Remove(publication);
        }
        public IEnumerable<T> GetAllPublication() //Повертає усі публікації
        {
            return publications;

        }
    }
    public static class PublicationExtensions
    {
        public static IEnumerable<Publication> FilterByAuthor(this IEnumerable<Publication> publications, string author) 
        {
            return publications.Where(pub => pub is Book book && book.Author == author); 
        }

        public static IEnumerable<Publication> SearchByTitle(this IEnumerable<Publication> publications, string title)
        {
            return publications.Where(pub => pub.Title.Contains(title));
        }

        public static IEnumerable<Publication> SortByPublicationDate(this IEnumerable<Publication> publications)
        {
            return publications.OrderBy(pub => pub.PublicationDate);
        }

        
    }

    class Program
    {
        static void Main()
        {
            try
            {
                LibraryCatalog<Publication> library = new LibraryCatalog<Publication>();
                //Library library = new Library();

                Book book = new Book("Artemis", new DateTime(2022, 11, 16), "Andi Weira");
                Book book1 = new Book("Martian", new DateTime(2015, 11, 25), "Andi Weira");
                Magazine magazine = new Magazine("Tech Today", new DateTime(2021, 2, 1), 3);
                Newpaper newspaper = new Newpaper("Daily News", new DateTime(2020, 3, 1), "Jane Smith");

                
                // Book invalidBook = new Book("", new DateTime(2021, 1, 1), "Author"); 

                library.AddPublication(book);
                library.AddPublication(book1);
                library.AddPublication(magazine);
                library.AddPublication(newspaper);

                // розширення та System.Linq
                var filteredByAuthor = library.GetAllPublication().FilterByAuthor("Andi Weira");
                var sortedByDate = filteredByAuthor.SortByPublicationDate();
            
             

                foreach (var publication in /*library*/  sortedByDate)
                {
                    publication.DisplayInfo();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
    }
  
    






}
