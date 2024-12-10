using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//LabSevenCode
//Step 1 - Add name, the course number, and the course CRN as a comment at the beginning of the code. Use either single line or multi-line comment syntax.
/* Isabella Tomasek
 * Course Number: 1050
 * CRN: 86411
*/
//Before you start adding your code, run the code first to see the output generated

namespace CompetencyLabSeven
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 20, b = 2;
            int result = a / b;
            Console.WriteLine($"{a} divided by {b} is {result}");

            int quotient, num1, num2;
            num1 = 40;
            //Step 3 - After completing step 2, change the value of num2 to 0 to test your exception handling
            num2 = 0;
            // Step 2 - Add exception handling to make sure dividing by 0 does not crash the program.
            try
            {
                quotient = num1 / num2;
                Console.WriteLine($"{num1} divided by {num2} is {quotient}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to divide by 0.");
            }


            Book book1 = new Book();
            book1.Display();

            /* Step 7 - After completing step 4 below, you should be able to uncomment the following lines: */
                Book book2 = new Book("978-0134601540", "Visual C# How to Program");
                  book2.author = "Paul Deitel and Harvey Deitel";
                  book2.publisher = "Pearson";
                      book2.year = 2016;
                      book2.pages = 1056;
                      book2.Display();   

            /* Step 8 - After completing step 5 below, you should be able to uncomment the following lines: */
              Book book3 = new Book("978-1337102100", "Microsoft Visual C#: An Introduction to Object-Oriented Programming ", "Joyce Farrell",  2017);
                book3.publisher = "Cengage Learning";
                book3.pages = 784;
                book3.Display(); 

            /* Step 9 - After completing step 6 below, you should be able to uncomment the following lines: */
               Book book4 = new Book("978-0135181966", "The Object-Oriented Thought Process", "Matt Weisfeld", "Addison-Wesley", 2019, 240);
                 book4.Display();  
        } //end of Main
    } //end of class Program

    class Book   //start of class Book definition
    {
        private string isbn;
        private string title;
        public string author;
        public string publisher;
        public int year;
        public int pages;

        //constructor method for the Book class
        //this constructor accepts no arguments; empty constructor
        //leave the next two following lines alone; make no changes here
        public Book()
        { }

        // Step 4 - Add a constructor method that accepts 2 parameters: isbn and title. Assign the parameters values to the class properties.
        public Book(string isbn, string title)
        {
            this.isbn = isbn;
            this.title = title;
        }


        // Step 5 - Add a constructor method that accepts 4 parameters: isbn, title, author, year. Assign the parameters values to the class properties.
        public Book(string isbn, string title, string author, int year)
        {
            this.isbn = isbn;
            this.title = title;
            this.author = author;
            this.year = year;
        }



        // Step 6 - Add a constructor method that accepts 6 parameters (isbn, title, author, publisher, year, pages) and assigns values to all of the properties of the class. Assign the parameters 	values to the class properties.
        public Book(string isbn, string title, string author, string publisher, int year, int pages)
        {
            this.isbn=isbn;
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.year = year;
            this.pages = pages;
        }


        //leave following lines alone;  make no changes here
        public void Display()
        {
            Console.WriteLine($"Book Details:\nISBN: {isbn}\nTitle: {title}\nAuthor: {author}\nPublisher: {publisher}\nYear: {year}\nPages: {pages}\n ");
        }

    }       //end of class Book definition
} //end of namespace LabSeven