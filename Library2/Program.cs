using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Library
{
    
     class Program
     {
       
         static void Main(string[] args)
         {

            Console.WriteLine(Library.GetAuthorID("Alexander Mazin"));
            Library.InsertBook(19, "C++ Programming Language", 331, "1986-01-29", "Stroustrup Bjarne");
            //Library.InsertAuthor(23, "Gadge", "Randy");
           // Library.Insert("Authors", "author_id,last_name,first_name", "22,'Mazinsss','Alexander'");
           // Library.Insert("Authors", "author_id,last_name,first_name", "5,'Bjarne','Stroustrup'");
           // Library.Insert
               // (
               // "Books",
               // "book_id,book_title,book_size,publish_date,author",
              //  "16,'Vikings',950,'2010-10-10',10"
               // );
            Library.Select("author_id,first_name,last_name", "Authors");
            Library.Select("book_title,publish_date,[Author]=first_name+ ' ' + last_name","Books,Authors","author=author_id",32);

         }
     }
}
