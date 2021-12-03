using System;

namespace OOPintrolec
{
  class Program
  {
    private const string V = "\t Number of Books: ";

        static void Main(string[] args)
        {

            Book[] myBooks = new Book[100]; //construct new array 

            Book bookObj = new Book(myBooks); //pass array into the book object 

            bookObj.GetAllBooks();
            bookObj.PrintAllBooks();

            Console.WriteLine("Total Number of books: " + Book.GetCount()); 

            //class is a blueprint for a house
            //object is the house itself
            // Book book1 = new Book(); //instantiate of an object - creating one instance of the class 

            // book1.SetBookName("Harry Potter 1");
            // book1.SetAuthorName("J.K.Rowling");
            // book1.SetPageCount(510);

            // Console.WriteLine(book1.GetBookName() + "\t" + book1.GetAuthorName() + "\t" + book1.GetPageCount()); 

            // Book book2 = new Book("Harry Potter 2", "J.K.Rowling", 600);
            // Console.WriteLine(book2.ToString()); 

        //     Book[] myBooks = new Book[100]; //this will create a 100 objects from the Book() class

        //     myBooks[0] = new Book(); //calls the constructor, needed to access the private variables

        //     myBooks[0].SetBookName("Harry Potter 1"); //make sure to understand the line | we use the array to SET because the class variables are private 
        //     myBooks[0].SetAuthorName("jk rowling"); //arrayObj[index].Setter("Value")
        //     myBooks[0].SetPageCount(510);

        //     Book.SetCount(1);

        //     Console.WriteLine(myBooks[0].ToString() +  "\t number of books: " + Book.GetCount());

        //     //contruct myBook[1] and increase count 
        //     myBooks[1] = new Book("Harry Potter 2", "J.K. Rowling", 600);

        //    // Book.SetCount(Book.GetCount()+1); //setting the count to GetCount + 1 
        //     Book.IncCount();
        //     Console.WriteLine(myBooks[1].ToString() +  "\t number of books: " + Book.GetCount());
            //you wouldnt create a book method bc u dont got the variables 


        }
    }
}
