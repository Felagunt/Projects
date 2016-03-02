using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colelctions
{
    class Library //: IEnumerable 
    {
        Book[] books;
        public Library()
        {
            books = new Book[] {new Book("Отцы и дети"), new Book("Лукоморье"),
            new Book("Евгений Онегин") };
        }

        public int Length
        {
            get { return books.Length; }
        }
        public Book this[int index]
        {
            get
            {
                return books[index];
            }
            set
            {
                books[index] = value;
            }
        }
        /*IEnumerator IEnumerable.GetEnumerator()
        {
            return books.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            for(int i = 0; i < books.Length; i++)
                yeld return books[i];
        }*/
        public IEnumerable GetBooks(int max)
        {
            for(int i=0;i<max; i++)
            {
                if(i==books.Length)
                {
                    yield break;
                }
                else
                {
                    yield return books[i];
                }
            }
        }
    }
}
