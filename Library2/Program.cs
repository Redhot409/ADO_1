using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Library2
{
    
     class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine(Library.connectionString);
            

            Library.Insert("Authors", "author_id,last_name,first_name", "12,'Mazin','Alexander'");
           // Library.Insert("Authors", "author_id,last_name,first_name", "5,'Bjarne','Stroustrup'");
            //Library.Insert
               // (
                //"Books",
                //"book_id,title_book,book_size,publish_date,author",
               // "6,'Vikings',950,'2010-10-10',10"
               // );
            Library.Select("author_id,first_name,last_name", "Authors");
            Library.Select("book_title,size,[Author]=first_name+ ' ' + last_name","Books,Authors","author=author_id;DROP TABLE Genres",15);

        }
    }
}
