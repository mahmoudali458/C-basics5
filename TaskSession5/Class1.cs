using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSession5
{
    internal class Book
    {

        private string password = "secret";
        internal int copiesInStock = 5;
        public string Title;
        public enum generation
        {
            Fiction,
            NonFiction,
            Science
        }
        public Genre BookGenre { get; set; }

    }
}
