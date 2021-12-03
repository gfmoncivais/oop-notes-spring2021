using System;

namespace OOPintrolec
{
 public class Book
 {
   //private- only access the class it is defined
        //public - can access from any class
        private string bookName; //instance 

        private string authorName; //instance: they tell us about the instance of an individual item or prompt i.e. the name of the book, the author name, etc ...

        private int pageCount; //instance 
        //cookie cutter: Book.cs | cookies: book1, book2, book3, book4...etc..

        //class variable: describe something about the whole class  -- relevant to all the books we have in total 
        //no static-- not a class
        //static = it is a class 
        private static int count;

        private Book[] myBooks; //creates the space for the array that will come from the constructor 
        // ^^ telling the constructor in Program to Book.cs and it'll get passed by referenced 


        public Book() //name of constructor has to be the name of the Class  //constructors do not have any return type  **VERY IMPORTANT TO PUT WHEN DEFINING CONSTRUCTORS
        {
            //default contructor creates an object of the class thus...why it is empty in the BODY
        }
    //overloaded constructors/methods: have the same name but they must have a different signature 
        public Book(string bookName, string authorName, int pageCount) //constructors: construct the object
        {
            this.bookName = bookName; //create the variables for the object
            this.authorName = authorName; //this. is called data shadowing  |  this.classVar = methodVar
            this.pageCount = pageCount;
        }

        public Book(string bookName)
        {
            this.bookName = bookName;
        }

        public Book(Book[] myBooks)
        {
            this.myBooks = myBooks;
        }
        //constructors : methods that allow us to access the elements of a class
        public string GetBookName() //GETTER 
        {
            return bookName;
        }

        public string GetAuthorName() //GETTER
        {
            return authorName;
        }
        public int GetPageCount() //GETTER
        {
            return pageCount;
        }

//STARTS SETTING DATA SHADOWING WITH  "this._____"
        public void SetBookName(string bookName) //SETTER 
        {
            this.bookName = bookName;
        }
        public void SetAuthorName(string authorName) //SETTER
        {
            this.authorName = authorName;
        }
        public void SetPageCount(int pageCount) //SETTER
        {
            this.pageCount = pageCount; 
        }

        public static void IncCount() //increases the count by adding one 
        {
            count ++;
        }

        public static int GetCount()
        {
            return count;
        }

        public static void SetCount(int count)
        {
            Book.count = count; //use the Book. to refer to the class variable, which would also be an example of data shadowing 
        }

        public override string ToString() //override will override the original ToString method into a new method 
        {
            return bookName + "\t" + authorName + "\t" + pageCount;
        }

        public void GetAllBooks() //instance method : need to create an object 
        {
            //prime read
            Console.Write("Enter a book name:  Stop to exit  ");
            string bookName = Console.ReadLine().ToLower(); 
            Book.SetCount(0);

            while(bookName != "stop")
            {
                Console.Write("Enter author name : ");
                string authorName = Console.ReadLine().ToLower();

                Console.Write("Enter Num of ☆Pages☆ : ");
                int pageCount = int.Parse(Console.ReadLine());

                myBooks[GetCount()] = new Book(bookName, authorName, pageCount);
                IncCount();

                //update read 
                Console.Write("Enter a book name. Stop to exit");
                bookName = Console.ReadLine().ToLower(); 
            }
        }

        public void PrintAllBooks()
        {
            for( int i = 0; i <count; i++) 
            {
                Console.WriteLine(myBooks[i].ToString()); 
            }
        }
        //data shadowing and stale data are gonna be on the test 
        // instance variables and class variables 
    }
}
