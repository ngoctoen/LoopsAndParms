using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoopsAndParms
{
    public partial class frmLoopsAndParms : Form
    {
        public frmLoopsAndParms()
        {
            InitializeComponent();
        }

        private Book book1, book2;





        private void frmLoopsAndParms_Load(object sender, EventArgs e)
        {

        }

        private void btnTriples_Click(object sender, EventArgs e)
        {
            int num = 0;

            txtOutput.Text = "Pythagorean Triples" + "\r\n\r\n" +
            "Num" + "\t" + "a" + "\t" + "b" + "\t"+ "c" + "\r\n";
                
                               
           
                

            for (int a = 1; a < 31; a++)
            {
                for (int b = a; b < 31; b++)
                {
                    for (int c = 1; c < 31; c++)
                    {
                        if (a * a + b * b == c * c)
                        {
                            num++;
                            txtOutput.Text = txtOutput.Text +
                               
                                num + "\t" + a + "\t" + b + "\t" + c + "\r\n";
                        }
                    }
                }
            }

        }


        private void passBooksByValue(Book b1, Book b2)
        { // passBooksByValue
            Book tempBook = new Book("Parameters are easy",
                                     "Sally Smitherington");
            b1 = tempBook;
            b2.Title = tempBook.Title;
        } // passBooksByValue


        private void btnByVal_Click(object sender, EventArgs e)
        {

            
            

            book1 = new Book("Java is fun", "Joe Cool");
            book2 = new Book("C# is Cool", "Barclay Benton");

            String beforeByVal = "Before By Val" + "\r\n" + "Book 1 = " + book1 + "\r\n" + "Book 2 = " + book2 + "\r\n\r\n"; 
          
            

            passBooksByValue(book1,book2);

            String afterByVal = "After By Val" + "\r\n" + "Book 1 = " + book1 + "\r\n" + "Book 2 = " + book2 + "\r\n\r\n";

            txtOutput.Text = beforeByVal  + afterByVal;



        }

        private void passBooksByReference(ref Book b1,ref Book b2)
        { // passBooksByValue
            Book tempBook2 = new Book("Parameters are easy",
                                     "Sally Smitherington");
            b1 = tempBook2;
            b2.Title = tempBook2.Title;
        } // passBooksByValue

        private void btnByRef_Click(object sender, EventArgs e)
        {
            String beforeByRef = "Before By Val" + "\r\n" + "Book 1 = " + book1 + "\r\n" + "Book 2 = " + book2 + "\r\n\r\n";

            passBooksByReference(ref book1, ref book2);

            String afterByRef = "After By Val" + "\r\n" + "Book 1 = " + book1 + "\r\n" + "Book 2 = " + book2 + "\r\n\r\n";

            txtOutput.Text = beforeByRef + afterByRef;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

