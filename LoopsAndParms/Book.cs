using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoopsAndParms
{
    public class Book
    { // Book

        private string title, author;

        public string Title
        { // Title
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        } // Title

        public string Author
        { // Author
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        } // Author

        public Book()
        { // constructor
            title = "unknown title";
            author = "unknown author";
        } // constructor

        public Book(string title,
                    string author)
        { // constructor
            this.title = title;
            this.author = author;
        } // constructor

       

       

        public override string ToString()
        { // ToString
            return title + " by " + author;
        } // ToString

    } // Book
}
