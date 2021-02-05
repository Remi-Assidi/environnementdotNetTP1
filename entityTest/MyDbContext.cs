using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1;

namespace entityTest
{
    public class MyBdContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public MyBdContext()
        {
            if (this.Database.CreateIfNotExists())
            {
                for (int i = 0; i < 20; i++)
                {
                    this.Books.Add(new Book() { Name = "Book" + i, Nb_page = 100 + i });
                }

                this.SaveChanges();
            }
        }
    }
}
