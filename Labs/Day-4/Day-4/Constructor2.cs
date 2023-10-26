using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Book
    {
        string ISBN;
        string BookName;
        //Constructor
        //- any access specifier
        // - cannot have any return type and have name same as of class

        /*-default constructor
         * parameterized constructor
         * static constructor
         * private constructor
         * copy constructor
        */
        public Book()
        {
            ISBN = "1897989";
            BookName = "C# with Vikash";
        }
        public Book(string isbn,string bookname)
        {
            ISBN=isbn;
            BookName = bookname;    
        }
        //destructor
        ~Book()
        {

        }
    }
    internal class Constructor2
    {
        public static void Main2()
        {
            Book book1 = new Book();
            Book book2 = new Book("7868756","Dot net with vikash");
        }
    }
}
